using System;
using System.Collections.Generic;
using System.Text;

namespace StackProblem
{
    class StockSpanUsingStack
    {
        // Driver method 
        public static void Start()
        {
            int[] price = { 10, 4, 5, 90, 120, 80 };
            Console.WriteLine("Stock Price on each day");
            Console.WriteLine(String.Join(",", price));
            int n = price.Length;
            int[] S = new int[n];

            // Fill the span values in array S[] 
            CalculateSpan(price, n, S);
            // print the calculated span values 
            Console.WriteLine("Stock Span on each day");
            Console.WriteLine(String.Join(",", S));
           
        }
     
        static void CalculateSpan(int[] price, int n, int[] S)
        {
            // Create a stack and Push index of first element to it      
            Stack<int> st = new Stack<int>();
            st.Push(0);

            // Span value of first  element is always 1
            S[0] = 1;

            // Calculate span values for rest of the elements  
            for (int i = 1; i < n; i++)
            {

                // Pop elements from stack while stack is not empty and top of stack is smaller than price[i] 
                while (st.Count > 0 && price[(int)st.Peek()] <= price[i])
                {
                    st.Pop();
                }

                // If stack becomes empty, then price[i] is greater than all elements on left of it               
                S[i] = (st.Count == 0) ? (i + 1) : (i - st.Peek());

                // Push this element to stack 
                st.Push(i);
            }
        }
        
    }
}
