using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo05_dynamicAddButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addButton();
        }

        public void addButton()
        {
            for (int i = 0; i < 5; i++)
            {
                Button btn = new Button();
                btn.Name = i.ToString();
                btn.Text = "点击事件";
                btn.Location = new Point(20,30+i*30);
                
                btn.Click += new System.EventHandler(this.btnClick);
                this.groupBox1.Controls.Add(btn);
            }
        }
        //点击事件
        private void btnClick(object sender,EventArgs e)
        {
            MessageBox.Show(((Button)sender).Name.ToString());
        }
    }
}
