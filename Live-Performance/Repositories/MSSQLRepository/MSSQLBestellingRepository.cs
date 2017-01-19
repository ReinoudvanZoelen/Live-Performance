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
    class MSSQLBestellingRepository:IBestellingRepository
    {
        private MSSQLKlantRepository KlantRepository = new MSSQLKlantRepository();
        //private MSSQLBestellingRepository();

        string StartQuery = "Select * from Bestelling";

        private Bestelling CreateObjectFromReader(SqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            int klantID = Convert.ToInt32(reader["KlantID"]);
            bool bezorging = Convert.ToBoolean(reader["Bezorging"]);
            DateTime bestelmoment = Convert.ToDateTime(reader["Bestelmoment"]);

            Klant klant = KlantRepository.GetById(klantID);

            // TODO: Fix this
            //List<Product> producten = ProductRepository.GetByBestellingID(id);

            Bestelling bestelling = new Bestelling(id, klant, null, bezorging, bestelmoment);

            return bestelling;
        }

        public bool Insert(Bestelling entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
