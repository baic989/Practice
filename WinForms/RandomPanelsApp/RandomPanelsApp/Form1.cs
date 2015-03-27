using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPanelsApp
{
    public partial class Form1 : Form
    {
        Random rnd;
        const int panelDimensions = 40;
        Panel selectedPanel;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private Panel GetPanel()
        {
            Panel pnl = new Panel();
            pnl.Size = new Size(panelDimensions, panelDimensions);
            pnl.Location = GetRandomLocation();
            pnl.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            pnl.ContextMenuStrip = contextMenuStripRemove;
            pnl.Click += PanelCLick;

            return pnl;
        }

        private void PanelCLick(object sender, EventArgs e)
        {
            if (selectedPanel != null)
            {
                selectedPanel.BorderStyle = BorderStyle.None;
            }

            Panel clickedPanel = sender as Panel;
            clickedPanel.BorderStyle = BorderStyle.Fixed3D;

            selectedPanel = clickedPanel;
        }

        private Point GetRandomLocation()
        {
            int maxX = containerPanel.Width - panelDimensions;
            int maxY = containerPanel.Height - panelDimensions;

            return new Point(rnd.Next(maxX), rnd.Next(maxY));
        }

        private void GeneratePanels(int numberOfPanels)
        {
            for (int i = 0; i < numberOfPanels; i++)
            {
                containerPanel.Controls.Add(GetPanel());
            }
        }

        private void panelToolStripMenuItem1Panel_Click(object sender, EventArgs e)
        {
            GeneratePanels(1);
        }

        private void panelsToolStripMenuItem5Panels_Click(object sender, EventArgs e)
        {
            GeneratePanels(5);
        }

        private void panelsToolStripMenuItem10Panels_Click(object sender, EventArgs e)
        {
            GeneratePanels(10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            containerPanel.ContextMenuStrip = contextMenuStripContainer;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Remove(selectedPanel);

            selectedPanel = null;
        }

        private void contextMenuStripRemove_Opened(object sender, EventArgs e)
        {
            if (selectedPanel != null)
            {
                selectedPanel.BorderStyle = BorderStyle.None;
            }

            Panel pnl = (sender as ContextMenuStrip).SourceControl as Panel;
            pnl.BorderStyle = BorderStyle.Fixed3D;
            selectedPanel = pnl;
        }

    }
}
