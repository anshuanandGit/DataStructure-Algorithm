using System;
using System.Collections.Generic;
using System.Text;

namespace StackProblem
{
   
    class StackToGetMin
    {
        Stack<int> st = new Stack<int>();
        int minElem = 0;

        public int GetMin()
        {
            if (st.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            Console.WriteLine("min elem is " + minElem);
            return minElem;
        }

        public void Push(int d)
        {
            if(st.Count == 0)
            {
                st.Push(d);
                Console.WriteLine("Pushed in Stack "+ d);
                minElem = d;
                return;
            }

            if(d < minElem)
            {              
                st.Push(2 * d - minElem);
                Console.WriteLine("Pushed in Stack " + d);
                minElem = d;                
            }
            else
            {
                st.Push(d);
                Console.WriteLine("Pushed in Stack " + d);
            }
        }

        public int Pop()
        {
            int rs = 0;
            if (st.Count == 0)
            {
                Console.WriteLine("Stack Underflow");
                return -1777;
            }

            int x = st.Pop();
            if (x < minElem)
            {
                rs = minElem;        
                minElem = 2 * minElem - x;            
            }
            else
            {              
                rs = x;
            }

            Console.WriteLine("popped " + rs);
            return rs;
        }
    }
}
