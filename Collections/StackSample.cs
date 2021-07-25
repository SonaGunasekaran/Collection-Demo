using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class StackSample
    {
        public void ExecuteStack()
        {
            Stack<int> stack = new Stack<int>();
            //insert the elements into the stack
            stack.Push(20);
            stack.Push(40);
            stack.Push(60);
            stack.Push(80);
            stack.Push(100);
            stack.Push(120);
            stack.Push(140);
            Console.WriteLine("\nRemove the element");
            //delete the top element from the stack
            stack.Pop();
            Console.WriteLine("Peek element at the top :{0}", stack.Peek());
            
            
        }
       
    }
}
