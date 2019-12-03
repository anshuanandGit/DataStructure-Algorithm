using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class LevelorderTraversal
    {
        public static void Start()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            Console.WriteLine("Levelorder Traversal");
            LevelOrder(root);
            Console.WriteLine("");
        }

        public static void LevelOrder(Node root)
        {
            if(root == null)
            {
                Console.WriteLine("Tree is null");
                return;
            }

            //Create a Queue..
            Queue<Node> qu = new Queue<Node>();
            //insert root;
            qu.Enqueue(root);

            while(qu.Count != 0)
            {
                Node x = qu.Dequeue();
                Console.Write(x.data + " ");

                //Check for chil of node and insert them in tree...
                if(x.left != null)
                {
                    qu.Enqueue(x.left);
                }
                if (x.right != null)
                {
                    qu.Enqueue(x.right);
                }
            }
        }

        
    }
}
