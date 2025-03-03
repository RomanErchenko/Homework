using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class SportCar: Car
    {
        public SportCar(int DoorAmount, double EngineVolume, string Model, string FuelType)
        :base( DoorAmount, EngineVolume, Model, FuelType)
        {
        }
        public override void Accelerate()
        {
            Console.WriteLine("Speed up procedure by computer,controlling fuel injection");
        }
        public override void EnginePower()
        {
            Console.WriteLine("Increase power engine");
        }
        public override void Start()
        {
            Console.WriteLine("Automatic start from button");
        }

        public void TurnOnRadio()
        {
            Radio.Condition = true;
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
