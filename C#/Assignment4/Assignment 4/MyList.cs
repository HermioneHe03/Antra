using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class MyList<T>
    {
        List<T> list;
        public void Add(T element)
        {
            list.Add(element);
        }
        public T Remove(int index)
            { return list[index]; }
        public bool Contains(T element)
        {
            foreach(T item in list)
            {
                if(item.Equals(element)) return true;
            }
            return false;
        }

        public void Clear()
        { list = new List<T>(); }
        public void InsertAt(T element, int index)
        { list[index] = element; }
        public void DeleteAt(int index)
        { list.RemoveAt(index); }
        public T Find(int index)
        { return (T)list[index]; }

    }
}
