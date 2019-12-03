using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class TreeLeafCount
    {
        public static void Start()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            Console.WriteLine("Total numbers of leaf");
            
            Console.WriteLine(LeafCount(root));
        }

        public static int LeafCount(Node root)
        {
            if(root == null)
            {
                return 0;
            }
            if(root.left ==null && root.right == null)
            {
                return 1;
            }

            //recurse to get count..
            return LeafCount(root.left) + LeafCount(root.right);

        }
    }
}
