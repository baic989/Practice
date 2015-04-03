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

namespace LoadRemoveFile
{
    public partial class Form1 : Form
    {
        private const int WH = 300;
        private PictureBox clickedPic = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectPic = new OpenFileDialog();
            selectPic.Filter = "Pictures|*.bmp;*.jpeg;*.png|All files|*.*";

            if (selectPic.ShowDialog() == DialogResult.OK)
            {
                ShowPicture(selectPic.FileName, selectPic.SafeFileName);
            }
        }

        private void ShowPicture(string path, string filename)
        {
            Label lbl = new Label();
            lbl.Name = "lblTitle";
            lbl.Text = filename.Substring(0, filename.LastIndexOf('.')).ToUpper();

            PictureBox picture = new PictureBox();
            picture.ImageLocation = path;
            picture.Size = new Size(WH, WH);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.MouseClick += picture_MouseClick;

            FlowLayoutPanel pictureFLP = new FlowLayoutPanel();
            pictureFLP.FlowDirection = FlowDirection.TopDown;
            pictureFLP.BackColor = Color.Brown;
            pictureFLP.Size = new Size(WH, WH + lbl.Height);
            pictureFLP.WrapContents = false;

            pictureFLP.Controls.Add(lbl);
            pictureFLP.Controls.Add(picture);
            flowLayoutPanel1.Controls.Add(pictureFLP);
        }

        void picture_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            SelectPic(pic);

            if (e.Button == MouseButtons.Right)
            {
                Label lbl = pic.Parent.Controls["lblTitle"] as Label;

                ChangeTitle ct = new ChangeTitle();
                ct.CurrentTitle = lbl.Text;

                if (ct.ShowDialog() == DialogResult.OK)
                {
                    lbl.Text = ct.GetNewTitle();
                }
            }

            SelectPic(pic);
        }

        private void SelectPic(PictureBox pic)
        {
            if (pic == clickedPic)
            {
                return;
            }

            if (clickedPic != null)
            {
                clickedPic.BorderStyle = BorderStyle.None;
            }

            pic.BorderStyle = BorderStyle.FixedSingle;
            clickedPic = pic;
            btnRemovePic.Enabled = true;
        }

        private void btnRemovePic_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Remove(clickedPic.Parent);
            clickedPic = null;
            btnRemovePic.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text files|*.txt";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sf.FileName))
                {
                    sw.Write(GetFilesForSaving());
                }
            }
        }

        private string GetFilesForSaving()
        {
            StringBuilder sb = new StringBuilder();

            foreach (FlowLayoutPanel pnl in flowLayoutPanel1.Controls)
            {
                Label lbl = GetControl<Label>(pnl);
                PictureBox pb = GetControl<PictureBox>(pnl);

                sb.Append(lbl.Text);
                sb.Append("|");
                sb.Append(pb.ImageLocation);
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

        private T GetControl<T>(Control parentControl)
        {
            foreach(var ctrl in parentControl.Controls)
            {
                if (ctrl is T)
                {
                    return (T)ctrl;
                }
            }

            return default(T);
        }
    }
}
