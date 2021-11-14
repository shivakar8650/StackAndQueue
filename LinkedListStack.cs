using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Queue_problems
{
    class LinkedListStack
    {
        private Node top;

        public LinkedListStack()
        {
            this.top = null;
        }

        internal void push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }
            Console.WriteLine(data + " pushed to the stack");
        }

        internal void display()
        {
            if (top == null)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                Node temp = top;
                Console.Write("Elements in stack is :");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine(" ");
            }
        }
       
    }
}
