using System;
using System.Collections.Generic;
using System.Text;

namespace StackProblem
{
    class TowerOfHanoi
    {
        private int noofdisk;
        private Stack<int> source = new Stack<int>();
        private Stack<int> aux = new Stack<int>();
        private Stack<int> dest = new Stack<int>();
        private int noOfMoves;

        public TowerOfHanoi(int n)
        {
            noofdisk = n;
            source = new Stack<int>();
            aux = new Stack<int>();
            dest = new Stack<int>();
            noOfMoves = (int) (Math.Pow(2, n)-1);
        }     

        public void StartGame()
        {
            string s = "S", a = "A", d = "D";

            //if no of disk are even...swap aux and dest ..
            if(noofdisk % 2 == 0)
            {
                string temp = a;
                a = d;
                d = a;
            }

            //move all disk on source stack ....big on at bottom..
            for(int i = noofdisk; i > 0; i--)
            {
                source.Push(i);  //all the disk will be stacked...
            }

            //iterate for each possible move
            for(int i =1; i<= noOfMoves; i++)
            {
                if (i % 3 == 1)
                {
                    MoveDiskBetweenPoles(source, dest, s, d);
                }
                else if(i % 3 == 2)
                {
                    MoveDiskBetweenPoles(source, aux, s, a);
                }
                else if (i % 3 == 0)
                {
                    MoveDiskBetweenPoles(aux, dest, a, d);
                }
            }
        }

        private void PrintMove(string frm, string to, int disk)
        {
            Console.WriteLine("Move the disk " + disk + " from " + frm + " to " + to);
        }

        private void MoveDiskBetweenPoles(Stack<int> A, Stack<int> B,string src, string dest)
        {           
            if(A.Count == 0 ) //if pole 1 empty  or contains smaller disk
            {
                int disk = B.Pop();
                A.Push(disk); //move disk on pole 1
                PrintMove(dest, src, disk);
            }            
            else if (B.Count == 0 || B.Peek() > A.Peek())//if pole 2 empty or contains smaller disk
            {
                int disk = A.Pop();
                B.Push(disk); //move disk on pole 2
                PrintMove(src, dest, disk);
            }
            else if (A.Peek() > B.Peek())
            {
                int disk = B.Pop();
                A.Push(disk); //move disk on pole 1
                PrintMove(dest, src, disk);
            }
            else
            {
                int disk = A.Pop();
                B.Push(disk); //move disk on pole 2
                PrintMove(src, dest, disk);
            }
        }

    }
}
