using System;

namespace StackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Program...!");

            /**
            StackUsingArray st = new StackUsingArray(10);
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);
            st.Pop();
            st.Pop();
            st.PrintStack();
            */
            /**
            StackUsingQueue st1 = new StackUsingQueue();
            st1.Push(1);
            st1.Push(2);
            st1.Push(3);
            st1.Push(4);
            st1.Push(5);
            Console.WriteLine("popped"+ st1.Pop());
            Console.WriteLine("popped"+ st1.Pop());
            */

            /**
            TwoStackArray ts = new TwoStackArray(10);
            ts.Push1(1);
            ts.Push1(2);
            ts.Push1(3);
            ts.Push1(4);

            ts.Push2(11);
            ts.Push2(12);
            ts.Push2(13);
            ts.Push2(14);

            ts.Pop1();
            ts.Pop1();
            ts.Pop2();
            ts.Pop2();
            */

            /**
            StackToGetMin st = new StackToGetMin();
            st.Push(18);
            st.GetMin();
            st.Push(15);
            st.GetMin();
            st.Push(17);
            st.GetMin();
            st.Push(22);
            st.GetMin();
            st.Push(10);
            st.GetMin();
            st.Push(22);
            st.GetMin();
            st.Pop();
            st.GetMin();
            st.Pop();
            st.Pop();
            st.Pop();
            st.GetMin();
            */
            //TowerOfHanoi th = new TowerOfHanoi(4);
            //th.StartGame();

            BalancedParanthesis.Start();
            Console.ReadKey();
        }
    }
}
