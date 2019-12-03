using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class CriticalRouter
    {
        public static void Start()
        {
            int numRouters = 7;
            int numLinks = 7;

            int[][] links = new int[7][];
            links[0] = new int[] { 0, 1 };
            links[1] = new int[] { 0, 2 };
            links[2] = new int[] { 1, 3 };
            links[3] = new int[] { 2, 3 };
            links[4] = new int[] { 2, 5 };
            links[5] = new int[] { 5, 6 };
            links[6] = new int[] { 3, 4 };

            List<int> op = getCriticalNodes(links, numLinks, numRouters);
            op.Sort();
            foreach (var x in op)
            {
                Console.WriteLine(x);
            }

        }
        static int time = 0;
        private static List<int> getCriticalNodes(int[][] links, int numLinks, int numRouters)
        {
            time = 0;
            Dictionary<int, HashSet<int>> map = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < numRouters; i++)
            {
                map.Add(i, new HashSet<int>());
            }

            foreach (int[] link in links)
            {
                map[link[0]].Add(link[1]);
                map[link[1]].Add(link[0]);
            }

            HashSet<int> set = new HashSet<int>();

            int[] low = new int[numRouters];
            int[] ids = new int[numRouters];

            int[] parent = new int[numRouters];

            Array.Fill(ids, -1);
            Array.Fill(parent, -1);

            for (int i = 0; i < numRouters; i++)
            {
                if (ids[i] == -1)
                    DFS(map, low, ids, parent, i, set);
            }
            return new List<int>(set);
        }



        private static void DFS(Dictionary<int, HashSet<int>> map, int[] low, int[] ids, int[] parent, int cur, HashSet<int> res)
        {
            int children = 0;
            ids[cur] = low[cur] = ++time;
            foreach (int nei in map[cur])
            {
                if (ids[nei] == -1)
                {
                    children++;
                    parent[nei] = cur;
                    DFS(map, low, ids, parent, nei, res);
                    low[cur] = Math.Min(low[cur], low[nei]);
                    if ((parent[cur] == -1 && children > 1) || (parent[cur] != -1 && low[nei] >= ids[cur]))
                        res.Add(cur);
                }
                else if (nei != parent[cur])
                    low[cur] = Math.Min(low[cur], ids[nei]);
            }
        }
    }
}
