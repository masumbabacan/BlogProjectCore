using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.EntityBusinessGenericRepository
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
    }
}
