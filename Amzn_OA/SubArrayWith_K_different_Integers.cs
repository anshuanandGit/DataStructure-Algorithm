using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class SubArrayWith_K_different_Integers
    {
        public static void Start()
        {
            int[] A = { 1, 2, 1, 2, 3 };
            int K = 2;
            int ans = SubarraysWithKDistinct(A, K);

            Console.WriteLine("Total no of Sub array with k distinct integer " + ans);

        }
        public static int SubarraysWithKDistinct(int[] A, int K)
        {
            return (AtMostK(A, K) - AtMostK(A, K - 1));
        }

        // all subarrays with <= K distinct numbers are counted.
        private static int AtMostK(int[] A, int K)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
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
                    map[A[left]] -=  1;
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
