using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你追到了我，我就让你嘿嘿嘿");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width - label1.Width;
            int y = this.ClientSize.Height - label1.Height;
            Random r = new Random();
            //MessageBox.Show((r.Next(0,5)).ToString());
            label1.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
        }
    }
}
