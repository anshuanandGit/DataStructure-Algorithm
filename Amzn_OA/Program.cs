using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Amzn_OA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Program!");

            /**
            int[] x = new int[] { 10, 20, 40,50,75,30 };
            int[] op = MovieSuggestion.GetMovieForFlight(x, 90, 30);
            Console.WriteLine("desired index "+op[0]+"   "+op[1]);
            int[] expected = new int[] { 0, 3 };          
            **/

            //TressureIsland2 t = new TressureIsland2();
            //t.Start();
            //UpdateServer.Start();
            //Console.WriteLine(x);
           // NoOfClusterInGraph.Start();


            Hashtable a = new Hashtable();
            string s = "";

            /*
            var items = new Dictionary<int, int>();
            items.Add(-1, 0);
            items.Add(0, 1);
            items.Add(-2, 0);
            items.Add(3, 1);

            // Use OrderBy method.
            foreach (var item in items.OrderBy(i => i.Value ))
            {
                Console.WriteLine(item);
            }

            var yu = from pair in items
                     orderby pair.Value descending
                     select pair;

            */

           // CriticalRouter.Start();
            //CriticalRouter_New.Start();
            //CriticalConnection.Start();
           // KLengthSubstringInString.Start();
            SubArrayWith_K_different_Integers.Start();
            SubstringWith_K_Distinct_char.Start();
            Console.ReadKey();


        }

        


    }
}
