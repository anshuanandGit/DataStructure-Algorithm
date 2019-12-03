using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class RotateADice
    {
        public static int GetMinmRotation(int[] dice)
        {
            int Mincount = int.MaxValue;
            int len = dice.Length;

            int d = 1;
            while(d < 7)
            {
                int currCount = 0;
                foreach(int x in dice)
                {
                    if(x + d ==7)//means oppisite side ...
                    {
                        currCount += 2; //rotate twice to get d
                    }
                    else if (x == d)
                    {
                        continue; //no need to rotate
                    }
                    else
                    {
                        currCount += 1;
                    }
                }
                Mincount = Math.Min(currCount, Mincount);

                d++;
            }


            return Mincount;
        }
    }
}
