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
    public class MSSQLSaladeRepository:Database,ISaladeRepository
    {
        private string StartQuery = "Select * From Salade";

        private Salade CreateObjectFromReader(SqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["Id"]);
            string naam = Convert.ToString(reader["Naam"]);
            decimal verkoopprijs = Convert.ToDecimal(reader["Verkoopprijs"]);
            decimal inkoopprijs = Convert.ToDecimal(reader["Inkoopprijs"]);

            return new Salade(id, naam, verkoopprijs, inkoopprijs);
        }

        public bool Insert(Salade entity)
        {
            bool insert = false;

            string query = "INSERT INTO Salade(Naam, Verkoopprijs, Inkoopprijs) values (@Naam, @Verkoopprijs, @Inkoopprijs)";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@Naam", entity.Naam);
                        command.Parameters.AddWithValue("@Verkoopprijs", entity.Verkoopprijs);
                        command.Parameters.AddWithValue("@Inkoopprijs", entity.Inkoopprijs);

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

        public bool Update(Salade entity)
        {
            bool update = false;

            string query = "Update Salade SET Naam = @Naam, Verkoopprijs = @Verkoopprijs, Inkoopprijs = @Inkoopprijs WHERE ID = @ID";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@Naam", entity.Naam);
                        command.Parameters.AddWithValue("@Verkoopprijs", entity.Verkoopprijs);
                        command.Parameters.AddWithValue("@Inkoopprijs", entity.Inkoopprijs);

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

            string query = "Delete from Salade where ID = @ID";

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

        public Salade GetById(int id)
        {
            Salade salade = new Salade();

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
                                salade = CreateObjectFromReader(reader);
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return salade;
        }

        public List<Salade> GetAll()
        {
            List<Salade> salades = new List<Salade>();

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
                                salades.Add(CreateObjectFromReader(reader));
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return salades;
        }

        public List<Salade> GetByBestellingID(int id)
        {
            List<Salade> salades = new List<Salade>();

            string query = "Select S.Id, S.Naam, S.Verkoopprijs, S.Inkoopprijs " +
                           "From Salade as S join BestellingProducten as BP on " +
                           "BP.PizzaID=S.Id where BP.BestellingID = @BestellingID";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@BestellingID", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                salades.Add(CreateObjectFromReader(reader));
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return salades;
        }
    }
}
