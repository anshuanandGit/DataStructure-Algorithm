using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    /**
     * Floyd’s Cycle-Finding Algorithm: This is the fastest method and has been described below:

        1. Traverse linked list using two pointers. 
        2. Move one pointer(slow_p) by one and another pointer(fast_p) by two. 
        3. If these pointers meet at the same node then there is a loop. If pointers do not meet then linked list doesn’t have a loop
     * */

    class DetectLoopWithSlwPointer
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
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return false;
            }

            Node slow_p = head,
                fast_p = head;
            while (slow_p != null && fast_p != null && fast_p.next != null)
            {
                slow_p = slow_p.next;
                fast_p = fast_p.next.next;
                if (slow_p == fast_p)
                {             
                    return true;
                }
            }

            return false;
        }

    }
}
