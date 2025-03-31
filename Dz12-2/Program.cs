
using Dz12_2;
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
        //Створіть:
        //Створіть клас OrderEventArgs, успадкуйте його від класу
        //EventArgs (базового класу визначення класів-аргументів подій).
        //У тілі класу створіть рядкову автовластивість Order.
       // Створіть 2 класи – Owner та NotOwner.
       // У тілі кожного з цих класів створіть:
// Подія типу EventHandler, закритого OrderEventArgs та з ім'ям OrderToDog.
// Створіть метод GiveAnOrder, який приймає рядок, створює екземпляр OrderEventArgs,
// поміщає в нього рядок-аргумент методу та викликає метод Invoke на подію.
//Створіть клас Dog. У тілі класу створіть:
//Строкова автовластивість Order;
//Метод OrderHandler – метод обробник події, який приймає два параметри –
//типу object (з ім'ям sender) та типу OrderEventArgs (з ім'ям e).
//Якщо джерело події – екземпляр класу Owner:
//1. Виведіть на екран рядкове значення команди, отримане з
//OrderEventArgs("Я виконую команду {e.Order}").
//2. Надайте властивості Order рядкове значення команди.
//• Якщо джерело події не Owner – виведіть на екран рядок
//«Дозірливо дивлюся на стороннього».
//У тілі методу Main створіть екземпляр класу Dog.
//Створіть екземпляри класів Owner та NotOwner та підпишіть на події цих
//класів метод OrderHandler.
//Викличте події екземплярів Owner та NotOwner.
//Виведіть на екран значення властивості Order екземпляра Dog.


        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            Owner owner = new Owner();
            NotOwner stranger = new NotOwner();

            owner.OrderToDog += myDog.OrderHandler;
            stranger.OrderToDog += myDog.OrderHandler;

            owner.GiveAnOrder("sit down");
            stranger.GiveAnOrder("Eat");



            Console.ReadKey();
        }
    }
}
