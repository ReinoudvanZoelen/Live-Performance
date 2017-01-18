using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    public class Pizza : Product
    {
        public string Bodemtype { get; set; }
        public double Oppervlakte { get; set; }
        public int[] Afmetingen { get; set; } 
        public List<Ingredient> Ingredienten { get; set; }
        public bool Custom { get; set; }
        public bool Glutenvrij { get; set; }

        public Pizza()
        {
        }

        public Pizza(string naam, bool custom, bool glutenvrij, int[] afmetingen, List<Ingredient> ingredienten)
        {
            this.Naam = naam;
            this.Custom = custom;
            this.Afmetingen = afmetingen;
            this.Glutenvrij = glutenvrij;
            this.Ingredienten = ingredienten;
        }

        public Pizza(int id, string naam, decimal verkoopprijs, decimal inkoopprijs, string bodemtype,
            double oppervlakte, int[] afmetingen, bool custom, bool glutenvrij, List<Ingredient> ingredienten)
        {
            this.ID = id;
            this.Naam = naam;
            this.Verkoopprijs = verkoopprijs;
            this.Inkoopprijs = inkoopprijs;
            this.Bodemtype = bodemtype;
            this.Oppervlakte = oppervlakte;
            this.Afmetingen = afmetingen;
            this.Custom = custom;
            this.Glutenvrij = glutenvrij;
            this.Ingredienten = ingredienten;
        }
    }
}
