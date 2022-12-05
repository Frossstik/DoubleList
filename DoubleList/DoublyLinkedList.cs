using DoubleList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DoublyConnectedDeck
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;

        public T this[int i]
        {
            get
            {
                Node<T> temp = head;
                for (int j = 0; j < i; j++)
                    temp = temp.Next;
                return temp.Data;
            }
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }

        public T Remove()
        {
            Node<T> current = tail;
            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    tail = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
                count--;
            }
            return current.Data;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        
        
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            Node<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}

