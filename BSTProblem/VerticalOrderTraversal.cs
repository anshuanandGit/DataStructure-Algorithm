using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BSTProblem
{
    class VerticalOrderTraversal
    {
        // Driver program to test above functions 
        public static void Start()
        {
            // TO DO Auto-generated method stub 
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);
            root.right.left.right = new Node(8);
            root.right.right.right = new Node(9);
            Console.WriteLine("Vertical Order traversal is");
            PrintVerticalOrder(root);
        }

        public static void PrintVerticalOrder(Node root)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            //start with root ...which is level 0
            GetVerticalOrder(0, map, root);

            //sort all the levels in increasing order.
            var sorted = from m in map orderby m.Key ascending select m;

            //iterate each level and print output

            foreach(var x in sorted)
            {
                Console.WriteLine(String.Join(" ", x.Value));
            }

        }

        public static void GetVerticalOrder(int level,Dictionary<int,List<int>> map,Node root)
        {
            if(root == null)
            {
                return;
            }
           
            //check if for given level list is already 
            if (map.ContainsKey(level))
            {
                List<int> levelist = map[level];
                levelist.Add(root.data);
            }
            else
            {
                List<int> levelist = new List<int>();
                levelist.Add(root.data);
                map.Add(level, levelist);
            }

            GetVerticalOrder(level - 1, map, root.left); //for left child reduce level by 1
            GetVerticalOrder(level + 1, map, root.right); //for right child increase level by 1
        }

    }
}
