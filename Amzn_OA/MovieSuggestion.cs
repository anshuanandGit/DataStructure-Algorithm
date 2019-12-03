using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class MovieSuggestion
    {
        public static int[] GetMovieForFlight(int[] movielist, int d, int m)
        {
            Console.WriteLine("Given Movie List " + String.Join(",", movielist));

            int[] op = new int[2];           
            Hashtable indexer = new Hashtable(); //store all teh indices for given movies
            for (int i=0; i <movielist.Length; i++){
                indexer.Add(movielist[i], i);
            }
         
            int target = d - m;
            int start = 0;
            int end = movielist.Length - 1;
            int max = 0;

            //sort array for handling..
            Array.Sort(movielist);
            int firstMoviLength = 0;
            int SecondMoviLength = 0;

            while(start <= end)
            {
                
                int sum = movielist[start] + movielist[end];

                if (sum == target) //no need to iterate more ...since array is sorted , first equal pair is solution..
                {
                    firstMoviLength = movielist[start];
                    SecondMoviLength = movielist[end];
                    break;
                }
                if(sum < target)
                {
                    if(sum == max) //means duplicate // //adding extra check , if two pair have same length.....to handle that
                    {
                        int maxOfPrevSet = Math.Max(firstMoviLength, SecondMoviLength);
                        int maxOfNewSet = Math.Max(movielist[start], movielist[end]);

                        if(maxOfNewSet > maxOfPrevSet) // need to replace list with new movie , since new pair contains one movie with highest length
                        {
                            firstMoviLength = movielist[start];
                            SecondMoviLength = movielist[end]; ;
                        }                       
                    }
                    else if(sum > max)
                    {
                        max = sum;
                        firstMoviLength = movielist[start];
                        SecondMoviLength = movielist[end];
                    }
                    start++; //move right...
                }
                else
                {
                    end--; // sum is big move the end pointer leftward 
                }
            }

            Console.WriteLine("Valid movie duration " + max);
            Console.WriteLine("Firstmovie " + firstMoviLength);
            Console.WriteLine("SecondMovie " + SecondMoviLength);            
            //get the original index of movie ..
            op[0] = (int)indexer[firstMoviLength];
            op[1] = (int)indexer[SecondMoviLength];
           

            return op;

        }
    }
}
