using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    class Factorial
    {
        //Recursive approach....
        public int Getfactorial_Rec(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Getfactorial(n - 1);
        }

        // Method to find factorial 
        // of given number 
        static int Getfactorial(int n)
        {
            if (n == 0|| n==1)
            {
                return 1;
            }

            int res = 1, i;
            for (i = 2; i <= n; i++)
            {
                res *= i;
            }
          
            return res;
        }
    }
}
