using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace lab2_splains
{
    /// <summary>
    /// Класс для рисования объектов. Небезопасен, обрабатывать исключения.
    /// </summary>
    class Painter
    {
        /// <summary>
        /// Заполняет область рисования указанным цветом
        /// </summary>
        /// <param name="pb">объект для рисования PictureBox, ссылочный</param>
        /// <param name="C">цвет для заливки</param>
        public static void fill_pictureBox(Panel pb, Color C)
        {
            using (Graphics G = pb.CreateGraphics())
            {
                G.Clear(C);
            }
        }

        public static void draw_grid(Panel pb, int ppd,Color C)
        {

                Graphics G = pb.CreateGraphics();
                Pen P = new Pen(C);
                Point p1row = new Point(0, (int)(pb.Height / 2) );
                Point p2row = new Point(pb.Width, (int)(pb.Height / 2) );
                G.DrawLine(P, p1row, p2row);
                G.DrawRectangle(P, 100, 100, 200, 200);

        }

    }
}
