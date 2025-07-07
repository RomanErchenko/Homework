using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P1_3
{
   public  class MyCollection<T>:IList,IList<T>
    {

        private readonly object [] contents = new object[100];
        private int count;
        object block = new object();

        public MyCollection()
        {
            count = 0;
        }
        public int Add(object value)
        {
            lock (block)
            {
                if (count < contents.Length)
                {
                    contents[count].Equals(value);
                    count++;

                    return (count - 1);
                }
                return -1;
            }
        }
        public void Add(T value)
        {
            lock (block)
            {


                if (count < contents.Length)
                {
                    contents[count] = value;
                    count++;


                }
            }
        }
        public void Clear()
        {
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public object SyncRoot
        {
            get { return null; }
        }

        public bool Contains(object value)
        {
            lock (block)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (contents[i].Equals(value))
                        return true;
                }
                return false;
            }
        }
        public int IndexOf(object value)
        {
            for (int i = 0; i < Count; i++)
                if (contents[i].Equals(value))
                    return i;
            return -1;
        }


        public void Insert(int index, object value)
        {
            lock (block)
            {
                if ((count + 1 <= contents.Length) && (index < Count) && (index >= 0))
                {
                    count++;

                    for (int i = Count - 1; i > index; i--)
                    {
                        contents[i] = contents[i - 1];
                    }
                    contents[index] = value;
                }
            }
        }

        public void Insert(int index, T value)
        {
            lock (block)
            {
                if ((count + 1 <= contents.Length) && (index < Count) && (index >= 0))
                {
                    count++;

                    for (int i = Count - 1; i > index; i--)
                    {
                        contents[i] = contents[i - 1];
                    }
                    contents[index] = value;
                }
            }
        }

        public bool IsFixedSize
        {
            get { return true; }
        }

        
        public bool IsReadOnly
        {
            get { return false; }
        }

      //  T IList<T>.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Remove(object value)
        {
            lock (block)
            {
                RemoveAt(IndexOf(value));
            }
        }
        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                    contents[i] = contents[i + 1];

                count--;
            }
        }

       

        public object this[int index]
        {
            get
            {
                return contents[index];
            }
            set
            {
                
                contents[index] = value;
            }
        }
       
          T IList<T>.this[int index]
        {
            get
            {
                return (T)contents[index];
            }
            set
            {

                contents[index] = value;
            }
        }
        public void CopyTo(Array array, int index)
        {
            lock (block)
            {
                int j = index;
                for (int i = 0; i < Count; i++)
                {
                    array.SetValue(contents[i], j);
                    j++;
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return contents[i];
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
                if (contents[i].Equals(item))
                    return i;
            return -1;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (contents[i].Equals(item))
                    return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            lock (block)
            {
                int j = arrayIndex;
                for (int i = 0; i < Count; i++)
                {
                    array.SetValue(contents[i], j);
                    j++;
                }
            }
        }

        public bool Remove(T item)
        {
            lock (block)
            {
                RemoveAt(IndexOf(item));
                return true;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)(object)contents).GetEnumerator();
        }
    }
}

