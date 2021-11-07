using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Queue_problems
{
    class LinkedListQueue
    {
        private Node front;
        private Node rear;

       public LinkedListQueue()
        {
            this.front = null;
            this.rear = null;
        }

        internal void Enqueu(int data)
        {
            Node node = new Node(data);
            if (front == null)
            {
                front = node;
                rear = node;
            }
            else
            {
                rear.next = node;
                rear = node;
              }
             Console.WriteLine(data + "ia added  to the Queue");
        }
        internal void display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = front;
                Console.Write("Element in Queue is :");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine(" ");
            }
        }
       /* internal void Dequeu()
        {
            if (head == null)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                head = head.next;
            }
        }
*/

    }
}
