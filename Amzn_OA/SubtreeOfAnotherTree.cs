using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class SubtreeOfAnotherTree
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null)
            {
                return false;
            }
            if (IsSame(s, t))
            {
                return true;
            }
            return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }

        private bool IsSame(TreeNode s, TreeNode t)
        {
            if (s == null && t == null)
            {
                return true;
            }
            if (s == null || t == null)
            {
                return false;
            }

            if (s.val != t.val)
            {
                return false;
            }

            return IsSame(s.left, t.left) && IsSame(s.right, t.right);
        }
    }

    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) {
            val = x;
        }
    }
}
