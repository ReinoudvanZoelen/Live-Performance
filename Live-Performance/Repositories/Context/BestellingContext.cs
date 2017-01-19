using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;
using Live_Performance.Repositories.RepositoryInterfaces;

namespace Live_Performance.Repositories.Context
{
    class BestellingContext : IBestellingRepository
    {
        private IBestellingRepository context;

        public BestellingContext(IBestellingRepository context)
        {
            this.context = context;
        }

        public bool Insert(Bestelling entity)
        {
            return context.Insert(entity);
        }

        public bool Update(Bestelling entity)
        {
            return context.Update(entity);
        }

        public bool Delete(int id)
        {
            return context.Delete(id);
        }

        public Bestelling GetById(int id)
        {
            return context.GetById(id);
        }

        public List<Bestelling> GetAll()
        {
            return context.GetAll();
        }
    }
}
