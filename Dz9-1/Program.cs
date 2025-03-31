
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6Calculator
{
    class Program
    {
        public delegate double MathFunc(double x,double y);
        public delegate double Div(double x, double y, out string message);
       
        static void Main(string[] args)
        {
            MathFunc mul = (dig1, dig2) => dig1 * dig2;
            Div div = (double dig1, double dig2, out string message) =>
            {
                if (dig2 != 0)
                {
                    message = "Success";
                    return dig1 / dig2;
                }
                else
                {
                    message = "Division by zero";
                    return double.NaN;
                }
            };
            MathFunc sum = delegate (double dig1, double dig2) { return dig1 + dig2; };
            MathFunc diff = (dig2, dig1) => dig2 - dig1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Calculator ===");
                Console.WriteLine("Enter first digit");
                double dig1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second digit");
                double dig2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1. Multiply 1");
                Console.WriteLine("2. Division 2");
                Console.WriteLine("3. Sum 3");
                Console.WriteLine("4. Difference 4");
                Console.WriteLine("5. Exit");
                Console.Write("Choose Action:");
                double result;
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                         double mult=mul(dig1, dig2);
                        Console.WriteLine("Multiply: " + mult);
                        break;
                    case "2":

                        string  message;
                        double divizion = div(dig1, dig2, out message);
                        Console.WriteLine("Multiply: " + divizion+message);
                        break;

                    case "3":

                       double summ=sum(dig1, dig2);
                        Console.WriteLine("Sum: " + summ);
                        break;

                    case "4":

                       double differ=diff(dig1, dig2);
                        Console.WriteLine("Difference: " + diff);
                        break;

                    case "5":

                        Console.WriteLine("Exit from Calculator...");
                        return;

                    default:

                        Console.WriteLine("Not correct input data.");
                        break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}