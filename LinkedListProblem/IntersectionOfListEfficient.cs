using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    /**
         * Get count of the nodes in the first list, let count be c1.
           Get count of the nodes in the second list, let count be c2.
           Get the difference of counts d = abs(c1 – c2)
           Now traverse the bigger list from the first node till d nodes so that from here onwards both the lists have equal no of nodes.
           Then we can traverse both the lists in parallel till we come across a common node. 
           (Note that getting a common node is done by comparing the address of the nodes)
         * */
    class IntersectionOfListEfficient
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
                n2.next.next.next = n1.next.next;

                Console.WriteLine("List 1");
                PrintList(n1);
                Console.WriteLine("List 2");
                PrintList(n2);

                Node n3 = MegeNode(n1, n2);
                if (n3 != null)
                {
                  Console.WriteLine("Intersection Node is " + n3.data);
                }
              
            }

            // function to find the intersection of two node 
            //Time Complexity O(n1+n2)
            //Space Complexity O(1)
            private static Node MegeNode(Node n1, Node n2)
            {
                int c1 = getCount(n1);
                int c2 = getCount(n2);

                if(c1 ==0 || c2 == 0)
                {
                    Console.WriteLine("No interscetion found");
                    return null;
                }
                if (c1 > c2)
                {
                    int d = c1 - c2;
                    return FindIntersection(d, n1, n2);
                }
                else
                {
                    int d = c2 - c1;
                    return FindIntersection(d, n2, n1);
                }            
            }
            
            private static Node FindIntersection(int d, Node biglist, Node smalllist)
            {
                
                int i = 0;
                Node t1 = biglist;
                //cover the d distance on big list
                while (i < d && t1 !=null)
                {
                    i++;
                    t1 = t1.next;
                }

                Node t2 = t1;
                Node t3 = smalllist;

                while (t2.next != null && t3.next != null)
                {
                    if (t2 == t3)
                    {
                        return t2;
                    }
                    t2 = t2.next;
                    t3 = t3.next;
                }

                return null;
            }

            //get node count
            private static int getCount(Node node)
            {
                Node current = node;
                int count = 0;

                while (current != null)
                {
                    count++;
                    current = current.next;
                }

                return count;
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

