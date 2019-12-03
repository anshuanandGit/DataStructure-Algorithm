using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class LowestCommonAncestor
    {
        public static void Start()
        {
            // Let us construct the BST shown in the above figure            
            Node root = new Node(20);
            root.left = new Node(8);
            root.right = new Node(22);
            root.left.left = new Node(4);
            root.left.right = new Node(12);
            root.left.right.left = new Node(10);
            root.left.right.right = new Node(14);

            int n1 = 10, n2 = 14;
            Node t = GetCommonAncestor(root, n1, n2);
            Console.WriteLine("LCA of " + n1 + " and " + n2 + " is " + t.data);

            n1 = 14;
            n2 = 8;
            t = GetCommonAncestor(root, n1, n2);
            Console.WriteLine("LCA of " + n1 + " and " + n2 + " is " + t.data);

            n1 = 10;
            n2 = 22;
            t = GetCommonAncestor(root, n1, n2);
            Console.WriteLine("LCA of " + n1 + " and " + n2 + " is " + t.data);
        }

        public static Node GetCommonAncestor(Node root, int n1, int n2)
        {
            while (root != null)
            {                 
                if (root.data > n1 && root.data > n2)
                {
                    root = root.left; // If both n1 and n2 are smaller than root, then LCA lies in left 
                }           
                else if (root.data < n1 && root.data < n2)
                {
                    root = root.right; // If both n1 and n2 are greater than root, then LCA lies in right 
                }
                else break;
            }
            return root;
        }
    }
}
