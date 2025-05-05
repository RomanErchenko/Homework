using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public int Count { get; private set; }

        public void AddLast(T value)
        {
            var node = new Node<T>(value);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            Count++;
        }

        public void AddFirst(T value)
        {
            var node = new Node<T>(value);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.Next = head;
                head = node;
            }
            Count++;
        }

        public bool Remove(T value)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, value))
                {
                    if (previous == null) // removing head
                    {
                        head = current.Next;
                        if (head == null)
                            tail = null;
                    }
                    else
                    {
                        previous.Next = current.Next;
                        if (current == tail)
                            tail = previous;
                    }

                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
