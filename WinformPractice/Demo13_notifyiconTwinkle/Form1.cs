using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo13_notifyiconTwinkle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Icon blank = Properties.Resources.blank;
        private Icon normal = Properties.Resources.logo;
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            notifyIcon.ShowBalloonTip(1000, "新信息提醒", "你有x条信息未处理", ToolTipIcon.None);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (notifyIcon.Icon != normal)
                notifyIcon.Icon = normal;
            else
                notifyIcon.Icon = blank;
        }
    }
}
