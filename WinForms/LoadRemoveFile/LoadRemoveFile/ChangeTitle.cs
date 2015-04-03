using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadRemoveFile
{
    public partial class ChangeTitle : Form
    {
        public string CurrentTitle;

        public ChangeTitle()
        {
            InitializeComponent();
        }

        private void ChangeTitle_Load(object sender, EventArgs e)
        {
            txtTitle.Text = CurrentTitle;
        }

        public string GetNewTitle()
        {
            return txtTitle.Text;
        }
    }
}
