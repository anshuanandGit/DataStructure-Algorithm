using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class TreeLeftView
    {
        //The left view contains all nodes that are first nodes in their levels.
        //A simple solution is to do level order traversal and print the first node in every level.
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

            Console.WriteLine("Left View of the tree..");
            LeftView(root);
            Console.WriteLine();
        }

        //do level order traversal and 
        //only consider left node..
        //if left node not there consider right
        public static void LeftView(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            
            Queue<Node> q = new Queue<Node>();
            //insert root
            q.Enqueue(root);

            while(q.Count != 0){

                int count = q.Count;
                for (int i = 1; i <= count; i++)
                {
                    Node x = q.Dequeue();
                    if (i == 1)
                    {
                        Console.Write(x.data + " ");//means left most ...
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
