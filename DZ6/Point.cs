using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    public struct Point
    {
        
        public readonly int X {get;}
        public readonly int Y { get; }


        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }   
    }
}
