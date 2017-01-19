using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    public abstract class Product
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public decimal Verkoopprijs { get; set; }
        public decimal Inkoopprijs { get; set; }
        
        public override string ToString()
        {
            return $"{Naam} €{Verkoopprijs}";
        }
    }
}
