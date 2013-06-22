using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1_gauss
{
    class Printer
    {
        /// <summary>
        /// Выводит матрицу
        /// </summary>
        /// <param name="src">Принимает исходную матрицу</param>
        public static void print_2d_array(double[,] src)
        {
            int szRow = src.GetLength(0);
            int szCol = src.GetLength(1);
           // Console.WriteLine(szRow);
           // Console.WriteLine(szCol);

            for (int i = 0; i < szRow; i++)
            {
                for (int j = 0; j < szCol; j++)
                {
                    Console.Write( " <" + Convert.ToString(src[i, j]) + "> ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
