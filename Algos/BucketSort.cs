using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    class BucketSort
    {
        public static void Start()
        {
            double[] data = { 0.897, 0.565, 0.656, 0.1234, 0.665, 0.3434 };
            Console.WriteLine("Array before sorting: " + String.Join("", data));
            int size = data.Length;

            List<double>  xx= BuckSort(data, size);
            Console.WriteLine("Sorted Array in Ascending Order: " + String.Join("",xx) );
        }

        public static List<double> BuckSort(double[] array, int size)
        {
            List<double>[] bucket = new List<double>[size];
            List<double> sortedlist = new List<double>();

            //initialize bucket
            for(int i=0;i<size; i++)
            {
                bucket[i] = new List<double>();
            }

            //insert in bucket
            for (int i = 0; i < size; i++)
            {
                int indx= (int)Math.Round(array[i] * size);
                bucket[indx].Add(array[i]);
            }

            for (int i = 0; i < size; i++)
            {
                if(bucket[i].Count > 0)
                {
                    bucket[i].Sort();
                    for(int j=0; j < bucket[i].Count; j++)
                    {
                        sortedlist.Add(bucket[i][j]);
                    }
                }
            }

            return sortedlist;
        }
       
    }
}
