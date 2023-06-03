using System.IO;
namespace KitchenWindowsForm
{
    public partial class frm�������� : Form
    {
        string dirKitchen = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\") + "\\�����");
        string fileKitchen;
        bool changes = false;
        public frm��������()
        {
            InitializeComponent();
        }
        private void cmd��������_Click(object sender, EventArgs e)
        {
            if (lst����.SelectedItem != null)
            {
                lst�����.Items.Add(lst����.SelectedItem);
                changes = true;
            }
        }
        private void cmd������_Click(object sender, EventArgs e)
        {
            if (lst�����.SelectedIndex >= 0)
            {
                lst�����.Items.RemoveAt(lst�����.SelectedIndex);
            }
        }
        private void cmd��������_Click(object sender, EventArgs e)
        {
            if (lst�����.Items.Count != 0)
            {
                MessageBox.Show("��������� ��������!", "�������� ��������",
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
            string s = Microsoft.VisualBasic.Interaction.InputBox("������� �������� ������ �����", "�������� ��������", " < ����� ����� > ");
            if (s == "") return;
            lst����.Items.Add(s);
            changes = true;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (lst����.SelectedIndex >= 0)
            {
                lst����.Items.RemoveAt(lst����.SelectedIndex);
                changes = true;
            }
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("������� ����� �������� �����", "�������� ��������", lst����.SelectedItem.ToString());
            if (s == lst����.SelectedItem.ToString()) return;
            int a = lst����.SelectedIndex;
            lst����.Items.RemoveAt(lst����.SelectedIndex);
            lst����.Items.Insert(a, s);
            changes = true;
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void menuLoad()
        {
            if (!Directory.Exists(dirKitchen))
            {
                MessageBox.Show("������� ������� �����������!\n������� ����������:" + Directory.GetCurrentDirectory(), "�������� ��������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Console.WriteLine("������� ����������:" + Directory.GetCurrentDirectory());

                return;
            }
            string[] files = Directory.GetFiles(dirKitchen, "*.khn");
            mnu�����.DropDownItems.Clear();
            foreach (string s in files)
            {
                string f = new FileInfo(s).Name.ToString();
                var new_items = mnu�����.DropDownItems.Add(f);
                f = f.Remove(f.Length - 4);
                mnu�����.DropDownItems.Add(f);
            }

        }
        private void frm��������_Load(object sender, EventArgs e)
        {
            menuLoad();
        }
        private void mnu�����_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (changes) saveKitchen();
            fileKitchen = dirKitchen + "\\" + e.ClickedItem.Text + ".khn";
            stat�����.Text = e.ClickedItem.Text + " �����";
            if (new FileInfo(fileKitchen).Exists == false)
            {
                MessageBox.Show("������ �� ���� ����� ���!",
                "�������� ��������", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            StreamReader f = new StreamReader(fileKitchen);
            lst����.Items.Clear();
            while (!f.EndOfStream) lst����.Items.Add(f.ReadLine());
            f.Close();
            toolStripMenuItem1.Enabled = true;
            changes = true;
        }
        void saveKitchen()
        {
            changes = false;
            DialogResult result = MessageBox.Show("�� ������ ��������� ��������� ? ", "�������� ��������",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            StreamWriter f = new StreamWriter(fileKitchen, false);
            for (int i = 0; i < lst����.Items.Count; i++) f.WriteLine(lst����.Items[i]);
            f.Close();
        }
        private void frm��������_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes) saveKitchen();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        private void mnu����_Click(object sender, EventArgs e)
        {
            mnu����.DropDownItems.Clear();
            var delete_kitchen = mnu����.DropDownItems.Add("�������");
            //delete_kitchen.Click += new EventHandler(deleteKitchen);
        }
        private void deleteKitchen()
        {
            //OpenFileDialog('');
        }
    }
}