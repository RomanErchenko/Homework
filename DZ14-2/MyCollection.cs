using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ14_2
{
    public class MyCollection<T>
    {
        public T[] mass=new T[10];
        private int count=0;

        public void Add(T elem)
        {
            if (count < 10)
            {
                mass[count] = elem;
                count++;
            }
        }

        public IEnumerable<T> GetEvenIndexValues()
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (i % 2 == 0)
                {
                 yield return mass[i];
                }    
            }
        
        }

        public IEnumerable<T> GetOddIndexValues()
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (i % 2 != 0)
                {
                    yield return mass[i];
                }
            }

        }
    }
}
