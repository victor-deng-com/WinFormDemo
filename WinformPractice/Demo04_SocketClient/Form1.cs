using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo04_SocketClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket socketSend;
        private void BTNconnect_Click(object sender, EventArgs e)
        {
            try
            {
                //负责通信的socket
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //获取要连接的远程服务器应用程序的IP地址和端口号
                IPAddress ip = IPAddress.Parse(TBservice.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(TBpoint.Text));

                socketSend.Connect(point);
                ShowMsg("连接成功");
                //开启一个新的线程不停地接收服务端发来的消息
                Thread th = new Thread(ReciveService);
                th.IsBackground = true;
                th.Start();
            }
            catch
            {
                //错误日志
            }
        }

        //不停地接收服务器发来的消息
        void ReciveService()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    //实际接收到的字节数
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    //获取标记
                    if (buffer[0] == 0)
                    {
                        string s = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        ShowMsg(socketSend.RemoteEndPoint + ":" + s);
                    }
                    else if (buffer[0] == 1)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.InitialDirectory = @"C:\Users\Gary\Desktop";
                        sfd.Title = "请选择要保存的文件";
                        sfd.Filter = "所有问价|*.*";
                        sfd.ShowDialog(this);//少this则不会弹出保存框
                        string path = sfd.FileName;
                        using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fsWrite.Write(buffer,1,r-1);
                        }
                        MessageBox.Show("保存成功");
                    }
                    else if (buffer[0] == 2)
                    {
                        shock();
                    }
                }
                catch
                {
                    //错误日志
                }
            }
        }

        //震动
        void shock()
        {
            for (int i = 0; i < 100; i++)
            {
                this.Location = new Point(200, 200);
                this.Location = new Point(280, 280);
            }
        }

        void ShowMsg(string str)
        {
            TBlog.AppendText(str + "\r\n");
        }

        private void BTNsend_Click(object sender, EventArgs e)
        {
            string str = TBsendMessage.Text.Trim();
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            socketSend.Send(buffer);
            TBsendMessage.Clear();
            TBsendMessage.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
