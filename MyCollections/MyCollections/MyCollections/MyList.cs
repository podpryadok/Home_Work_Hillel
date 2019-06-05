using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyCollections
{
    class MyList<T> : IList<T>
    {
        T[] elements = new T[4];

        private int count = 0;
        private int position = -1;

        #region Ilist

        public T this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region ICollection

        public int Count { get { return elements.Length; } } //всего элементов в массиве

        public bool IsReadOnly { get { return false; } }

        public void Add(T item)
        {
            if (count <= elements.Length)
            {
                elements[count] = item;
                count++;
            }
            else
            {
                throw new Exception("Array is full!");
            }
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Add(array[arrayIndex]);
        }

        public bool Remove(T item)
        {
            bool compleat = false;

            for (int i = 0; i < elements.Length; i++)
            {
                if (item.GetHashCode() == elements[i].GetHashCode())
                {
                    //надо придумать как удалить этот элемент
                    compleat = true;
                }
            }
            return compleat;
        }
        #endregion

        #region IEnumerable

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
