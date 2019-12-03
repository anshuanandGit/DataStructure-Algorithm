using System;
using System.Collections.Generic;
using System.Text;

namespace StackProblem
{
    class StackAsLinkedList
    {
        StackNode root;

        public void Push(int d)
        {
            StackNode newNode = new StackNode(d);
            if (root == null)
            {
                root = newNode;
                return;
            }
            StackNode temp = root;
            root = newNode;
            newNode.next = temp;
            Console.WriteLine(d + " pushed to stack");
        }

        public int Pop()
        {            
            if (root == null)
            {
               Console.WriteLine("Stack is IsEmpty");
                return -1;
            }
            int x = root.data;
            root = root.next;
            return x;
        }

        public int Peek()
        {
            if (root == null)
            {
                Console.WriteLine("Stack is IsEmpty");
                return -1;
            }
            int x = root.data;          
            return x;
        }

        public bool IsEmpty()
        {
            if(root == null)
            {
                return true;
            }
            return false;
        }
    }

    class StackNode
    {
        public int data;
        public StackNode next;

        public StackNode(int d)
        {
            data = d;
            next = null;
        }
    }
}
