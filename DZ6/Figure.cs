using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    public class Figure
    {
        private Point[] points;

        public Figure(Point[] points )
        {
            if (points.Length < 3)
            {
                Console.WriteLine("Need to enter more points");
            }
            this.points = points;
        }
        public Point[] Point
        {
            get { return points; }
        }

        public Point this[int index] 
        {
        
            get { return points[index]; }
        }

    }
}
