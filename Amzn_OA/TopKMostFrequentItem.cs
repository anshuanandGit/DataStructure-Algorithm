using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Amzn_OA
{
    class TopKMostFrequentItem
    {
        public static void Start()
        {
            int[] M = { 1, 3, 4, 1, 2, 3, 7, 2 };
            var x = TopKFrequent(M, 2);
            Console.WriteLine(x[0] + " " + x[1]);
        }

       
       public static  IList<int> TopKFrequent(int[] nums, int k)
        {

            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> op = new List<int>();

            foreach (int i in nums)
            {
                if (dic.ContainsKey(i))
                {
                    dic[i] += 1;
                }
                else
                {
                    dic.Add(i, 1);
                }
            }

            int j = 0;
            var yu = from d in dic orderby d.Value descending select d;

            foreach (var itm in yu)
            {
                if (j == k)
                {
                    break;
                }
                else
                {
                    op.Add(itm.Key);
                    j++;
                }
            }
            return op;

        }
    }
}
