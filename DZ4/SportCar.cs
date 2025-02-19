using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class SportCar:Car
    {
        public SportCar(int DoorAmount,double EngineVolume,string Model,string ModelMark,string Colour,string FuelType,Transmission Transmission) :base( DoorAmount,EngineVolume,Model,ModelMark,Colour,FuelType,Transmission)
        {
            Accelerate();
            EnginePower();
            Start();
            Stop();
            Show();
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
        public override void Stop()
        {
            Console.WriteLine("Automatic start from button");
        }
        
    }
}
