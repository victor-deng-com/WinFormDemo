using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo23
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 8 || textBox1.Text.Length > 10)
            {
                errorProvider1.SetError(textBox1, "用户名必须为8-12位");
                errorProvider1.Icon = new Icon(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo23\ico\error.ico");
            }
            else
            {
                errorProvider1.SetError(textBox1, "通过验证");
                errorProvider1.Icon = new Icon(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo23\ico\true.ico");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox2.Text)
            {
                errorProvider2.SetError(textBox3, "两次输入的密码不一致");
                errorProvider2.Icon = new Icon(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo23\ico\error.ico");
            }
            else
            {
                errorProvider2.SetError(textBox2, "通过验证");
                errorProvider2.SetError(textBox3, "通过验证");
                errorProvider2.Icon = new Icon(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo23\ico\true.ico");
            }
        }
    }
}
