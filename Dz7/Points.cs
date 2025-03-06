using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz7
{
    public struct Points
    {
        private int x;
        private int y;

        public Points(int x,int y)
        { 
        this.x = x;
        this.y = y;
        }

        public int X
        {
          get { return x; }
        }
        public int Y
        {
          get { return y; } 
        }

    }
}
