using System;
using System.Collections.Generic;
using System.Text;

namespace StackProblem
{
    class TwoStackArray
    {
        int[] arr;
        int top1;
        int top2;
        int capacity = 0;

        public TwoStackArray(int size)
        {
            capacity = size;
            top1 = -1;
            top2 = size;
            arr = new int[size];
        }

        public void Push1(int x)
        {
            if(top1 < top2 - 1)
            {
                top1++;
                arr[top1] = x;
                Console.WriteLine("Stack1: Insert "+ x);
            }
            else
            {
                Console.WriteLine("Stack Overflow");
            }
        }

        public void Push2(int x)
        {
            if (top1 < top2 - 1)
            {
                top2--;
                arr[top2] = x;
                Console.WriteLine("Stack2: Insert " + x);
            }
            else
            {
                Console.WriteLine("Stack Overflow");
            }
        }

        public int Pop1()
        {
            if (top1 >= 0)
            {
                int x = arr[top1];
                top1--;
                Console.WriteLine("Stack1: Pop Out " + x);
                return x;
            }
            else
            {
                Console.WriteLine("Stack1: Underflow ");
                return -1;
            }
        }

        public int Pop2()
        {
            if (top2 < capacity)
            {
                int x = arr[top2];
                top2++;
                Console.WriteLine("Stack2: Pop Out " + x);
                return x;
            }
            else
            {
                Console.WriteLine("Stack2: Underflow ");
                return -1;
            }
        }
    }
}
