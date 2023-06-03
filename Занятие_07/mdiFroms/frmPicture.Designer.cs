namespace mdiFroms
{
    partial class frmPicture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            picКартинка = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picКартинка).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(picКартинка);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // picКартинка
            // 
            picКартинка.BackColor = Color.White;
            picКартинка.BorderStyle = BorderStyle.FixedSingle;
            picКартинка.Location = new Point(0, 0);
            picКартинка.Name = "picКартинка";
            picКартинка.Size = new Size(509, 349);
            picКартинка.SizeMode = PictureBoxSizeMode.AutoSize;
            picКартинка.TabIndex = 0;
            picКартинка.TabStop = false;
            picКартинка.MouseClick += Полотно_MouseClick;
            picКартинка.MouseMove += picКартинка_MouseMove;
            // 
            // frmPicture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "frmPicture";
            Text = "frmPicture";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picКартинка).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox picКартинка;
    }
}