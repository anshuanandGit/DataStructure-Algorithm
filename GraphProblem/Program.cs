using System;

namespace GraphProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Graph Test!");
            GraphDFS.Start();
            GraphBFS.Start();
            DetectLoopInGraph.Start();
            TopologicalSort.Start();
            Console.ReadKey();
        }
    }
}
