using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;
using Live_Performance.Repositories.RepositoryInterfaces;

namespace Live_Performance.Repositories.Context
{
    public class SaladeContext : ISaladeRepository
    {
        private ISaladeRepository context;

        public SaladeContext(ISaladeRepository context)
        {
            this.context = context;
        }

        public bool Insert(Salade entity)
        {
            return this.context.Insert(entity);
        }

        public bool Update(Salade entity)
        {
            return context.Update(entity);
        }

        public bool Delete(int id)
        {
            return context.Delete(id);
        }

        public Salade GetById(int id)
        {
            return context.GetById(id);
        }

        public List<Salade> GetAll()
        {
            return context.GetAll();
        }

        public List<Salade> GetByBestellingID(int id)
        {
            return context.GetByBestellingID(id);
        }
    }
}
