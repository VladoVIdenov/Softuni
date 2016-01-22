using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{   
    public class GenList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private const int DefaultCapacity = 5;

        private T[] array;
        private int index;
        private int currentCapacity;
        
        
        public GenList(int capacity = DefaultCapacity)
        {
            this.array = new T[capacity];
            this.currentCapacity = capacity;
            this.index = 0;
        }
        
        public void Add(T item)
        {
            int currentCapacity = this.array.Length;
            if (currentCapacity == this.index)
            {
                this.Resize(this.currentCapacity * 2);
            }
            this.array[this.index] = item;
            index++;
        }

        
        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < this.index; i++)
            {
                newArray[i] = this.array[i];

            }
            this.array = newArray;
            this.currentCapacity = newCapacity;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.index; i++)
            {
                yield return this.array[i];
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public T Max()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            T max = this.array[0];
            for (int i = 0; i < this.index; i++)
            {
                if (this.array[i].CompareTo(max) > 0)
                {
                    max = this.array[i];
                }
            }
            return max;
        }

        public T Min()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            T min = this.array[0];
            for (int i = 0; i < this.index; i++)
            {
                if (this.array[i].CompareTo(min) < 0)
                {
                    min = this.array[i];
                }
            }
            return min;
        }

        public int IndexOf(T item)
        {
            int notfound = -1;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].CompareTo(item) == 0)
                {
                    return i;
                }
            }
            return notfound;
            
        }

        public void Clear()
        {
            this.index = 0;
        }

        public void Remove(T item)
        {
            RemoveAt(IndexOf(item));
        }

        public void RemoveAt(int position)
        {
            if ((position < 0) && (position > index))
            {
                throw new IndexOutOfRangeException("This index is out of range");
            }
            else if((position >= 0) && (position < index))
            {
                for (int i = position; i < this.index - 1; i++)
                {
                    this.array[i] = this.array[i + 1];
                }
                index--;
            }
        }
        public void Insert(int position, T item)
        {
            if ((index + 1 <= this.array.Length) && (position < index) && (position >= 0))
            {
                index++;

                for (int i = index - 1; i > position; i--)
                {
                    this.array[i] = this.array[i - 1];
                }
                this.array[position] = item;
            }
            else
            {
                throw new IndexOutOfRangeException("This index is out of range");
            }
        }

        public T this[int position]
        {
            get
            {
                return this.array[position];
            }
            set
            {
                if (position < 0 || position > this.array.Length)
                {
                    throw new IndexOutOfRangeException("This index is out of range");
                }
                this.array[position] = value;
            }

        }

        public bool Contains(T item)
        {
            bool inList = false;
            for (int i = 0; i < index; i++)
            {
                if (this.array[i].CompareTo(item) == 0)
                {
                    inList = true;
                    break;
                }
            }
            return inList;
        }

        public override string ToString()
        {
            string result = string.Empty;
            foreach (var item in this)
            {
                if (string.IsNullOrEmpty(result))
                    result += item.ToString();
                else
                    result += string.Format(", {0}", item);
            }
            return result;
        }
    }
}
