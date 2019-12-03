using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Imp
{
    class RotateArray
    {
        // Driver code 
        public static void Start()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("before roatation");
            Console.WriteLine(String.Join(",", arr));
            LeftRotate1(arr, 2, 7);
            Console.WriteLine("after roatation");
            Console.WriteLine(String.Join(",", arr));      
        }

        //Time - O(n) .. Space O(d)
        private static void LeftRotate1(int[] ar, int d, int n)
        {
            //craete a temp array...
            int[] temp = new int[d];

            for(int i = 0; i < d; i++)
            {
                temp[i] = ar[i];
            }

            for (int i = 0; i < n-d; i++)
            {
                ar[i] = ar[i+d];
            }

            for (int i = 0; i < d; i++)
            {
                ar[n-d +i] = temp[i];
            }
        }

        private static int GCD(int a ,int b)
        {
            while(a!=0 && b != 0)
            {
                if(a > b)
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

        //Time O(n)...Space O(1)...Juggler method uses GCD
        static void LeftRotate(int[] arr, int d, int n)
        {
            int i, j, k, temp;
            int g_c_d = GCD(d, n);

            for (i = 0; i < g_c_d; i++)
            {
                /* move i-th values of blocks */
                temp = arr[i];
                j = i;
                while (true)
                {
                    k = j + d;
                    if (k >= n)
                    {
                        k = k - n;
                    }                     
                    if (k == i)
                    {
                        break;
                    }                    
                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }
        }
    }
}
