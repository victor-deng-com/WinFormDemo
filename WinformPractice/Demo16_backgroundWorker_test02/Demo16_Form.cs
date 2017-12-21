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

namespace Demo16_backgroundWorker_test02
{
    public partial class Demo16_Form : Form
    {
        public Demo16_Form()
        {
            InitializeComponent();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            btn_stop.Enabled = false;
        }

        private void Demo16_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //不要直接使用组件实例名称（backgroundWorker1),因为有多个BackgroundWorker时，  
            //直接使用会产生耦合问题，应该通过下面的转换使用它  
            BackgroundWorker worker = sender as BackgroundWorker;
            //下面的内容相当于线程要处理的内容。//注意：不要在此事件中和界面控件打交道  
            Random r = new Random();
            int numCount = 0;
            while (worker.CancellationPending == false)
            {
                int num = r.Next(0, 10000);
                if (num % 5 == 0)
                {
                    numCount++;
                    worker.ReportProgress(0, num);
                    Thread.Sleep(1000);
                }
            }
            e.Result = numCount;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int num = (int)e.UserState;
            tb_log.Text += num + " ";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
                tb_log.Text += "\n\n操作停止，共生产" + e.Result + "个能被5整除的随机数";
            else
                tb_log.Text += "\n操作过程中产生错误：" + e.Error;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            tb_log.Text = "开始产生10000以内的随机数……\n\n";
            btn_start.Enabled = false;
            btn_stop.Enabled = true;
            //在后台线程开始操作  
            backgroundWorker.RunWorkerAsync();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
            btn_stop.Enabled = false;
            btn_start.Enabled = true;
        }
    }
}
