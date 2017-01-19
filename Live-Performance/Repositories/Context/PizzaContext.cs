using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;
using Live_Performance.Repositories.RepositoryInterfaces;

namespace Live_Performance.Repositories.Context
{
    public class PizzaContext:IPizzaRepository
    {
        private IPizzaRepository context;

        public PizzaContext(IPizzaRepository context)
        {
            this.context = context;
        }

        public bool Insert(Pizza entity)
        {
            return this.context.Insert(entity);
        }

        public bool Update(Pizza entity)
        {
            return this.context.Update(entity);
        }

        public bool Delete(int id)
        {
            return this.context.Delete(id);
        }

        public Pizza GetById(int id)
        {
            return this.context.GetById(id);
        }

        public List<Pizza> GetAll()
        {
            return this.context.GetAll();
        }

        public List<Pizza> GetByBestellingID(int id)
        {
            return context.GetByBestellingID(id);
        }
    }
}
