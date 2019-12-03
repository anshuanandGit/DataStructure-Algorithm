using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    class MergeSortedListWithHash
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
            List<int> hs = new List<int>();

            while (n1 != null)
            {
                hs.Add(n1.data);
                n1 = n1.next;
            }

            while (n2 != null)
            {
                hs.Add(n2.data);
                n2 = n2.next;
            }

            //sort list..
            hs.Sort();
            Node t1 = new Node(hs[0]);
            Node t2 = t1;
            for(int i=1; i<hs.Count; i++)
            {
                t2.next = new Node(hs[i]);
                t2 = t2.next;
            }

            return t1;

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
