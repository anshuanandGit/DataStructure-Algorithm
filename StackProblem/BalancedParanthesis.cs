using System;
using System.Collections.Generic;
using System.Text;

namespace StackProblem
{
    class BalancedParanthesis
    {
        public static void Start()
        {
            char[] exp = { '{', '(', ')', '}', '[', ']' };

            if (AreParenthesisBalanced(exp))
            {
                Console.WriteLine("Balanced ");
            }               
            else{
                Console.WriteLine("Not Balanced ");
            }
                
        }

        private static bool AreParenthesisBalanced(char[] exp)
        {
            Stack<char> st = new Stack<char>();

            for(int i=0;i<exp.Length; i ++)
            {
                char x = exp[i];

                if (x== '('|| x == '{'|| x == '[')
                {
                    st.Push(x);
                }
                else if (x == ')' || x == '}' || x == ']')
                {
                    //check if stack empty ..means no matching pair
                    if (st.Count == 0)
                    {
                        return false;
                    }
                    else if (!IsMatchingPair( st.Pop() ,x)){
                        return false; //if pair is there match them
                    }
                }
            }

            if (st.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static Boolean IsMatchingPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
            {
                return true;
            }            
            else if (character1 == '{' && character2 == '}')
            {
                return true;
            }
            else if (character1 == '[' && character2 == ']')
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }
    }
}
