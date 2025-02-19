using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class MiniVan:Car
    {
        public MiniVan(int DoorAmount, double EngineVolume, string Model, string ModelMark, string Colour, string FuelType, Transmission Transmission) : base(DoorAmount, EngineVolume, Model, ModelMark, Colour, FuelType, Transmission)
        {
            Accelerate();
            EnginePower();
            Start();
            Stop();
            Show();
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
        public void TurnOFFRadio()
        {
            Radio.Condition = false;
            if (Radio.Condition == true)
            {
                Console.WriteLine("Radion is off");
            }
        }
    }
}
