using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    class GCD
    {
        public int getGCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }                   
            }

            if (a == 0)
            {
                return b;
            }
            else
            {
                return a;
            }
                
        }

        public int GCDRecursive(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if (a > b)
            {
                return GCDRecursive(a % b, b);
            }
            else
            {
                return GCDRecursive(a, b % a);
            }
                
        }
    }
}
