using Ayesha1281246.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayesha1281246.Repositories
{
    public interface IGenericRepository<T> where T:Entity, new()
    {
        IEnumerable<T> Get();
        T Get(int ID);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(int ID);
    }
}
