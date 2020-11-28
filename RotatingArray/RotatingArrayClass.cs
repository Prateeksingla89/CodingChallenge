using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatingArray
{
    public class RotatingArrayClass
    {
        public int[,] rotateArray(int m, int n, int[,] matrix)
        {
            int[,] ret;
            if (m > 1 && n > 1)
            {
                ret = new int[m, n];

                for (int i = 0; i < m; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        Console.Write(matrix[n - j - 1, i]);

                    }
                    Console.WriteLine();
                }

            }
            else
            {
               ret= new int[0, 0];
            }

            return ret;
        }
    }
}
