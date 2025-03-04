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
        static void Main(string[] args)
        {
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

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                       MathAction.Multiply(dig1, dig2);
                        break;
                    case "2":
                       MathAction.Division(dig1, dig2);
                        break;
                    case "3":
                        MathAction.Sum(dig1, dig2);
                        break;
                    case "4":
                        MathAction.Difference(dig1, dig2);
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