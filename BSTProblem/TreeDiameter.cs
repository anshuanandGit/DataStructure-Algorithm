using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class TreeDiameter
    {
        //Diameter - max distance between two edges
        public static void Start()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            Console.WriteLine("Diameter of the tree is");
            int d= GetDiameter(root);
            Console.WriteLine(d);
        }

        private static int ans = 0;

        public static int GetDiameter(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            int h = GetHeight(root);

            return ans;
        }

        public static int GetHeight(Node root)
        {
            if(root == null)
            {
                return 0;
            }
            int left_height = GetHeight(root.left);
            int right_height = GetHeight(root.right);

            ans = Math.Max(ans, left_height + right_height + 1);
            int h = Math.Max(left_height, right_height) + 1;

            return h;
        }

    }
}
