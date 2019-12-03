using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class LargestBSTInTree
    {
        public static void Start()
        {
            /* Let us construct the following Tree  
                50  
             /      \  
            10        60  
           /  \       /  \  
          5   20    55    70  
         /     /  \  
        45   65    80  
         */
                    
            Node root = new Node(50);
            root.left = new Node(10);
            root.right = new Node(60);
            root.left.left = new Node(5);
            root.left.right = new Node(20);
            root.right.left = new Node(55);
            root.right.left.left = new Node(45);
            root.right.right = new Node(70);
            root.right.right.left = new Node(65);
            root.right.right.right = new Node(80);

            /* The complete tree is not BST as 45 is in right subtree of 50.  
             The following subtree is the largest BST  
                 60  
                /  \  
              55    70  
              /     /  \  
            45     65   80  
            */
        }


    }
}
