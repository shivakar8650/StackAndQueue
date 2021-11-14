using System;

namespace Stack_Queue_problems
{
    class Program
    {
        static void Main(string[] args)
        {

          

            LinkedListQueue Queue = new LinkedListQueue();
            Queue.Enqueu(70);
            Queue.Enqueu(30);
            Queue.Enqueu(56);
            Queue.Enqueu(85);
            Queue.display();
            Queue.Dequeu();
            Queue.display();

        }
    }
}
