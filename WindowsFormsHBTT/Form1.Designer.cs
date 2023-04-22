namespace WindowsFormsHBTT
{
    partial class frmРедактор
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.picКартинка = new System.Windows.Forms.PictureBox();
            this.mnuИнструмент = new System.Windows.Forms.MenuStrip();
            this.инструментToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Цвет = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратикиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clВыбор = new System.Windows.Forms.ColorDialog();
            this.перекрестьеToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.толщинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picКартинка)).BeginInit();
            this.mnuИнструмент.SuspendLayout();
            this.SuspendLayout();
            // 
            // picКартинка
            // 
            this.picКартинка.BackColor = System.Drawing.Color.White;
            this.picКартинка.Location = new System.Drawing.Point(12, 42);
            this.picКартинка.Name = "picКартинка";
            this.picКартинка.Size = new System.Drawing.Size(776, 396);
            this.picКартинка.TabIndex = 0;
            this.picКартинка.TabStop = false;
            this.picКартинка.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Полотно_MouseClick);
            this.picКартинка.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picКартинка_MouseMove);
            // 
            // mnuИнструмент
            // 
            this.mnuИнструмент.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструментToolStripMenuItem,
            this.Цвет,
            this.толщинаToolStripMenuItem});
            this.mnuИнструмент.Location = new System.Drawing.Point(0, 0);
            this.mnuИнструмент.Name = "mnuИнструмент";
            this.mnuИнструмент.Size = new System.Drawing.Size(800, 24);
            this.mnuИнструмент.TabIndex = 1;
            this.mnuИнструмент.Text = "Инструмент";
            // 
            // инструментToolStripMenuItem
            // 
            this.инструментToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.квадратикиToolStripMenuItem2,
            this.перекрестьеToolStripMenuItem3});
            this.инструментToolStripMenuItem.Name = "инструментToolStripMenuItem";
            this.инструментToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.инструментToolStripMenuItem.Text = "Инструмент";
            // 
            // Цвет
            // 
            this.Цвет.Name = "Цвет";
            this.Цвет.Size = new System.Drawing.Size(45, 20);
            this.Цвет.Text = "Цвет";
            this.Цвет.Click += new System.EventHandler(this.Цвет_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Линии в центр";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // квадратикиToolStripMenuItem2
            // 
            this.квадратикиToolStripMenuItem2.Name = "квадратикиToolStripMenuItem2";
            this.квадратикиToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.квадратикиToolStripMenuItem2.Text = "Квадратики";
            this.квадратикиToolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // перекрестьеToolStripMenuItem3
            // 
            this.перекрестьеToolStripMenuItem3.Name = "перекрестьеToolStripMenuItem3";
            this.перекрестьеToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.перекрестьеToolStripMenuItem3.Text = "Перекрестье";
            this.перекрестьеToolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // толщинаToolStripMenuItem
            // 
            this.толщинаToolStripMenuItem.Name = "толщинаToolStripMenuItem";
            this.толщинаToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.толщинаToolStripMenuItem.Text = "Толщина";
            this.толщинаToolStripMenuItem.Click += new System.EventHandler(this.Толщина_Click);
            // 
            // frmРедактор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picКартинка);
            this.Controls.Add(this.mnuИнструмент);
            this.MainMenuStrip = this.mnuИнструмент;
            this.Name = "frmРедактор";
            this.Text = "Графический Редактор";
            ((System.ComponentModel.ISupportInitialize)(this.picКартинка)).EndInit();
            this.mnuИнструмент.ResumeLayout(false);
            this.mnuИнструмент.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picКартинка;
        private System.Windows.Forms.MenuStrip mnuИнструмент;
        private System.Windows.Forms.ToolStripMenuItem инструментToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem квадратикиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Цвет;
        private System.Windows.Forms.ColorDialog clВыбор;
        private System.Windows.Forms.ToolStripMenuItem перекрестьеToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem толщинаToolStripMenuItem;
    }
}

