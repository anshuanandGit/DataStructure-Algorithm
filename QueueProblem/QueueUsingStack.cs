using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProblem
{

    class QueueUsingStack
    {
        Stack<int> st1 = new Stack<int>();
        Stack<int> st2 = new Stack<int>();
        int size = 0;

        public void Enqueue(int d)
        {
            st1.Push(d);
            Console.WriteLine("data EnQueued " + d);
            size++;
        }

        public int Dequeue()
        {
            if(st1.Count == 0)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            
            while (st1.Count > 1) // move all st1 items to st2 except first item
            {
                st2.Push(st1.Pop());
            }

            int x = st1.Pop();

            //again push back all contenets in st1
            while (st2.Count > 0) // move all st1 items to st2 except first item
            {
                st1.Push(st2.Pop());
            }           

            Console.WriteLine("dequeued data "+ x);
            return x;
        }

        public int GetCount()
        {
            return size;
        }
    }
}
