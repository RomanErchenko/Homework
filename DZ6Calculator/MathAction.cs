using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6Calculator
{
    public static class MathAction
    {
        
        public static double Sum(double d1, double d2)
        { 
         return d1+d2;
        }
        public static double Division(double d1, double d2,out string message)
        {
            
            if (d2 == 0)
            {
                message = "Error";
                return 0;
            }
            else
            {
                message = "ok";
                return d1/ d2;  
            }
        }
        public static double Difference(double d1, double d2)
        {
            return d1 - d2;
        }
        public static double Multiply(double d1, double d2)
        {
            return d1 * d2;
        }


    }
}
