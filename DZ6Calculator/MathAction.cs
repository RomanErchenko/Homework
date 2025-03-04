using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6Calculator
{
    public static class MathAction
    {
        public static void Sum(double d1, double d2)
        { 
         Console.WriteLine($"Sum of two didgit are: {d1 + d2}");
        }
        public static void Division(double d1, double d2)
        {
            if (d2 == 0)
            {
                Console.WriteLine("Division by zero");
            }
            else
            {
                Console.WriteLine($"Division of two didgit are: {d1 / d2}");
            }
        }
        public static void Difference(double d1, double d2)
        {   
            Console.WriteLine($"Difference of two didgit are: {d1 - d2}");
        }
        public static void Multiply(double d1, double d2)
        {
            Console.WriteLine($"Multiply of two didgit are: {d1 * d2}");
        }


    }
}
