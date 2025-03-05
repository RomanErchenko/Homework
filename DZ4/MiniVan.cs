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
        public MiniVan(int doorAmount, double engineVolume, string model, string fuelType, string markOfRadio)
        : base(doorAmount, engineVolume, model, fuelType, markOfRadio)
        {
        }
        public override void Accelerate()
        {
            double power=0;
            power = power + 20;
            Console.WriteLine("Power Accelerate: " + power);
        }
        public override void EnginePower()
        {
           base.EnginePower();
        }
    }
}
