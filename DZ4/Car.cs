using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public abstract class Car
    {
        private int DoorAmount { get; set; }
        private double EngineVolume { get; set; }
        private string Model { get; set; }
        public string ModelMark { get; init; }
        public string Colour { get; init; }
        private string FuelType { get; set; }
        public Transmission Transmission { get; set; }
        public Radio RadiO { get; set; }

        public Car(int DoorAmount,double EngineVolume,string Model,string FuelType)
        { 
         this.DoorAmount = DoorAmount;
         this.EngineVolume = EngineVolume;
         this.Model = Model;
         //this.ModelMark = ModelMark;
         //this.Colour = Colour;
         this.FuelType = FuelType;
         //this.Transmission = Transmission;
          RadiO = new Radio();
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
