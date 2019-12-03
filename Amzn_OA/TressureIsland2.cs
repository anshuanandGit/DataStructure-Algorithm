using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    //Multi Source and Destination problem..
    //Here account for Multiple sources..........
    class TressureIsland2
    {
        public void Start()
        {

            char[,] testcase = new char[5, 5] {
                                             { 'S', 'O', 'O', 'S', 'S' },
                                             { 'D', 'O', 'D', 'O', 'D' },
                                             { 'O', 'O', 'O', 'O', 'X' },
                                             { 'X', 'D', 'D', 'O', 'O' },
                                             { 'X', 'D', 'D', 'D', 'O' }
                                             };


            int x = TreasureIsland(testcase);
            Console.WriteLine(x);
        }


        public int TreasureIsland(char[,] island)
        {
            if (island == null || island.Length == 0)
            {
                return 0;
            }

            int steps = 0;
            int R = island.GetLength(0);
            int C = island.GetLength(1);
            Queue<Coordinate> queue = new Queue<Coordinate>();

            // add all sources to queue and set 'visited'.
            for (int i = 0; i < R; ++i)
            {
                for (int j = 0; j < C; ++j)
                {
                    if (island[i,j] == 'S')
                    {
                        queue.Enqueue(new Coordinate(i,j));
                    }
                }
            }
            queue.Enqueue(new Coordinate(0, 0));

            bool[,] visited = new bool[R, C];

            visited[0, 0] = true;
            int[,] dirs = { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };

            // bfs
            while (queue.Count != 0)
            {

                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    Coordinate coordinate = queue.Dequeue();
                    int x = coordinate.x;
                    int y = coordinate.y;

                    if (island[x, y] == 'X')
                    {
                        return steps;
                    }

                    for (int k = 0; k < dirs.GetLength(0); k++)
                    {

                        int newX = x + dirs[k, 0];
                        int newY = y + dirs[k, 1];

                        if (newX >= 0 && newX < R &&
                            newY >= 0 && newY < C &&
                            island[newX, newY] != 'D'
                            && !visited[newX, newY])
                        {
                            queue.Enqueue(new Coordinate(newX, newY));
                            visited[newX, newY] = true;
                        }
                    }
                }


                steps++;
            }

            return 0;
        }
    }

   
}
