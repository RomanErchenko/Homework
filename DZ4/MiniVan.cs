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
        public MiniVan(int DoorAmount, double EngineVolume, string Model,string FuelType) : base(DoorAmount, EngineVolume, Model,FuelType)
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
         RadiO.Condition=true;
         if (RadiO.Condition == true)
            {
                Console.WriteLine("Radion is on");
            }
        
        }
        public void TurnOFFRadio()
        {
            RadiO.Condition = false;
            if (RadiO.Condition != true)
            {
                Console.WriteLine("Radion is off");
            }
        }
       
    }
}
