using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class ResourceUtilization
    {
        public static void Start()
        {
     
            int[][] a = new int[4][];
            a[0] =new int[]{1,3  };
            a[1] = new int[] { 2,5};
            a[2] = new int[] {3,7 };
            a[3] = new int[] {4,10 };

            int[][] b = new int[4][];
            b[0] = new int[] {1,2 };
            b[1] = new int[] {2,3 };
            b[2] = new int[] {3,4 };
            b[3] = new int[] {4,5 };

            int target = 10;
            IList<IList<int>> res = GetUtilization(target, a, b);
            Console.WriteLine("done");
            
        }

        public static IList<IList<int>> GetUtilization(int target, int[][] forwardRouteList, int[][] returnRouteList)
        {
            List<IList<int>> res = new List<IList<int>>();

            int len1 = forwardRouteList.Length, 
                len2 = returnRouteList.Length;

            if (len1 == 0 || len2 == 0) {
                return res;
            }

            Array.Sort(forwardRouteList, (int[] a, int[] b)=> (a[1] - b[1]));
            Array.Sort(returnRouteList, (int[] a, int[] b)=> (a[1] - b[1]));

            int left = 0, 
                right = len2 - 1, 
                maxVal = -1;

            Dictionary<int, List<IList<int>>> map = new Dictionary<int, List<IList<int>>>();

            while (left < len1 && right >= 0)
            {
                int sum = forwardRouteList[left][1] + returnRouteList[right][1];

                if (sum > target){
                    --right;
                    continue;
                }
                else if(sum <= target)
                {
                    if (sum >= maxVal)
                    {
                        maxVal = sum;

                        // add an entry for this sum in map
                        if (!map.ContainsKey(maxVal))
                        {
                            map.Add(maxVal, new List<IList<int>>());
                        }

                        int r = right;
                        //optimize the solution...reduce the right counter if found duplicate
                        while(r >=0 && returnRouteList[r][1] == returnRouteList[right][1])
                        {
                            List<int> a = new List<int>();

                            a.Add(forwardRouteList[left][0]);
                            a.Add(returnRouteList[r][0]);

                            map[maxVal].Add(a); //add the list to map

                            r--; //move right counter
                        }

                        ++left;
                    }
                }
                
              
            }
            //return all the list with optimum max value
            return map[maxVal];
        }
    }
}
