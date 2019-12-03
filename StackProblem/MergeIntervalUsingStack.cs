using System;
using System.Collections.Generic;
using System.Text;

namespace StackProblem
{
    class MergeIntervalUsingStack
    {
        public static void Start()
        {
            List<List<int>> interval = new List<List<int>>();
            interval.Add(new List<int> { 6, 8});
            interval.Add(new List<int> { 1, 9 });
            interval.Add(new List<int> { 2, 4 });
            interval.Add(new List<int> { 4, 7 });           

            foreach(List<int>  xx in interval)
            {
                Console.WriteLine(String.Join(",", xx));
            }

            List<List<int>> res = MergeInterval(interval);

            foreach (List<int> xx in res)
            {
                Console.WriteLine(String.Join(",", xx));
            }           
            
        }

        public static List<List<int>> MergeInterval(List<List<int>> interval)
        {
            List<List<int>> op = new List<List<int>>();

            //sort the intervals first..
            interval.Sort((a, b) => a[0] - b[0]);

            Stack<List<int>> stInterval = new Stack<List<int>>();
            
            //push first interval
            stInterval.Push(interval[0]);

            //iterate over array and check for overlap
            for(int i=1;i < interval.Count; i++)
            {
                List<int> curr = interval[i];
                List<int> stacktop = stInterval.Peek();

                if(stacktop[1] <curr[0]) //compare end of stack top to start of curr interval
                {
                    stInterval.Push(curr);
                }
                else if(stacktop[1] < curr[1])//compare end of stack top to end of curr interval
                {
                    //overlap scenario
                    stacktop[1] = curr[1];
                    stInterval.Pop();   //remove last interval and insert updated one
                    stInterval.Push(stacktop);

                }
            }

            for(int i=0;i< stInterval.Count; i++)
            {
                op.Add(new List<int>(stInterval.Pop()));
            }

            return op;
            
        }
    }
}
