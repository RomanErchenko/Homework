﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class SportCar: Car
    {
        public override event Action EngineFault;
        public SportCar(int doorAmount, double engineVolume, string model, string fuelType, string markOfRadio)
        :base( doorAmount, engineVolume, model, fuelType, markOfRadio)
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
                if (criticalCondition == 5)
                {
                    EngineFault?.Invoke();
                    EngineCondition = EngineState.Malfunctioned;
                }
            }
        }

        public override void EnginePower()
        {
            Console.WriteLine("Increase power engine");
        }

    }
}
