using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snehulak
{
    public partial class Form1 : Form
    {
        int move;
        Color snowColor = Color.White;
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int pulSirky = background.Width / 2;
            int vyskaPlatna = background.Height;
            int r = (int)trackBar1.Value;
            int r1 = 2 * r / 3;
            int r2 = 2 * r1 / 3;
            int r3 = r1 / 2;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.FillEllipse(Brushes.White, (pulSirky + move) - r, vyskaPlatna - 2 * r, 2 * r, 2 * r);
            e.Graphics.FillEllipse(Brushes.White, (pulSirky + move) - r1, vyskaPlatna - 2 * r - 2 * r1, 2 * r1, 2 * r1);
            e.Graphics.FillEllipse(Brushes.White, (pulSirky + move) - r2, vyskaPlatna - 2 * r - 2 * r1 - 2 * r2, 2 * r2, 2 * r2);
            e.Graphics.FillEllipse(Brushes.White, (pulSirky + move) - r1 - 2 * r3, vyskaPlatna - 2 * r - r1 - r3, 2 * r3, 2 * r3);
            e.Graphics.FillEllipse(Brushes.White, (pulSirky + move) + r1, vyskaPlatna - 2 * r - r1 - r3, 2 * r3, 2 * r3);

            e.Graphics.FillEllipse(Brushes.White, (pulSirky + move) - r, vyskaPlatna - 2 * r, 2 * r, 2 * r);

            e.Graphics.FillRectangle(new SolidBrush(snowColor), -1 ,vyskaPlatna - 2 * 5,1000,100);

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            background.Refresh();
        }
        private void openSnowColor_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            openSnowColor.BackColor = colorDialog2.Color;
            snowColor = colorDialog2.Color;
            background.Refresh();
        }

        private void openBacColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            openBacColor.BackColor = colorDialog1.Color;
            background.BackColor = colorDialog1.Color;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            move = trackBar2.Value;
            background.Refresh();
        }
    }
}
