using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    //1 :.Створіть клас Point c двома закритими int полями, що позначають координати X і Y в системі
    //Декартової координат.
    // Створіть статичний клас Geometry.У тілі класу створіть два перевизначення статичного
    // методу GetPerimeter для обчислення периметра трикутника і чотирикутника, що приймають
    // як аргументи екземпляри типу Point з координатами вершин фігури.Також створіть дві перевизначення
    // статичного методу GetAria для обчислення площі трикутника і чотирикутника,
    // що приймають як аргументи також екземпляри типу Point з координатами вершин фігури.
    // Майте на увазі, що фігури можуть бути неправильних форм і зі сторонами – не паралельними осям.
    // У методі Main продемонструйте роботу вказаних методів.
    //2 
    //Додайте до класу Geometry перевантаження методу GetAria, що приймає змінну кількість точок,
    //для обчислення площі простого багатокутника (немає перетинів сторін). Сторона багатокутника
    //позначається найближчими точками набору аргументів, а остання
    //точка з'єднана з першою (за рахунком).
    //3
    //Створіть клас Figure. У тілі класу створіть закрите поле типу масиву
    //елементів класу Point (з 1-2 завдання). Створіть метод розширення,
    //що виконує обчислення площі фігури, виходячи з того, що лінії сторін відповідають
    //найближчим елементам масиві точок (по індексу), а остання точка з'єднана
    //з першою (за рахунком).


    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(3,4);
            Point B = new Point(5,1);
            Point C = new Point(4,2);
            Point D = new Point(6,9);
            Point E = new Point(11, 7);

            double triangle = Geometry.GetPerimetr(A,B,C);
            Console.WriteLine($"Perimetr of Triange: {triangle}");
            Console.WriteLine(new string('-',30));

            double quadrangle= Geometry.GetPerimetr(A, B,C,D);
            Console.WriteLine($"Perimetr of Quadrangle: {quadrangle}");
            Console.WriteLine(new string('-', 30));

            triangle = Geometry.GetArea(A,B,C);
            Console.WriteLine($"Area of Triange: {triangle}");
            Console.WriteLine(new string('-', 30));

            quadrangle = Geometry.GetArea(A, B, C, D);
            Console.WriteLine($"Area of Quadrangle: {quadrangle}");
            Console.WriteLine(new string('-', 30));

            Point[] p = [A,B,C,D,E,];
            double multiangle = Geometry.GetArea(p);
            Console.WriteLine($"Area of MultiAngle: {multiangle}");
            Console.WriteLine(new string('-', 30));

            Figure figure = new Figure(p);
            figure.GetAreaExtansion();
            Console.WriteLine($"ExtantionMethodInfo: {figure.GetAreaExtansion()}");
            Console.WriteLine(new string('-', 30));

            Point fig = figure[0];
            Console.WriteLine($"cordinate: {fig.X},{fig.Y}");
            Console.ReadKey();
        }
    }
}