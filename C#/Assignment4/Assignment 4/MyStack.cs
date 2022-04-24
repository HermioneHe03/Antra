using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class MyStack<T>
    {
        Stack<T> stack = new Stack<T>();
        public int Count()
            { return stack.Count; }
        public T Pop()
            { return stack.Pop(); }
        public void Push()
            { stack.Push(stack.Pop()); }
    }
}
