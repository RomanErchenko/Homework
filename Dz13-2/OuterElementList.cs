using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz13_2
{
    public class OuterElementList<T>:IEnumerable<T>, IEnumerator<T>
    {
        private T[] items;
        private int count;
        public OuterElementList(int n)
        {
            items = new T[n];
        }
        public T this[int index]
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

        T IEnumerator<T>.Current
        {
            get { return items[position]; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this;
        }
        public void Add(T elem)
        {
            items[count] = elem;
            count++;

        }
        void IDisposable.Dispose()
        {
            Reset();
        }

    }
}
