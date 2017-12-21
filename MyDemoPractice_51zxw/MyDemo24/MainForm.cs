﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo24
{
    public partial class MainForm : Form
    {
        public void outlog(string str)
        {
            textBox2.AppendText(DateTime.Now.ToString()+str+"\n");
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public int num;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < num)
            {
                timer1.Stop();
            }

            //progressBar1.PerformStep();
            if (progressBar1.Value > progressBar1.Minimum)
            {
                progressBar1.PerformStep();
                outlog("倒计时正在工作，已完成工作"+ ((1-Convert.ToDouble(progressBar1.Value)/ Convert.ToDouble(progressBar1.Maximum))*100).ToString()+"%");
            }
            else
            {
                outlog("进度已完成");
                timer1.Stop();
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //progressBar1.Value = 50;
            //progressBar1.Increment(30);

            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() != "")
                {
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = Convert.ToInt32(textBox1.Text);
                    progressBar1.Step = -1;
                    progressBar1.Value = progressBar1.Maximum;
                    button1.Enabled = false;
                    button2.Enabled = true;
                    //textBox2.AppendText(DateTime.Now.ToString()+"时间设置正确，请按开始键继续\n");
                    outlog("时间正确设置，请按开始键继续");
                }
            }
            catch
            {
                MessageBox.Show("请输入正确的秒数（必须为整数）","错误的输入");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                outlog("进度已经被暂停");
                button3.Text = "继续";
                timer1.Stop();
            }
            else
            {
                outlog("进度条继续工作");
                button3.Text = "暂停";
                timer1.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            outlog("倒计时停止工作");
            outlog("=============================");
            timer1.Enabled=false;
            progressBar1.Value = 0;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button3.Text = "暂停";
        }
    }
}
