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

        public override void Accelerate(GasAcceleratorPedal pedal)
        {
            if (EngineCondition == EngineState.SwitchedOn)
            {
                AccelerationFormula formula = new AccelerationFormula(Formula);
                formula.Invoke(CurrentSpeed, pedal);
            }
        }

        public override void EnginePower()
        {
            Console.WriteLine("Increase power engine");
        }

    }
}
