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
    public class MSSQLKlantRepository:Database, IKlantRepository
    {
        private string StartQuery = "Select * From klant";

        private Klant CreateObjectFromReader(SqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string naam = Convert.ToString(reader["Naam"]);
            string postcode = Convert.ToString(reader["Postcode"]);
            string huisnummer = Convert.ToString(reader["Huisnummer"]);

            Klant klant = new Klant(id, naam, postcode, huisnummer);

            return klant;
        }

        public bool Insert(Klant entity)
        {
            bool insert = false;

            string query = "INSERT INTO Klant(Naam, Postcode, Huisnummer) values (@Naam, @Postcode, @Huisnummer)";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@Naam", entity.Naam);
                        command.Parameters.AddWithValue("@Postcode", entity.Postcode);
                        command.Parameters.AddWithValue("@Huisnummer", entity.Huisnummer);

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

        public bool Update(Klant entity)
        {
            bool update = false;

            string query = "Update Klant SET Naam = @Naam, Postcode = @Postode, Huisnummer = @Huisnummer WHERE ID = @ID";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@Naam", entity.Naam);
                        command.Parameters.AddWithValue("@Postcode", entity.Postcode);
                        command.Parameters.AddWithValue("@Huisnummer", entity.Huisnummer);

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

            string query = "Delete from Klant where ID = @ID";

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

        public Klant GetById(int id)
        {
            Klant klant = new Klant();

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
                                klant = CreateObjectFromReader(reader);
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return klant;
        }

        public List<Klant> GetAll()
        {
            List<Klant> klanten = new List<Klant>();

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
                                klanten.Add(CreateObjectFromReader(reader));
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return klanten;
        }
    }
}
