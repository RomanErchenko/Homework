using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz12_1
{
    public class Human
    {

        private Action myAction = null;

        public event Action JumpE
        {
            add { myAction += value; }
            remove { myAction -= value; }
        }

        public void InvokeEvent()
        {
            myAction.Invoke();
        }
    
        public void Jump()
        {
            Console.WriteLine("I am jumping");
        }
    }
}
