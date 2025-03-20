using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10
{
    class MyClass
    {
        public void Method1<T>(ref T value1, ref T value2)
        {
            T prop = value1;
            value1 = value2;
            value2 = prop;
        }
        public void Method2<T>(ref T value1, ref T value2)
        {
            Console.WriteLine($"Range of value1: {value1},Range of value2: {value2}");
        }

    }
   class Program
   {
      public delegate void MyDelegate<T>(ref T value, ref T value2);
       
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            int m = 2;
            int n = 3;
            MyDelegate<int> my1 = new MyDelegate<int>(my.Method2<int>);
            my1.Invoke(ref m, ref n);
            my1 = new MyDelegate<int>(my.Method1<int>);
            my1.Invoke(ref m, ref n);
            my1 = new MyDelegate<int>(my.Method2<int>);
            my1.Invoke(ref m,ref n);

            string p = "Test";
            string k = "word";
            MyDelegate<string> my2 = new MyDelegate<string>(my.Method2<string>);
            my2.Invoke(ref p, ref k);
            my2 = new MyDelegate<string>(my.Method1<string>);
            my2.Invoke(ref p, ref k);
            my2 = new MyDelegate<string>(my.Method2<string>);
            my2.Invoke(ref p, ref k);

            Console.ReadKey();
        }
   }
}