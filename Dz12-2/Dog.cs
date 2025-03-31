using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz12_2
{
    public class Dog
    {
        public string Order { get; set; }

        public void OrderHandler(object sender, OrderEventArgs e)
        {
            if (sender is Owner)
            {
                Console.WriteLine($"I am following order {e.Order}");
                Order = e.Order;
            }
            else 
            {
                Console.WriteLine("Suspicious looking for stranger");
            }
        }
    }
}
