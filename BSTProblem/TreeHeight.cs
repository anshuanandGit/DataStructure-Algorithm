using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class TreeHeight
    {
        public static void Start()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            Console.WriteLine("Height of the tree is");

            Console.WriteLine(GetHeight(root));
        }

        public static int GetHeight(Node root)
        {
            if(root == null)
            {
                return -1;
            }

            int left_height = GetHeight(root.left);
            int right_height = GetHeight(root.right);

            int h = Math.Max(left_height, right_height)+1;

            return h;

        }
    }
}
