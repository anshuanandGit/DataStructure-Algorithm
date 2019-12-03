using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    class Fibbonacci
    {
        //Non recurcive method ..runs in O(n) time and O(1) space ....
        static int Fib(int n)
        {
            // To return the first Fibonacci number  
            if (n == 0) {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            int a = 0, b = 1, c = 0;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return b;
        }
    }
}
