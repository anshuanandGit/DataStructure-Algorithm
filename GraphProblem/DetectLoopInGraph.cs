using System;
using System.Collections.Generic;
using System.Text;

namespace GraphProblem
{
    class DetectLoopInGraph
    {
        public static void Start()
        {
            List<int>[] graph = new List<int>[4];
            graph[0] = new List<int> { 1, 2 };
            graph[1] = new List<int> { 2 };
            graph[2] = new List<int> { 0, 3 };
            graph[3] = new List<int> { 3 };


            if (FindCycle(graph)){
                Console.WriteLine("Cycle found in the graph");
            }
            else
            {
                Console.WriteLine("Cycle not found in the graph" );
            }
           
        }

        public static bool FindCycle(List<int>[] graph)
        {
            int num_nodes = graph.Length;

            bool[] visited = new bool[num_nodes];
            bool[] nodecall_stack = new bool[num_nodes];  // To track all the back edges visited

            Array.Fill(visited, false); //all unvisited will have -1 value.

            //start with node 2
            for (int i = 0; i < num_nodes; i++)
            {
                if (IsCyclic(i, visited, nodecall_stack, graph))
                {
                    return true;
                }                
            }

            return false;

        }

        public static bool IsCyclic(int to_visit, bool[] visited, bool[] nodecall_stack , List<int>[] graph)
        {
            if (nodecall_stack[to_visit])
            {                
                return true;// stack all ready contains to be visited node ...means cycle is there
            }

            if (visited[to_visit])
            {
                return false;
            }
            
            visited[to_visit] = true; //mark the node visited
            nodecall_stack[to_visit] = true; //mark the node visited

            //get all connecting nodes..
            List<int> connection = graph[to_visit];

            foreach (int v in connection)
            {
                if (IsCyclic(v, visited, nodecall_stack, graph))
                {
                    return true;
                }
            }
            nodecall_stack[to_visit] = false;

            return false;

        }


    }
}
