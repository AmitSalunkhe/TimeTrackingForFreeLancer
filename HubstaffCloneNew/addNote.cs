using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubstaffCloneNew
{
    public partial class addNote : Form
    {
        public addNote()
        {
            InitializeComponent();
            btnAddNote.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello i am Clicked");
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            if (txtNote.Text == "")
            {
                btnAddNote.Enabled = false;
            }
            else
            {
                btnAddNote.Enabled = true;
            }
        }
    }
}
