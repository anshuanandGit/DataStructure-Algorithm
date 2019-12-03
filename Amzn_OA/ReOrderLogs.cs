using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class ReOrderLogs
    {
            public string[] ReorderLogFiles(string[] logs)
            {

                List<string> letter = new List<string>();
                List<string> digit = new List<string>();

                //seperate both the logs ..type
                foreach (string ss in logs)
                {
                    string[] x = ss.Split(" ", 2);
                    if (Char.IsDigit(x[1][0]))
                    {
                        digit.Add(ss);
                    }
                    else
                    {
                        letter.Add(ss);
                    }
                }

                //custom sort for Letter array
                letter.Sort((log1, log2) => {

                    String[] split1 = log1.Split(" ", 2);
                    String[] split2 = log2.Split(" ", 2);

                    int cmp = split1[1].CompareTo(split2[1]);

                    if (cmp != 0) //compare letter
                    {
                        return cmp;
                    }
                    else  // if both are same compare by identifier
                    {
                        return split1[0].CompareTo(split2[0]);
                    }
                });
                
               //merge digit array in sorted letetr array
                letter.AddRange(digit);
                return letter.ToArray();
            }
        }

   
}
