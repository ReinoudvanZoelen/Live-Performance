using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;
using Live_Performance.Repositories.RepositoryInterfaces;

namespace Live_Performance.Repositories.Context
{
    class TemplateContext:ITemplateRepository
    {
        private ITemplateRepository context;

        public TemplateContext(ITemplateRepository context)
        {
            this.context = context;
        }

        public bool Insert(Template entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Template entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Template GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Template> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
