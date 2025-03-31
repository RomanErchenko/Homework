using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    public static class Geometry
    {
        public static double GetSide(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static double GetPerimetr(Point A, Point B, Point C)
        {
            double side1 = GetSide(A.X, B.X, A.Y, B.Y);
            double side2 = GetSide(B.X, C.X, B.Y, C.Y);
            double side3 = GetSide(A.X, C.X, A.Y, C.Y);
            return  side1 + side2 + side3;
        }

        public static double GetPerimetr(Point A, Point B, Point C, Point D)
        {
            double side1 = GetSide(A.X, B.X, A.Y, B.Y);
            double side2 = GetSide(B.X, C.X, B.Y, C.Y);
            double side3 = GetSide(C.X, D.X, C.Y, D.Y);
            double side4 = GetSide(A.X, D.X, A.Y, D.Y);
            return side1 + side2 + side3 + side4;
        }

        public static double GetArea(Point A, Point B, Point C)
        {
            return 0.5 * Math.Abs(A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X * (A.Y - B.Y));
        }

        public static double GetArea(Point A, Point B, Point C, Point D)
        {
            double triangle1 = GetArea(A, B, C);
            double triangle2 = GetArea(B, C, D);
            return triangle1 + triangle2;
        }

        public static double GetArea(params Point[] p)
        {
            if (p.Length < 3)
            {
                Console.WriteLine("Need to enter more points");
                return 0;
            }
            double area = 0;
            int n=p.Length;
            for (int i = 0; i < n; i++)
            {
                int j = (i + 1) % n;
                area += p[i].X * p[j].Y - p[j].X * p[i].Y;
            }
            return Math.Abs(area) / 2;
        }
        public static double GetAreaExtansion(this Figure figure)
        {
            Point[] p=figure.Point;
            double area = 0;
            int n = p.Length;
            for (int i = 0; i < n; i++)
            {
                int j = (i + 1) % n;
                area += p[i].X * p[j].Y - p[j].X * p[i].Y;
            }
            return Math.Abs(area) / 2;
        }
    }
}