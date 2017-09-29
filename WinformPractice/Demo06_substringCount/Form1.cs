using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo06_substringCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //子串计数主算法
        static int SubstringCount(string str, string substring)
        {
            if (str.Contains(substring))
            {
                string strReplaced = str.Replace(substring, "");
                return (str.Length - strReplaced.Length) / substring.Length;
            }
            return 0;
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            string str = tb_string.Text.ToString();
            string substring = tb_substring.Text.ToString();

            int count=SubstringCount(str,substring);
            label_result.Text = count.ToString();
        }
    }
}
