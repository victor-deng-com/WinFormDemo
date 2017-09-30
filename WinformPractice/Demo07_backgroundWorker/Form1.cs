using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo07_backgroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //打开backgroundWorker的两个重要属性
            backgroundWorkerExample.WorkerReportsProgress = true;
            backgroundWorkerExample.WorkerSupportsCancellation = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tb_log.Text = "以下是全部信息：\r\n";
            //在后台线程开始操作  
            backgroundWorkerExample.RunWorkerAsync();
        }


        #region 通信时接收到的信息结构
        public struct GetMessage
        {
            public string operation;
            public string buyer_id;
            public string buyer_name;
            public string message_id;
            public string message;
        }
        #endregion

        private void backgroundWorkerExample_DoWork(object sender, DoWorkEventArgs e)
        {
            //不要直接使用组件实例名称（backgroundWorker1),因为有多个BackgroundWorker时，  
            //直接使用会产生耦合问题，应该通过下面的转换使用它  
            BackgroundWorker worker = sender as BackgroundWorker;
            //下面的内容相当于线程要处理的内容。
            //注意：不要在此事件中和界面控件打交道，否则会报异常  
            //添加模拟数据
            List<GetMessage> buyers = new List<GetMessage>();
            buyers.Add(new GetMessage { operation = "buyer", buyer_id = "1", buyer_name = "张三", message_id = "1", message = "你好，请问你的商品库存还有多少？多少件以上包邮？价格能不能打个折？" });
            buyers.Add(new GetMessage { operation = "buyer", buyer_id = "2", buyer_name = "李四", message_id = "2", message = "你的商品做的不错，还有没有其他商品可推荐" });
            buyers.Add(new GetMessage { operation = "buyer", buyer_id = "3", buyer_name = "王五", message_id = "3", message = "你好，请问多少件以上包邮？你的商品库存还有多少？价格能不能打个折？" });

            worker.ReportProgress(0, buyers);

            e.Result = "呵呵";
        }

        //这里可以与界面控件打交道
        private void backgroundWorkerExample_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            List<GetMessage> getMessage = (List<GetMessage>)e.UserState;
            foreach (GetMessage message in getMessage)
            {
                if (message.operation == "buyer")
                {
                    Button putBuyer = new Button();
                    string buyerStr = "\r\n" + message.buyer_name + "：" + Environment.NewLine + message.message + "\r\n";
                    putBuyer.Text = buyerStr;
                    putBuyer.Dock = DockStyle.Bottom;
                    putBuyer.BackColor = Color.Aqua;
                    putBuyer.MaximumSize = new Size(panel1.Width, 9999);//要配合AutoSize=true使用，高自适应
                    putBuyer.AutoSize = true;

                    //日志文本框
                    tb_log.Text += buyerStr;

                    panel1.Controls.Add(putBuyer);
                }
            }
        }

        //线程结束时自动调用的结果返回，可用于线程异常结束的重启
        private void backgroundWorkerExample_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
                tb_log.Text += "\n\n操作停止，返回一个结果" + e.Result;
            else
                tb_log.Text += "\n操作过程中产生错误：" + e.Error;
        }
    }
}
