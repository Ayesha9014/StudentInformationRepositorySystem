using Ayesha1281246.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayesha1281246.Repositories
{
    public class GenericRepositoryImpl<T>:IGenericRepository<T> where T:Entity, new()
    {
        private List<T> each = new List<T>();
        public IEnumerable<T> Get()
        {
            return each;
        }
        public T Get(int ID)
        {
            return each.First(x=> x.ID == ID);
        }

        public void Add(T entity)
        {
            each.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            each.AddRange(entities);
        }
        public void Update(T entity)
        {
            int details = each.FindIndex(x=> x.ID == entity.ID);
            each.RemoveAt(details);
            each.Insert(details, entity);
        }
        public void Delete(int ID)
        {
            var e1 = each.First(x=> x.ID == ID);
            each.Remove(e1);
        }

       
       

        
    }
}
