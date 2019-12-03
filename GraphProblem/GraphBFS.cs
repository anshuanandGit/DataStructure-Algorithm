using System;
using System.Collections.Generic;
using System.Text;

namespace GraphProblem
{
    class GraphBFS
    {
        public static void Start()
        {
            List<int>[] graph = new List<int>[4];
            graph[0] = new List<int> { 1, 2 };
            graph[1] = new List<int> { 2 };
            graph[2] = new List<int> { 0, 3 };
            graph[3] = new List<int> { 3 };

            BFS(graph);
            Console.WriteLine();
        }

        public static void BFS(List<int>[] graph)
        {
            bool[] visited = new bool[graph.Length];

            Array.Fill(visited, false); //set false for all nodes..
            Queue<int> q = new Queue<int>();

            //start with node 2..
            q.Enqueue(2);
            visited[2] = true; //mark visited

            while (q.Count > 0)
            {
                int v = q.Dequeue();
                Console.Write(v + " ");
                
                //get adjacent nodes of v
                List<int> neighbours = graph[v];

                foreach(int neighbour in neighbours)
                {
                    if (!visited[neighbour])
                    {
                        visited[neighbour] = true;
                        q.Enqueue(neighbour);
                    }                    
                }
            }

        }


    }
}
