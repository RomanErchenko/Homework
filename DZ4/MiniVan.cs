using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class MiniVan:Car
    {
        public MiniVan(int doorAmount, double engineVolume, string model,string fuelType)
        : base(doorAmount, engineVolume, model,fuelType)
        {
        }
        public override void Accelerate()
        {
            Console.WriteLine("Normal speed");
        }
        public override void EnginePower()
        {
           base.EnginePower();
        }

        public void TurnOnRadio()
        { 
         Radio.Condition=true;
         if (Radio.Condition == true)
            {
                Console.WriteLine("Radion is on");
            }
        
        }
        public void TurnOffRadio()
        {
            Radio.Condition = false;
            if (Radio.Condition != true)
            {
                Console.WriteLine("Radion is off");
            }
        }
       
    }
}
