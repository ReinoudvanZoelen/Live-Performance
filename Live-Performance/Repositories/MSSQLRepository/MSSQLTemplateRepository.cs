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
    public class MSSQLTemplateRepository : Database, ITemplateRepository
    {
        #region
        //Hier komen de andere MSSQLRepositories die we nodig hebben, bijv:

        //MSSQLTramRepository TramRepository = new MSSQLTramRepository();
        //MSSQLEmployeeRepository EmployeeRepository = new MSSQLEmployeeRepository()
        #endregion


        private string StartQuery = "Select * from Table";

        private Template CreateObjectFromReader(SqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string naam = Convert.ToString(reader["Naam"]);

            #region Properties that can be NULL in the database
            string eigenschap = "";

            if (reader["Eigenschap"] != System.DBNull.Value)
            {
                eigenschap = Convert.ToString(reader["Eigenschap"]);
            }
            #endregion

            Template template = new Template(id, naam);

            return template;
        }

        public bool Insert(Template entity)
        {
            bool insert = false;

            string query = "INSERT INTO Template(Template_ID, TemplateName) values (@Template_ID, @TemplateName)";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@Template_ID", entity.Id);
                        command.Parameters.AddWithValue("@TemplateName", entity.Name);
                        
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

        public bool Update(int id, Template entity)
        {
            bool update = false;

            string query = "Update Template SET TemplateName = @TemplateName, OtherProperty = @OtherProperty WHERE Template_ID = @ID";

            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@TemplateName", entity.Name);
                        command.Parameters.AddWithValue("@OtherProperty", entity.Name);

                        command.Parameters.AddWithValue("@ID", entity.Id);

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

            string query = "Delete from Template where Template_ID = @ID";

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

        public Template GetById(int id)
        {
            Template template = new Template();

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
                                template = CreateObjectFromReader(reader);
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return template;
        }

        public List<Template> GetAll()
        {
            List<Template> templates = new List<Template>();

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
                                templates.Add(CreateObjectFromReader(reader));
                            }
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return templates;
        }
    }
}
