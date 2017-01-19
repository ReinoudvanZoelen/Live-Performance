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
    public class CreateLogic
    {
        private PizzaContext pizzaContext = new PizzaContext(new MSSQLPizzaRepository());
        private IngredientContext ingredientContext = new IngredientContext(new MSSQLIngredientRepository());

        public void InsertPizza(Pizza pizza)
        {
            pizzaContext.Insert(pizza);
        }

        public List<Ingredient> GetIngredients()
        {
            return ingredientContext.GetAll();
        }
    }
}
