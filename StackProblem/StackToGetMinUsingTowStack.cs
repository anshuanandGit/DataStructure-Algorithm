using System;
using System.Collections.Generic;
using System.Text;

namespace StackProblem
{
    class StackToGetMinUsingTowStack
    {
        Stack<int> mainstack = new Stack<int>();
        Stack<int> auxstack = new Stack<int>();  //this stack will keep min element wrt to each insert.

        public void Push(int x)
        {
            mainstack.Push(x);
            Console.WriteLine("Pushed to Stack " + x);

            if (auxstack.Count > 0)
            {
                int y = auxstack.Peek();
                if (x < y)
                {
                    auxstack.Push(x);                    
                }
                else
                {
                    auxstack.Push(y);
                }
            }
            else
            {
                auxstack.Push(x);
            }
        }

        public int Pop()
        {
            if (mainstack.Count == 0)
            {
                Console.WriteLine("Underflow");
                return -1;
            }

            int x = mainstack.Pop();
            auxstack.Pop();//pop from aus stack also
            Console.WriteLine("Popped from Stack " + x);
            return x;
        }

        public int GetMin()
        {
            if (auxstack.Count == 0)
            {
                Console.WriteLine("Underflow");
                return -1;
            }
            int x = auxstack.Peek();
            Console.WriteLine("min elem " + x);
            return x;
        }
    }
}
