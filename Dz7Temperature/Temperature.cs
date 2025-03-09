using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz7Temperature
{
    public struct Temperature
    {
        public double TempC { get;}
        public double TempF { get;}
        public double TempK { get;}
        public Temperature(double TempC)
        { 
         this.TempC = TempC;
         this.TempF = TempC * 9 / 5 + 32;
         this.TempK = TempC + 273;
        }
        public void Show()
        {
            Console.WriteLine($"Temp in C: {TempC}");
            Console.WriteLine($"Temp in F: {TempF}");
            Console.WriteLine($"Temp in K: {TempK}");
        }
    }
}
