using System;
using System.Collections.Generic;
using System.Text;

namespace GraphProblem
{
    class TopologicalSort
    {
        public static void Start()
        {
            List<int>[] graph = new List<int>[6];
            graph[0] = new List<int> {  };
            graph[1] = new List<int> {  };
            graph[2] = new List<int> { 3 };
            graph[3] = new List<int> { 1 };
            graph[4] = new List<int> { 0 , 1};
            graph[5] = new List<int> { 2 , 0};

            TopSort(graph);
            Console.WriteLine();
        }

        public static void TopSort(List<int>[] graph)
        {
            int num_nodes = graph.Length;
            bool[] visited = new bool[num_nodes];
            Stack<int> node_order = new Stack<int>();

            Array.Fill(visited, false); //all unvisited will have -1 value.

            //start with node 2
            for (int i = 0; i < num_nodes; i++)
            {
                if (!visited[i])
                {
                    DFS_Util(i, visited, graph,node_order);
                }
            }

            //print stack
            Console.WriteLine("Following is the Topological Sort for the graph >>  ");
            while (node_order.Count > 0)
            {
                Console.Write(node_order.Pop() + " ");
            }

        }

        public static void DFS_Util(int to_visit, bool[] visited, List<int>[] graph, Stack<int> node_order)
        {
            //mark the node visite
            visited[to_visit] = true;
           

            //get all connecting nodes..
            List<int> connection = graph[to_visit];

            foreach (int v in connection)
            {
                if (!visited[v])
                {
                    DFS_Util(v, visited, graph, node_order);
                }
            }

            //once the all connected node visited , then only add the current node to stack
            node_order.Push(to_visit);
        }
    }
}
