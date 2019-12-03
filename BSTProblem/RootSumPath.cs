using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    /*  
    Given a tree and a sum, return true if  
    there is a path from the root down to a  
    leaf, such that adding up all the values   
    along the path equals the given sum.  
  
    
    */

    class RootSumPath
    {
        public static void Start()
        {
            int sum = 21;

            /* Constructed binary tree is  
                10  
                / \  
            8     2  
            / \ /  
            3 5 2  
            */
          
            Node root = new Node(10);
            root.left = new Node(8);
            root.right = new Node(2);
            root.left.left = new Node(3);
            root.left.right = new Node(5);
            root.right.left = new Node(2);

            if (HaspathSum(root, sum))
            {
                Console.WriteLine("There is a root to leaf path with sum " + sum);
            }
            else
            {
                Console.WriteLine("There is no root to leaf path with sum " + sum);
            }
        }

        /*
          Strategy: 
          subtract the node value from the  
          sum when recurring down, and check to see 
          if the sum is 0 when you run out of tree. 
        */
        public static bool HaspathSum(Node root,int sum)
        {  
            if (root == null)
            {
                return (sum == 0);
            }
            else
            {
                bool ans = false;               
                int subsum = sum - root.data;
                if (subsum == 0 && root.left == null && root.right == null)
                {
                    return true; //leaf node found..
                }

                /* otherwise check both subtrees */
                if (root.left != null)
                {
                    ans = ans || HaspathSum(root.left, subsum);
                }
                if (root.right != null)
                {
                    ans = ans || HaspathSum(root.right, subsum);
                }
                return ans;
            }
       
        }
    }
}
