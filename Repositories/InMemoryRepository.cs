using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid_Implmentation.Interfaces;

namespace Solid_Implmentation.Repositories
{
    public class InMemoryRepository<T> : IRepository<T>
    {
        public List<T> items = new List<T>();
        public void Add(T item)
        {
         
            items.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return items;
        }

        public T GetById(int id)
        {
            return items.FirstOrDefault(x => x.GetType().GetProperty("id").GetValue(x, null).Equals(id));
        }

        public void Remove(T item)
        {
          items.Remove(item);
        }
    }
}
