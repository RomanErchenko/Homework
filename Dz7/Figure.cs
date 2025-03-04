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
        public Points?[] point = new Points?[6];
        private string figureName;
        int count;
        public string FigureName
        { 
         get { return figureName; } 
        }
        public Points? this[int index]
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
                Check();
            }
        }
        public void Check()
        {
            count = 0;
            for (int i = 0; i < point.Length; i++)
            {
                if (point[i] != null)
                { 
                  count++;
                }

            }
            if (count == 0)
            {
                figureName = FigureType.non.ToString();
            }
            if (count == 1)
            {
                figureName = FigureType.dot.ToString();
            }
            if (count == 2)
            {
                figureName = FigureType.line.ToString();
            }
            if (count == 3)
            {
                figureName = FigureType.triangle.ToString();
            }
            if (count == 4)
            {
                figureName = FigureType.quadrangle.ToString();
            }
            if (count == 5)
            {
                figureName = FigureType.pentagon.ToString();
            }
            if (count == 6)
            {
                figureName = FigureType.hexagon.ToString();
            }

        }


    }
}
