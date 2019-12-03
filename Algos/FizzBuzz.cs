using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    class FizzBuzz
    {
        public static void Start()
        {
            for (int i = 1; i <= 100; i++)
            {

                string res = (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" : (i % 5 == 0) ? "Buzz" :
                             (i % 3 == 0) ? "Fizz" : i.ToString();
                Console.WriteLine(res);
              
            }
        }
    }
}
