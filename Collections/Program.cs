using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections Programs!");
            ListSample list = new ListSample();
            list.ListOperations();
            StackSample stack = new StackSample();
            stack.ExecuteStack();
            
        }
    }
}
