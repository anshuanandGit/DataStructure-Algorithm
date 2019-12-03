using System;
using System.Collections.Generic;
using System.Text;

namespace GraphProblem
{
    class GraphDFS
    {
        public static void Start()
        {
            List<int>[] graph = new List<int>[4];
            graph[0] = new List<int> { 1, 2 };
            graph[1] = new List<int> { 2 };
            graph[2] = new List<int> { 0, 3 };
            graph[3] = new List<int> { 3 };

       
            DFS(graph);
            Console.WriteLine();
        }

        public static void DFS(List<int>[] graph)
        {
            int num_nodes = graph.Length;
            int[] visited = new int[num_nodes];
            Array.Fill(visited, -1); //all unvisited will have -1 value.

            //start with node 2
            for (int i = 0; i < num_nodes; i++)
            {
                if (visited[i] == -1)
                {
                    DFS_Util(i, visited, graph);
                }
            }
              
        }

        public static void DFS_Util(int to_visit , int[] visited, List<int>[] graph)
        {
            //mark the node visite
            visited[to_visit] = 1;
            //print node
            Console.Write(to_visit + " ");

            //get all connecting nodes..
            List<int> connection = graph[to_visit];

            foreach(int v in connection)
            {
                if(visited[v] == -1)
                {
                    DFS_Util(v, visited, graph);
                }               
            }
        }
    }
}
