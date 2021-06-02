using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp21
{
    class MyList<T> : IEnumerable<T> where T : IComparable<T>
    {
        public ElementList<T> first = new ElementList<T>(default, null, null);
        public ElementList<T> last = new ElementList<T>(default, null, null);
        int count = 0;
        public T this[int index]
        {
            get { return At(index); }
        }

        public void Prepend(T item)
        {
            if (first.value == null)
            {
                first = new ElementList<T>(item, null, null);
            }
            else
            {
                ElementList<T> newElement = new ElementList<T>(item, first, null);
                first.prev = newElement;
                first = newElement;
            }

            if (last.value == null)
                last = first;
            count++;
        }

        public void Qppend(T item)
        {
            if (first.value == null)
                Prepend(item);
            else
            {
                ElementList<T> newElement = new ElementList<T>(item, null, last);
                last.next = newElement;
                last = newElement;
                count++;
            }
        }

        public void RemoveAt(int index)
        {
            ElementList<T> element = first;
            for (int i = 1; i <= index; i++)
            {
                if (i == index && i != 1 && element != last)
                {
                    element.next.prev = element.prev;
                    element.prev.next = element.next;
                }
                else if (i == index && i == 1)
                {
                    first = element.next;
                }
                else if (i == index && i == Count())
                {
                    last = element.prev;
                }
                else
                    element = element.next;
            }
            count--;
        }

        public T At(int index)
        {
            ElementList<T> element = first;
            for (int i = 1; i <= index; i++)
            {
                if (i == index)
                    break;
                else
                    element = element.next;
            }
            return element.value;
        }

        public int Count()
        {
            return count;
        }

        public int CompareTo(T value)
        {
            if (this == null && value == null)
                return 0; // equals
            else if (this == null && value != null)
                return -1; // this<item
            else if (this != null && value == null)
                return 1; // this>item
            else
                return CompareTo(value);
        }

        public T[] ToArray()
        {
            T[] arrayList = new T[count];
            int i = 0;
            foreach (T value in this)
            {
                arrayList[i++] = value;
            }
            return arrayList;
        }

        private MyList<T> Merge(MyList<T> left, MyList<T> right)
        {
            MyList<T> list = new MyList<T>();
            int leftIndex = 1;
            int rightIndex = 1;
            while(leftIndex <= left.count && rightIndex <= right.count)
            {
                if(left[leftIndex].CompareTo(right[rightIndex]) <= 0)
                {
                    list.Qppend(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    list.Qppend(right[rightIndex]);
                    rightIndex++;
                }
            }
            while (leftIndex <= left.count)
            {
                list.Qppend(left[leftIndex]);
                leftIndex++;
            }
            while (rightIndex <= right.count)
            {
                list.Qppend(right[rightIndex]);
                rightIndex++;
            }
            return list;
        }

        public MyList<T> Sort()
        {
            if (count != 1)
            {
                int mid = count / 2;
                MyList<T> left = Take(mid);
                MyList<T> right = Skip(mid);
                left=left.Sort();
                right=right.Sort();
                return Merge(left, right);
            }
            else
                return this;
        }

        public MyList<T> Take(int count)
        {
            MyList<T> list = new MyList<T>();
            ElementList<T> element = first;
            int i = 1;
            while (i <= count)
            {
                list.Qppend(element.value);
                element = element.next;
                i++;
            }
            return list;
        }

        public MyList<T> Skip(int count_s)
        {
            MyList<T> list = new MyList<T>();
            ElementList<T> element = last;
            int i = count;
            while (i > count_s)
            {
                list.Prepend(element.value);
                element = element.prev;
                i--;
            }
            return list;
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }

        public EnumMyList<T> GetEnumerator()
        {
            return new EnumMyList<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


    class EnumMyList<T> : IEnumerator<T> where T : IComparable<T>
    {
        private ElementList<T> current;
        private int index = 0;
        private int count;

        public EnumMyList(MyList<T> myList)
        {
            if (current == null)
                current = myList.first;
            count = myList.Count();
        }
        public object Current { get { return current.value; } }
        T IEnumerator<T>.Current { get { return (T)Current; } }

        public void Dispose()
        {

        }
        public bool MoveNext()
        {
            if (current.next != null && index < count && index != 0)
            {
                current = current.next;
                index++;
                return true;
            }
            else if (index == 0)
            {
                index++;
                return true;
            }
            else return false;
        }
        public void Reset()
        {
            current = default;
            index = 0;
        }
    }

    class ElementList<T>
    {
        public T value;
        public ElementList<T> next;
        public ElementList<T> prev;

        public ElementList(T value, ElementList<T> next, ElementList<T> prev)
        {
            this.value = value;
            this.next = next;
            this.prev = prev;
        }
    }
}
