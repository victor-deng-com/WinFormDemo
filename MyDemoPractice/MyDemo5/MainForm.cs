using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void redbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void bluebtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void btnls18_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("隶书",18);
        }

        private void btnls20_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("隶书", 20);
        }

        private void btnkt18_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("楷体", 18);
        }

        private void btnkt20_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("楷体", 20);
        }

        private void btnxmfh_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet=true;
        }

        private void btndw_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Gray;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("宋体",9);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionBackColor = Color.White;
        }
    }
}
