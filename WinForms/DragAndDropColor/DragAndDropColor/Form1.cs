using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDropColor
{
    public partial class Form1 : Form
    {
        Button controlToDrop;
        bool dndEnd;
        public Form1()
        {
            InitializeComponent();
            dndEnd = true;
            label1.Text = "Drag buttons to one another to change color";
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            StartDragAndDrop(btn);
        }

        private void StartDragAndDrop(Button btn)
        {
            if (btn.BackColor == SystemColors.Control)
                return;

            dndEnd = false;
            controlToDrop = btn;

            label1.Text = btn.Text + " started DnD";

            btn.DoDragDrop(btn.BackColor, DragDropEffects.Move);

            if (dndEnd)
            {
                btn.BackColor = SystemColors.Control;
            }
        }

        private void btn_DragDrop(object sender, DragEventArgs e)
        {
            dndEnd = true;
            Button btn = sender as Button;
            btn.BackColor = (Color)e.Data.GetData(typeof(Color));


            label1.Text = "DragDrop";
        }

        private void btn_DragEnter(object sender, DragEventArgs e)
        {
            Button btn = sender as Button;

            if (btn == controlToDrop)
            {
                label1.Text = "Can't drop here.";

                return;
            }

            e.Effect = DragDropEffects.Move;

            label1.Text = "DragEnter";
        }

        private void btn_DragLeave(object sender, EventArgs e)
        {
            label1.Text = "DragLeave";
        }

        private void btn_DragOver(object sender, DragEventArgs e)
        {
            label1.Text = "DragOver";
        }
    }
}
