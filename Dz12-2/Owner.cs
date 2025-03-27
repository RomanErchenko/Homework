using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz12_2
{
    public class Owner
    {
        public event EventHandler<OrderEventArgs> OrderToDog;

        public void GiveAnOrder(string m)
        { 
            OrderToDog?.Invoke(this, new OrderEventArgs() {Order=m });
        }
    }
}
