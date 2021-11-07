using System;

namespace Stack_Queue_problems
{
    class Program
    {
        static void Main(string[] args)
        {

            /*LinkedListStack stack = new LinkedListStack();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.display();
            stack.isempty();*/

            LinkedListQueue Queue = new LinkedListQueue();
            Queue.Enqueu(70);
            Queue.Enqueu(30);
            Queue.Enqueu(56);
            Queue.display();
            Queue.Dequeu();
            Queue.display();





        }
    }
}
