using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class MyGarage:IEnumerable<Car>,IEnumerator<Car>
    {

        private List<Car> cars = new List<Car>();
        private int position = -1;
       
        public void AddCar(Car car)
        {
            cars.Add(car);
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
            position++;
            return (position < cars.Count);
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
