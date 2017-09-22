using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo9
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] mystr = {"Java","PHP","C#" };
            for (int i=0;i<mystr.Length;i++)
            {
                comboBox1.Items.Add(mystr[i]);
                //listBox1.Items.Add(mystr[i]);
                //checkedListBox1.Items.Add(mystr[i]);
            }
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = comboBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = listBox1.SelectedItem.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = checkedListBox1.SelectedItem.ToString();
            label6.Text = "";
            foreach (string outstr in checkedListBox1.CheckedItems)
            {
                label6.Text += outstr + " ";
            }
        }
    }
}
