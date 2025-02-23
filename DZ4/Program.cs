
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
        static void Main(string[] args)
        {
            SportCar sportCar = new SportCar(2, 6.4, "Mersedez", "gasoline")
            { 
              ModelMark="Sport",
              Colour="blue",
              Transmission=Transmission.Robot 
            };
            Console.WriteLine(new string('-',33));
            MiniVan minivan = new MiniVan(4, 1.4, "Cooper", "fueloil")
            {
                ModelMark = "Hachback",
                Colour = "green",
                Transmission = Transmission.Automatic,
                
            };
            minivan.RadiO.MarkOfRadio = "MiniVanRadio";
            MiniVan miniVan = new MiniVan(2, 1.2, "Citroen", "gazoline")
            {
                ModelMark = "Hachback",
                Colour = "red",
                Transmission = Transmission.Automatic
            };
            minivan.RadiO.MarkOfRadio = "MiniVanRadio";
            Car[] Holder=new Car[3];
            Holder[0]=sportCar;
            Holder[1]=minivan;
            Holder[2]=miniVan;
            for (int i = 0; i < Holder.Length; i++)
            {
                if (Holder[i] is MiniVan)
                {
                    MiniVan v = Holder[i] as MiniVan;
                    v.TurnOnRadio();
                }
                else { Console.WriteLine("no radio"); }
                Console.WriteLine(new string('-', 33));
                Holder[i].Show();
                Holder[i].Start();
                Console.WriteLine(new string('-', 33));
            }
            Console.WriteLine(new string('-', 33));
            for (int i = 0; i < Holder.Length; i++)
            {
                if (Holder[i] is MiniVan)
                {
                    MiniVan v = Holder[i] as MiniVan;
                    v.TurnOFFRadio();
                }
                else { Console.WriteLine("no radio"); }
                Console.WriteLine(new string('-', 33));
                Holder[i].Stop();
                Console.WriteLine(new string('-', 33));
            }
                Console.ReadKey();
          
        }
    }
}