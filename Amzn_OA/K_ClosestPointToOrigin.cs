using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class K_ClosestPointToOrigin
    {
        public int[][] KClosest(int[][] points, int K)
        {

            int[][] op = new int[K][];
            int[] dist = new int[points.Length];

            for (int i = 0; i < points.Length; i++)
            {
                dist[i] = GetDist(points[i]);
            }

            Array.Sort(dist);
            int kthDistance = dist[K - 1];

            int m = 0;

            for (int i = 0; i < points.Length; i++)
            {
                if (GetDist(points[i]) <= kthDistance)
                {
                    op[m] = points[i];
                    m++;
                }
            }

            return op;
        }

        public int GetDist(int[] point)
        {
            return point[0] * point[0] + point[1] * point[1];
        }
    }
}
