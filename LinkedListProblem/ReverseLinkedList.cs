using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    class ReverseLinkedList
    {
        public static void Start()
        {
            Node root = new Node(1);
            root.next = new Node(2);
            root.next.next = new Node(3);
            root.next.next.next = new Node(4);
            root.next.next.next.next = new Node(5);
            Console.WriteLine("Original List");
            PrintList(root);

            root = ReverseListRecursion(root);
            Console.WriteLine("Reversed List");
            PrintList(root);

            root = ReverseListIteration(root);
            Console.WriteLine("Reverse List Again");
            PrintList(root);
           

        }
   
        //Time Complexity O(n)...
        //Space Complexity O(1)
        public static Node ReverseListRecursion(Node head)
        {
            if (head == null)
            {
                return head;
            }
            // last node or only one node 
            if (head.next == null)
            {
                return head;
            }

            Node newHeadNode = ReverseListRecursion(head.next);

            // change references for middle chain 
            head.next.next = head;
            head.next = null;

            // send back new head , node in every recursion 
            return newHeadNode;
        }


        //Time Complexity O(n)...Space Complexity O(1)
        public static Node ReverseListIteration(Node head)
        {
            Node prev = null, 
                current = head, 
                next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
            return head;
        }

        public static void PrintList(Node head)
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
