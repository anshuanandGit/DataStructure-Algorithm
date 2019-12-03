using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Amzn_OA
{
    class TopKFrequentWord
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {

            Dictionary<string, int> dic = new Dictionary<string, int>();
            List<string> op = new List<string>();

            foreach (string rv in words)
            {
                if (dic.ContainsKey(rv))
                {
                    dic[rv] += 1; //increase counter
                }
                else
                {
                    dic.Add(rv, 1);
                }
            }

            var x = from d in dic orderby d.Value descending select d;

            int cnt = 0;
            foreach (var itm in dic)
            {
                if (cnt == k)
                {
                    break;
                }
                else
                {
                    op.Add(itm.Key);
                    cnt++;
                }
            }

            return op;
        }
    }
}
