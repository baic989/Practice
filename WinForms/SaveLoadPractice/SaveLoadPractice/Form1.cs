using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveLoadPractice
{
    public partial class Form1 : Form
    {
        Random rnd;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void newSquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeNewSquare();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            makeNewSquare();
        }

        private void makeNewSquare()
        {
            Panel pnl = new Panel();
            pnl.Width = 100;
            pnl.Height = 100;
            pnl.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));

            mainContainer.Controls.Add(pnl);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            mainContainer.Controls.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            saveAll();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAll();
        }

        private void saveAll()
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = ".txt Files|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(save.FileName))
                {
                    sw.Write(getColorsFromPanels());
                }
            }
        }

        private string getColorsFromPanels()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Panel pnl in mainContainer.Controls)
            {
                sb.Append(pnl.BackColor.R + ";");
                sb.Append(pnl.BackColor.G + ";");
                sb.Append(pnl.BackColor.B);
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAll();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            openAll();
        }

        private void openAll()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = ".txt Files|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                mainContainer.Controls.Clear();

                string[] lines = File.ReadAllLines(path);
                foreach (string item in lines)
                {
                    Panel p = new Panel();
                    string[] colors = item.Split(';');

                    p.Width = 100;
                    p.Height = 100;
                    p.BackColor = Color.FromArgb(int.Parse(colors[0]), int.Parse(colors[1]), int.Parse(colors[2]));

                    mainContainer.Controls.Add(p);
                }
            }
        }
    }
}
