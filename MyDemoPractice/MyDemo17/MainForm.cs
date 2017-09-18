using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo17
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void NormalRadio_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void StretchImageRadio_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void AutoSizeRadio_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void CenterImageRadio_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            label7.Visible = false;
        }

        private void ZoomRadio_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
