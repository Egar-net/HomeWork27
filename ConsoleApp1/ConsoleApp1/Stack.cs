using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Stack<T>
    {
        private List<T> LIFO = new List<T>();
        
        public void Push(T element)
        {
            LIFO.Add(element); 
        }

        public T Pop() 
        {
           if (LIFO.Count == 0)
           {
                Console.WriteLine("Stack пустой");
           }

            int lastNum = LIFO.Count - 1; 
             T lastItem = LIFO[lastNum];
            LIFO.RemoveAt(lastNum); 
            return lastItem;
        }


    }
}
