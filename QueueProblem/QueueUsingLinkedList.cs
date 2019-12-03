using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProblem
{
    class QueueUsingLinkedList
    {
        Node root =null;
        Node front = null;
        Node rear = null;

        public void Enqueue(int d)
        {
            Node newNode = new Node(d);
            Console.WriteLine("EnQueue " + d);
            if (rear == null)
            {
                rear = newNode;
                front = rear ;
                return;
            }
            Node temp = rear;
            rear.next = newNode;
            rear = rear.next;
        }

        public int Dequeue()
        {
            if(rear == null)
            {
                Console.WriteLine("Queue Empty");
                return -1;
            }
            int x = front.data;

           // Node temp = front;
            front = front.next;
            if (front == null)
            {
                rear = null;
            }
              
            Console.WriteLine("DeQueue " + x);
            Console.WriteLine("Front at " + front.data);
            Console.WriteLine("Rear at " + rear.data);
            return x;
        }
    }



    class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
