using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public bool IsNull()
        {
            return root == null;
        }

        public void Insert(int d)
        {
            root = Insert(root, d);
        }

        private Node Insert(Node root, int d)
        {
            if (root == null)
            {
                return new Node(d);
            }
            if(root.data == d)
            {
                return root;
            }
            if(d > root.data)
            {
                root.right = Insert(root.right, d);
            }
            if (d < root.data)
            {
               root.left = Insert(root.left, d);
            }

            return root;
        }

        public bool Search(int d)
        {
            return Search(root, d);
        }

        private bool Search(Node root,int d)
        {
            if (root == null)
            {
                return false;
            }
            else if (root.data == d)
            {
                return true;
            }
            else if (d > root.data)
            {
                return Search(root.right, d);
            }
            else
            {
                return Search(root.left, d);
            }             
        }

        public void Delete(int d)
        {
            root = Delete(root, d);
        }

        private Node Delete(Node root,int d)
        {
            if (root == null)
            {
                return null;
            }
            else if(d < root.data)
            {
                root.left = Delete(root.left, d);
            }
            else if (d > root.data)
            {
                root.right = Delete(root.right, d);
            }
            else
            {   //Node found
                if (root.left == null)
                {
                    return root.right; //if left node is null , after deleting right node will pe parent
                }
                else if (root.right == null)
                {
                    return root.left; //if right node is null , after deleting left node will pe parent
                }
                else
                {
                    //Node has two child..
                    root.data = GetMaxFromLeftTree(root.left); //get max data from left sub tree and assign to root
                    //delete that specific node...
                    root.left = Delete(root.left, root.data);
                }                
            }

            return root;
        }

        private int GetMaxFromLeftTree(Node p)
        {
            while (p.right != null)
            {
                p = p.right;
            }
            return p.data;
        }

        
        public BinarySearchTree Clone()
        {
            BinarySearchTree twin = null;
            twin = new BinarySearchTree();


            twin.root = CloneHelper(root);
            return twin;
        }

        private Node CloneHelper(Node p)
        {
            if (p == null)
            {
                return null;
            }
            else
            {
                Node nw= new Node(p.data);
                nw.left = CloneHelper(p.left);
                nw.right = CloneHelper(p.right);
                return nw;
            }
        }
    }
}
