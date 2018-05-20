using System;

namespace Learning
{
    class StackImplementation
    {
        static void Main(string[] args)
        {
            CustomStack<int> cStack = new CustomStack<int>();
            cStack.PrintStack();
            cStack.Pop();
            cStack.Peek();
            cStack.Push(10);
            cStack.PrintStack();
            cStack.Push(11);
            cStack.Push(12);
            cStack.Push(13);
            cStack.Push(14);
            cStack.Push(15);
            cStack.Push(16);
            cStack.PrintStack();
            var item = cStack.Pop();
            Console.WriteLine("Popped Item is: " + item);
            cStack.PrintStack();
            item = cStack.Peek();
            Console.WriteLine("Peek Item is: " + item);
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Custom Stack Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class CustomStack<T>
    {
        private int MaxSize = 100;
        private T[] StackArray;
        private int Top;

        /// <summary>
        /// Constructor
        /// </summary>
        public CustomStack()
        {
            StackArray = new T[MaxSize];
            Top = -1;
            Console.WriteLine("Stack Initialized");
        }
        /// <summary>
        /// Push item to stack
        /// </summary>
        /// <param name="data"></param>
        public void Push(T data)
        {
            Console.WriteLine("Performing Push Operation");
            if (Top < MaxSize - 1)
            {
                StackArray[++Top] = data;
            }
            else 
                Console.WriteLine("Stack is full");
        }
        /// <summary>
        /// Pop item from stack
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            Console.WriteLine("Performing Pop Operation");
            if (Top > -1)
            {
                var data = StackArray[Top];
                StackArray[Top--] = default(T);
                return data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }
        }
        /// <summary>
        /// Get the top most stack item
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            Console.WriteLine("Performing Peek Operation");
            if (Top > -1)
            {
                return StackArray[Top];
            }
            Console.WriteLine("Stack is empty");
            return default(T);
        }

        /// <summary>
        /// Print stack items
        /// </summary>
        public void PrintStack()
        {
            Console.WriteLine("Performing Print Stack Operation");
            if (Top > -1)
            {
                Console.Write("Stack Items are: ");
                for (int i = 0; i <= Top; i++)
                {
                    if (i != Top)
                    {
                        Console.Write(StackArray[i] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(StackArray[i]);
                    }
                }
            }
        }
    }
}
