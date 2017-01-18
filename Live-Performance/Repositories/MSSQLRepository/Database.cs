using System.Data.SqlClient;
using System.Windows.Forms;

namespace Live_Performance.Repositories.MSSQLRepository
{
    public class Database
    {
        private string Server;
        private string DB;
        private string Uid;
        private string Password;
        public SqlConnection Connection;
        
        public bool OpenConnection()
        {
            Server = "mssql.fhict.local";
            DB = "dbi354261_bios";
            Uid = "dbi354261_bios";
            Password = "CYEn440g9ZZJa0IYvBTC";
            string connectionString = "SERVER=" + Server + ";" + "DATABASE=" + 
                DB + ";" + "UID=" + Uid + ";" + "PASSWORD=" + Password + ";";

            Connection = new SqlConnection(connectionString); 

            try
            {
                Connection.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return false;
            }
        }

    }
}
