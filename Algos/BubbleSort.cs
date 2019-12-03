using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    class BubbleSort
    {
        public static void Start()
        {
            int[] data = { 6, 23, 21, 54, 42, 39, 11, 2 };
            Console.WriteLine("Array before sorting: " + String.Join(",", data));
            int size = data.Length;

           Sort(data);
            Console.WriteLine("Sorted Array in Ascending Order: " + String.Join(",", data));
        }

        public static void Sort(int[] ar){
            int len = ar.Length;

            bool sorted = false;
            for(int i=0; i < len -1; i++){

                for (int j = 0; j < len-i-1; j++)
                {
                    sorted = false;
                    if (ar[j] > ar[j+1])
                    {
                        int temp = ar[j+1];
                        ar[j+1] = ar[j];
                        ar[j] = temp;
                        sorted = true;
                    }
                }

                if (sorted == false)
                {
                    break;
                }
            }

       }
    }
}
