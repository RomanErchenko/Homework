using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_1
{
   public  class MyCollection<T>:IEnumerable<T>,IEnumerator<T>
    {
        private readonly T[] cars = new T[10];
        private int position = -1;
        private int count = 0;
        public void Add(T elem)
        {
            cars[count] = elem;
            count++;

        }
        public IEnumerator<T> GetEnumerator()
        {
            position = -1;
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public T Current => cars[position];
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

