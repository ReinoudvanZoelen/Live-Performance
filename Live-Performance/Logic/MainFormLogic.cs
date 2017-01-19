using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public IngredientContext IngredientContext = new IngredientContext(new MSSQLIngredientRepository());
    }
}
