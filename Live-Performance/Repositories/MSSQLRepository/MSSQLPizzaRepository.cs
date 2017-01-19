using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;
using Live_Performance.Repositories.RepositoryInterfaces;

namespace Live_Performance.Repositories.MSSQLRepository
{
    public class MSSQLPizzaRepository : Database, IPizzaRepository
    {
        private MSSQLIngredientRepository IngredientRepository = new MSSQLIngredientRepository();

        private string StartQuery = "Select * From Pizza";

        private Pizza CreateObjectFromReader(SqlDataReader reader)
        {
            //
            // Read the standard data from the database
            //

            int id = Convert.ToInt32(reader["Id"]);
            string naam = Convert.ToString(reader["Naam"]);
            bool custom = Convert.ToBoolean(reader["Custom"]);
            bool glutenvrij = Convert.ToBoolean(reader["Glutenvrij"]);

            //
            // Afmetingen consists of all data we have regarding the size of the pizza
            // This will be used to calculate the size, shape and price
            // These need to be handled by a System.DBNull.Value because they are nullable in the DB
            //

            int[] afmetingen = new int[3];
            afmetingen[0] = Convert.ToInt32(reader["Afmeting_A"]);

            if (reader["Afmeting_B"] != System.DBNull.Value)
            {
                afmetingen[1] = Convert.ToInt32(reader["Afmeting_B"]);
            }

            if (reader["Afmeting_C"] != System.DBNull.Value)
            {
                afmetingen[2] = Convert.ToInt32(reader["Afmeting_C"]);
            }
            
            //
            // Starts processing data, get all of the associated ingredients
            //

            List<Ingredient> ingredienten = IngredientRepository.GetByPizzaID(id);


            //
            // Get the exact prices in an array
            // [0] is verkoop
            // [1] is inkoop
            //

            decimal[] prijzen = CalculateVerkoopInkoopPrijzen(ingredienten);
            
            // 
            // Call the method to calculate the surface area
            //

            double oppervlakte = CalculateOppervlakte(afmetingen);
            
            //
            // Calculate the final prices 
            // 

            decimal verkoopprijs = prijzen[0] * Convert.ToDecimal(oppervlakte);
            decimal inkoopprijs = prijzen[1] * Convert.ToDecimal(oppervlakte);

            //
            // Get the type of Bodem that the pizza has
            //

            string bodemtype = GetBodemtype(ingredienten);
            
            //
            // Put it all together and return the object
            //

            return new Pizza(id, naam, verkoopprijs, inkoopprijs, bodemtype, oppervlakte, afmetingen, custom, glutenvrij, ingredienten);
        }

        private string GetBodemtype(List<Ingredient> ingredienten)
        {
            foreach (Ingredient ingredient in ingredienten)
            {
                if (ingredient.Naam.ToLower().Contains("deeg"))
                {
                    return ingredient.Naam;
                }
            }
            return "";
        }

        private decimal[] CalculateVerkoopInkoopPrijzen(List<Ingredient> ingredienten)
        {
            decimal[] output = new decimal[2];

            output[0] = new decimal(0);
            foreach (Ingredient ingredient in ingredienten)
            {
                output[0] = output[0] + ingredient.Verkoopprijs;
            }

            output[1] = new decimal(0);
            foreach (Ingredient ingredient in ingredienten)
            {
                output[1] = output[1] + ingredient.Inkoopprijs;
            }

            return output;
        }

        private double CalculateOppervlakte(int[] afmetingen)
        {
            double oppervlakte;

            int AfmetingenCount = 0;

            foreach (int i in afmetingen)
            {
                if (i > 0)
                {
                    AfmetingenCount++;
                }
            }

            switch (AfmetingenCount)
            {
                case (1): // Rond
                    oppervlakte = 0.25 * Math.PI * afmetingen[0];
                    break;
                case (2): // Vierkant
                    oppervlakte = afmetingen[0] * afmetingen[1];
                    break;
                case (3): // Driehoek
                    int a = afmetingen[0];
                    int b = afmetingen[1];
                    int c = afmetingen[2];

                    int s = (a + b + c) / 2;
                    oppervlakte = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                    break;
                default:
                    oppervlakte = -1;
                    break;
            }

            return oppervlakte;
        }

