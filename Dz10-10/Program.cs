
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
            ArrayDisplayer<int> arr =new ArrayDisplayer<int>(3);
            arr.Add(1);
            arr.Add(2);
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[3]);
            arr.DisplayInfo();

            ArrayDisplayer<string> ar1 = new ArrayDisplayer<string>(3);
            ar1.Add("rrr");
            ar1.Add("yy");
            Console.WriteLine(ar1[0]);
            Console.WriteLine(ar1[3]);
            Console.ReadKey();
        }

    }
}

