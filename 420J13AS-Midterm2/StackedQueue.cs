using System;

namespace _420J13AS_Midterm2
{
    class StackedQueue<T>
    {
        readonly MyStack<T> stackA = new MyStack<T>();
        readonly MyStack<T> stackB = new MyStack<T>();

        public void Enqueue(T x)
        {
            stackA.Push(x);
        }

        public T Dequeue()
        {
            while (stackA.Count() > 1)
            {
                stackB.Push(stackA.Pop());
            }
            T result = stackA.Pop();
            while (stackB.Count() > 0)
            {
                stackA.Push(stackB.Pop());
            }
            return result;
        }

        public T Peek()
        {
            while (stackA.Count() > 1)
            {
                stackB.Push(stackA.Pop());
            }
            T result = stackA.Peek();
            while (stackB.Count() > 0)
            {
                stackA.Push(stackB.Pop());
            }
            return result;
        }

        public int Count()
        {
            return stackA.Count();
        }

        public void Sort()
        {
            if (stackA.Count() > 0 && stackA.Peek() is IComparable)
            {
                int sortedCount = 0;
                while (stackA.Count() > 0)
                {
                    T max = stackA.Pop();
                    stackB.Push(max);

                    while (stackA.Count() > 0)
                    {
                        T next = stackA.Pop();
                        if (((IComparable)max).CompareTo((IComparable)next) < 0)
                        {
                            max = next;
                        }
                        stackB.Push(next);
                    }
                    for (int i = stackB.Count(); i > sortedCount; i--)
                    {
                        T current = stackB.Pop();
                        if (!current.Equals(max))
                        {
                            stackA.Push(current);
                        }
                    }
                    stackB.Push(max);
                    sortedCount++;
                }
                while (stackB.Count() > 0)
                {
                    stackA.Push(stackB.Pop());
                }
            }
        }
    }
}
