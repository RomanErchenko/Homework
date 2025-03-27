
using System;
using System.Collections.Generic;
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
        //Task 4
        static void Main(string[] args)
        {
          
            SportCar sportCar = new SportCar(2, 6.4, "Mersedez", "gasoline", "Sport car Radio")
            {
                ModelMark = "Sport",
                Colour = "blue",
                Transmission = Transmission.Robot,
                MaxSpeed = 300,
                EngineCondition=EngineState.SwitchedOff 
            };
            Console.WriteLine(sportCar.CurrentSpeed);
            Console.WriteLine(new string('-',33));
            MiniVan minivan = new MiniVan(4, 1.4, "Cooper", "fueloil", "Minivan cooper Radio")
            {
                ModelMark = "Hachback",
                Colour = "green",
                Transmission = Transmission.Automatic,
                MaxSpeed = 200,
                EngineCondition = EngineState.SwitchedOff
            };

            MiniVan miniVan = new MiniVan(2, 1.2, "Citroen", "gazoline", "Minivan citroen Radio")
            {
                ModelMark = "Hachback",
                Colour = "red",
                Transmission = Transmission.Automatic,
                MaxSpeed = 190,
                EngineCondition = EngineState.SwitchedOff
            };
            
            Car[] Holder=new Car[3];
            Holder[0]=sportCar;
            Holder[1]=minivan;
            Holder[2]=miniVan;

            for (int i = 0; i < Holder.Length; i++)
            {
                Holder[i].Show();
                Console.WriteLine(Holder[i].RadioMark());
                if (Holder[i] is MiniVan)
                {
                    MiniVan v = (MiniVan)Holder[i];
                    v.TurnOnRadio();
                }
                if (Holder[i] is SportCar)
                {
                    SportCar v = (SportCar)Holder[i];
                    v.TurnOnRadio();
                }
                Holder[i].StartStop();
                Console.WriteLine(new string('-', 33));
            }
            Console.WriteLine(new string('-', 33));

            for (int i = 0; i < Holder.Length; i++)
            {
                if (Holder[i] is MiniVan)
                {
                    MiniVan v = (MiniVan)Holder[i];
                    v.TurnOffRadio();
                }
                if (Holder[i] is SportCar)
                {
                    SportCar v = (SportCar)Holder[i];
                    v.TurnOffRadio();
                }
                Console.WriteLine(new string('-', 33));
               // Holder[i].StartStop();
                Console.WriteLine(new string('-', 33));
            }

            for (int i = 0; i < Holder.Length; i++)
            {  
                    Holder[i].Accelerate(GasAcceleratorPedal.Halfpush);
                

                Console.WriteLine("Power Accelerate: " + Holder[i].CurrentSpeed );
            }
            Console.WriteLine(new string('-', 33));

            for (int i = 0; i < Holder.Length; i++)
            {
                Holder[i].Accelerate(GasAcceleratorPedal.Halfpush);


                Console.WriteLine("Power Accelerate: " + Holder[i].CurrentSpeed);
            }
            //максимальне прискорення яке знищуе двигун
            for (int i = 0; i < 3; i++)
            {
                Holder[1].Accelerate(GasAcceleratorPedal.Fullpowerfpush);


                Console.WriteLine("Power Accelerate: " + Holder[i].CurrentSpeed);
            }

            Console.ReadKey();
        }
    }
}