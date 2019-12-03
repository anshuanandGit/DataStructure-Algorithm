using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class PrisonerAfterNDays
    {
        public static void Start()
        {

        }
        public int[] PrisonAfterNDays(int[] cells, int N)
        {
            if (cells.Length == 0 || N == 0)
            {
                return cells;
            }

            //find cycle....
            HashSet<string> mapper = new HashSet<string>();
            int cycle = 0;
            bool hasCycle = false;

            for (int i = 0; i < N; i++)
            {

                int[] next = NextDayStatus(cells);
                string cellpattern = String.Join("", next); //convert in string pattern 
                if (!mapper.Contains(cellpattern))
                {
                    mapper.Add(cellpattern);
                    cycle++;
                }
                else
                {
                    hasCycle = true;
                    break;
                }
                cells = next;
            }

            if (hasCycle)
            {
                int reqIteraion = N % cycle;
                for (int i = 0; i < reqIteraion; i++)
                {
                    cells = NextDayStatus(cells);
                }
            }

            return cells;

        }

        public int[] NextDayStatus(int[] cell)
        {

            int[] res = new int[cell.Length];

            for (int i = 1; i < cell.Length - 1; i++)
            {
                if (cell[i - 1] == cell[i + 1])
                {
                    res[i] = 1;
                }
                else
                {
                    res[i] = 0;
                }
            }
            return res;
        }
    }
}
