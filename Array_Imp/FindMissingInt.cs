using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Imp
{
    class FindMissingInt
    {
        /* program to test above function */
        public static void Start()
        {
            int[] a = { 1, 2, 4, 5, 6 };
            Console.WriteLine(String.Join(",",a));

            int nm = getMissingNo(a, 5);
            Console.WriteLine(nm);
        }

        // Function to ind missing number 
        // Time O(n)...Space O(1)
        // This method will create integer overflow for large numbers....
        static int getMissingNo(int[] a, int n)
        {

            int total = (n + 1) * (n + 2) / 2;

            for (int i = 0; i < n; i++)
            {
                total -= a[i];
            }
            return total;
        }

        /**
         *   1) XOR all the array elements, let the result of XOR be X1.
             2) XOR all numbers from 1 to n, let XOR be X2.
             3) XOR of X1 and X2 gives the missing number.
         * */
        // Function to find missing number 
        static int getMissingNoXor(int[] a, int n)
        {
            int x1 = a[0];
            /* For xor of all the elements  
            in array */
            for (int i = 1; i < n; i++)
            {
                x1 = x1 ^ a[i];
            }

            /* For xor of all the elements  
            from 1 to n+1 */
            int x2 = 1;
            for (int i = 2; i <= n + 1; i++)
            {
                x2 = x2 ^ i;
            }
               

            return (x1 ^ x2);
        }

    }
}
