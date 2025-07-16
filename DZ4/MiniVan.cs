using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    
    public class MiniVan: Car
    {
        public override event Action EngineFault;
        public MiniVan(int doorAmount, double engineVolume, string model, string fuelType, string markOfRadio)
        : base(doorAmount, engineVolume, model, fuelType, markOfRadio)
        {
            EngineFault += () =>
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Engine is Dead!!! You need to repair your car!");
                Console.ResetColor();
            };
        }

        public override void Accelerate(GasAcceleratorPedal pedal)
        {
            if (EngineCondition == EngineState.SwitchedOn)
            {
                AccelerationFormula formula = new AccelerationFormula(Formula);
                formula.Invoke(CurrentSpeed, pedal);
            }
            if (CurrentSpeed > MaxSpeed)
            {
                Console.WriteLine("Engine OverLoad");
                Thread.Sleep(3);
                criticalCondition++;
                try
                {
                    if (criticalCondition == 3)
                    {
                        EngineFault?.Invoke();
                        EngineCondition = EngineState.Malfunctioned;
                        throw new CarDeadEngine(CurrentSpeed,EngineInfo,"MyExceptionA");
                    }
                }
                catch (CarDeadEngine ex) 
                {
                    Console.WriteLine(ex.Message);
                    ex.Show();
                }
            }
        }

        public override void EnginePower()
        {
           base.EnginePower();
        }
    }
}
