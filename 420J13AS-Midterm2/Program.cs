using System;

namespace _420J13AS_Midterm2
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.a)
            Console.WriteLine("6.a)________________________________");
            int[] inputA = new int[] { 3, 7, 4, 2, 8, 5, 7, 1, 6, 9, 7, 0 };
            Quicksort(inputA);
            Console.WriteLine(string.Join(", ", inputA));

            //6.b)
            Console.WriteLine("6.b)________________________________");
            int[] inputB = new int[] { 3, 7, 4, 2, 8, 5, 7, 1, 6, 9, 7, 0 };
            UnluckySort(inputB, 7);
            Console.WriteLine(string.Join(", ", inputB));
            UnluckySort(inputB, 8);
            Console.WriteLine(string.Join(", ", inputB));

            //7.a)
            Console.WriteLine("7.a)________________________________");
            MyStack<int> stack = new MyStack<int>();
            Console.WriteLine($"Count: {stack.Count()}");
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine($"Peek: {stack.Peek()}");
            stack.Push(3);
            Console.WriteLine($"Count: {stack.Count()}");
            Console.WriteLine($"{stack.Pop()}, {stack.Pop()}, {stack.Pop()}");

            //7.b)
            Console.WriteLine("7.b)________________________________");
            StackedQueue<string> queue = new StackedQueue<string>();
            Console.WriteLine($"Count: {queue.Count()}");
            queue.Enqueue("Uno");
            queue.Enqueue("Dos");
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue("Tres");
            queue.Enqueue("Cuatro");
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue("Cinco");
            queue.Enqueue("Seis");
            Console.WriteLine($"Peek: {queue.Peek()}");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine($"Count: {queue.Count()}");
        }

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void Quicksort(int[] array)
        {
            Quicksort(array, 0, array.Length - 1);
        }

        static void Quicksort(int[] array, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(array, p, r);
                Quicksort(array, p, q - 1);
                Quicksort(array, q + 1, r);
            }
        }

        static int Partition(int[] array, int p, int r)
        {
            //TODO
            return p;
        }

        static void UnluckySort(int[] array, int unluckyNumber)
        {
            UnluckySort(array, 0, array.Length - 1, unluckyNumber);
        }

        static void UnluckySort(int[] array, int p, int r, int unluckyNumber)
        {
            if (p < r)
            {
                int q = UnluckyPartition(array, p, r, unluckyNumber);
                UnluckySort(array, p, q - 1, unluckyNumber);
                UnluckySort(array, q + 1, r, unluckyNumber);
            }
        }

        static int UnluckyPartition(int[] array, int p, int r, int unluckyNumber)
        {
            //TODO
            return p;
        }
    }
}
