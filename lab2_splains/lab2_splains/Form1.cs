using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab2_splains
{
    public partial class f_main : Form
    {
        public f_main()
        {
            InitializeComponent();
        }

        private void tbN_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_setN_Click(object sender, EventArgs e)
        {
            try
            {
                globals.CSNcount = Convert.ToInt32(tbN.Text);
            }
            catch (FormatException FE)
            {
                lErrors.Text = "FormatException:CSNcount";
                globals.CSNcount = 0;
            }
            catch (OverflowException OE)
            {
                lErrors.Text = "OverflowException:CSNcount";
                globals.CSNcount = 0;
            }
        }

        private void pb_main_Click(object sender, EventArgs e)
        {

        }

        private void f_main_Load(object sender, EventArgs e)
        {
            globals.fillColor = p_paint.BackColor;
        }

        private void bDraw_Click(object sender, EventArgs e)
        {
            try
            {
                Painter.fill_pictureBox(p_paint, Color.Red /*globals.fillColor*/);
                Painter.draw_grid(p_paint, 10, globals.gridColor);
            }
            catch (Exception E)
            {
                lErrors.Text = E.Message;
            }
        }

        private void p_paint_Click(object sender, EventArgs e)
        {
        }
    }
}
