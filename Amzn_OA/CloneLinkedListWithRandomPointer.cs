using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class CloneLinkedListWithRandomPointer
    {       
        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }

            Node curr = head;
            Node temp = null;

            // insert additional node after  every node of original list 
            while (curr != null)
            {
                temp = curr.next;
                // Inserting node  
                curr.next = new Node(curr.val, temp, null);
                //curr.next.next = temp;  
                curr = temp;
            }

            curr = head;

            // adjust the random pointers of the newly added nodes  
            while (curr != null)
            {
                if (curr.next != null)
                {
                    if (curr.random != null)
                    {
                        curr.next.random = curr.random.next;
                    }
                    else
                    {
                        curr.next.random = curr.random;
                    }
                }
                // move to the next newly added node / by skipping an original node  
                curr = (curr.next != null) ? curr.next.next : curr.next;
            }

            Node original = head;
            Node copy = head.next;

            // save the start of copied linked list  
            temp = copy;

            // now separate the original list  
            // and copied list  
            while (original != null && copy != null)
            {
                original.next = (original.next != null) ? original.next.next : original.next;

                copy.next = (copy.next != null) ? copy.next.next : copy.next;
                original = original.next;
                copy = copy.next;
            }
            return temp;
        }
    }
}

// Definition for a Node.
public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node() { }
    public Node(int _val, Node _next, Node _random)
    {
        val = _val;
        next = _next;
        random = _random;
    }
}

