using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    public class Ingredient:Product
    {

        public bool Halal { get; set; }
        public bool Veganistisch { get; set; }

        public Ingredient()
        {
        }

        public Ingredient(int id, string naam, decimal verkoopprijs, decimal inkoopprijs, bool halal, bool veganistisch)
        {
            this.ID = id;
            this.Naam = naam;
            this.Verkoopprijs = verkoopprijs;
            this.Inkoopprijs = inkoopprijs;
            this.Halal = halal;
            this.Veganistisch = veganistisch;
        }
    }
}
