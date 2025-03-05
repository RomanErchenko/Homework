using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class SportCar: Car
    {
        public SportCar(int DoorAmount, double EngineVolume, string Model, string FuelType, string MarkOfRadio)
        :base( DoorAmount, EngineVolume, Model, FuelType, MarkOfRadio)
        {
        }
        public override void Accelerate()
        {
            double power = 0;
            power = power + 50;
            Console.WriteLine("Power Accelerate: " + power);
        }
        public override void EnginePower()
        {
            Console.WriteLine("Increase power engine");
        }
        public override void Start()
        {
            Console.WriteLine("Automatic start from button");
        }

    }
}