        public bool Insert(Pizza entity)
        {
            bool insert = false;

            string query = "INSERT INTO Pizza(Naam, Custom, Oppervlakte, Afmeting_A, Afmeting_B, Afmeting_C, Glutenvrij) " +
                           "values (@Naam, @Custom, @Oppervlakte, @Afmeting_A, @Afmeting_B, @Afmeting_C, @Glutenvrij)";
            
            entity.Oppervlakte = CalculateOppervlakte(entity.Afmetingen);

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@Naam", entity.Naam);
                        command.Parameters.AddWithValue("@Custom", Convert.ToInt32(entity.Custom));
                        command.Parameters.AddWithValue("@Oppervlakte", entity.Oppervlakte);
                        command.Parameters.AddWithValue("@Afmeting_A", entity.Afmetingen[0]);
                        command.Parameters.AddWithValue("@Afmeting_B", entity.Afmetingen[1]);
                        command.Parameters.AddWithValue("@Afmeting_C", entity.Afmetingen[2]);
                        command.Parameters.AddWithValue("@Glutenvrij", entity.Glutenvrij);

                        command.ExecuteNonQuery();

                        AssignIngredientsToPizza(entity.Ingredienten);

                        insert = true;
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
            
            return insert;
        }



        private void AssignIngredientsToPizza(List<Ingredient> ingredients)
        {
            string query = "INSERT INTO PizzaIngredient(PizzaID, IngredientID) " +
                           "values (@PizzaID, @IngredientID)";

            // Get the latest pizza that has been created
            List<Pizza> pizzas = GetAll();
            int pizzaId = pizzas[pizzas.Count - 1].ID;

            try
            {
                if (OpenConnection())
                {
                    foreach (Ingredient ingredient in ingredients)
                    {
                        using (SqlCommand command = new SqlCommand(query, Connection))
                        {
                            command.Parameters.AddWithValue("@PizzaID", pizzaId);
                            command.Parameters.AddWithValue("@IngredientID", ingredient.ID);

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
        }

        private void UnassignIngredientsFromPizza(int id)
        {
            string query = "Delete from PizzaIngredient where PizzaID = @ID";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool Update(Pizza entity)
        {
            bool update = false;

            string query = "Update Pizza SET Naam = @Naam, Custom = @Custom, Oppervlakte = @Oppervlakte, " +
                           "Afmeting_A = @Afmeting_A, Afmeting_B = @Afmeting_B, Afmeting_C = @Afmeting_C, " +
                           "Glutenvrij = @Glutenvrij WHERE ID = @ID";

            entity.Oppervlakte = CalculateOppervlakte(entity.Afmetingen);
            UnassignIngredientsFromPizza(entity.ID);

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@Naam", entity.Naam);
                        command.Parameters.AddWithValue("@Custom", Convert.ToInt32(entity.Custom));
                        command.Parameters.AddWithValue("@Oppervlakte", entity.Oppervlakte);
                        command.Parameters.AddWithValue("@Afmeting_A", entity.Afmetingen[0]);
                        command.Parameters.AddWithValue("@Afmeting_B", entity.Afmetingen[1]);
                        command.Parameters.AddWithValue("@Afmeting_C", entity.Afmetingen[2]);
                        command.Parameters.AddWithValue("@Glutenvrij", entity.Glutenvrij);

                        command.Parameters.AddWithValue("@ID", entity.ID);

                        command.ExecuteNonQuery();

                        AssignIngredientsToPizza(entity.Ingredienten);

                        update = true;
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return update;
        }



        public bool Delete(int id)
        {
            bool delete = false;

            UnassignIngredientsFromPizza(id);

            string query = "Delete from Pizza where ID = @ID";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        command.ExecuteNonQuery();

                        delete = true;
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return delete;
        }

        public Pizza GetById(int id)
        {
            Pizza pizza = new Pizza();

            string query = StartQuery + " where ID = @ID";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@ID", id.ToString());

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pizza = CreateObjectFromReader(reader);
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return pizza;
        }

        public List<Pizza> GetAll()
        {
            List<Pizza> pizzas = new List<Pizza>();

            string query = StartQuery;

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pizzas.Add(CreateObjectFromReader(reader));
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return pizzas;
        }
    }
}
