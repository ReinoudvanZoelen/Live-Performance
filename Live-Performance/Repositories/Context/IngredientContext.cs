using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;
using Live_Performance.Repositories.RepositoryInterfaces;

namespace Live_Performance.Repositories.Context
{
    public class IngredientContext : IIngredientRepository
    {
        private IIngredientRepository context;

        public IngredientContext(IIngredientRepository context)
        {
            this.context = context;
        }

        public bool Insert(Ingredient entity)
        {
            return context.Insert(entity);
        }

        public bool Update(Ingredient entity)
        {
            return context.Update(entity);
        }

        public bool Delete(int id)
        {
            return context.Delete(id);
        }

        public Ingredient GetById(int id)
        {
            return context.GetById(id);
        }

        public List<Ingredient> GetAll()
        {
            return context.GetAll();
        }

        public List<Ingredient> GetByPizzaID(int id)
        {
            return context.GetByPizzaID(id);
        }
    }
}
