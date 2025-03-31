using Dz12_1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz12
{
    class Program
    {
      //Створіть:
   //• клас Human;
   //• делегат, який може бути проасоційований із методом, який нічого
   //не повертає та не приймає.
  //У тілі класу Human створіть:
  //• подія JumpE відповідно до делегату.
  //• захищений механізм доступу до події для
  //додавання та видалення методів-обробників.
  //• метод Jump, що виводить на екран слово "стрибаю".
  //Створіть екземпляр Human у методі Main, підпишіть метод Jump на подію JumpE.
  //Викличте виникнення події JumpE
        static void Main(string[] args)
        {
            Human human = new Human();
            human.JumpE += new Action(human.Jump);
            human.InvokeEvent();
            Console.ReadKey();  
        }
    }
}
            