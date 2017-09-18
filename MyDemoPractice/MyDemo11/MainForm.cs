using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo11
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void routineBTN_Click(object sender, EventArgs e)
        {
            RoutineForm myRF = new RoutineForm();
            myRF.TopLevel = false;
            myRF.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(myRF);
            myRF.BringToFront();
            myRF.Show();
        }

        private void downloadBTN_Click(object sender, EventArgs e)
        {
            DownloadForm myDF = new DownloadForm();
            myDF.TopLevel = false;
            myDF.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(myDF);
            myDF.BringToFront();
            myDF.Show();
        }

        private void exteriorBTN_Click(object sender, EventArgs e)
        {
            ExteriorForm myEF = new ExteriorForm();
            myEF.TopLevel = false;
            myEF.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(myEF);
            myEF.BringToFront();
            myEF.Show();
        }

        private void remoteBTN_Click(object sender, EventArgs e)
        {
            RemoteForm myRF = new RemoteForm();
            myRF.TopLevel = false;
            myRF.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(myRF);
            myRF.BringToFront();
            myRF.Show();
        }
    }
}
