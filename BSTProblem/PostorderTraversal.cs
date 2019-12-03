using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class PostorderTraversal
    {
        public static void Start()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            Console.WriteLine("Postorder Traversal");
            Postorder(root);
            Console.WriteLine("");
        }

        public static void Postorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Postorder(root.left);
            Postorder(root.right);
            Console.Write(root.data + " ");
        }
    }
}
