using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class MyGarage : IEnumerable<Car>, IEnumerator<Car>
    {

        private readonly Car[] cars = new Car[10];
        private int position = -1;
        private int count = 0;

        public void Add(Car elem)
        {
            cars[count] = elem;
            count++;

        }


        public IEnumerator<Car> GetEnumerator()
        {
            position = -1; 
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
        public Car Current => cars[position];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (position < cars.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            Reset();
        }
    }
}
