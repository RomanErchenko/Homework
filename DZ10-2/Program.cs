using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10
{
    class MyMassive<T>
    {
       
        public T[] Titems = new T[0];

        public void Add(T value)
        {
            T[] mass=new T[Titems.Length + 1];
            for (int i = 0; i < Titems.Length; i++)
            {
                mass[i] = Titems[i];
            }
            Titems = new T[Titems.Length + 1];
            mass[Titems.Length - 1] = value;
            Titems = mass;
            
        }
        public T this[int index]
        {
            get
            {
              
                    if (index >= 0 && index < Titems.Length)
                    {
                        return Titems[index];
                    }
                    return  default;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        
            MyMassive<int> myclass = new MyMassive<int>();
            myclass.Add(1);
            Console.WriteLine(myclass[0]);
            myclass.Add(3);
            Console.WriteLine(myclass[1]);
            Console.ReadKey();
        }
    }
}