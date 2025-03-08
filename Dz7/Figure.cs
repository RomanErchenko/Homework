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
        Non,
        Dot,
        Line,
        Triangle,
        Quadrangle, 
        Pentagon,
        Hexagon
    }
    public class Figure
    {
        public Point?[] point = new Point?[6];
        private string figureName;
        int count;

        public string FigureName
        { 
         get { return figureName; } 
        }

        public Point? this[int index]
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
           
          figureName = count switch
           {
              0 => FigureType.Non.ToString(),
              1 => FigureType.Dot.ToString(),
              2 => FigureType.Line.ToString(),
              3 => FigureType.Triangle.ToString(),
              4 => FigureType.Quadrangle.ToString(),
              5 => FigureType.Pentagon.ToString(),
              6 => FigureType.Hexagon.ToString()
           };
        }
    }
}
