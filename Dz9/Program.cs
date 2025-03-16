
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9
{
    class Program
    {
        public delegate  int MyDelegate(int value);
        public delegate void MyDelegate2(ref int value);
        static void Main(string[] args)
        { 
         MyClass my = new MyClass();
         MyDelegate t = new MyDelegate(my.Method1);
                    t = new MyDelegate(my.Method2);
         Console.WriteLine(t.Invoke(3));
         Console.WriteLine("-----------------");
          
         MyDelegate2 t2 = new MyDelegate2(my.Method3);
                     t2 = new MyDelegate2(my.Method4);
                     int p = 3;
                     t2.Invoke( ref p);
            Console.ReadKey(); 
        }

    }
}
