using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9
{
    public class MyClass
    {
        public int Method1(int i) 
        {
            return i++;
        }
        public int Method2(int i)
        {
            return i--;
        }
        public void Method3(ref int i)
        {
             Console.WriteLine(i++);
        }
        public void Method4(ref int i)
        {
            Console.WriteLine(i--);
        }
    }
}
