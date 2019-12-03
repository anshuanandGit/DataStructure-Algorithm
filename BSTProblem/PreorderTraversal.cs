using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class PreorderTraversal
    {
        public static void Start()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            Console.WriteLine("Preorder Traversal");
            Preorder(root);
            Console.WriteLine();
        }

        public static void Preorder(Node root)
        {
            if(root == null)
            {
                return;
            }

            Console.Write(root.data + " ");
            Preorder(root.left);
            Preorder(root.right);
        }
    }
}
