using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace lab2_splains
{
    class axisTools
    {
        /// <summary>
        /// служит для коррекции координат плоскости относительно центра
        /// </summary>
        /// <param name="P">Элемент типа Panel для рисования,ссылочный</param>
        /// <returns>Координаты центра для коррекции</returns>
        public static Point center(ref Panel P)
        {
            return new Point(P.Width / 2, P.Height / 2);
        }

    }
}
