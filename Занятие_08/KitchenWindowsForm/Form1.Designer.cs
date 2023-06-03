namespace KitchenWindowsForm
{
    partial class frmРесторан
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpМеню = new GroupBox();
            lstМеню = new ListBox();
            mnuContext = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            grpЗаказ = new GroupBox();
            lstЗаказ = new ListBox();
            cmdДобавить = new Button();
            cmdУбрать = new Button();
            cmdЗаказать = new Button();
            menuStrip1 = new MenuStrip();
            mnuФайл = new ToolStripMenuItem();
            mnuКухня = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statКухня = new ToolStripStatusLabel();
            kchenContext = new ContextMenuStrip(components);
            удалитьКухнюToolStripMenuItem = new ToolStripMenuItem();
            grpМеню.SuspendLayout();
            mnuContext.SuspendLayout();
            grpЗаказ.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            kchenContext.SuspendLayout();
            SuspendLayout();
            // 
            // grpМеню
            // 
            grpМеню.Controls.Add(lstМеню);
            grpМеню.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpМеню.Location = new Point(55, 79);
            grpМеню.Name = "grpМеню";
            grpМеню.Size = new Size(237, 314);
            grpМеню.TabIndex = 0;
            grpМеню.TabStop = false;
            grpМеню.Text = "МЕНЮ:";
            // 
            // lstМеню
            // 
            lstМеню.ContextMenuStrip = mnuContext;
            lstМеню.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstМеню.FormattingEnabled = true;
            lstМеню.ItemHeight = 17;
            lstМеню.Items.AddRange(new object[] { "Глазунья", "Гусь жареный", "Зелёный горошек", "Килька в том. соусе", "Компот", "Мундиры", "Омар. не Хайам", "Сахар для чая", "Сухари сушеные", "Цветная капуста", "Чёрно-белая капуста" });
            lstМеню.Location = new Point(6, 49);
            lstМеню.Name = "lstМеню";
            lstМеню.Size = new Size(225, 259);
            lstМеню.TabIndex = 0;
            lstМеню.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // mnuContext
            // 
            mnuContext.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            mnuContext.Name = "mnuContext";
            mnuContext.Size = new Size(221, 92);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(220, 22);
            toolStripMenuItem1.Text = "Добавить новое блюдо";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(220, 22);
            toolStripMenuItem2.Text = "Заказать блюдо";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Enabled = false;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(220, 22);
            toolStripMenuItem3.Text = "Удалить блюдо";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Enabled = false;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(220, 22);
            toolStripMenuItem4.Text = "Изменить название блюда";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // grpЗаказ
            // 
            grpЗаказ.Controls.Add(lstЗаказ);
            grpЗаказ.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpЗаказ.Location = new Point(502, 79);
            grpЗаказ.Name = "grpЗаказ";
            grpЗаказ.Size = new Size(237, 314);
            grpЗаказ.TabIndex = 1;
            grpЗаказ.TabStop = false;
            grpЗаказ.Text = "ЗАКАЗ:";
            // 
            // lstЗаказ
            // 
            lstЗаказ.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstЗаказ.FormattingEnabled = true;
            lstЗаказ.ItemHeight = 17;
            lstЗаказ.Location = new Point(6, 49);
            lstЗаказ.Name = "lstЗаказ";
            lstЗаказ.Size = new Size(225, 259);
            lstЗаказ.TabIndex = 0;
            // 
            // cmdДобавить
            // 
            cmdДобавить.Location = new Point(331, 143);
            cmdДобавить.Name = "cmdДобавить";
            cmdДобавить.Size = new Size(139, 33);
            cmdДобавить.TabIndex = 2;
            cmdДобавить.Text = "&Добавить ->";
            cmdДобавить.UseVisualStyleBackColor = true;
            cmdДобавить.Click += cmdДобавить_Click;
            // 
            // cmdУбрать
            // 
            cmdУбрать.Location = new Point(331, 209);
            cmdУбрать.Name = "cmdУбрать";
            cmdУбрать.Size = new Size(139, 33);
            cmdУбрать.TabIndex = 3;
            cmdУбрать.Text = "<- &Убрать";
            cmdУбрать.UseVisualStyleBackColor = true;
            cmdУбрать.Click += cmdУбрать_Click;
            // 
            // cmdЗаказать
            // 
            cmdЗаказать.Location = new Point(331, 274);
            cmdЗаказать.Name = "cmdЗаказать";
            cmdЗаказать.Size = new Size(139, 33);
            cmdЗаказать.TabIndex = 4;
            cmdЗаказать.Text = "&Заказать";
            cmdЗаказать.UseVisualStyleBackColor = true;
            cmdЗаказать.Click += cmdЗаказать_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuФайл, mnuКухня });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuФайл
            // 
            mnuФайл.Name = "mnuФайл";
            mnuФайл.Size = new Size(48, 20);
            mnuФайл.Text = "Файл";
            // 
            // mnuКухня
            // 
            mnuКухня.Name = "mnuКухня";
            mnuКухня.Size = new Size(91, 20);
            mnuКухня.Text = "Выбор кухни";
            mnuКухня.DropDownItemClicked += mnuКухня_DropDownItemClicked;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statКухня });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // statКухня
            // 
            statКухня.Name = "statКухня";
            statКухня.Size = new Size(0, 17);
            statКухня.Click += toolStripStatusLabel1_Click;
            // 
            // kchenContext
            // 
            kchenContext.Items.AddRange(new ToolStripItem[] { удалитьКухнюToolStripMenuItem });
            kchenContext.Name = "kchenContext";
            kchenContext.Size = new Size(157, 26);
            // 
            // удалитьКухнюToolStripMenuItem
            // 
            удалитьКухнюToolStripMenuItem.Name = "удалитьКухнюToolStripMenuItem";
            удалитьКухнюToolStripMenuItem.Size = new Size(156, 22);
            удалитьКухнюToolStripMenuItem.Text = "Удалить кухню";
            // 
            // frmРесторан
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(cmdЗаказать);
            Controls.Add(cmdУбрать);
            Controls.Add(cmdДобавить);
            Controls.Add(grpЗаказ);
            Controls.Add(grpМеню);
            MainMenuStrip = menuStrip1;
            Name = "frmРесторан";
            Text = "Ресторан \"Студент\"";
            FormClosing += frmРесторан_FormClosing;
            Load += frmРесторан_Load;
            grpМеню.ResumeLayout(false);
            mnuContext.ResumeLayout(false);
            grpЗаказ.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            kchenContext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpМеню;
        private ListBox lstМеню;
        private GroupBox grpЗаказ;
        private ListBox lstЗаказ;
        private Button cmdДобавить;
        private Button cmdУбрать;
        private Button cmdЗаказать;
        private ContextMenuStrip mnuContext;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuФайл;
        private ToolStripMenuItem mnuКухня;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statКухня;
        private ContextMenuStrip kchenContext;
        private ToolStripMenuItem удалитьКухнюToolStripMenuItem;
    }
}