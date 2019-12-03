using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class SearchIn2DMatrix
    {
        public static void Start()
        {
            int[,] M = { { 1, 4, 7, 11, 15 }, { 2, 5, 8, 12, 19 }, { 3, 6, 9, 16, 22 }, { 10, 13, 14, 17, 24 }, { 18, 21, 23, 126, 30 } };
            int target = 5;
            Console.WriteLine(SearchMatrix(M, target));

        }

        public static bool  SearchMatrix(int[,] matrix, int target)
        {
            bool found = false;
            int R = matrix.GetLength(0);
            int C = matrix.GetLength(1);

            if (R == 0 || C == 0)
            {
                return false;
            }
            int r = 0;
            int c = C - 1;

            while (r < R && c >= 0)
            {
                if (matrix[r, c] == target)
                {
                    return true;
                }
                else if (matrix[r, c] > target)
                {
                    c--;
                }
                else
                {
                    r++;
                }

            }

            return found;
        }
    }
}
