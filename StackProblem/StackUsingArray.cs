using System;
using System.Collections.Generic;
using System.Text;

namespace StackProblem
{
    class StackUsingArray
    {
        int[] lis;
        int top;
        int max;

        public StackUsingArray(int size)
        {
            lis = new int[size];
            top = -1;
            max = top;
        }

         public void Push(int a)
        {
            if(top == max - 1)
            {
                Console.WriteLine("Stack Overflow...");
                return;
            }
            top += 1; //increment the top
            lis[top] = a;

        }

        public int Peek()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack Empty...");
                return -1;
            }
            int res = lis[top];
            return res;
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Empty...");
                return -1;
            }
            int res = lis[top];
            top--;
            return res;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void PrintStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("{0} pushed into stack", lis[i]);
                }
            }
        }
    }
}
