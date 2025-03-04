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
        public MiniVan(int doorAmount, double engineVolume, string model, string fuelType, string MarkOfRadio)
        : base(doorAmount, engineVolume, model, fuelType, MarkOfRadio)
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
    }
}
