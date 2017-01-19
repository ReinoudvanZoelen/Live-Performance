using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;
using Live_Performance.Repositories.Context;
using Live_Performance.Repositories.MSSQLRepository;

namespace Live_Performance.Logic
{
    public class MainFormLogic
    {
        public KlantContext KlantContext = new KlantContext(new MSSQLKlantRepository());
        public PizzaContext PizzaContext = new PizzaContext(new MSSQLPizzaRepository());
        public DrankContext DrankContext = new DrankContext(new MSSQLDrankRepository());
        public SaladeContext SaladeContext = new SaladeContext(new MSSQLSaladeRepository());
        public BestellingContext bestellingContext = new BestellingContext(new MSSQLBestellingRepository());

        public void NewBestelling(Klant klant, List<Pizza> pizzas, List<Drank> dranken, List<Salade> salades)
        {
            // De nieuwe bestelling aanmaken, op de klant
            Bestelling bestelling = new Bestelling(klant);
            bestellingContext.Insert(bestelling);
            
            // Pizzas, Dranken en Salades toewijzen
            bestellingContext.AssignPizzaToBestelling(pizzas);
            bestellingContext.AssignDrankToBestelling(dranken);
            bestellingContext.AssignSaladeToBestelling(salades);
        }

        public List<Bestelling> GetOvenList()
        {
            List<Bestelling> bestellingen = bestellingContext.GetAll();
            List<Bestelling> oven = new List<Bestelling>();

            foreach (Bestelling bestelling in bestellingen)
            {
                DateTime bestellingKlaar = bestelling.Bestelmoment;
                int minutes = bestellingContext.GetWachttijd(bestelling.ID);
                bestellingKlaar = bestellingKlaar.AddMinutes(minutes);
                if (DateTime.Now < bestellingKlaar)
                {
                    oven.Add(bestelling);
                }
            }

            return oven;
        }
    }
}
