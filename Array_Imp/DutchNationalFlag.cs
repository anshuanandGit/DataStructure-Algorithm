using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Imp
{
    class DutchNationalFlag
    {
        /*Driver function to check for above functions*/
        public static void Start()
        {
            int[] arr = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            Console.WriteLine("Array before seggregation ");
            Console.WriteLine(String.Join(",",arr));
            int arr_size = arr.Length;

            Sort012(arr, arr_size);

            Console.WriteLine("Array after seggregation ");
            Console.WriteLine(String.Join(",", arr));
            Console.ReadKey();
            
        }

        private static void Sort012(int[] a, int len)
        {
            int low = 0;
            int mid = 0;
            int high = len - 1;
            int temp = 0;

            while (mid <= high)
            {
                switch (a[mid])
                {
                    case 0:
                        temp = a[mid];
                        a[mid] = a[low];
                        a[low] = temp;
                        low++;
                        mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        temp = a[mid];
                        a[mid] = a[high];
                        a[high] = temp;
                        high--;
                      
                        break;
                }
            }
        }
    }
}
