using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class MergeSortedList
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            ListNode temp1 = l1;
            ListNode temp2 = l2;

            List<int> lis = new List<int>();
            while (temp1 != null || temp2 != null)
            {

                if (temp1 != null && temp2 != null)
                {
                    lis.Add(temp1.val);
                    lis.Add(temp2.val);
                    temp1 = temp1.next;
                    temp2 = temp2.next;
                }
                else if (temp1 != null && temp2 == null)
                {
                    lis.Add(temp1.val);
                    temp1 = temp1.next;
                }
                else if (temp1 == null && temp2 != null)
                {
                    lis.Add(temp2.val);
                    temp2 = temp2.next;
                }
            }

            lis.Sort();
            ListNode op = null;
            ListNode temp3 = null;
            if (lis.Count > 0)
            {
                op = new ListNode(lis[0]);
                temp3 = op;
            }

            for (int i = 1; i < lis.Count; i++)
            {
                temp3.next = new ListNode(lis[i]);
                temp3 = temp3.next;
            }
            return op;
        }
    }

  
 
 public class ListNode {
     public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
 
}
