using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz13_1
{
    public delegate void MyDelegate();
    public class Program
    {
        public static void Method()
        {
            Console.WriteLine("info from method");
            Thread.Sleep(1000);
        }
        public static void Method1()
        {
            Console.WriteLine("info from method 1");
            Thread.Sleep(1000);
        }
        public static void Method2()
        {
            while (true) 
            {
                Console.BackgroundColor = ConsoleColor.Red;  
                Console.Clear(); 
                Console.ForegroundColor = ConsoleColor.White;  
                Console.WriteLine("thread 3");
                Console.ResetColor();
                Thread.Sleep(1000);
            }
        }
        public static void Method3()
        {
            while (true)
            {   
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("           thread 4");
                Console.ResetColor();
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            //    Thread thread1 = new Thread(new ThreadStart(Method1));
            //    Thread thread2 = new Thread(new ThreadStart(Method2));
            //    Thread thread3 = new Thread(new ThreadStart(Method3));

            //    thread1.Start();
            //    thread2.Start();
            //    thread3.Start();

            MyDelegate my = new MyDelegate(Method);
            my.Invoke();
            my = new MyDelegate(Method1);
            my.Invoke();

            Console.ReadKey();
        }
    }
}
