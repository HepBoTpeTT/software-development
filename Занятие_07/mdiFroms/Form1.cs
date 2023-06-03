namespace mdiFroms
{
    public partial class mdiGeneral : Form
    {
        public static Pen p = new Pen(Color.Black, 1);
        int countPicture = 0;
        public static int Инструмент = 1;
        public mdiGeneral()
        {
            InitializeComponent();
            mnuGeneral.MdiWindowListItem = mnuWindow;
        }
        private void Цвет_Click(object sender, EventArgs e)
        {
            if (clВыбор.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            p.Color = clВыбор.Color;
        }
        private void mnuNewPicture_Click(object sender, EventArgs e)
        {
            countPicture++;
            frmPicture childForm = new frmPicture
            {
                MdiParent = this,
                Text = "Рисунок#" + countPicture.ToString(),
                buf = new Bitmap(1280, 720)
            };
            childForm.Show();
        }
        private void mnuOpenPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            Image pic = Image.FromFile(openFileDialog1.FileName);
            float k = 1;
            if (pic.Width >= pic.Height && pic.Width > 1280) k = 1280f / pic.Width;
            else if (pic.Width < pic.Height && pic.Height > 720) k = 720f / pic.Height;
            frmPicture childForm = new frmPicture
            {
                MdiParent = this,
                Text = openFileDialog1.FileName,
                buf = new Bitmap(pic, (int)(pic.Width * k), (int)(pic.Height * k))
            };
            childForm.Show();
        }
        private void mnuSavePicture_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            frmPicture X = (frmPicture)ActiveMdiChild;

            X.buf.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);

            ActiveMdiChild.Text = saveFileDialog1.FileName;
        }
        private void mnuSortCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void mnuSortVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void mnuSortHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void mnuSortIcons_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        public void mnuViewConditionPictureSize_Text(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                mnuViewConditionPictureSize.Text = "Размер изображения: " + ActiveMdiChild.Width + "x" + ActiveMdiChild.Height;
            }
            else
            {
                mnuViewConditionPictureSize.Text = "Размер изображения: 0x0";
            }
        }
    }
}