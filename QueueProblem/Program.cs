using System;

namespace QueueProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Queue!");
            QueueUsingStack q = new QueueUsingStack();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);

            q.Dequeue();
            q.Dequeue();
            q.Dequeue();

            Console.ReadKey();
        }
    }
}
