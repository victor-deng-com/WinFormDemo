using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo16
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        string race;
        string web;
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control outctrl in panel1.Controls)
            {
                if (outctrl is RadioButton)
                {
                    if (((RadioButton)outctrl).Checked)
                    {
                        race = outctrl.Text;
                    }
                }
            }
            foreach (Control outctrl in panel2.Controls)
            {
                if (outctrl is RadioButton)
                {
                    if (((RadioButton)outctrl).Checked)
                    {
                        web = outctrl.Text;
                    }
                }
            }

            MessageBox.Show("你登记的信息是：\n姓名："+textBox1.Text+"\n单位："+textBox2.Text+"\n性别："+comboBox1.SelectedItem+"\n年龄："+numericUpDown1.Value+"\n种族："+race+"\n最常登陆的网站："+web,"\n感谢你的提交");
        }
    }
}
