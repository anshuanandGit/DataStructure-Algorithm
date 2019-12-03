using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    class MergeSort
    {
        public static void Start()
        {
            int[] data = { 6, 23, 21, 54, 42, 39, 11, 2 };
            Console.WriteLine("Merge Sort ..Array before sorting: " + String.Join(" ", data));
            int size = data.Length;

            Sort(data, 0, size-1);
            Console.WriteLine("Sorted Array in Ascending Order: " + String.Join(" ", data));
        }

        public static void Sort(int[] a, int l, int h)
        {
            if(l < h)
            {
                int mid = (l + h) / 2;

                Sort(a, l, mid);
                Sort(a, mid+1, h);
                Merge(a, l,mid, h);

            }
        }

        public static void Merge(int[] arr , int l,int m, int h)
        {
            int n1 = m - l + 1;
            int n2 = h - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for(int c=0; c < n1; c++)
            {
                L[c] = arr[l + c];
            }
            for (int d = 0; d < n2; d++)
            {
                R[d] = arr[m + 1+ d];
            }

            
            /* Merge the temp arrays */

            // Initial indexes of first and second subarrays 
            int i = 0, j = 0;

            // Initial index of merged subarry array 
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
