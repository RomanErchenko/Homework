
using System;
using System.Collections.Generic;
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

            SportCar sportCar = new SportCar(2, 6.4, "Mersedez", "Sport", "blue", "gasoline", Transmission.Robot);
            Console.WriteLine(new string('-',33));
            MiniVan minivan = new MiniVan(4, 1.4, "Cooper", "Hachback", "green", "fueloil", Transmission.Automatic);
            minivan.TurnOnRadio();
           Console.ReadKey();
          
        }
    }
}