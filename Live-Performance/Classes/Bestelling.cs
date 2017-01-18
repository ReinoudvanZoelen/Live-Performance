using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    public class Bestelling
    {
        public int ID { get; set; }
        public Klant Klant { get; set; }
        public List<Product> Producten { get; set; }
        public bool Bezorging { get; set; }
        public DateTime Bestelmoment { get; set; }

        public Bestelling()
        {

        }

        public Bestelling(int id, Klant klant, List<Product> producten, bool bezorging, DateTime bestelmoment)
        {
            this.ID = id;
            this.Klant = klant;
            this.Producten = producten;
            this.Bezorging = bezorging;
            this.Bestelmoment = bestelmoment;
        }
    }
}
