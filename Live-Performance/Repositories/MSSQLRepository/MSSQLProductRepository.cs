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
    class MSSQLProductRepository:Database,IProductRepository
    {
        private string StartQuery = "Select * from Pizza";

        private Product CreateObjectFromReader(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByBestellingID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
