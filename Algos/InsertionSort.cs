using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    class InsertionSort
    {
        public static void Start()
        {
            int[] data = { 6, 23, 21, 54, 42, 39, 11, 2 };
            Console.WriteLine("Insertion Sort ..Array before sorting: " + String.Join(",", data));
            int size = data.Length;

            Sort(data);
            Console.WriteLine("Sorted Array in Ascending Order: " + String.Join(",", data));
        }

        public static void Sort(int[] ar)
        {
            int len = ar.Length;
          
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < i; j++)
                {                   
                    if (ar[j] > ar[i])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;                      
                    }
                }

            }

        }
    }
}
