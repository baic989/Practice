namespace RandomPanelsApp
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
            this.components = new System.ComponentModel.Container();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.contextMenuStripContainer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelToolStripMenuItem1Panel = new System.Windows.Forms.ToolStripMenuItem();
            this.panelsToolStripMenuItem5Panels = new System.Windows.Forms.ToolStripMenuItem();
            this.panelsToolStripMenuItem10Panels = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripRemove = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripContainer.SuspendLayout();
            this.contextMenuStripRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(547, 441);
            this.containerPanel.TabIndex = 0;
            // 
            // contextMenuStripContainer
            // 
            this.contextMenuStripContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.removeAllToolStripMenuItem});
            this.contextMenuStripContainer.Name = "contextMenuStripContainer";
            this.contextMenuStripContainer.Size = new System.Drawing.Size(135, 48);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelToolStripMenuItem1Panel,
            this.panelsToolStripMenuItem5Panels,
            this.panelsToolStripMenuItem10Panels});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // panelToolStripMenuItem1Panel
            // 
            this.panelToolStripMenuItem1Panel.Name = "panelToolStripMenuItem1Panel";
            this.panelToolStripMenuItem1Panel.Size = new System.Drawing.Size(123, 22);
            this.panelToolStripMenuItem1Panel.Text = "1 Panel";
            this.panelToolStripMenuItem1Panel.Click += new System.EventHandler(this.panelToolStripMenuItem1Panel_Click);
            // 
            // panelsToolStripMenuItem5Panels
            // 
            this.panelsToolStripMenuItem5Panels.Name = "panelsToolStripMenuItem5Panels";
            this.panelsToolStripMenuItem5Panels.Size = new System.Drawing.Size(123, 22);
            this.panelsToolStripMenuItem5Panels.Text = "5 Panels";
            this.panelsToolStripMenuItem5Panels.Click += new System.EventHandler(this.panelsToolStripMenuItem5Panels_Click);
            // 
            // panelsToolStripMenuItem10Panels
            // 
            this.panelsToolStripMenuItem10Panels.Name = "panelsToolStripMenuItem10Panels";
            this.panelsToolStripMenuItem10Panels.Size = new System.Drawing.Size(123, 22);
            this.panelsToolStripMenuItem10Panels.Text = "10 Panels";
            this.panelsToolStripMenuItem10Panels.Click += new System.EventHandler(this.panelsToolStripMenuItem10Panels_Click);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.removeAllToolStripMenuItem.Text = "Remove All";
            // 
            // contextMenuStripRemove
            // 
            this.contextMenuStripRemove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStripRemove.Name = "contextMenuStripRemove";
            this.contextMenuStripRemove.Size = new System.Drawing.Size(118, 26);
            this.contextMenuStripRemove.Opened += new System.EventHandler(this.contextMenuStripRemove_Opened);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 441);
            this.Controls.Add(this.containerPanel);
            this.Name = "Form1";
            this.Text = "RIGHT CLICK INSIDE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStripContainer.ResumeLayout(false);
            this.contextMenuStripRemove.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripContainer;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelToolStripMenuItem1Panel;
        private System.Windows.Forms.ToolStripMenuItem panelsToolStripMenuItem5Panels;
        private System.Windows.Forms.ToolStripMenuItem panelsToolStripMenuItem10Panels;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRemove;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}

