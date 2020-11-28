using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatingArray
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] array = new int[4, 4] {
    { 1,5,9,13 },
    { 2,6,10,14 },
    { 3,7,11,15 },
    { 4,8,12,16}
};

            int row = array.GetLength(0);
            int col = array.GetLength(1);
            RotatingArrayClass rotatingArrayClass = new RotatingArrayClass();
            int[,] rotated = rotatingArrayClass.rotateArray(row, col, array);


            Console.ReadLine();

        }
    }
}