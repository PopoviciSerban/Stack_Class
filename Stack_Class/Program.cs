using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Stk<int> intStack = new Stk<int>(64);
            Stk<string> stringStack = new Stk<string>(128);

            intStack.Push(1);
            intStack.Push(3);
            intStack.Push(3);
            intStack.Push(7);

            while (!intStack.Empty())
                Console.WriteLine(intStack.Pop());

            //Console.WriteLine(stringStack.Pop());

            stringStack.Push("Sprite");
            stringStack.Push("Fanta");

            Console.WriteLine(stringStack.Pop());

            stringStack.Push("Cola");
            stringStack.Push("Lipton");
            stringStack.Push("Neumarkt");

            while (!stringStack.Empty())
                Console.WriteLine(stringStack.Pop());

            Console.ReadKey();
        }
    }

    internal class Stk<T>
    {
        private T[] data;
        private int index;
        private int capacity;

        public Stk(int x)
        {
            capacity = x;
            index = 0;
            data = new T[capacity];
        }

        public void Push(T x)
        {
            if (index == capacity - 1)
                throw new System.IndexOutOfRangeException();
            else
                data[index++] = x;
        }

        public T Pop()
        {
            if (index == 0)
                throw new System.IndexOutOfRangeException();
            else
                return data[--index];
        }

        public void Clear()
        {
            T[] newdata = new T[capacity];
            data = newdata;
            index = 0;
        }

        public bool Empty()
        {
            if (index == 0)
                return true;
            return false;
        }
    }
}
