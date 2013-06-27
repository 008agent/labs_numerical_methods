using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lab1_gauss;

namespace lab1_gaus
{
    class Menu
    {
        public static void main_menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.solve test matrix");
                Console.WriteLine("2.solve random matrix");
                Console.WriteLine("3.exit");
                char ans = Console.ReadKey().KeyChar;
                switch (ans)
                {
                    case '1':
                        {
                            Gauss g = new Gauss(Program.tst, 3);
                            Console.WriteLine("Source matrix : ");
                            Printer.print_2d_array(Program.tst);
                            Console.WriteLine("Solutions : ");
                            Printer.print_1d_array(g.solve_matrix());
                            Console.WriteLine("Determinant : ");
                            Console.WriteLine(g.get_determ());
                            Console.ReadKey();
                            break;
                        }
                    case '2':
                        {
                            Gauss g = new Gauss(5);
                            g.init_matrix_randoms(-10, 10);
                            Console.WriteLine("Source matrix : ");
                            Printer.print_2d_array(g.getMatrix);
                            Console.WriteLine("Solutions : ");
                            Printer.print_1d_array(g.solve_matrix());
                            Console.WriteLine("Determinant : ");
                            Console.WriteLine(g.get_determ());
                            Console.ReadKey();
                            break;
                        }
                    case '3':
                        {
                            return;
                            //break;
                        }
                    default:
                        {
                            main_menu();
                            break;
                        }
                }
            }
        }

    }
}
