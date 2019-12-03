using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Amzn_OA
{
    class TopNBuzzWord
    {
        public static void Start()
        {
            string[] Review = { "newshop is providing good service in the city; everyone should use newshop","best service by newshop",
                                "fashionbeats has great service in the city.","I am proud to have fashionbeats'","mymarket has awesoem service",
                                 "Thanks newshop for great service"};
            string[] Competitor = { "newshop","shopnow","afshion","fashionbeats","mymarket","tcellular" };
            int topNCompetiotor = 2;

            var x = TopKFrequent(Review, Competitor, topNCompetiotor);
            Console.WriteLine(x[0] + " " + x[1]);
        }


        public static IList<string> TopKFrequent(string[] review,string[] brands, int k)
        {
            char[] delim = { ' ', ',', '.', '?', '!', ';', ':', '\'' };
            Dictionary<string, int> dic = new Dictionary<string, int>();
            List<string> op = new List<string>();

            string expandReview = String.Join(",", review); //spread entire review string...
            string[] arrRev = expandReview.Split(delim);

            foreach (string rv in arrRev)
            {
                if (brands.Contains(rv))
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
            }

            var x = from d in dic orderby d.Value descending select d;

            int cnt = 0;
            foreach(var itm in x)
            {
                if(cnt == k)
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
