using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    class SumTwoList
    {
        public static void Start()
        {
            Node n1 = new Node(7);
            n1.next = new Node(5);
            n1.next.next = new Node(9);
            n1.next.next.next = new Node(4);
            n1.next.next.next.next = new Node(6);

            Node n2 = new Node(8);
            n2.next = new Node(4);

            Console.WriteLine("List 1: ");
            PrintList(n1);
            Console.WriteLine("List 2: ");
            PrintList(n2);

            Node x = GetSum(n1, n2);
            Console.WriteLine("Sum : ");
            PrintList(x);

        }

        private static Node GetSum(Node n1,Node n2)
        {
            if(n1 == null && n2 == null)
            {
                return null;
            }
            int carry = 0;
            int sum = 0;
            int d=0;

            Node t1 = n1;
            Node t2 = n2;
            Node op = new Node() ;
            Node t3 = new Node();

            int cntr = 0;

            while(t1 !=null || t2 != null)
            {
                //get carry from past sum
                sum += carry;

                if (t1 != null)
                {
                    sum += t1.data;
                    t1 = t1.next;
                }
                if (t2 != null)
                {
                    sum += t2.data;
                    t2 = t2.next;
                }

                d = sum % 10;
                carry = sum / 10;

                if (cntr == 0) //create first node
                {
                    t3 = new Node(d);
                    op = t3; //save the header....
                }
                else
                {
                    t3.next= new Node(d);
                    t3 = t3.next;
                }
                sum = 0;//reset sum
                cntr++;
            }

            if (carry > 0)
            {
                t3.next = new Node(carry);
            }

            return op;
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
