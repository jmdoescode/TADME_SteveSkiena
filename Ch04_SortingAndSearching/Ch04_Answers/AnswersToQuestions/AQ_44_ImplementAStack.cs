using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04_Answers.AnswersToQuestions
{
    public class AQ_44_ImplementAStack
    {
        public class Stack
        {
            private static int capacity = 10;
            private static int size = 0;
            private static object[] items = new object[capacity];
            private static object _minimumElement;

            public object MinimumElement
            {
                get { return _minimumElement; }
            }

            public int Size
            {
                get { return size; }
            }


            private static void EnsureCapacity()
            {
                if (size + 1 == capacity)
                {
                    object[] newArr = new object[capacity * 2];
                    for (int i = 0; i < capacity; i++)
                        newArr[i] = items[i];
                    items = newArr;
                    capacity *= 2;
                }
                else if (size < capacity / 2)
                {
                    //shrink array
                }
            }

            public void Push(object val)
            {
                EnsureCapacity();
                items[size] = val;
                size++;

                if ((int)val < (int)_minimumElement)
                    _minimumElement = val;
                else if (_minimumElement == null)
                    _minimumElement = val;
            }

            public void Push(params object[] arr)
            {
                foreach (object val in arr)
                {
                    EnsureCapacity();
                    items[size] = val;
                    size++;

                    if (_minimumElement == null)
                        _minimumElement = val;
                    else if ((int)val < (int)_minimumElement)
                        _minimumElement = val;
                }
            }

            public object Pop()
            {
                if (size == 0) throw new Exception();

                EnsureCapacity();
                object temp = items[size - 1];
                size--;
                return temp;
            }
        }
    }
}
