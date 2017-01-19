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
    class MSSQLBestellingRepository : Database, IBestellingRepository
    {
        private MSSQLKlantRepository KlantRepository = new MSSQLKlantRepository();

        string StartQuery = "Select * from Bestelling";

        private Bestelling CreateObjectFromReader(SqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            int klantID = -1;
            if (reader["KlantID"] != System.DBNull.Value)
            {
                klantID = Convert.ToInt32(reader["KlantID"]);
            }
            bool bezorging = Convert.ToBoolean(reader["Bezorging"]);
            DateTime bestelmoment = Convert.ToDateTime(reader["Bestelmoment"]);

            Klant klant = new Klant();
            if (klantID != -1)
            {
                klant = KlantRepository.GetById(klantID);
            }

            // TODO: Fix this
            //List<Product> producten = ProductRepository.GetByBestellingID(id);

            Bestelling bestelling = new Bestelling(id, klant, null, bezorging, bestelmoment);

            return bestelling;
        }

        public int GetWachttijd(int bestellingId)
        {
            int minuten = 0;

            string query = "Select count(PizzaID) as Aantal from BestellingProducten where BestellingID = @bestellingID";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@bestellingID", bestellingId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                minuten = (Convert.ToInt32(reader["Aantal"]) * 10);
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return minuten;
        }

        public bool Insert(Bestelling entity)
        {
            bool insert = false;

            string query = "INSERT INTO Bestelling(KlantID, Bezorging) " +
               "values (@KlantID, @Bezorging)";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        if (entity.Klant != null)
                        {
                            command.Parameters.AddWithValue("@KlantID", entity.Klant.ID);
                            command.Parameters.AddWithValue("@Bezorging", true);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@KlantID", System.DBNull.Value);
                            command.Parameters.AddWithValue("@Bezorging", false);
                        }

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

        public void AssignDrankToBestelling(List<Drank> entityProducten)
        {
            string query = "INSERT INTO BestellingProducten(BestellingID, DrankID) " +
               "values (@BestellingID, @DrankID)";

            // Get the latest pizza that has been created
            List<Bestelling> bestellingen = GetAll();
            int bestellingid = bestellingen[bestellingen.Count - 1].ID;

            try
            {
                if (OpenConnection())
                {
                    foreach (Drank drank in entityProducten)
                    {
                        using (SqlCommand command = new SqlCommand(query, Connection))
                        {
                            command.Parameters.AddWithValue("@BestellingID", bestellingid);
                            command.Parameters.AddWithValue("@DrankID", drank.ID);

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

        public void AssignSaladeToBestelling(List<Salade> entityProducten)
        {
            string query = "INSERT INTO BestellingProducten(BestellingID, SaladeID) " +
               "values (@BestellingID, @SaladeID)";

            // Get the latest pizza that has been created
            List<Bestelling> bestellingen = GetAll();
            int bestellingid = bestellingen[bestellingen.Count - 1].ID;

            try
            {
                if (OpenConnection())
                {
                    foreach (Salade salade in entityProducten)
                    {
                        using (SqlCommand command = new SqlCommand(query, Connection))
                        {
                            command.Parameters.AddWithValue("@BestellingID", bestellingid);
                            command.Parameters.AddWithValue("@SaladeID", salade.ID);

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

        public void AssignPizzaToBestelling(List<Pizza> entityProducten)
        {
            string query = "INSERT INTO BestellingProducten(BestellingID, PizzaID) " +
               "values (@BestellingID, @PizzaID)";

            // Get the latest pizza that has been created
            List<Bestelling> bestellingen = GetAll();
            int bestellingid = bestellingen[bestellingen.Count - 1].ID;

            try
            {
                if (OpenConnection())
                {
                    foreach (Pizza pizza in entityProducten)
                    {
                        using (SqlCommand command = new SqlCommand(query, Connection))
                        {
                            command.Parameters.AddWithValue("@BestellingID", bestellingid);
                            command.Parameters.AddWithValue("@PizzaID", pizza.ID);

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

        public bool Update(Bestelling entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Bestelling GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bestelling> GetAll()
        {
            List<Bestelling> bestellingen = new List<Bestelling>();

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
                                bestellingen.Add(CreateObjectFromReader(reader));
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return bestellingen;
        }
    }
}
