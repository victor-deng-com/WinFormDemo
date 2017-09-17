using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox3.Checked)
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    }
                    else
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic);
                    }
                }
                else
                {
                    if (checkBox3.Checked)
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Underline);
                    }
                    else
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                    }
                }
            }
            else
            {
                if (checkBox2.Checked)
                {
                    if (checkBox3.Checked)
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Italic | FontStyle.Underline);
                    }
                    else
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
                    }
                }
                else
                {
                    if (checkBox3.Checked)
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
                    }
                    else
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                    }
                }
            }
            //Font font = new Font(textBox1.Font, FontStyle.Regular);
            //if (checkBox1.Checked)
            //{
            //    textBox1.Font = font(textBox1.Font,FontStyle.Bold);
            //}
            //if (checkBox2.Checked)
            //{
            //    textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            //}
            //if (checkBox3.Checked)
            //{
            //    textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            //}
        }
    }
}
