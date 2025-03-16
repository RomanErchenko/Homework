using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class MiniVan: Car
    {
        
        public MiniVan(int doorAmount, double engineVolume, string model, string fuelType, string markOfRadio,double CurrentSpeed)
        : base(doorAmount, engineVolume, model, fuelType, markOfRadio, CurrentSpeed)
        {
           
        }

        public override void Accelerate(GasAcceleratorPedal pedal)
        {
            AccelerationFormula formula=new AccelerationFormula(Formula);
            formula.Invoke(CurrentSpeed, pedal);
        }

        public override void EnginePower()
        {
           base.EnginePower();
        }
    }
}
