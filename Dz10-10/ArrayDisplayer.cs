using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10_10
{
    public class ArrayDisplayer<T>
    {
       private T[] arrayitems;
       private DateTime[] dates;
       private int counter;

        public ArrayDisplayer(int n)
        { 
          arrayitems = new T[n];
          dates = new DateTime[n];
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < counter)
                {
                    return arrayitems[index];
                }
               return default;
            }
        }

        public void AddItemToMass(T item)
        {
          
            if (counter < arrayitems.Length)
            {
                arrayitems[counter] = item;
                dates[counter] = DateTime.Now;
                counter++;
            }
        }

        public void DisplayInfoOnConsole()
        {
            for (int i = 0; i < counter; i++)
            {
             Console.WriteLine($"number in slot:{i}");
             Console.WriteLine($"Info inside slot:{arrayitems[i]}");
             Console.WriteLine($"Date of producing:{dates[i]}");
            } 

            int empty=arrayitems.Length-counter;
            Console.WriteLine($"Empty slots:{empty}");
            Console.WriteLine($"Slots with information:{counter}");
            Console.WriteLine($"Type of element:{arrayitems.GetType()}");
            Console.WriteLine(new string('-', 33));
        }
    }
}
