using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace LinkedListProblem
{
    class DetectLoopUsingHash
    {

        public static void Start()
        {
            Node root = new Node(1);
            root.next = new Node(2);
            root.next.next = new Node(3);
            root.next.next.next = new Node(4);
            root.next.next.next.next = new Node(5);
            //create a loop ..
            root.next.next.next.next.next = root;          

            if (DetectLoop(root))
            {
                Console.WriteLine("loop found");
            }
            else
            {
                Console.WriteLine("Not found");
            }
          


        }

        private static bool DetectLoop(Node head)
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
                return false;
            }
            HashSet<Node> ht = new HashSet<Node>();

            Node temp = head;
            while(temp.next != null)
            {
                if (ht.Contains(temp))
                {
                    return true;
                }
                ht.Add(temp);
                temp = temp.next;
            }

            return false;
        }


      
    }
}
