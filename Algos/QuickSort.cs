using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    class QuickSort
    {
        public static void Start()
        {
            int[] data = { 6, 23, 21, 54, 42, 39, 11, 2 };
            Console.WriteLine("QUICK Sort ..Array before sorting: " + String.Join(" ", data));
            int size = data.Length;

            Sort(data, 0, size - 1);
            Console.WriteLine("Sorted Array in Ascending Order: " + String.Join(" ", data));
        }

        public static void Sort(int[] a, int l, int h)
        {
            if (l < h)
            {
                /* pi is partitioning index, arr[pi] is  
               now at right place */
                int pi = Partition(a, l, h);

                // Recursively sort elements before 
                // partition and after partition 
                Sort(a, l, pi - 1);
                Sort(a, pi + 1, h);

            }
        }

        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j] < pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
}
