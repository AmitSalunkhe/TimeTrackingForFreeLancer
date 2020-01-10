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
    public partial class LFHubstaff_home : Form
    {
        bool sizecall, timer;
        string a;

        public LFHubstaff_home()
        {
            InitializeComponent();
            sizecall = timer = false;
           // btnAddNote.Enabled = false;
            this.Size = new Size(364, 742);
            this.StartPosition = new FormStartPosition();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picPlayStop_Click(object sender, EventArgs e)
        {
            if (sizecall == true)
            { 
                this.Size = new Size(949,742);
                picPlayStop.Image = Image.FromFile("../Images/back-30.png");
                sizecall = false;
            }
            else
            {
                this.Size = new Size(364,742);
                picPlayStop.Image = Image.FromFile("../Images/forward-30.png");
                sizecall = true;
            }

        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if(btnAddNote.Enabled)
            {
                addNote an = new addNote();
            }
            else
            {
                MessageBox.Show("Please Start Project First!!!");
            }
        }

        private void btnPlayStop_Click(object sender, EventArgs e)
        {
            if (timer == true)
            {
                MessageBox.Show("Timer Stopped");
                btnPlayStop.Image = Image.FromFile("../Images/play-50.png");
                btnAddNote.Enabled = false;
                timer = false;
            }
            else
            {
                MessageBox.Show("Timer Started");
                btnPlayStop.Image = Image.FromFile("../Images/stop-50.png");
                btnAddNote.Enabled = true;
                timer = true;
            }
        }
    }
}
