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

namespace Demo03_SocketService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNstart_Click(object sender, EventArgs e)
        {
            try
            {
                //当点击开始监听的时候，在服务器端创建一个负责监听IP地址跟端口号的socket
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(TBserver.Text);
                //创建端口对象
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(TBport.Text));
                //监听
                socketWatch.Bind(point);
                ShowMsg("监听成功");
                socketWatch.Listen(10);

                //按钮变化
                BTNstart.Enabled = false;
                BTNstop.Enabled = true;
                //开启新线程
                Thread th = new Thread(ListenClientConnect);
                th.IsBackground = true;
                th.Start(socketWatch);
            }
            catch
            {
                //异常日志
            }
        }

        Socket socketSend;
        //等待客户端的连接，并且创建与之通信用的Socket
        void ListenClientConnect(object oj)
        {
            Socket socketWatch = oj as Socket;
            //等待客户端的连接
            while (true)
            {
                try
                {
                    //接收socket通道
                    socketSend = socketWatch.Accept();
                    //将远程连接的客户端的IP 地址和Socket存入集合中
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    //将连接的IP地址和端口号存入下拉框中
                    CBuserIP.Items.Add(socketSend.RemoteEndPoint.ToString());
                    //提示连接成功
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");
                    //开启一个新线程不停地接收客户端发送过来的信息
                    Thread th = new Thread(Recive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
                catch
                {
                    //异常日志
                }
            }
        }

        //将远程连接的客户端的IP 地址和Socket存入集合中
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        //服务器端不停地接收客户端发送过来的消息
        void Recive(object oj)
        {
            Socket socketSend = oj as Socket;
            while (true)
            {
                try
                {
                    //客户端连接成功后，服务端应该接受客户端发来的信息2M
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    //实际接受到的有效字节数
                    int r = socketSend.Receive(buffer);
                    //用户下线则接收到的有效字节数为0
                    if (r == 0) { break; }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                }
                catch
                {
                    //异常日志
                }
            }
        }

        void ShowMsg(string str)
        {
            TBlog.AppendText(str + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        //服务器给客户端发送消息
        private void BTNsendMessage_Click(object sender, EventArgs e)
        {
            string str = TBsendMessage.Text;
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            //添加信息类型标记
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            //将泛型集合转换为数组
            byte[] newBuffer = list.ToArray();

            //socketSend.Send(buffer);
            //获得用户在下拉框中选中的IP地址
            string ip = CBuserIP.SelectedItem.ToString();
            dicSocket[ip].Send(newBuffer);
        }

        private void BTNchose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory= @"C:\Users\Administrator\Desktop";
            ofd.Title = "请选择要发送的文件";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();
            TBpath.Text = ofd.FileName;
        }

        private void BTNsendFile_Click(object sender, EventArgs e)
        {
            //获取要发送文件的路径
            string path = TBpath.Text;
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                //标记信息类型
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();

                dicSocket[CBuserIP.SelectedItem.ToString()].Send(newBuffer, 0,r+1,SocketFlags.None);
            }
        }

        //发送震动
        private void button3_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = 2;
            dicSocket[CBuserIP.SelectedItem.ToString()].Send(buffer);
        }
    }
}
