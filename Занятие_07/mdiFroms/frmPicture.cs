using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdiFroms
{
    public partial class frmPicture : Form
    {
        public Bitmap buf;
        Graphics gr;
        public frmPicture()
        {
            InitializeComponent();
            buf = new Bitmap(picКартинка.Width, picКартинка.Height);
            gr = Graphics.FromImage(buf);
        }
        private void picКартинка_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (mdiGeneral.Инструмент == 1) gr.DrawLine(mdiGeneral.p, e.X, e.Y, picКартинка.Width / 2, picКартинка.Height / 2);
            if (mdiGeneral.Инструмент == 2) gr.DrawRectangle(mdiGeneral.p, e.X, e.Y, 40, 40);
            if (mdiGeneral.Инструмент == 3)
            {
                gr.DrawLine(mdiGeneral.p, e.X - 20, e.Y, e.X + 20, e.Y);
                gr.DrawLine(mdiGeneral.p, e.X, e.Y - 20, e.X, e.Y + 20);
            }
            picКартинка.Image = buf;
        }
        private void frmPicture_Load(object sender, EventArgs e)
        {
            gr = Graphics.FromImage(buf);
            picКартинка.Image = buf;
        }
        private void Полотно_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                gr.Clear(Color.White);
                picКартинка.Image = buf;
            }
        }
    }
}
