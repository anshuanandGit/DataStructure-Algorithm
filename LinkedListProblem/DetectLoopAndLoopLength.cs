using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    class DetectLoopAndLoopLength
    {
        public static void Start()
        {
            Node root = new Node(1);
            root.next = new Node(2);
            root.next.next = new Node(3);
            root.next.next.next = new Node(4);
            root.next.next.next.next = new Node(5);
            //create a loop ..
            root.next.next.next.next.next = root.next.next;

            int x = DetectLoop(root);
            if (x > 0)
            {
                Console.WriteLine("loop found");
                Console.WriteLine("loop Length "+ x);
            }
            else
            {
                Console.WriteLine("Not found");
            }

        }

        private static int  DetectLoop(Node head)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return -1;
            }

            Node slow_p = head,    fast_p = head;
            while (slow_p != null && fast_p != null && fast_p.next != null)
            {
                slow_p = slow_p.next;
                fast_p = fast_p.next.next;
                if (slow_p == fast_p)
                {
                    return countNodes(slow_p);
                }
            }

            return 0;
        }

        // Returns count of nodes present in loop.  
       private  static int countNodes(Node n)
        {
            int res = 1;
            Node temp = n;
            while (temp.next != n)
            {
                res++;
                temp = temp.next;
            }
            return res;
        }
    }
}
