using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Imp
{
    class CheckPalindromeNumber
    {
        public static void Start()
        {
            int x = 1221;
            if (IsPalindrome(x))
            {
                Console.WriteLine(x + " is palindrome");
            }
            else
            {
                Console.WriteLine(x + " is not palindrome");
            }
        }

        private static bool IsPalindrome(int n)
        {
            int divisor = 1;
            //get the correct divisor 
            //to extract first and last digit
            //We will do divison and mod with divisor to check first and last digit matches..
            while(n/divisor >= 10)
            {
                divisor *= 10;
            }

            //if n = 20002 , divisor = 10000

            while (n != 0)
            {
                int lead = n / divisor;
                int tail = n % 10;

                if(lead != tail)
                {
                    return false;
                }

                //remove lead and tail to check ..after first iteration 20002 will be 000
                // Removing the leading and  
                // trailing digit from number 
                n = (n % divisor) / 10;

                // Reducing divisor by  
                // a factor of 2 as 2  
                // digits are dropped 
                divisor = divisor / 100;
            }

            return true;
        }
    }

}
