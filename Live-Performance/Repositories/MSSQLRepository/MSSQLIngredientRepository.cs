using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;
using Live_Performance.Repositories.RepositoryInterfaces;

namespace Live_Performance.Repositories.MSSQLRepository
{
    class MSSQLIngredientRepository:Database, IIngredientRepository
    {
        private string StartQuery = "Select * From Product where [Type] = 'Ingredient'";

        public bool Insert(Ingredient entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Ingredient entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Ingredient GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ingredient> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
