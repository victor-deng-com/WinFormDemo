using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked||radioButton2.Checked)
            {
                string name = textBox1.Text;
                string pwd = textBox2.Text;
                if (name == "admin" && pwd == "admin" && radioButton1.Checked)
                {
                    MessageBox.Show("登录成功", "管理员账户");
                }
                else if (name == "guest" && pwd == "guest" && radioButton1.Checked)
                {
                    MessageBox.Show("登录成功", "来宾账号");
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入","错误提示");
                }
            }
            else
            {
                MessageBox.Show("请选择用户类型","错误提示");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        
    }
}
