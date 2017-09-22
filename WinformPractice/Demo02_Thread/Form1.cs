using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo02_Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool b = false;
        private void button1_Click(object sender, EventArgs e)
        {
            //后台线程
            //如果线程执行的方法需要参数，那么要求这个参数必须是object类型
            //Thread th = new Thread(PlayGame);
            //th.IsBackground = true;
            //th.Start("123");//线程传递的参数在此传递

            if (b == false)
            {
                b = true;
                button1.Text = "停止";
            }
            else
            {
                b = false;
                button1.Text = "开始";
            }
            //PlayGame();
            Thread th = new Thread(PlayGame);
            th.IsBackground = true;
            th.Start();
        }

        private void PlayGame()
        {
            Random r = new Random();
            while (b)
            {
                label1.Text = r.Next(0,10).ToString();
                label2.Text = r.Next(0, 10).ToString();
                label3.Text = r.Next(0, 10).ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //不检查线程间是否有调用
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
