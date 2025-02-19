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
        private string ModelMark { get; set; }
        private string Colour { get; set; }
        private string FuelType { get; set; }
        private Transmission Transmission { get; set; }
        public Radio Radio { get; set; }

        public Car(int DoorAmount,double EngineVolume,string Model,string ModelMark,string Colour,string FuelType, Transmission Transmission)
        { 
         this.DoorAmount = DoorAmount;
         this.EngineVolume = EngineVolume;
         this.Model = Model;
         this.ModelMark = ModelMark;
         this.Colour = Colour;
         this.FuelType = FuelType;
         this.Transmission = Transmission;
          Radio = new Radio();
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
        public virtual void Stop()
        {
            Console.WriteLine("Mechanical stop by rotation key");
        }
        public  void WindowWashing()
        {
            Console.WriteLine("Window washing");
        }

        public void Show()
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
