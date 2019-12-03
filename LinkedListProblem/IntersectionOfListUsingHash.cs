using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    //This method is not very efficient
    //If list are big it will result in huge space 
    class IntersectionOfListUsingHash
    {
        public static void Start()
        {
            // list 1 
            Node n1 = new Node(1);
            n1.next = new Node(2);
            n1.next.next = new Node(3);
            n1.next.next.next = new Node(4);
            n1.next.next.next.next = new Node(5);
            n1.next.next.next.next.next = new Node(6);
            n1.next.next.next.next.next.next = new Node(7);
            
            // list 2 
            Node n2 = new Node(10);
            n2.next = new Node(9);
            n2.next.next = new Node(8);
            n2.next.next.next = n1.next.next.next;

            Console.WriteLine("List 1");
            PrintList(n1);
            Console.WriteLine("List 2");
            PrintList(n2);

            Node n3 = MegeNode(n1, n2);
            Console.WriteLine("Intersection Node is ");
            Console.WriteLine(n3.data);
        }

        // function to find the intersection of two node 
        //Time Complexity O(n1+n2)
        //Space Complexity O(n1+n2)
        public static Node MegeNode(Node n1, Node n2)
        {
            // define hashset 
            HashSet<Node> hs = new HashSet<Node>();
            while (n1 != null)
            {
                hs.Add(n1);
                n1 = n1.next;
            }
            while (n2 != null)
            {
                if (hs.Contains(n2))
                {
                    return n2;
                }
                n2 = n2.next;
            }
            return null;
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
