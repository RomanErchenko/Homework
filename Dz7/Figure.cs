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
           
          figureName = count switch
           {
              0 => FigureType.non.ToString(),
              1 => FigureType.dot.ToString(),
              2 => FigureType.line.ToString(),
              3 => FigureType.triangle.ToString(),
              4 => FigureType.quadrangle.ToString(),
              5 => FigureType.pentagon.ToString(),
              6 => FigureType.hexagon.ToString()
           };
        }
    }
}
