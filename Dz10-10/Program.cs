
using Dz10_10;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10
{
    // Створити клас ArrayDisplayer - зробити його дженеріком.
    // Створити там масив на таку к-ть елементів,я ку передано в конструкторі,
    // для доступу до елементів звичайний індексатор з валідацією на вихід індексу
    // за межі - доступ тільки до заповнених елементів, тільки на читання.
    // Метод Add - додає новий елемент наступним і фіксує в інший
    // масив дату час додавання. Метод DisplayInfo виводить таку інформацію
    // на консоль - скільки вже заповнено елементів масиву, скільки залишилось,
    // якого типу елементи і виводить їх всіх з нумерацією і з датою додавання.
    class Program
    {
        static void Main(string[] args)
        {
            ArrayDisplayer<int> arrinteger = new ArrayDisplayer<int>(3);
            arrinteger.AddItemToMass(1);
            arrinteger.AddItemToMass(2);
            Console.WriteLine(arrinteger[0]);
            Console.WriteLine(arrinteger[1]);
            Console.WriteLine(arrinteger[3]);
            arrinteger.DisplayInfoOnConsole();

            ArrayDisplayer<string> arrstring = new ArrayDisplayer<string>(3);
            arrstring.AddItemToMass("rrr");
            arrstring.AddItemToMass("yy");
            Console.WriteLine(arrstring[0]);
            Console.WriteLine(arrstring[3]);
            arrstring.DisplayInfoOnConsole();

            Console.ReadKey();
        }

    }
}

