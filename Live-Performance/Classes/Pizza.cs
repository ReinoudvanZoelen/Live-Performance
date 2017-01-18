using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    public class Pizza : Product
    {
        public double Oppervlakte { get; set; }
        public string Bodemtype { get; set; }
        public string Vorm { get; set; }
        public List<Ingredient> Ingredienten { get; set; }
        public bool Custom { get; set; }
        public bool Glutenvrij { get; set; }
    }
}
