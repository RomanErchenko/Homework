using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    public  class Figure
    {
        private Point[] point;

        public Figure(Point[] point )
        {
            if (point.Length < 3)
            {
                Console.WriteLine("Need to enter more points");
            }
            this.point = point;
        }
        public Point[] Point
        {
            get { return point; }
        }

    }
}
