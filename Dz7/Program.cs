using Dz7;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = Dz7.Point;

namespace DZ7
{
    //Створіть структуру Point. У тілі структури створіть два private поля типу int – x та y.
    //Створіть власний конструктор для ініціалізації полів при створенні. Створіть властивості для доступу
    //до полів без зміни полів.
   // Створіть клас Figure з private полем типу масиву елементів Point на 6 елементів та рядковим
   // private полем figureName для вказівки типу фігури, залежно від кількості
   // вершин фігури(non, dot, line, triangle, quadrangle, pentagon, hexagon).
   // Створіть індексатор.Значення figureName має змінюватися при додаванні та видаленні елементів
   // масиву відповідно до назви фігури з такою кількістю точок.
   // Продемонструйте роботу функціонала Figure у методі Main.
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Point p1 = new Point(12, 10);
            Point p2 = new Point(12, 20);
            Point p3 = new Point(2, 20);
            Point p4 = new Point(12, 22);

            Figure  figure = new Figure();
            figure[0] = p1;
            Console.WriteLine(figure.FigureName);

            figure[1] = p2;
            Console.WriteLine(figure.FigureName);

            figure[0] = null;
            Console.WriteLine(figure.FigureName);

            figure[0] = p1;
            figure[2] = p3;
            figure[3] = p4;
            Console.WriteLine(figure.FigureName);

            Console.ReadKey();
        }
    }
}