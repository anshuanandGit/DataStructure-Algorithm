using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class CheckIfTreeIsBST
    {
        public static void Start()
        {
            
            Node root = new Node(4);
            root.left = new Node(2);
            root.right = new Node(5);
            root.left.left = new Node(1);
            root.left.right = new Node(3);

            if (IsBST1(root))
            {
                Console.WriteLine("IS BST");
            }
            else
            {
                Console.WriteLine("Not a BST");
            }
              
        }

        static Node prev = null;
        public static bool IsBST(Node root)
        {
            if(root != null)
            {
                if (!IsBST(root.left))
                {
                    return false;
                }                 
                // allows only distinct values node 
                if (prev != null && root.data <= prev.data)
                {
                    return false;
                }
                   
                prev = root;
                return IsBST(root.right);
            }
            return true;
        }

        //using In Order traversal
        //Space Complexity O(n)
        public static bool IsBST1(Node root)
        {
            bool res = true;

            if (root != null)
            {
                List<int> nodeslist = new List<int>();
                GetNodesUsingInorder(root, nodeslist);

                for(int i=0;i< nodeslist.Count-1; i++)
                {
                    if(nodeslist[i] > nodeslist[i + 1])
                    {
                        res = false;
                        break;
                    }
                }
            }
            return res;
        }

        private static void GetNodesUsingInorder(Node root,List<int> nodeslist)
        {
            if (root != null)
            {
                GetNodesUsingInorder(root.left, nodeslist);
                nodeslist.Add(root.data);
                GetNodesUsingInorder(root.right, nodeslist);
            }
        } 
    }
}
