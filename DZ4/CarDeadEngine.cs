using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class CarDeadEngine:Exception
    {
        private double EngineVolume { get; set; }
        private DateTime DamageTime { get; set; }
        private double MaxSpeed { get; set; }
        public CarDeadEngine(double EngineVolume,double MaxSpeed,string message):base(message)
        {
            this.EngineVolume = EngineVolume;
            this.MaxSpeed = MaxSpeed;
            DamageTime = DateTime.Now;
          
        }
        public void Show()
        {
            Console.WriteLine($"Engine Power{EngineVolume}");
            Console.WriteLine($"Max speed was increased to much{MaxSpeed}");
            Console.WriteLine($"Time log {DamageTime }");
        }
    }

    
}
