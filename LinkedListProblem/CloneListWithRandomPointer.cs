using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    class CloneListWithRandomPointer
    {
        public static void Start()
        {
            Noder start = new Noder(1);
            start.next = new Noder(2);
            start.next.next = new Noder(3);
            start.next.next.next = new Noder(4);
            start.next.next.next.next = new Noder(5);

            // 1's random points to 3  
            start.random = start.next.next;

            // 2's random points to 1  
            start.next.random = start;

            // 3's and 4's random points to 5  
            start.next.next.random = start.next.next.next.next;
            start.next.next.next.random = start.next.next.next.next;

            // 5's random points to 2  
            start.next.next.next.next.random = start.next;
            Console.WriteLine("Original List");
            PrintList(start);

            Console.WriteLine("Cloned List");
            Noder x = CloneUsingHashMap(start);
            PrintList(x);
        }

        //Time Complexity O(n)
        //Space Complexity O(n)
        private static Noder  CloneUsingHashMap(Noder head)
        {
            if(head == null)
            {
                return null;
            }
            
            Dictionary<Noder, Noder> Map = new Dictionary<Noder, Noder>(); //map will store all nodes as key and new nodes as value

            Noder clone;
            Noder orginal = head;   
            //iterate and insert new nodes in map
            while (orginal != null)
            {
                clone = new Noder(orginal.data);
                Map.Add(orginal, clone); //key = original node , value = new Node(original node data)
                orginal = orginal.next;
            }

            orginal = head; //bring the pointer to head again
            while(orginal != null)
            {
                clone = Map[orginal];
                if(orginal.next != null)
                {
                    clone.next = Map[orginal.next];
                }
                if(orginal.random != null)
                {
                    clone.random = Map[orginal.random];
                }            
                orginal = orginal.next;
            }
            //all the values in map are now pointing to correct next and random address.
            //return head of cloned node..

            return Map[head]; //this will return corrosponding cloned head

        }

        // This function clones a given  
        // linked list in O(1) space  

        private static Noder CloneInConstantSpace(Noder start)
        {
            Noder curr = start, 
                  temp = null;

            // insert additional node after every node of original list  
            while (curr != null)
            {
                temp = curr.next;
                // Inserting node  
                curr.next = new Noder(curr.data);
                curr.next.next = temp;
                curr = temp;
            }
            curr = start;

            // adjust the random pointers of the newly added nodes  
            while (curr != null)
            {
                if (curr.next != null)
                {
                    curr.next.random = (curr.random != null)? curr.random.next : curr.random;
                }         
            // move to the next newly added node by skipping an original node  
                curr = (curr.next != null) ? curr.next.next : curr.next;
            }

            Noder original = start, copy = start.next;

            // save the start of copied linked list  
            temp = copy;

            // now separate the original list and copied list  
            while (original != null && copy != null)
            {
                original.next = (original.next != null) ? original.next.next : original.next;

                copy.next = (copy.next != null) ? copy.next.next : copy.next;
                original = original.next;
                copy = copy.next;
            }

            return temp;
        }


        static void PrintList(Noder start)
        {
            Noder ptr = start;
            while (ptr != null)
            {
                Console.WriteLine("Data = " + ptr.data +  ", Random = " +    ptr.random.data);
                ptr = ptr.next;
            }
        }

    }

    class Noder
    {
        public int data;
        public Noder next;
        public Noder random;
        public Noder(int d)
        {
            data = d;
            next = null;
        }

        public Noder()
        {
        }
    }
}
