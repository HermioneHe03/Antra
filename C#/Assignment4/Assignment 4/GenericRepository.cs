using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_4;

namespace Assignment_4
{
    public class GenericRepository<T>: IGenericRepository<T> where T: class
    {
        public List<T> list = new List<T>();


        public void Add(T item)
        {
            list.Add(item);
        }
        public void Remove(T item)
        { list.Remove(item);}
        public void Save()
        { throw new NotImplementedException(); }
        public IEnumerable<T> GetAll()
        { return list; }
        public T GetById(int id)
        { return list[id]; }

    }

    
}
