using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;
using Live_Performance.Repositories.RepositoryInterfaces;

namespace Live_Performance.Repositories.Context
{
    public class DrankContext:IDrankRepository
    {
        private IDrankRepository context;

        public DrankContext(IDrankRepository context)
        {
            this.context = context;
        }

        public bool Insert(Drank entity)
        {
            return context.Insert(entity);
        }

        public bool Update(Drank entity)
        {
            return context.Update(entity);
        }

        public bool Delete(int id)
        {
            return context.Delete(id);
        }

        public Drank GetById(int id)
        {
            return context.GetById(id);
        }

        public List<Drank> GetAll()
        {
            return context.GetAll();
        }

        public List<Drank> GetByBestellingID(int id)
        {
            return context.GetByBestellingID(id);
        }
    }
}
