using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalPicturesApp
{
    public enum Picture
    {
        Horse,
        Elephant,
        Hippo
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Show(Picture picTitle)
        {
            switch (picTitle)
            {
                case Picture.Horse:
                    myPicBox.Image = MyResources._51NhtW9exnL__SX355_;
                    break;
                case Picture.Elephant:
                    myPicBox.Image = MyResources.AfricanElephant;
                    break;
                case Picture.Hippo:
                    myPicBox.Image = MyResources.hippo;
                    break;
                default:
                    break;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Show(Picture.Horse);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Show(Picture.Elephant);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Show(Picture.Hippo);
        }

        private void horseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show(Picture.Horse);
        }

        private void elephantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show(Picture.Elephant);
        }

        private void hippoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show(Picture.Hippo);
        }
    }
}
