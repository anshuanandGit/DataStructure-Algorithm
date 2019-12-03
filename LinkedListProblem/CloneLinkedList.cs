using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    class CloneLinkedList
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
           
            Node op = CloneList(root);
            Console.WriteLine("Cloned List");
            PrintList(op);

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

        //Time Complexity O(n)...Space Complexity O(1)
        public static Node CloneList(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("list empty");
                return null;
            }
           
            Node op = new Node(root.data); //add first data
            Node temp = root.next;
            Node cloneTemp = op;

            while (temp != null)
            {
                cloneTemp.next = new Node(temp.data);
                temp = temp.next;
                cloneTemp = cloneTemp.next;
            }

            return op;
        }

    }
}
