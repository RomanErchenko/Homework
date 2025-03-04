using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz7Temperature
{
    public struct Temperature
    {
        public double TempC { get; set; }
        public double TempF { get; set; }
        public double TempK { get; set; }
        public Temperature(double TempC)
        { 
         this.TempC = TempC;
        }
        public void Show()
        {
            Console.WriteLine($"Temp in C: {TempC}");
            Console.WriteLine($"Temp in F: {TempF}");
            Console.WriteLine($"Temp in K: {TempK}");
        }
        public void TempConvert()
        { 
         TempF = TempC*9/5+32;
         TempK = TempC + 273;
        }
    }
}
