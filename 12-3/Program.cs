
using _12_3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dz12
{
    class Program
    {
//Напишіть консольну програму, яка відстежуватиме натискання кнопок клавіатури і повністю заповнюватиме екран консолі значеннями натиснутого символу, при цьому кожен раз після натискання клавіші колір тексту (Console.ForegroundColor) повинен змінюватися випадковим чином (крім чорного).
// Деталі:
//• Створіть клас KeyEventArgs, спадкоємець EventArgs.У тілі класу створіть автовластивість PresedKey типу char.
//• Створіть клас Keyboard.У тілі класу створіть:
//o подія типу EventHandler з ім'ям PressedKeyEventHandler, закритого KeyEventArgs.
//o Створіть метод PresKeyEvent, що приймає char, що запускає виконання події і передає далі значення отриманого char (поміщеного в KeyEventArgs).
//o Метод Start, що звертається до консолі для зчитування натиснутої кнопки.Якщо натиснуто будь-яку клавішу крім q (у будь-якому регістрі та з урахуванням кирилиці), має запускатися подія.Інакше у циклі продовжується запит на введення символу.Якщо введено q – очищення екрана консолі виводиться на екран червоним кольором рядок “You are exiting the program!”.
//• У класі Program створіть метод PresedKeyHandler, який можна підписати на подію PressedKeyEventHandler. Завдання методу:
//o Встановити максимально допустимий для системи розмір вікна консолі за шириною та висотою.
//o Очистити екран консолі.
//o Змінити колір тексту в консолі випадковим чином, але так, щоб він не повторювався з попереднім кольором тексту консолі.
//o Вивести на екран максимально можливу для даного екрану консолі кількість символів, натиснутий користувачем на клавіатурі.
//У методі Main створіть екземпляр класу Keyboard, підпишіть на його подію відповідний метод та запустіть метод Start.
        
        static Random random = new Random();
        static ConsoleColor lastColor = ConsoleColor.White;
        static void PressedKeyHandler(object sender, KeyEventArgs e)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.Clear();
            Console.ForegroundColor = GetRandomConsoleColor();

            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            string output = new string(e.PresedKey, width - 1);

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(output);
            }
        }
        static ConsoleColor GetRandomConsoleColor()
        {
            ConsoleColor newColor;
            do
            {
                newColor = (ConsoleColor)random.Next(1, 16);
            } while (newColor == lastColor || newColor == ConsoleColor.Black);

            lastColor = newColor;
            return newColor;
        }
        static void Main(string[] args)
        {
            Keyboard keyboard = new Keyboard();
            keyboard.PressedKeyEventHandler += PressedKeyHandler;
            keyboard.Start();
            Console.ReadKey();
        }
    }
}
