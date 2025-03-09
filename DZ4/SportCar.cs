using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class SportCar: Car
    {
        public SportCar(int doorAmount, double engineVolume, string model, string fuelType, string markOfRadio)
        :base( doorAmount, engineVolume, model, fuelType, markOfRadio)
        {

        }

        public override void Accelerate()
        {
            CurrentSpeed += 50;
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
