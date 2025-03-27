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
        public  event Action EngineFault;
        private int criticalCondition = 0;

        private readonly Radio radio;
        private int DoorAmount { get; }
        private double EngineVolume { get; }
        private string Model { get; }
        private string FuelType { get;}
        public string ModelMark { get; init; }
        public string Colour { get; set; }
        public Transmission Transmission { get; init; }
        public double CurrentSpeed { get; protected set; }
        public double MaxSpeed {  get; init; }
        public EngineState EngineCondition { get; set; }
        public Car(int doorAmount, double engineVolume, string model, string fuelType, string markOfRadio)
        { 
         this.DoorAmount = doorAmount;
         this.EngineVolume = engineVolume;
         this.Model = model;
         this.FuelType = fuelType;  
         radio = new Radio(markOfRadio);
         EngineFault += () =>
         {
             Console.BackgroundColor = ConsoleColor.Red; 
             Console.Clear();  
             Console.ForegroundColor = ConsoleColor.Yellow;
             Console.WriteLine("Engine is Dead!!! You need to repair your car!");
             Console.ResetColor();
         };
        }

       

        public virtual void EnginePower()
        {
            Console.WriteLine("NormalPower");
        }

        public abstract void Accelerate(GasAcceleratorPedal pedal);
       

        public virtual void StartStop()
        {
            if (EngineCondition == EngineState.SwitchedOn)
            {
                if (CurrentSpeed > 0)
                {
                    Console.WriteLine("Engine Running");
                    return;
                }
                if (CurrentSpeed == 0)
                { 
                 EngineCondition= EngineState.SwitchedOff;
                }
            }
            if (EngineCondition == EngineState.SwitchedOff)
            { 
              EngineCondition = EngineState.SwitchedOn;
                Accelerate(GasAcceleratorPedal.Quarterpush);
            }
           
        }

        public  void Brake()
        {
            while (CurrentSpeed > 0)
            { 
             CurrentSpeed--;

            }
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
                case GasAcceleratorPedal.Quarterpush:
                     CurrentSpeed = Speed * Speed  / 100 + 20;
                    break;
                case GasAcceleratorPedal.Halfpush:
                     CurrentSpeed = Speed * Speed  / 100 + 50;
                    break;
                case GasAcceleratorPedal.Halfandquarterpush:
                     CurrentSpeed = Speed * Speed  / 100 + 75;
                    break;
                case GasAcceleratorPedal.Fullpowerfpush:
                     CurrentSpeed = Speed * Speed  / 4 + 100;
                    break;
                default:
                     CurrentSpeed = Speed * Speed / 4 + 5;
                    break;


            }
            if (CurrentSpeed > MaxSpeed)
            {
                Console.WriteLine("Engine OverLoad");
                Thread.Sleep(3);
                criticalCondition++;
                if (criticalCondition ==3)
                {
                    EngineFault?.Invoke();
                    EngineCondition = EngineState.Malfunctioned;
                    Brake();
                }
            }
        }

    }
}
