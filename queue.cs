using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    using System;
    using System.Collections;
    using System.Collections.Generic;
    using static ConsoleApp1.nodecs;

    public class Queue<T>
    {
        public List<T> frontPtr;
        public List<T> rearPtr;

        public Queue()
        {
            frontPtr = null;
            rearPtr = null;
        }

        public void Enqueue(T item)
        {
            List<T> newNode = new List<T>();
            newNode.Add(item);
            if (rearPtr == null)
            {
                frontPtr = rearPtr = newNode;
            }
            else
            {
                rearPtr = newNode;
            }
        }

        public void Dequeue()
        {
            if (frontPtr != null)
                frontPtr.Remove(frontPtr.First());
            else { 
                rearPtr = null;
            Console.WriteLine("Queue is empty!");
            }
        }

        public List<T> Front()
        {
            return frontPtr;
        }
        public List<T> Rear()
        {
                return rearPtr;
        }

        public bool IsEmpty()
        {
            return frontPtr == null;
        }

        public void Print()
        {
            
             List <T> current = frontPtr;
            current.AddRange(rearPtr);
             foreach (var o in current)
         {
            Console.WriteLine($"{o}");
                current = current;
            }
            //int listLength = current.Count();
            //while (current != null && )
            //{
            //    Console.WriteLine($"  {current}");
            //    current = current;
            //}
        }
        public int Count
        {
            get
            {
                int count = 0;
                List <T> current = frontPtr;
                while (current != null)
                {
                    count++;
                    current = current;
                }
                return count;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            List<T> list = new List<T>();
            List<T> current = frontPtr;

            while (current != null)
            {
                list.AddRange(current);
                current = current;
            }
            return list.GetEnumerator();
        }
    }
}

 
