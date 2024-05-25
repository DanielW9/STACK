using STACK;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK
{
    class Stack
    {
        private int maxSize;
        private int[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new int[maxSize];
            top = -1;
        }

        public void Push(int value)
        {
            if (top == maxSize - 1)
            {
                Console.WriteLine("Stos jest pełny. Nie można dodać więcej elementów.");
            }
            else
            {
                stackArray[++top] = value;
            }
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stos jest pusty. Brak elementów do usunięcia.");
                return -1;
            }
            else
            {
                return stackArray[top--];
            }
        }

        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stos jest pusty. Brak elementów do wyświetlenia.");
                return -1;
            }
            else
            {
                return stackArray[top];
            }
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }
    }

    class Program
    {
        static void Main()
        {
            Stack stack = new Stack(5);

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Element na szczycie stosu: " + stack.Peek());

            stack.Pop();
            stack.Pop();

            Console.WriteLine("Czy stos jest pusty? " + stack.IsEmpty());
        }
    }

    
}
