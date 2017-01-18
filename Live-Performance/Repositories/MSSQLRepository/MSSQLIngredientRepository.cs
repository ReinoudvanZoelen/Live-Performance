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
    public class MSSQLIngredientRepository:Database, IIngredientRepository
    {
        private string StartQuery = "Select * From Ingredient";

        private Ingredient CreateObjectFromReader(SqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["Id"]);
            string naam = Convert.ToString(reader["Naam"]);
            decimal verkoopprijs = Convert.ToDecimal(reader["Verkoopprijs"]);
            decimal inkoopprijs = Convert.ToDecimal(reader["Inkoopprijs"]);
            bool halal = Convert.ToBoolean(reader["Halal"]);
            bool veganistisch = Convert.ToBoolean(reader["Veganistisch"]);

            return new Ingredient(id, naam, verkoopprijs, inkoopprijs, halal, veganistisch);
        }

        public bool Insert(Ingredient entity)
        {
            bool insert = false;

            string query = "INSERT INTO Ingredient(Naam, Verkoopprijs, Inkoopprijs, Halal, Veganistisch) values (@Naam, @Verkoopprijs, @Inkoopprijs, @Halal, @Veganistisch)";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@Naam", entity.Naam);
                        command.Parameters.AddWithValue("@Verkoopprijs", entity.Verkoopprijs);
                        command.Parameters.AddWithValue("@Inkoopprijs", entity.Inkoopprijs);
                        command.Parameters.AddWithValue("@Halal", Convert.ToInt32(entity.Halal));
                        command.Parameters.AddWithValue("@Veganistisch", Convert.ToInt32(entity.Veganistisch));

                        command.ExecuteNonQuery();

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

        public bool Update(Ingredient entity)
        {
            bool update = false;

            string query = "Update Ingredient SET Naam = @Naam, Verkoopprijs = @Verkoopprijs, Inkoopprijs = @Inkoopprijs, Halal = @Halal, Veganistisch = @Veganistisch WHERE ID = @ID";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@Naam", entity.Naam);
                        command.Parameters.AddWithValue("@Verkoopprijs", entity.Verkoopprijs);
                        command.Parameters.AddWithValue("@Inkoopprijs", entity.Inkoopprijs);
                        command.Parameters.AddWithValue("@Halal", Convert.ToInt32(entity.Halal));
                        command.Parameters.AddWithValue("@Veganistisch", Convert.ToInt32(entity.Veganistisch));

                        command.Parameters.AddWithValue("@ID", entity.ID);

                        command.ExecuteNonQuery();

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

            string query = "Delete from Ingredient where ID = @ID";

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

        public Ingredient GetById(int id)
        {
            Ingredient ingredient = new Ingredient();

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
                                ingredient = CreateObjectFromReader(reader);
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return ingredient;
        }

        public List<Ingredient> GetAll()
        {
            List<Ingredient> ingredients = new List<Ingredient>();

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
                                ingredients.Add(CreateObjectFromReader(reader));
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return ingredients;
        }

        public List<Ingredient> GetByPizzaID(int id)
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            string query = "select i.Id, i.Naam, i.Verkoopprijs, i.Inkoopprijs, i.Halal, i.Veganistisch from PizzaIngredient p_i inner join Ingredient i on i.Id=p_i.IngredientID where PizzaID = @PizzaID";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@PizzaID", id.ToString());

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ingredients.Add(CreateObjectFromReader(reader));
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return ingredients;
        }
    }
}
