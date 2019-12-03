using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Amzn_OA
{
    class MinCostToConnectRope
    {
        public static void Start()
        {
            int[] ropes = new int[] { 8, 4, 6, 12 };
            Console.WriteLine(connectRopes(ropes));
        }

        public static int connectRopes(int[] ropes)
        {
            int len = ropes.Length;
            if (len == 0) return 0;
            Queue<int> pq = new Queue<int>();

            foreach (int rope in ropes)
            {
                pq.Enqueue(rope);
            }
            int costs = 0;
            while (pq.Count > 1)
            {
                pq = SortQ(pq);
                int rope1 = pq.Dequeue();
                int rope2 = pq.Dequeue();
                int ropeNew = rope1 + rope2;
                costs += ropeNew;
                pq.Enqueue(ropeNew);
            }
            return costs;
        }

        public static Queue<int> SortQ(Queue<int> q)
        {
            var a = q.ToArray().ToList();
            a.Sort();
            Queue<int> pq = new Queue<int>(a);
            return pq;
        }
    }

   
}
