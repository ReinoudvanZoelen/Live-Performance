using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;
using Live_Performance.Repositories.RepositoryInterfaces;

namespace Live_Performance.Repositories.Context
{
    public class KlantContext:IKlantRepository
    {
        private IKlantRepository context;

        public KlantContext(IKlantRepository context)
        {
            this.context = context;
        }

        public bool Insert(Klant entity)
        {
            return context.Insert(entity);
        }

        public bool Update(Klant entity)
        {
            return context.Update(entity);
        }

        public bool Delete(int id)
        {
            return context.Delete(id);
        }

        public Klant GetById(int id)
        {
            return context.GetById(id);
        }

        public List<Klant> GetAll()
        {
            return context.GetAll();
        }
    }
}
