using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo15
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //获取当前行的第一个字符所在的索引值
            int index = textBox1.GetFirstCharIndexOfCurrentLine();
            //获取行号
            int line = textBox1.GetLineFromCharIndex(index) + 1;
            //获取列数
            int column = textBox1.SelectionStart - index + 1;
            toolStripStatusLabel3.Text = "第" + line + "行，第" +column+ "列";
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //获取当前行的第一个字符所在的索引值
            int index = textBox1.GetFirstCharIndexOfCurrentLine();
            //获取行号
            int line = textBox1.GetLineFromCharIndex(index) + 1;
            //获取列数
            int column = textBox1.SelectionStart - index + 1;
            toolStripStatusLabel3.Text = "第" + line + "行，第" + column + "列";
        }
    }
}
