namespace AnimalPicturesApp
{
    partial class Form1
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
            this.chooseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elephantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hippoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.myPicBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseToolStripMenuItem
            // 
            this.chooseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horseToolStripMenuItem,
            this.elephantToolStripMenuItem,
            this.hippoToolStripMenuItem});
            this.chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
            this.chooseToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.chooseToolStripMenuItem.Text = "Choose";
            // 
            // horseToolStripMenuItem
            // 
            this.horseToolStripMenuItem.Name = "horseToolStripMenuItem";
            this.horseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.horseToolStripMenuItem.Text = "Horse";
            this.horseToolStripMenuItem.Click += new System.EventHandler(this.horseToolStripMenuItem_Click);
            // 
            // elephantToolStripMenuItem
            // 
            this.elephantToolStripMenuItem.Name = "elephantToolStripMenuItem";
            this.elephantToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.elephantToolStripMenuItem.Text = "Elephant";
            this.elephantToolStripMenuItem.Click += new System.EventHandler(this.elephantToolStripMenuItem_Click);
            // 
            // hippoToolStripMenuItem
            // 
            this.hippoToolStripMenuItem.Name = "hippoToolStripMenuItem";
            this.hippoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hippoToolStripMenuItem.Text = "Hippo";
            this.hippoToolStripMenuItem.Click += new System.EventHandler(this.hippoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(498, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AnimalPicturesApp.MyResources._51NhtW9exnL__SX355_;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Horse";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::AnimalPicturesApp.MyResources.AfricanElephant;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Elephant";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::AnimalPicturesApp.MyResources.hippo;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Hippo";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // myPicBox
            // 
            this.myPicBox.Location = new System.Drawing.Point(12, 54);
            this.myPicBox.Name = "myPicBox";
            this.myPicBox.Size = new System.Drawing.Size(474, 280);
            this.myPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myPicBox.TabIndex = 0;
            this.myPicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 346);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.myPicBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox myPicBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elephantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hippoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

