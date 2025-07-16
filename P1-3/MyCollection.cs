using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P1_3
{
   public  class MyCollection<T>:ICollection<T>
    {
        T[] elements = new T[0];
        public void Add(T item)
        {
            var newArray = new T[elements.Length + 1]; 
            elements.CopyTo(newArray, 0);              
            newArray[newArray.Length - 1] = item;      
            elements = newArray;                       
        }
        public void Clear()
        {
            elements = new T[0];
        }
        public bool Contains(T item)
        {
            foreach (var element in elements)
            {
                if (element.Equals(item))
                    return true;
            }

            return false;

            ////Or we can use LINQ :)
            return elements.Contains(item);
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            elements.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return elements.Length; }
        }
        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            int index = 0;
            var newArray = new T[elements.Length-1];
            for (int i=0; i<elements.Length; i++)
           {

                if ((elements[i].Equals(item)))
                {
                    index = i;
                }
               
           }
            for (int i = 0; i < index; i++)
            {
                newArray[i]=elements[i];
            }
            for (int i = index; i < elements.Length; i++)
            {
                newArray[i-1] = elements[i];
            }
            elements = newArray;
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)elements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<T>).GetEnumerator();
        }

    }
}

