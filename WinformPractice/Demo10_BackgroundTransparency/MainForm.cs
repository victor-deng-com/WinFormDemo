using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo10_BackgroundTransparency
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Red;
            this.BackColor = Color.Red;
            //BackColor = Color.FromArgb(50, 40, 60, 82);
        }

        
    }
}
