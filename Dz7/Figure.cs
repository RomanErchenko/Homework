using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dz7
{
    public enum FigureType
    {
        non,
        dot,
        line,
        triangle,
        quadrangle, 
        pentagon,
        hexagon
    }
    public class Figure
    {
        public Point[] point = new Point[6];
        private string figureName;
        int count=0;
        public Point this[int index]
        {
            get 
            {
                for (int i = 0; i < point.Length; i++)
                {
                    if (index == i) 
                    {
                        return point[i];
                    }
                }
                return point[index];    
            }
            set 
            {
                point[index] = value;
                
            }
        }

        public void Check()
        {
            for (int i = 0; i < point.Length; i++)
            {
                if (point[i].)
            }


        }


    }
}
