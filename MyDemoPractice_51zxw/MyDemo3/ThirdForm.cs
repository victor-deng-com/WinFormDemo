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
    public partial class ThirdForm : Form
    {
        public ThirdForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("逗你玩的呢","哈哈哈真是无聊的程序");
            //想关闭所有窗体，只需要关闭主窗体即可
            //要获取当前打开的主窗体的实例，通过静态存储，全局共享解决
            Try.mainfrm1.Close();
        }
    }
}
