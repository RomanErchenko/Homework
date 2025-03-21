using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10_10
{
    public class ArrayDisplayer<T>
    {
       private T[] array;
       private DateTime[] date;
       private int amount;

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
               return default;
            }
        }

        public void Add(T item)
        {
            //for (int i = 0; i < array.Length; i++) 
            //{
            // if (EqualityComparer<T>.Default.Equals(array[i], default(T)))
            // {
            //      array[i] = item;
            //      date[i] = DateTime.Now;
            //        amount++;
            //      break;
            // }
            //}
            if (amount < array.Length)
            {
                array[amount] = item;
                date[amount] = DateTime.Now;
                amount++;
            }
        }

        public void DisplayInfoOnConsole()
        {
            for (int i = 0; i < amount; i++)
            {
                    Console.WriteLine($"number in slot:{i}");
                    Console.WriteLine($"Info inside slot:{array[i]}");
                    Console.WriteLine($"Date of producing:{date[i]}");
            } 
            int empty=array.Length-amount;
            Console.WriteLine($"Empty slots:{empty}");
            Console.WriteLine($"Slots with information:{amount}");
            Console.WriteLine($"Type of element:{array.GetType()}");
            Console.WriteLine(new string('-',33));
        }
    }
}
