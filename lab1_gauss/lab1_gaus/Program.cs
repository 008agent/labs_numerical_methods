using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lab1_gaus;

namespace lab1_gauss
{
    class Program
    {
        //тестовая матрица
       public static double[,] tst = {
                           {2.0,1.0,-1.0,8.0},
                           {-3,-1,2,-11},
                           {-2,1,2,-3},
                        };

        static void Main(string[] args)
        {
            Menu.main_menu();
        }
    }
}
