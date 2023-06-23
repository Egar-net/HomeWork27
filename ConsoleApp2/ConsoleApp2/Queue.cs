using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    public class Queue<T> : DataStrukture, IDataVisualizer<T>
    {
        public void Enqueue(T element)
        {
            data.Add(element);
        }

        public T Dequeue()
        {
            if (data.Count == 0)
            {
                throw new InvalidOperationException("Очередь пуста");
            }

            T element = (T)data[0];
            data.RemoveAt(0);
            return element;
        }

        public void VisualizeData()
        {
            Console.WriteLine("Очередь:");
            foreach (T element in data)
            {
                Console.WriteLine(element);
            }
        }
    }
}
