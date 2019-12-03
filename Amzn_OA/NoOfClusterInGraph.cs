using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    /**
     * A graph where all vertices are connected with each other has exactly one connected component, 
     * consisting of the whole graph. Such a graph with only one connected component is called a Strongly Connected Graph.
       The problem can be easily solved by applying DFS() on each component. In each DFS() call, a component or a sub-graph 
       is visited. We will call DFS on the next un-visited component. The number of calls to DFS() gives the number of 
       connected components. BFS can also be used.
     * 
     * Cluster = No of connected Island...
     * **/

    class NoOfClusterInGraph
    {

        // Driver Code 
        public static void Start()
        {
            int[,] M = new int[,] { { 1, 1, 0, 0, 0 },
                                    { 0, 1, 0, 0, 1 },
                                    { 1, 0, 0, 1, 1 },
                                    { 0, 0, 0, 0, 0 },
                                    { 1, 0, 1, 0, 1 } };
            int m = CountIslands(M);
            Console.Write("Number of islands is: " + m);
        }

        public static int CountIslands(int[,] M)
        {
            int R = M.GetLength(0);
            int C = M.GetLength(0);
            
            bool[,] visited = new bool[R, C]; // Make a bool array to .mark visited cells.Initially all cells are unvisited        
            int count = 0; // Initialize count as 0 and travese through the all cells of given matrix

            for (int i = 0; i < R; ++i)
                for (int j = 0; j < C; ++j)
                {
                    if (M[i, j] == 1 && !visited[i, j])
                    {
                        // If a cell with value 1 is not visited yet, then new island found, Visit all cells in this island and increment island count 
                        DFS(M, i, j, visited, R, C);
                        ++count;
                    }
                }                    

            return count;
        }

        // A function to check if a given cell (row, col) an be included in DFS 
        static bool IsValidMove(int[,] M, int row,int col, bool[,] visited,int R,int C)
        {
            // row number is in range, column number is in range and value is 1 and not yet visited 
            return (row >= 0) && (row < R) && 
                   (col >= 0) && (col < C) && 
                   (M[row, col] == 1 && 
                   !visited[row, col]);
        }

        // A utility function to do  DFS for a 2D boolean matrix. It only considers the 8  neighbors as adjacent vertices 
        static void DFS(int[,] M, int row,int col, bool[,] visited, int R, int C)
        {
           
            int[,] moves_4 = { { 0, -1 }, { 0, 1 }, { -1, 0 }, { 1, 0 } }; //Use this for up, down, right , left movement. A cell will have only 4 Move

            visited[row, col] = true; // Mark this cell as visited 

            // Recur for all  connected neighbours 
            for (int k = 0; k < moves_4.GetLength(0); ++k)
            {
                if (IsValidMove(M, row + moves_4[k,0], col + moves_4[k,1], visited, R, C))
                {
                    DFS(M, row + moves_4[k, 0], col + moves_4[k, 1], visited, R, C);
                }
            }        
                  
        }


    }
}
