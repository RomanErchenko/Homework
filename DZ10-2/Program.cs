using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10
{
    class Myclass<T>
    {
       
        public T[] massive = new T[0];

        public void Add(T value)
        {
            T[] mass=new T[massive.Length+1];
            for (int i = 0; i < massive.Length; i++)
            {
                mass[i] = massive[i];
            }
            massive = new T[massive.Length + 1];
            mass[massive.Length - 1] = value;
            massive = mass;
            
        }
        public T this[int index]
        {
            get
            {
              
                    if (index >= 0 && index < massive.Length)
                    {
                        return massive[index];
                    }
                    throw new IndexOutOfRangeException("Индекс выходит за границы массива");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        
            Myclass<int> myclass = new Myclass<int>();
            myclass.Add(1);
            Console.WriteLine(myclass[0]);
            myclass.Add(3);
            Console.WriteLine(myclass[1]);
            Console.ReadKey();
        }
    }
}