using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class TreeRightView
    {
        public static void Start()
        {
            Node root = new Node(10);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(7);
            root.left.right = new Node(8);
            root.right.right = new Node(15);
            root.right.left = new Node(12);
            root.right.right.left = new Node(14);

            Console.WriteLine("Right View of the tree..");
            RighttView(root);
            Console.WriteLine();

        }

        //do level order traversal and 
        //only consider Right most node..
        //if right node not there consider left then only
        public static void RighttView(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }

            Queue<Node> q = new Queue<Node>();
            //insert root
            q.Enqueue(root);

            while (q.Count != 0)
            {
                int count = q.Count;
              

                for(int i = 1; i <= count; i++)
                {
                    Node x = q.Dequeue();
                    if (i == count)
                    {                        
                        Console.Write(x.data + " ");//means right most ...
                    }

                    if (x.left != null)//insert left node first
                    {
                        q.Enqueue(x.left);
                    }
                    if (x.right != null)//insert right node later
                    {
                        q.Enqueue(x.right);
                    }                   
                }             
            }


        }


    }
}
