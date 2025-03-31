
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    //Задання. 
    // Створити абстрактний клас Car - винести туди весь базовий
    // фунціонал - кількість дверй об'єм двигуна, марка модель.
    // ПРодумати конструктор (приймає те без чого об'єкти немає сенсу),
    // колір, методи Start Stop Accelerate.
    // Продумати який метод буде абстрактиним який віртуальним
    // який звичайний. Треба всі предстаники
    // Унаслідувати SportCar - перевизначити прискорення MiniVan .
    // Створити клас Radio  створити його в абстратному класі.
    // В класі мінівен додати методи TurnOnRadio TurnOff
    class Program
    {
        public static double RunDistance;

        public static void Run(object mycar)
        {
            if (mycar is MiniVan)
            {
                MiniVan  car = (MiniVan)mycar;
                car.Accelerate(GasAcceleratorPedal.Fullpowerfpush);
                while (car.Distance < RunDistance)
                {
                    car.Distance += car.CurrentSpeed;  
                    Console.WriteLine($"Пройдено: {car.Distance},{car.ModelMark} км");

                    if (car.Distance >= RunDistance)
                    {
                        Console.WriteLine($"Машина доіхала до фінішу!{car.ModelMark}");
                        break;
                    }
                }
            }
            if (mycar is SportCar)
            {
                SportCar car=(SportCar)mycar;
                car.Accelerate(GasAcceleratorPedal.Fullpowerfpush);
                while (car.Distance < RunDistance)
                {
                    car.Distance += car.CurrentSpeed;  // Едем 1 час (200 км)
                    Console.WriteLine($"Пройдено: {car.Distance},{car.ModelMark} км");

                    if (car.Distance >= RunDistance)
                    {
                        Console.WriteLine($"Машина доіхала до фінішу! {car.ModelMark}");
                        
                        break;
                    }
                }
            }
        }
        //Task 4
        static void Main(string[] args)
        {
          Console.OutputEncoding= Encoding.UTF8;
            SportCar sportCar = new SportCar(2, 6.4, "Mersedez", "gasoline", "Sport car Radio")
            {
                ModelMark = "Sport-Mersedez",
                Colour = "blue",
                Transmission = Transmission.Robot,
                MaxSpeed = 300,
                EngineCondition=EngineState.SwitchedOff 
            };
            SportCar BmwSport = new SportCar(2, 6.4, "BMW", "gasoline", "Sport car Radio")
            {
                ModelMark = "Sport-Bmw",
                Colour = "blue",
                Transmission = Transmission.Robot,
                MaxSpeed = 350,
                EngineCondition = EngineState.SwitchedOff
            };
            Console.WriteLine(sportCar.CurrentSpeed);
            Console.WriteLine(new string('-',33));
            MiniVan minivan = new MiniVan(4, 1.4, "Cooper", "fueloil", "Minivan cooper Radio")
            {
                ModelMark = "Hachback-Cooper",
                Colour = "green",
                Transmission = Transmission.Automatic,
                MaxSpeed = 200,
                EngineCondition = EngineState.SwitchedOff
            };

            MiniVan miniVan = new MiniVan(2, 1.2, "Citroen", "gazoline", "Minivan citroen Radio")
            {
                ModelMark = "Hachback-Citroen",
                Colour = "red",
                Transmission = Transmission.Automatic,
                MaxSpeed = 190,
                EngineCondition = EngineState.SwitchedOff
            };

            MiniVan mini = new MiniVan(2, 1.2, "Citroen", "gazoline", "Minivan citroen Radio")
            {
                ModelMark = "Nissan-Minivan",
                Colour = "red",
                Transmission = Transmission.Automatic,
                MaxSpeed = 230,
                EngineCondition = EngineState.SwitchedOff
            };

            //Car[] Holder=new Car[3];
            //Holder[0]=sportCar;
            //Holder[1]=minivan;
            //Holder[2]=miniVan;

            //for (int i = 0; i < Holder.Length; i++)
            //{
            //    Holder[i].Show();
            //    Console.WriteLine(Holder[i].RadioMark());
            //    if (Holder[i] is MiniVan)
            //    {
            //        MiniVan v = (MiniVan)Holder[i];
            //        v.TurnOnRadio();
            //    }
            //    if (Holder[i] is SportCar)
            //    {
            //        SportCar v = (SportCar)Holder[i];
            //        v.TurnOnRadio();
            //    }
            //    Holder[i].StartStop();
            //    Console.WriteLine(new string('-', 33));
            //}
            //Console.WriteLine(new string('-', 33));

            //for (int i = 0; i < Holder.Length; i++)
            //{
            //    if (Holder[i] is MiniVan)
            //    {
            //        MiniVan v = (MiniVan)Holder[i];
            //        v.TurnOffRadio();
            //    }
            //    if (Holder[i] is SportCar)
            //    {
            //        SportCar v = (SportCar)Holder[i];
            //        v.TurnOffRadio();
            //    }
            //    Console.WriteLine(new string('-', 33));
            //   // Holder[i].StartStop();
            //    Console.WriteLine(new string('-', 33));
            //}

            //for (int i = 0; i < Holder.Length; i++)
            //{  
            //        Holder[i].Accelerate(GasAcceleratorPedal.Halfpush);
                

            //    Console.WriteLine("Power Accelerate: " + Holder[i].CurrentSpeed );
            //}
            //Console.WriteLine(new string('-', 33));

            //for (int i = 0; i < Holder.Length; i++)
            //{
            //    Holder[i].Accelerate(GasAcceleratorPedal.Halfpush);


            //    Console.WriteLine("Power Accelerate: " + Holder[i].CurrentSpeed);
            //}
            //максимальне прискорення яке знищуе двигун
            //for (int i = 0; i < 3; i++)
            //{
            //    Holder[1].Accelerate(GasAcceleratorPedal.Fullpowerfpush);


            //    Console.WriteLine("Power Accelerate: " + Holder[i].CurrentSpeed);
            //}
            sportCar.StartStop();
            BmwSport.StartStop();
            mini.StartStop();
            miniVan.StartStop();
            minivan.StartStop();

            RunDistance = 1000;
            Thread thread1 = new Thread(new ParameterizedThreadStart(Run));
            Thread thread2 = new Thread(new ParameterizedThreadStart(Run));
            Thread thread3 = new Thread(new ParameterizedThreadStart(Run));
            Thread thread4 = new Thread(new ParameterizedThreadStart(Run));
            Thread thread5 = new Thread(new ParameterizedThreadStart(Run));

            thread1.Start(sportCar);
            thread2.Start(BmwSport);
            thread3.Start(mini);
            thread4.Start(miniVan);
            thread5.Start(minivan);

            Console.ReadKey();
        }
    }
}