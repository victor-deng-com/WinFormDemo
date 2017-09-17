using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //在内存中创建SecondForm的一个实例
            SecondForm myfrm2 = new SecondForm();
            //展示窗口
            myfrm2.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Try.mainfrm1 = this;
        }
    }
}
