using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Linkedlist!");

            /**
            LinkedList L = new LinkedList();
            L.AddLast(1);
            L.AddLast(2);
            L.AddLast(3);
            L.AddLast(4);
            L.AddLast(5);
            L.PrintList();

            L.AddAfter(3, 22);
            L.PrintList();
            L.AddBefore(4, 11);
            L.PrintList();
            L.DeleteAt(5);
            L.PrintList();
            **/
            CloneListWithRandomPointer.Start();

            Console.ReadKey();
        }
    }
}
