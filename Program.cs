using System;

namespace Stack_Queue_problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the UC2_stack!");
            LinkedListStack stack = new LinkedListStack();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.display();
            stack.isempty();
        }
    }
}
