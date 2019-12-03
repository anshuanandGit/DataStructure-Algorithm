using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class KLengthSubstringInString
    {
        public static void Start()
        {

            string s = "awaglknagawunagwkwagl";
            int k = 4;
            List<String> op = getSubstrings(s, k);
            foreach(string sss in op)
            {
                Console.WriteLine(sss);
            }
            
        }
        public static  List<String> getSubstrings(string s, int k)
        {
            HashSet<String> set = new HashSet<String>();
            for (int i = 0; i < s.Length - k + 1; i++)
            {
                String st = "";
                for (int j = i; j < i + k; j++)
                {
                    if (st.IndexOf(s[j]) != -1) //check if char is part of string.....if yes break
                    {
                        break;
                    }
                    else
                    {
                        st = st + s[j];
                    }
                }
                if (st.Length== k)
                {
                    set.Add(st);
                }
            }
            return new List<string>(set);

        }
    }
}
