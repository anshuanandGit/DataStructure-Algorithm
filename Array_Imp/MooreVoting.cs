using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Imp
{
    class MooreVoting
    {
        static void PrintMajority(int[] a, int size)
        {           
            int cand = FindCandidate(a, size);          
            if (IsMajority(a, size, cand))
            {
                Console.Write(" " + cand + " ");
            }
            else
            {
                Console.Write("No Majority Element found");
            }
                
        }

        /* Function to find the candidate for Majority */
        static int FindCandidate(int[] a, int size)
        {
            int maj_index = 0, count = 1;
            int i;
            for (i = 1; i < size; i++)
            {
                if (a[maj_index] == a[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }                 

                if (count == 0)
                {
                    maj_index = i;
                    count = 1;
                }
            }
            return a[maj_index];
        }

        static bool IsMajority(int[] a, int size, int cand)
        {
            int i, count = 0;
            for (i = 0; i < size; i++)
            {
                if (a[i] == cand)
                {
                    count++;
                }              
            }
            if (count > size / 2)
            {
                return true;
            }
            else
            {
                return false;
            }              
        }

        // Driver Code 
        public static void Start()
        {
            int[] a = { 1, 3, 3, 1, 2 };
            int size = a.Length;
            PrintMajority(a, size);
        }
    }
}
