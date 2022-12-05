using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DoubleList
{
    class Stack<T> : IEnumerable<T>
    {
        private T[] items;
        private int count;
        const int n = 1;
        public Stack()
        {
            items = new T[n];
        }
        public Stack(int length)
        {
            items = new T[length];
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public int Count
        {
            get { return count; }
        }

        public T Current => throw new NotImplementedException();

        public void Push(T item)
        {
            // увеличиваем стек
            if (count == items.Length)
                Resize(items.Length + 1);

            items[count++] = item;
        }
        public T Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T item = items[--count];
            items[count] = default(T); // сбрасываем ссылку

            if (count > 0 && count < items.Length - 1)
                Resize(items.Length - 1);

            return item;
        }

        private void Resize(int max)
        {
            T[] tempItems = new T[max];
            for (int i = 0; i < count; i++)
                tempItems[i] = items[i];
            items = tempItems;
        }

        public void Clear()
        {
            items = null;
            count = 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

        public void Sort(/*Comparison<T> comparison*/)
        {/*
            if (comparison == null)
            {
                throw new Exception("comparison == null");
            }*/

            if (count > 1)
            {
                Array.Sort(items);
            }
        }
    }
}
