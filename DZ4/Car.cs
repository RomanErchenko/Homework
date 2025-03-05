using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public abstract class Car
    {
        private readonly Radio radio;
        private int DoorAmount { get; set; }
        private double EngineVolume { get; set; }
        private string Model { get; set; }
        private string FuelType { get; set; }
        public string ModelMark { get; init; }
        public string Colour { get; set; }
        public Transmission Transmission { get; init; }

        public Car(int doorAmount, double engineVolume, string model, string fuelType,string markOfRadio)
        { 
         this.DoorAmount = doorAmount;
         this.EngineVolume = engineVolume;
         this.Model = model;
         this.FuelType = fuelType;
          radio = new Radio(markOfRadio);  
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

        private class Radio
        {
            public bool Condition { get; set; }
            public string MarkOfRadio { get; }
            public Radio(string MarkOfRadio)
            {
                this.MarkOfRadio = MarkOfRadio;
            }
        }

        public void TurnOnRadio()
        {
            radio.Condition = true;
            if (radio.Condition)
            {
                Console.WriteLine("Radion is on");
            }
        }

        public void TurnOffRadio()
        {
            radio.Condition = false;
            if (!radio.Condition)
            {
                Console.WriteLine("Radion is off");
            }
        }
        public string RadioMark()
        { return radio.MarkOfRadio;}
    }
}
