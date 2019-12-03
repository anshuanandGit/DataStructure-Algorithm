using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class CriticalRouter_New
    {
        public static void Start()
        {
            int numRouters =7;
            int numLinks = 7;

            int[][] links = new int[7][];
            links[0] = new int[] { 0, 1 };
            links[1] = new int[] { 0, 2 };
            links[2] = new int[] { 1, 3 };
            links[3] = new int[] { 2, 3 };
            links[4] = new int[] { 2, 5 };
            links[5] = new int[] { 5, 6 };
            links[6] = new int[] { 3, 4 };            

            List<int> op = CriticalConnections(numRouters, links);

            foreach (var x in op)
            {
                Console.WriteLine(String.Join(" ", x));
            }


        }

        public static List<int> CriticalConnections(int n, int[][] connections)
        {
            int[] disc = new int[n];
            int[] low = new int[n];

            // use adjacency list instead of matrix will save some memory, adjmatrix will cause MLE
            List<int>[] graph = new List<int>[n];
            List<int> res = new List<int>();

            Array.Fill(disc, -1); // use disc to track if visited (disc[i] == -1)

            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>(); //insert a list for each node
            }

            // build graph
            for (int i = 0; i < connections.Length; i++)
            {
                int from = connections[i][0];
                int to = connections[i][1];

                graph[from].Add(to);
                graph[to].Add(from);
            }

            for (int i = 0; i < n; i++)
            {
                if (disc[i] == -1)
                {
                    DFS(i, low, disc, graph, res, i);
                }
            }
            return res;
        }

        static int time = 0; // time when discover each vertex

        private static void DFS(int u, int[] low, int[] disc, List<int>[] graph, List<int> res, int pre)
        {
            disc[u] = low[u] = ++time; // discover u

            for (int j = 0; j < graph[u].Count; j++)  //iterate for each point
            {
                int v = graph[u][j];
                if (v == pre)
                {
                    continue; // if parent vertex, ignore
                }
                if (disc[v] == -1)
                { // if not discovered
                    DFS(v, low, disc, graph, res, u);
                    low[u] = Math.Min(low[u], low[v]);

                    if (low[v] > disc[u])
                    {
                        // u - v is critical, there is no path for v to reach back to u or previous vertices of u
                        if(u ==0 && graph[u].Count > 1) //root node can only be articulation if got mutiple child node
                        {
                            res.Add(u);
                        }
                        else if(u !=0)
                        {
                            res.Add(u);
                        }
                    }
                }
                else
                { // if v discovered and is not parent of u, update low[u], cannot use low[v] because u is not subtree of v
                    low[u] = Math.Min(low[u], disc[v]);
                }
            }

        }
    }
}
