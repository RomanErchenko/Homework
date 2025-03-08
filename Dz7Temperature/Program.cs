using Dz7Temperature;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7Temperature
{
    class Program
    {
        //Домашнє завдання. 
       // Створити структуру, яка б мітила значення температури у цельсіях фарингейтах і кельвінах.
        //Приймаємо в конструктор цельсії виводимо у властивостях все інше
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature(37);
            temperature.Show();
            Console.ReadKey();
        }
    }
}