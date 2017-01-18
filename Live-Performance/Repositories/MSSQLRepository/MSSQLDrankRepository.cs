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
    public class MSSQLDrankRepository:Database, IDrankRepository
    {
        private string StartQuery = "Select * From Drank";

        private Drank CreateObjectFromReader(SqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["Id"]);
            string naam = Convert.ToString(reader["Naam"]);
            decimal verkoopprijs = Convert.ToDecimal(reader["Verkoopprijs"]);
            decimal inkoopprijs = Convert.ToDecimal(reader["Inkoopprijs"]);
            bool alcoholhoudend = Convert.ToBoolean(reader["Alcoholhoudend"]);

            Drank drank = new Drank(id, naam, verkoopprijs, inkoopprijs, alcoholhoudend);

            return drank;
        }

        public bool Insert(Drank entity)
        {
            bool insert = false;

            string query = "INSERT INTO Drank(Naam, Verkoopprijs, Inkoopprijs, Alcoholhoudend) values (@Naam, @Verkoopprijs, @Inkoopprijs, @Alcoholhoudend)";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@Naam", entity.Naam);
                        command.Parameters.AddWithValue("@Verkoopprijs", entity.Verkoopprijs);
                        command.Parameters.AddWithValue("@Inkoopprijs", entity.Inkoopprijs);
                        command.Parameters.AddWithValue("@Alcoholhoudend", Convert.ToInt32(entity.Alcoholhoudend));

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

        public bool Update(Drank entity)
        {
            bool update = false;

            string query = "Update Drank SET Naam = @Naam, Verkoopprijs = @Verkoopprijs, Inkoopprijs = @Inkoopprijs, Alcoholhoudend = @Alcoholhoudend WHERE ID = @ID";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@Naam", entity.Naam);
                        command.Parameters.AddWithValue("@Verkoopprijs", entity.Verkoopprijs);
                        command.Parameters.AddWithValue("@Inkoopprijs", entity.Inkoopprijs);
                        command.Parameters.AddWithValue("@Alcoholhoudend", Convert.ToInt32(entity.Alcoholhoudend));

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

            string query = "Delete from Drank where ID = @ID";

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

        public Drank GetById(int id)
        {
            Drank drank = new Drank();

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
                                drank = CreateObjectFromReader(reader);
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return drank;
        }

        public List<Drank> GetAll()
        {
            List<Drank> dranken = new List<Drank>();

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
                                dranken.Add(CreateObjectFromReader(reader));
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return dranken;
        }
    }
}
