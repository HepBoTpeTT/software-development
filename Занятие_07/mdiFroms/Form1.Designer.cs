namespace mdiFroms
{
    partial class mdiGeneral
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
            mnuGeneral = new MenuStrip();
            mnuFiles = new ToolStripMenuItem();
            mnuNewPicture = new ToolStripMenuItem();
            mnuOpenPicture = new ToolStripMenuItem();
            mnuSavePicture = new ToolStripMenuItem();
            mnuTools = new ToolStripMenuItem();
            mnuColor = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuSortCascade = new ToolStripMenuItem();
            mnuSortVertical = new ToolStripMenuItem();
            mnuSortHorizontal = new ToolStripMenuItem();
            mnuSortIcons = new ToolStripMenuItem();
            mnuView = new ToolStripMenuItem();
            mnuViewCondition = new ToolStripMenuItem();
            mnuViewConditionPictureSize = new ToolStripMenuItem();
            панельИнструментовToolStripMenuItem = new ToolStripMenuItem();
            clВыбор = new ColorDialog();
            mnuGeneral.SuspendLayout();
            SuspendLayout();
            // 
            // mnuGeneral
            // 
            mnuGeneral.Items.AddRange(new ToolStripItem[] { mnuFiles, mnuTools, mnuColor, mnuWindow, mnuView });
            mnuGeneral.Location = new Point(0, 0);
            mnuGeneral.Name = "mnuGeneral";
            mnuGeneral.Size = new Size(800, 24);
            mnuGeneral.TabIndex = 1;
            mnuGeneral.Text = "menuStrip1";
            // 
            // mnuFiles
            // 
            mnuFiles.DropDownItems.AddRange(new ToolStripItem[] { mnuNewPicture, mnuOpenPicture, mnuSavePicture });
            mnuFiles.Name = "mnuFiles";
            mnuFiles.Size = new Size(48, 20);
            mnuFiles.Text = "Файл";
            // 
            // mnuNewPicture
            // 
            mnuNewPicture.Name = "mnuNewPicture";
            mnuNewPicture.Size = new Size(210, 22);
            mnuNewPicture.Text = "Новое полотно";
            mnuNewPicture.Click += mnuNewPicture_Click;
            // 
            // mnuOpenPicture
            // 
            mnuOpenPicture.Name = "mnuOpenPicture";
            mnuOpenPicture.Size = new Size(210, 22);
            mnuOpenPicture.Text = "Открыть изображение";
            mnuOpenPicture.Click += mnuOpenPicture_Click;
            // 
            // mnuSavePicture
            // 
            mnuSavePicture.Name = "mnuSavePicture";
            mnuSavePicture.Size = new Size(210, 22);
            mnuSavePicture.Text = "Сохранить изображение";
            mnuSavePicture.Click += mnuSavePicture_Click;
            // 
            // mnuTools
            // 
            mnuTools.Name = "mnuTools";
            mnuTools.Size = new Size(95, 20);
            mnuTools.Text = "Инструменты";
            // 
            // mnuColor
            // 
            mnuColor.Name = "mnuColor";
            mnuColor.Size = new Size(45, 20);
            mnuColor.Text = "Цвет";
            mnuColor.Click += Цвет_Click;
            // 
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuSortCascade, mnuSortVertical, mnuSortHorizontal, mnuSortIcons });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(48, 20);
            mnuWindow.Text = "Окно";
            // 
            // mnuSortCascade
            // 
            mnuSortCascade.Name = "mnuSortCascade";
            mnuSortCascade.Size = new Size(158, 22);
            mnuSortCascade.Text = "Каскад";
            mnuSortCascade.Click += mnuSortCascade_Click;
            // 
            // mnuSortVertical
            // 
            mnuSortVertical.Name = "mnuSortVertical";
            mnuSortVertical.Size = new Size(158, 22);
            mnuSortVertical.Text = "Вертикально";
            mnuSortVertical.Click += mnuSortVertical_Click;
            // 
            // mnuSortHorizontal
            // 
            mnuSortHorizontal.Name = "mnuSortHorizontal";
            mnuSortHorizontal.Size = new Size(158, 22);
            mnuSortHorizontal.Text = "Горизонтально";
            mnuSortHorizontal.Click += mnuSortHorizontal_Click;
            // 
            // mnuSortIcons
            // 
            mnuSortIcons.Name = "mnuSortIcons";
            mnuSortIcons.Size = new Size(158, 22);
            mnuSortIcons.Text = "Иконки";
            mnuSortIcons.Click += mnuSortIcons_Click;
            // 
            // mnuView
            // 
            mnuView.DropDownItems.AddRange(new ToolStripItem[] { mnuViewCondition, панельИнструментовToolStripMenuItem });
            mnuView.Name = "mnuView";
            mnuView.Size = new Size(39, 20);
            mnuView.Text = "Вид";
            mnuView.Click += mnuViewConditionPictureSize_Text;
            // 
            // mnuViewCondition
            // 
            mnuViewCondition.DropDownItems.AddRange(new ToolStripItem[] { mnuViewConditionPictureSize });
            mnuViewCondition.Name = "mnuViewCondition";
            mnuViewCondition.Size = new Size(196, 22);
            mnuViewCondition.Text = "Строка состояния";
            // 
            // mnuViewConditionPictureSize
            // 
            mnuViewConditionPictureSize.Name = "mnuViewConditionPictureSize";
            mnuViewConditionPictureSize.Size = new Size(197, 22);
            mnuViewConditionPictureSize.Text = "Размер изображения: ";
            // 
            // панельИнструментовToolStripMenuItem
            // 
            панельИнструментовToolStripMenuItem.Name = "панельИнструментовToolStripMenuItem";
            панельИнструментовToolStripMenuItem.Size = new Size(196, 22);
            панельИнструментовToolStripMenuItem.Text = "Панель инструментов";
            // 
            // mdiGeneral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuGeneral);
            IsMdiContainer = true;
            MainMenuStrip = mnuGeneral;
            Name = "mdiGeneral";
            Text = "Графический редактор Художник 2.0";
            WindowState = FormWindowState.Maximized;
            mnuGeneral.ResumeLayout(false);
            mnuGeneral.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuGeneral;
        private ToolStripMenuItem mnuFiles;
        private ToolStripMenuItem mnuTools;
        private ToolStripMenuItem mnuColor;
        private ToolStripMenuItem mnuWindow;
        private ColorDialog clВыбор;
        private ToolStripMenuItem mnuNewPicture;
        private ToolStripMenuItem mnuOpenPicture;
        private ToolStripMenuItem mnuSavePicture;
        private ToolStripMenuItem mnuSortCascade;
        private ToolStripMenuItem mnuSortVertical;
        private ToolStripMenuItem mnuSortHorizontal;
        private ToolStripMenuItem mnuSortIcons;
        private ToolStripMenuItem mnuView;
        private ToolStripMenuItem mnuViewCondition;
        private ToolStripMenuItem mnuViewConditionPictureSize;
        private ToolStripMenuItem панельИнструментовToolStripMenuItem;
    }
}