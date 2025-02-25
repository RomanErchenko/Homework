using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public abstract class Car
    {
        private int doorAmount;
        private double engineVolume;
        private string model;
        private string fuelType;
        public string ModelMark { get; init; }
        public string Colour { get; set; }
        public Transmission Transmission { get; init; }
        public Radio Radio { get; set; }

        public int DoorAmount
        { 
          get { return doorAmount; }
        }
        public double EngineVolume
        {
            get { return engineVolume; }
        }
        public string Model
        {
            get { return model; }
        }
        public string FuelType
        {
            get { return fuelType; }
        }

        public Car(int doorAmount, double engineVolume, string model, string fuelType)
        { 
         this.doorAmount = doorAmount;
         this.engineVolume = engineVolume;
         this.model = model;
         this.fuelType = fuelType;
         
          
        }
        public virtual void EnginePower()
        {
            Console.WriteLine("NormalPower");
        }
        public abstract void Accelerate();
        public virtual void Start()
        {
            Console.WriteLine("Mechanical start by rotation key");
        }
        public  void Stop()
        {
            Console.WriteLine("Mechanical stop by rotation key");
        }
        public  void WindowWashing()
        {
            Console.WriteLine("Window washing");
        }

        public virtual void Show()
        {
            Console.WriteLine(DoorAmount);
            Console.WriteLine(EngineVolume);
            Console.WriteLine(Model);
            Console.WriteLine(ModelMark);
            Console.WriteLine(Colour);
            Console.WriteLine(FuelType);
            Console.WriteLine(Transmission);

        }
    }
}
