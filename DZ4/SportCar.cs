using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class SportCar: Car
    {
        public SportCar(int doorAmount, double engineVolume, string model, string fuelType, string markOfRadio,double CurrentSpeed)
        :base( doorAmount, engineVolume, model, fuelType, markOfRadio,CurrentSpeed)
        {

        }

        public override void Accelerate(GasAcceleratorPedal pedal)
        {
            AccelerationFormula formula = new AccelerationFormula(Formula);
             formula.Invoke(CurrentSpeed, pedal);
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
