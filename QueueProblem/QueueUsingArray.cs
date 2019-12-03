using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProblem
{
    //This queue is not efficient ....because once elements are deleted from front , those space cannot be reused...
    //Enqueue and Dequeue O(1) 
    class QueueUsingArray
    {
        int[] arr;
        int front, rear, capacity;

        public QueueUsingArray(int c)
        {
            capacity = c;
            arr = new int[capacity];
            front = 0;
            rear = -1;
        }

        public void Enqueue(int d)
        {
            if(rear == capacity - 1)
            {
                Console.WriteLine("Overflow..");
                return;
            }
            rear++;
            arr[rear] = d;
            Console.WriteLine("Inserted in queue "+ d);
        }

        public int Dequeue()
        {
            if(front == rear + 1)
            {
                Console.WriteLine("Queue is empty..");
                return -1;
            }
            Console.WriteLine("Dequeued " + arr[front]);
            int x = arr[front];
            front++;
            Console.WriteLine("Front item is {0}", arr[front]);
            Console.WriteLine("Rear item is {0} ", arr[rear]);

            return x;
        }
    }
}
