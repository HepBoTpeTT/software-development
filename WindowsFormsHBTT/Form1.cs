using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace WindowsFormsHBTT
{
    public partial class frmРедактор : Form
    {
        Pen p = new Pen(Color.Black, 1);
        Bitmap buf;
        Graphics gr;
        int Инструмент;
        public frmРедактор()
        {
            InitializeComponent();
            buf = new Bitmap(picКартинка.Width, picКартинка.Height);
            gr = Graphics.FromImage(buf);
        }
        private void picКартинка_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (Инструмент == 1) gr.DrawLine(p, e.X, e.Y, picКартинка.Width / 2, picКартинка.Height / 2);
            if (Инструмент == 2) gr.DrawRectangle(p, e.X, e.Y, 40, 40);
            if (Инструмент == 3) {
                gr.DrawLine(p, e.X - 20, e.Y, e.X + 20, e.Y);
                gr.DrawLine(p, e.X, e.Y - 20, e.X, e.Y + 20);
            }
            picКартинка.Image = buf;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Инструмент = 1;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Инструмент = 2;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Инструмент = 3;
        }
        private void Цвет_Click(object sender, EventArgs e)
        {
            if (clВыбор.ShowDialog() == DialogResult.Cancel) {
                return;
            }
            p.Color = clВыбор.Color;
        }
        private void Толщина_Click(object sender, EventArgs e)
        {
            TrackBar толщина = new TrackBar();
            толщина.Maximum = 30;
            толщина.TickFrequency = 5;
            толщина.Show();
        }
        private void Полотно_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                gr.Clear(Color.White);
                picКартинка.Image = buf;
            }
        }
    }
}
