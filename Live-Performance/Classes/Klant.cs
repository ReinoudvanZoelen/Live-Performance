using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    public class Klant
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public string Postcode { get; set; }
        public string Huisnummer { get; set; }


        public Klant(int id, string naam, string postcode, string huisnummer)
        {
            ID = id;
            Naam = naam;
            Postcode = postcode;
            Huisnummer = huisnummer;
        }

        public Klant()
        {
            
        }

        public override string ToString()
        {
            return $"{Naam}";
        }
    }
}
