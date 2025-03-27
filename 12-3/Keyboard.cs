using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3
{
    public class Keyboard
    {

        public event EventHandler<KeyEventArgs> PressedKeyEventHandler;
        public void PresKeyEvent(char symbol)
        {
            PressedKeyEventHandler?.Invoke(this, new KeyEventArgs() { PresedKey = symbol });

        }
        public void Start()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                char pressedChar = keyInfo.KeyChar;

                if (char.ToLower(pressedChar) == 'q')
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are exiting the program!");
                    break;
                }

                PresKeyEvent(pressedChar);
            }

        }
    }
}
