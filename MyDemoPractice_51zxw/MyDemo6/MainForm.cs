using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MyDemo6
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("定时弹出框");
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
            
            ////定时播放音乐
            //SoundPlayer sp = new SoundPlayer();
            //sp.SoundLocation = @"路径";
            //if (DateTime.Now.Hour == 10 && DateTime.Now.Minute == 35 && DateTime.Now.Second == 0)
            //{
            //    sp.Play();//单次播放
            //    sp.PlayLooping();//循环播放
            //}
            //if (DateTime.Now.Hour == 10 && DateTime.Now.Minute == 35 && DateTime.Now.Second == 0)
            //{
            //    sp.Stop();//停止播放
            //}

            //计时功能
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public int t = 0;
        public string GetTimeFormat(int t)
        {
            string hh, mm, ss, mms;
            int temp=t/100;//获取以秒为单位总秒数
            int ms = t % 100;
            int h = temp / 3600;
            int m = temp / 60 % 60;
            int s = temp % 60;
            if (ms < 10) { mms = "0" + ms.ToString(); } else { mms = ms.ToString(); }
            if (h < 10) { hh = "0" + h.ToString(); } else { hh = h.ToString(); }
            if (m < 10) { mm = "0" + m.ToString(); } else { mm = m.ToString(); }
            if (s < 10) { ss = "0" + s.ToString(); } else { ss = s.ToString(); }
            return hh + "：" + mm + "：" + ss + "." + ms;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            t++;
            label3.Text = GetTimeFormat(t);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer3.Enabled)
            {
                timer3.Stop();
                button1.Text = "开始计时";
                button2.Enabled = true;
            }
            else
            {
                timer3.Start();
                button1.Text = "停止计时";
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = GetTimeFormat(0);
        }
    }
}
