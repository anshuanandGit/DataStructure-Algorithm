using System;
using System.Collections.Generic;
using System.Text;

namespace StackProblem
{
    class TowerOfHanoi_Recusive
    {

        // Driver method 
        public static void Start()
        {
            // Number of disks 
            int n = 3;

            // A, B and C are names of rods 
            TowerOfHanoi(n, 'A', 'C', 'B');
        }

        // C# recursive function to solve  
        // tower of hanoi puzzle 
        static void TowerOfHanoi(int n, char from_rod,
                                 char to_rod, char aux_rod)
        {
            if (n == 1)
            {
                Console.WriteLine("Move disk 1 from rod " + from_rod + " to rod " + to_rod);
                return;
            }

            TowerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
            Console.WriteLine("Move disk " + n + " from rod " + from_rod + " to rod " + to_rod);
            TowerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
        }

    }
}
