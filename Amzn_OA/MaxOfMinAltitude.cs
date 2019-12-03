using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class MaxOfMinAltitude
    {
        public static void Start()
        {
            int[,] A = { { 1, 1 }, { 4, 5 } };
            int[,] B = { { 5, 7 }, { 3, 4 }, { 9, 8 } };
            int[,] C = { { 5, 7, 6, 8 }, { 3, 4, 2, 1 }, { 9, 8, 4, 6 } };
            int tc1 = MinMaxScore( A);
            int tc2 = MinMaxScore(B);
            int tc3 = MinMaxScore(C );
            Console.WriteLine(tc1 + " " + tc2 + " " + tc3);

        }

        public static int MinMaxScore(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            //total number of possible path = no of columns
            int[] dp = new int[n];
            //set value for first path max ..we have to ignore M[0,0] , M[R-1,C-1] ...they shoul not be considered for min value in path
            dp[0] = int.MaxValue;  
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }  
                   
                    if (j == 0 && i != 0)
                    {
                        dp[j] = Math.Min(matrix[i,j], dp[j]);
                    }
                    else if (j != 0 && i == 0)
                    {
                        dp[j] = Math.Min(matrix[i,j], dp[j - 1]);
                    }
                    else
                    {
                        dp[j] = Math.Min(Math.Max(dp[j], dp[j - 1]), matrix[i,j]);
                    }
                }
            }
            return dp[n - 1];
        }
    }
}
