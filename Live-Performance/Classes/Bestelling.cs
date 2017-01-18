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
    }
}
