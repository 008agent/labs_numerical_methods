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
        public static void fill_pictureBox(ref Panel pb, Color C)
        {
            using (Graphics G = pb.CreateGraphics())
            {
                G.Clear(C);
            }
        }

        /// <summary>
        /// Отрисовывает оси oX и oY с заданным масштабом
        /// </summary>
        /// <param name="pb">объект для рисования Panel</param>
        /// <param name="ppd">Масштаб</param>
        /// <param name="C"></param>
        public static void draw_grid(ref Panel pb, int ppd,Color C)
        {

                Graphics G = pb.CreateGraphics();

                Pen P = new Pen(C);
                Point p1row = new Point(0, (pb.Height / 2) );
                Point p2row = new Point(pb.Width, (pb.Height / 2) );
                G.DrawLine(P, p1row, p2row);

                Point p1col = new Point( pb.Width/2 , 0 );
                Point p2col = new Point( pb.Width/2 , pb.Width );
                G.DrawLine(P, p1col, p2col);

        }

        public static void draw_graph(ref Panel pb/*, int[] X,int[] Y*/, int ppd, Color C)
        {
            /*
             *  1) берем 3-4 точки на интервале 0 по 2Пи(шаг более менее большой). 
             *  2) берем 8-10 точек на интервале 0 по 2Пи (уменьшаем шаг)
             *  3) точки с предыдущего примера, только для одной точки изменяем значение y, например было 0.8, делаем -5, смотрим как ведет себя интерполяция.
             *  4) берем 8-10 точек на интервале 0 по 50Пи.
             *  В итоге, должны получить график, на котором одним цветом исходная функция (sinx), полученный график в результате интерполяции
             *  и на графике должны быть отмечены сами точки (узлы) интерполяции (чтобы они были видны). Интерполяционный график должен пройти через исходные эти точки.
             *  Sinx тоже (за исключением точки в исходных данных 3, для которой меняли значение y).
             *  Программа должна позволять найти значение y для любого введенного x(расчитывается на основе построенного интерполяционного многочлена).
             */
            double[] xtmp = new double[400];
            double[] ytmp = new double[400];
            Point[] ptmp = new Point[400];

            //заполнение значениями функции
            int j = 0;
            for (float i = -6.28f; i < 6.28f; i+=0.0314f)
            {
                xtmp[j] = i;
                ytmp[j] = Math.Sin(xtmp[j]);
                j++;
            }
            //преобразование координат
            using (Graphics G = pb.CreateGraphics())
            {
                Pen P = new Pen(C);
                for (int i = 0; i < 400; i++)
                {
                    xtmp[i] = (xtmp[i] * ppd) + axisTools.center(ref pb).X;
                    ytmp[i] = (ytmp[i] * ppd) + axisTools.center(ref pb).Y;
                    ptmp[i] = new Point((int)xtmp[i], (int)ytmp[i]);
                }
                G.DrawCurve(P, ptmp);
            }
            
        }

    }
}
