using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    public class LinkedList
    {
        Node head;

        public LinkedList()
        {
            head = null;
        }       

        public void Clear()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void AddFirst(int d)
        {
            Node newNode = new Node(d);
            newNode.next = head;
            head = newNode;
        }

        public void AddLast(int d)
        {
            if (head == null)
            {
                AddFirst(d);
                return;
            }

            Node cur = head;
            while (cur.next != null)
            {
                cur = cur.next;
            }

            cur.next = new Node(d);
        }

        public int GetFirst()
        {
            return head.data;
        }

        public int GetLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return -1;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp.data;
        }

        public int GetDataAt(int indx)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return -1;
            }

            int cntr = -1;
            Node temp = head;
            bool found = false;

            while(temp.next != null)
            {
                cntr++;
                if (cntr == indx)
                {
                    found = true;
                    break;
                }
                temp = temp.next;                
            }

            if (found)
            {
                return temp.data;
            }
            else
            {
                return -1;
            }
        }

        public void AddAfter(int indx, int d)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            int cntr = -1;
            Node temp = head;
            bool found = false;
            while (temp.next != null)
            {
                cntr++;
                if (cntr == indx)
                {
                    found = true;
                    break;
                }
                temp = temp.next;
            }

            if (found)
            {
                Node t = temp.next;
                Node y = new Node(d);
                y.next = t;
                temp.next = y;
            }
            else
            {
                Console.WriteLine("index not found ");
            }
        }

        public void AddBefore(int indx, int d)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            int cntr = -1;
            Node temp = head;
            bool found = false;
            while (temp.next != null)
            {
                cntr++;
                if (cntr == indx - 1)
                {
                    found = true;
                    break;
                }
                temp = temp.next;
            }

            if (found)
            {
                Node t = temp.next;
                Node y = new Node(d);
                y.next = t;
                temp.next = y;
            }
            else
            {
                Console.WriteLine("index not found ");
            }
        }

        public void DeleteAt(int indx)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            int cntr = -1;
            Node temp = head;
            bool found = false;
            while (temp.next != null)
            {
                cntr++;
                if (cntr == indx-1)
                {
                    found = true;
                    break;
                }
                temp = temp.next;
            }

            if (found)
            {
                Node t = temp.next.next;
                temp.next = t;
            }
            else
            {
                Console.WriteLine("index not found ");
            }
        }

        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node temp = head;

            while (temp != null)
            {
                Console.Write(temp.data+ " > ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }





    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

        public Node()
        {
        }
    }
}
