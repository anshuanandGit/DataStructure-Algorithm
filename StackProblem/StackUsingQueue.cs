using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace StackProblem
{
    //There are two way of doing this...
    // Make Push operation costly...
    // make Pop operation costly..
    class StackUsingQueue
    {
        private Queue<int> q1 = new Queue<int>();
        private Queue<int> q2 = new Queue<int>();
        private int curr_size = 0;

        public void Push(int d)
        {
            //push data to q2
            q2.Enqueue(d);
            Console.WriteLine("Pushed to Stack "+d);
            curr_size++;
            //one by one dequeue all data from q1 and add behind q2
            while (q1.Count > 0){
                q2.Enqueue(q1.Dequeue());
            }

            //swap bot the queue.
            Queue<int> temp = q1;
            q1 = q2;
            q2 = temp;
        }

        public int Pop()
        {
            if(q1.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            curr_size--;
            return q1.Dequeue();
        }
    }
}
