using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo12
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mystr = "";
            foreach (Control outctrl in groupBox1.Controls)
            {
                if (outctrl is RadioButton)
                {
                    if (((RadioButton)outctrl).Checked)
                    {
                        mystr = "你的性别是：" + outctrl.Text;
                    }
                }
            }
            foreach (Control outctrl in groupBox2.Controls)
            {
                if (outctrl is RadioButton)
                {
                    if (((RadioButton)outctrl).Checked)
                    {
                        mystr += "\n你的工作是：" + outctrl.Text;
                    }
                }
            }
            MessageBox.Show(mystr,"选择的结果");
        }
    }
}
