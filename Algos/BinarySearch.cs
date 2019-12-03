using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    class BinarySearch
    {
        // Driver method to test above 
        public static void Start()
        {

            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;

            int result = Binary_Search(arr, 0, n - 1, x);

            if (result == -1)
            {
                Console.WriteLine("Element not present");
            }
            else
            {
                Console.WriteLine("Element found at index "
                                 + result);
            }

        }

       public static int Binary_Search(int[] arr, int l,int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
                               
                if (arr[mid] == x)
                {
                    // If the element is present at the 
                    // middle itself 
                    return mid;
                }
                
                if (arr[mid] > x)
                {
                    // If element is smaller than mid, then 
                    // it can only be present in left subarray 
                    return Binary_Search(arr, l, mid - 1, x);
                }
                else
                {
                    // Else the element can only be present 
                    // in right subarray 
                    return Binary_Search(arr, mid + 1, r, x);
                }           
            }

            // We reach here when element is not present 
            // in array 
            return -1;
        }

       
    }
}
