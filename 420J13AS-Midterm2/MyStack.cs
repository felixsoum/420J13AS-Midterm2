namespace _420J13AS_Midterm2
{
    class MyStack<T>
    {
        readonly T[] stack = new T[4];
        int top = -1;

        public void Push(T x)
        {
            stack[++top] = x;
        }

        public T Pop()
        {
            return stack[top--];
        }

        public T Peek()
        {
            return stack[top];
        }

        public int Count()
        {
            return top + 1;
        }
    }
}
