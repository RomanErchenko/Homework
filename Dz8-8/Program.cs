
using Dz8_8;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    class Program
    {
        static void Main(string[] args)
        {
          string word=  Console.ReadLine();
           word= word.ToLower();
            bool notFruit = true;
            bool notVegetable = true;
            for (Fruit friut = Fruit.Apple; friut <= Fruit.Berry; friut++)
            {
                if (friut.ToString().ToLower() == word)
                {
                    Console.WriteLine("kompot");
                    notFruit = false;
                }
            }
            for (Vegetable t = Vegetable.Carrot; t <= Vegetable.Sparge; t++)
            {
                if (t.ToString().ToLower() == word)
                {
                    Console.WriteLine("borsh");
                    notVegetable = false;
                }
            }
            if ((notFruit) && (notVegetable))
            { Console.WriteLine(" no such dish"); }
           

            Console.ReadKey();
        }
    }
}