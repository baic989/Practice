namespace DragAndDropColor
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.AllowDrop = true;
            this.btn1.BackColor = System.Drawing.Color.Yellow;
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1.Location = new System.Drawing.Point(12, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(104, 94);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn_DragDrop);
            this.btn1.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn_DragEnter);
            this.btn1.DragOver += new System.Windows.Forms.DragEventHandler(this.btn_DragOver);
            this.btn1.DragLeave += new System.EventHandler(this.btn_DragLeave);
            this.btn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn2
            // 
            this.btn2.AllowDrop = true;
            this.btn2.Location = new System.Drawing.Point(362, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(104, 94);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn_DragDrop);
            this.btn2.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn_DragEnter);
            this.btn2.DragOver += new System.Windows.Forms.DragEventHandler(this.btn_DragOver);
            this.btn2.DragLeave += new System.EventHandler(this.btn_DragLeave);
            this.btn2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn4
            // 
            this.btn4.AllowDrop = true;
            this.btn4.Location = new System.Drawing.Point(362, 299);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(104, 94);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "button4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn_DragDrop);
            this.btn4.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn_DragEnter);
            this.btn4.DragOver += new System.Windows.Forms.DragEventHandler(this.btn_DragOver);
            this.btn4.DragLeave += new System.EventHandler(this.btn_DragLeave);
            this.btn4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn3
            // 
            this.btn3.AllowDrop = true;
            this.btn3.Location = new System.Drawing.Point(12, 299);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(104, 94);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "button3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn_DragDrop);
            this.btn3.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn_DragEnter);
            this.btn3.DragOver += new System.Windows.Forms.DragEventHandler(this.btn_DragOver);
            this.btn3.DragLeave += new System.EventHandler(this.btn_DragLeave);
            this.btn3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label1;
    }
}

