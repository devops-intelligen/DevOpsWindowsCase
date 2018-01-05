namespace DevOpsWindowCase
{
    partial class DevOpsWindowCase
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logo3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logo1ToolStripMenuItem,
            this.logo2ToolStripMenuItem,
            this.logo3ToolStripMenuItem});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.menu1ToolStripMenuItem.Text = "Genpact Logo";
            this.menu1ToolStripMenuItem.Click += new System.EventHandler(this.menu1ToolStripMenuItem_Click);
            // 
            // logo1ToolStripMenuItem
            // 
            this.logo1ToolStripMenuItem.Name = "logo1ToolStripMenuItem";
            this.logo1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logo1ToolStripMenuItem.Text = "Logo 1";
            this.logo1ToolStripMenuItem.Click += new System.EventHandler(this.logo1ToolStripMenuItem_Click);
            // 
            // logo2ToolStripMenuItem
            // 
            this.logo2ToolStripMenuItem.Name = "logo2ToolStripMenuItem";
            this.logo2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logo2ToolStripMenuItem.Text = "Logo 2";
            this.logo2ToolStripMenuItem.Click += new System.EventHandler(this.logo2ToolStripMenuItem_Click);
            // 
            // logo3ToolStripMenuItem
            // 
            this.logo3ToolStripMenuItem.Name = "logo3ToolStripMenuItem";
            this.logo3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logo3ToolStripMenuItem.Text = "Logo 3";
            this.logo3ToolStripMenuItem.Click += new System.EventHandler(this.logo3ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\logo1.jpg";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(43, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 235);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DevOpsWindowCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 305);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DevOpsWindowCase";
            this.Text = "DevOpsWindowCase";
            this.Load += new System.EventHandler(this.DevOpsWindowCase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem logo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logo3ToolStripMenuItem;
    }
}

