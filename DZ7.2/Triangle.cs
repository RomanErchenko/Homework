using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static DZ7._2.Triangle;

namespace DZ7._2
{
    public class Triangle
    {
        private TriangleData data;

        public Triangle(double sideA, double sideB, double sideC)
        {
            data = TriangleMethod(sideA, sideB, sideC);
        }

        public TriangleData TriangleMethod(double sideA, double sideB, double sideC)
        {
            if (!IsValidTriangle(sideA, sideB, sideC))
            {
                Console.WriteLine("The provided sides do not form a valid triangle.");
            }
            return new TriangleData(sideA, sideB, sideC);
        }

        private static bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
        }
        public void ShowTriangleData()
        {
            Console.WriteLine($"Sides: {data.SideA}, {data.SideB}, {data.SideC}");
            Console.WriteLine($"Perimeter: {data.Perimetr}");
            Console.WriteLine($"Area: {data.Area}");
            Console.WriteLine($"Type: {data.TriangleType}");
        }
        public struct TriangleData
        { 
         
         public readonly double SideA { get; }
         public readonly double SideB { get; }
         public readonly double SideC { get; }
         public readonly double Perimetr { get; }
         public readonly double Area { get; }
         public readonly string TriangleType { get; }
            public TriangleData(double sideA, double sideB, double sideC)
            {
             this.SideA = sideA;
             this.SideB = sideB;
             this.SideC = sideC;
             Perimetr =sideA + sideC + sideC;
             double semiPerimeter = Perimetr / 2;
             Area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
             TriangleType = DetermineTriangleType(sideA, sideB, sideC);

            }

            private static string DetermineTriangleType(double a, double b, double c)
            {
                double[] sides = { a, b, c };
                Array.Sort(sides); 

                if (sides[0] == sides[1] && sides[1] == sides[2]) return "Equilateral";
                if (sides[0] == sides[1] || sides[1] == sides[2]) return "Isosceles";
                if (Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 1e-10)
                    return "Right-angled";
                return "Scalene";
            }
        }

    }
}
