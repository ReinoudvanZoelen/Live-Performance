using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    public class Salade:Product
    {
        public Salade(int id, string naam, decimal verkoopprijs, decimal inkoopprijs)
        {
            this.ID = id;
            this.Naam = naam;
            this.Verkoopprijs = verkoopprijs;
            this.Inkoopprijs = inkoopprijs;
        }

        public Salade()
        {
            
        }
    }
}
