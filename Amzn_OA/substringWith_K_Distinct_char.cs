using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class SubstringWith_K_Distinct_char
    {
        public static void Start()
        {
            
            int K = 2;           
            string S = "pqpqs";
            int ans = SubarraysWithKDistinct(S, K);
            Console.WriteLine("Total no of Substring with k distinct char " + ans);

        }
        public static int SubarraysWithKDistinct(string A, int K)
        {
            return (AtMostK(A, K) - AtMostK(A, K - 1));
        }

        // all subarrays with <= K distinct numbers are counted.
        private static int AtMostK(string A, int K)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int distinct = 0, ans = 0;

            for (int left = 0, right = 0; right < A.Length; right++)
            {
                if (map.ContainsKey(A[right]))
                {
                    map[A[right]] += 1;
                }
                else
                {
                    map.Add(A[right], 1);
                }

                if (map[A[right]] == 1)
                {
                    distinct++;
                }

                while (distinct > K)
                {
                    map[A[left]] -= 1;
                    if (map[A[left]] == 0)
                    {
                        distinct--;
                    }
                    left++;
                }
                ans += right - left + 1;
            }
            return ans;
        }
    }
}
