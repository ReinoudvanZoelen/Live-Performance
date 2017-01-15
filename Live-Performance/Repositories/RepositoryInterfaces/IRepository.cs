using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Repositories.RepositoryInterfaces
{
    public interface IRepository<T> where T : class
    {
        bool Insert(T entity);
        bool Update(int id, T entity);
        bool Delete(int id);
        T GetById(int id);
        List<T> GetAll();
    }
}

