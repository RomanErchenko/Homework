using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class Garage:IEnumerable,IEnumerator
    {
        private Car [] items;
        private int count = 0;
        public Garage()
        {
            items = new Car[10];
        }
        public Car this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        int position = -1;
        public bool MoveNext()
        {
            if (position < items.Length - 1)
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

        public object Current
        {
            get { return items[position]; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

      
        public void Add(Car elem)
        {
            items[count] = elem;
            count++;

        }
        void Dispose()
        {
            Reset();
        }
    }
}

    

