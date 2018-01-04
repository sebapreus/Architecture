using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();

        T GetByID(int id);

        void Update(T entity);

        void Delete(T entity);

        void Create(T entity);
    }
}
