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
         private readonly double sideA;
         private readonly double sideB;
         private readonly double sideC;
         private readonly double perimeter;
         private readonly double area;
         private readonly string triangleType;
         public double SideA => sideA;
         public double SideB => sideB;
         public double SideC => sideC;
         public double Perimetr => perimeter;
         public double Area => area;
         public string TriangleType => triangleType;
         public TriangleData(double sideA, double sideB, double sideC)
         {
          this.sideA = sideA;
          this.sideB = sideB;
          this.sideC = sideC;
          perimeter =sideA + sideC + sideC;
          double semiPerimeter = perimeter / 2;
          area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
          triangleType = DetermineTriangleType(sideA, sideB, sideC);

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
