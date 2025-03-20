using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10_10
{
    public class ArrayDisplayer<T>
    {
        T[] array;
        DateTime[] date;
        int amount;
        public ArrayDisplayer(int n)
        { 
          array = new T[n];
          date = new DateTime[n];
        }
        public T this[int index]
        {
            get
            {

                if (index >= 0 && index < amount)
                {
                    return array[index];
                }
                // throw new IndexOutOfRangeException("Index out of range");
               return default;
            }
        }
        public void Add(T item)
        {
            for (int i = 0; i < array.Length; i++) 
            {
             if (EqualityComparer<T>.Default.Equals(array[i], default(T)))
                {
                  array[i] = item;
                  date[i] = DateTime.Now;
                    amount++;
                  break;
                }
            }
        } 
        public void DisplayInfo()
        {
            int count = 0;
            for (int i = 0; i < date.Length; i++)
            {
                if (date[i] != DateTime.MinValue)
                {
                    Console.WriteLine($"number in slot:{i}");
                    Console.WriteLine($"Info inside slot:{array[i]}");
                    Console.WriteLine($"Date of producing:{date[i]}");
                    count++;
                }
            } 
            int empty=array.Length-count;
            Console.WriteLine($"Empty slots:{empty}");
            Console.WriteLine($"Slots with information:{count}");
            Console.WriteLine($"Type of element:{array.GetType()}");
            Console.WriteLine(new string('-',33));
        }
    }
}
