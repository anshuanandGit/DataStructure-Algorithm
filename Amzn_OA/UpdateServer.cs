using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class UpdateServer
    {
        public static void Start()
        {

            int[,] testcase = new int[4, 5] {
                                             { 0,1,1,0,1},
                                             { 0,1,0,1,0},
                                             { 0,0,0,0,1},
                                             { 0,1,0,0,0}
                                             };


            int x = UpdateServerMethod(testcase);
            Console.WriteLine(x);
        }


        public static int UpdateServerMethod(int[,] servers)
        {
            if (servers == null || servers.Length == 0)
            {
                return -1;
            }

            int days = 0;
            int R = servers.GetLength(0);
            int C = servers.GetLength(1);
            int UpdatesDone = 0;
            int NoOfServers = R * C;

            int[,] movements = { { 0, -1 }, { 0, 1 }, { -1, 0 }, { 1, 0 } };

            Queue<Coordinate1> places = new Queue<Coordinate1>();

            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (servers[i,j] == 1)
                    {
                        UpdatesDone += 1;//server is already having file
                        places.Enqueue(new Coordinate1(i, j));
                    }
                }
            }
            while (places.Count !=0)
            {
                if (UpdatesDone == NoOfServers) //check if all server updated
                {
                    return days;
                }

                int ServerReadyToUpdate = places.Count; //run updated with Active server

                for (int i = 0; i < ServerReadyToUpdate; i++)
                {
                    Coordinate1 p = places.Dequeue();
                    int currentX = p.x;
                    int currentY = p.y;

                    //servers[currentX, currentY] = 1;
                    for (int k=0; k<movements.GetLength(0);k++)
                    {
                        int newX = currentX + movements[k,0];
                        int newY = currentY + movements[k,1];
                        Coordinate1 t = new Coordinate1(newX, newY);

                        if (t.IsPositionSafe(R,C) && servers[newX,newY] == 0)
                        {
                            places.Enqueue(t);
                            servers[newX,newY] = 1;
                            //increase cound for updated servers
                            UpdatesDone++;
                        }
                    }
                }
                days++;
            }

            return -1;
        }
    }

    class Coordinate1
    {
        public int x;
        public int y;

        public Coordinate1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool IsPositionSafe(int x, int y)
        {
            return (this.x >= 0 && this.x < x && this.y >= 0 && this.y < y);
        }
    }
}
