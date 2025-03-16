using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DZ4
{
 
    public delegate void AccelerationFormula(double CurrentSpeed,GasAcceleratorPedal pedal);
    public abstract class Car
    {
        private readonly Radio radio;
        private int DoorAmount { get; }
        private double EngineVolume { get; }
        private string Model { get; }
        private string FuelType { get;}
        public string ModelMark { get; init; }
        public string Colour { get; set; }
        public Transmission Transmission { get; init; }
        public double CurrentSpeed { get; protected set; }
        public Car(int doorAmount, double engineVolume, string model, string fuelType,string markOfRadio,double CurrentSpeed)
        { 
         this.DoorAmount = doorAmount;
         this.EngineVolume = engineVolume;
         this.Model = model;
         this.FuelType = fuelType;  
         radio = new Radio(markOfRadio);
         this.CurrentSpeed = CurrentSpeed;
            
        }

        public virtual void EnginePower()
        {
            Console.WriteLine("NormalPower");
        }

        public abstract void Accelerate( GasAcceleratorPedal pedal);
       

        public virtual void Start()
        {
            Console.WriteLine("Mechanical start by rotation key");
        }

        public  void Stop()
        {
           CurrentSpeed = 0;
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
        public double SpeedUp()
        {
            return CurrentSpeed * 1.15 + 15;
        }


        public void Formula(double Speed, GasAcceleratorPedal pedal)
        {
           
            switch (pedal)
            {
                case GasAcceleratorPedal.quarterpush:
                     CurrentSpeed = Speed * Speed * 2 / 2 + 20;
                    break;
                case GasAcceleratorPedal.halfpush:
                     CurrentSpeed = Speed * Speed * 2 / 2 + 50;
                    break;
                case GasAcceleratorPedal.halfandquarterpush:
                     CurrentSpeed = Speed * Speed * 2 / 2 + 75;
                    break;
                case GasAcceleratorPedal.fullpowerfpush:
                     CurrentSpeed = Speed * Speed * 2 / 2 + 100;
                    break;
                default:
                     CurrentSpeed = Speed * Speed * 2 / 2 + 5;
                    break;


            }
        }

    }
}
