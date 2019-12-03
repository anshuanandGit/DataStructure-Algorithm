using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    class MergeListWithRecursion
    {
        public static void Start()
        {
            Node n1 = new Node(2);
            n1.next = new Node(5);
            n1.next.next = new Node(9);
            n1.next.next.next = new Node(11);
            n1.next.next.next.next = new Node(16);

            Node n2 = new Node(3);
            n2.next = new Node(8);
            n2.next.next = new Node(13);
            n2.next.next.next = new Node(19);

            Console.WriteLine("List 1: ");
            PrintList(n1);
            Console.WriteLine("List 2: ");
            PrintList(n2);

            Node x = MergeList(n1, n2);
            Console.WriteLine("Merged List : ");
            PrintList(x);

        }

        private static Node MergeList(Node n1, Node n2)
        {
            if (n1 == null && n2 != null)
            {
                return n2;
            }
            else if (n2 == null && n1 != null)
            {
                return n1;
            }

            if (n1.data < n2.data)
            {
                n1.next = MergeList(n1.next, n2);
                return n1;
            }
            else
            {
                n2.next = MergeList(n2.next, n1);
                return n2;
            }

        }

        private static void PrintList(Node head)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node temp = head;

            while (temp != null)
            {
                Console.Write(temp.data + " > ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
