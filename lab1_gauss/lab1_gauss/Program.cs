using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1_gauss
{
    class Program
    {
        static void Main(string[] args)
        {
            Gauss g = new Gauss(3);
            g.init_matrix();
            Printer.print_2d_array(g.getMatrix);
            g.init_matrix_randoms(1, 10);
            Printer.print_2d_array(g.getMatrix);
            Console.ReadKey();
        }
    }
}
