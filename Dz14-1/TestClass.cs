using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dz14_1
{
    public class TestClass
    {

        public IEnumerable<string> MyMethod()
        {
            for (int i = 0; i < 10; i++) 
            {
                yield return "Hello World";
            }
        
        }

      }
}