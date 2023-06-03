using System.IO;
namespace KitchenWindowsForm
{
    public partial class frmРесторан : Form
    {
        string dirKitchen = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\") + "\\Кухня");
        string fileKitchen;
        bool changes = false;
        public frmРесторан()
        {
            InitializeComponent();
        }
        private void cmdДобавить_Click(object sender, EventArgs e)
        {
            if (lstМеню.SelectedItem != null)
            {
                lstЗаказ.Items.Add(lstМеню.SelectedItem);
                changes = true;
            }
        }
        private void cmdУбрать_Click(object sender, EventArgs e)
        {
            if (lstЗаказ.SelectedIndex >= 0)
            {
                lstЗаказ.Items.RemoveAt(lstЗаказ.SelectedIndex);
            }
        }
        private void cmdЗаказать_Click(object sender, EventArgs e)
        {
            if (lstЗаказ.Items.Count != 0)
            {
                MessageBox.Show("Приятного аппетита!", "Ресторан «Студент»",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem3.Enabled = true;
            toolStripMenuItem4.Enabled = true;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("Введите название нового блюда", "Ресторан «Студент»", " < Новое блюдо > ");
            if (s == "") return;
            lstМеню.Items.Add(s);
            changes = true;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (lstМеню.SelectedIndex >= 0)
            {
                lstМеню.Items.RemoveAt(lstМеню.SelectedIndex);
                changes = true;
            }
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("Введите новое название блюда", "Ресторан «Студент»", lstМеню.SelectedItem.ToString());
            if (s == lstМеню.SelectedItem.ToString()) return;
            int a = lstМеню.SelectedIndex;
            lstМеню.Items.RemoveAt(lstМеню.SelectedIndex);
            lstМеню.Items.Insert(a, s);
            changes = true;
        }

        private void кухняToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void menuLoad()
        {
            if (!Directory.Exists(dirKitchen))
            {
                MessageBox.Show("Каталог «Кухня» отсутствует!\nТекущая директория:" + Directory.GetCurrentDirectory(), "Ресторан «Студент»",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Console.WriteLine("Текущая директория:" + Directory.GetCurrentDirectory());

                return;
            }
            string[] files = Directory.GetFiles(dirKitchen, "*.khn");
            mnuКухня.DropDownItems.Clear();
            foreach (string s in files)
            {
                string f = new FileInfo(s).Name.ToString();
                var new_items = mnuКухня.DropDownItems.Add(f);
                f = f.Remove(f.Length - 4);
                mnuКухня.DropDownItems.Add(f);
            }

        }
        private void frmРесторан_Load(object sender, EventArgs e)
        {
            menuLoad();
        }
        private void mnuКухня_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (changes) saveKitchen();
            fileKitchen = dirKitchen + "\\" + e.ClickedItem.Text + ".khn";
            statКухня.Text = e.ClickedItem.Text + " кухня";
            if (new FileInfo(fileKitchen).Exists == false)
            {
                MessageBox.Show("Данных об этой кухне нет!",
                "Ресторан «Студент»", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            StreamReader f = new StreamReader(fileKitchen);
            lstМеню.Items.Clear();
            while (!f.EndOfStream) lstМеню.Items.Add(f.ReadLine());
            f.Close();
            toolStripMenuItem1.Enabled = true;
            changes = true;
        }
        void saveKitchen()
        {
            changes = false;
            DialogResult result = MessageBox.Show("Вы хотите сохранить изменения ? ", "Ресторан «Студент»",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            StreamWriter f = new StreamWriter(fileKitchen, false);
            for (int i = 0; i < lstМеню.Items.Count; i++) f.WriteLine(lstМеню.Items[i]);
            f.Close();
        }
        private void frmРесторан_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes) saveKitchen();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        private void mnuФайл_Click(object sender, EventArgs e)
        {
            mnuФайл.DropDownItems.Clear();
            var delete_kitchen = mnuФайл.DropDownItems.Add("Удалить");
            //delete_kitchen.Click += new EventHandler(deleteKitchen);
        }
        private void deleteKitchen()
        {
            //OpenFileDialog('');
        }
    }
}