using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo08_JsonAndObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //通信时接收到的信息结构
        public struct GetMessage
        {
            public string operation;
            public string buyer_id;
            public string buyer_name;
            public string message_id;
            public string message;
        }

        private void btn_object_Click(object sender, EventArgs e)
        {
            GetMessage message = new GetMessage { operation = "buyer", buyer_id = "1", buyer_name = "张三", message_id = "1", message = "你好，请问你的商品库存还有多少？多少件以上包邮？价格能不能打个折？" };
            //对象转Json
            string str = JsonConvert.SerializeObject(message);
            tb_objectToJson.Text = str;
            //json转对象,GetMessage为要转换成的对象类型。
            GetMessage getMessage = JsonConvert.DeserializeObject<GetMessage>(str);
            tb_JsonToObject.Text = getMessage.ToString();

            tb_JsonToObject.Text +="\r\n"+getMessage.operation.ToString()+","+getMessage.buyer_name.ToString();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            //添加模拟数据
            List<GetMessage> buyers = new List<GetMessage>();
            buyers.Add(new GetMessage { operation = "buyer", buyer_id = "1", buyer_name = "张三", message_id = "1", message = "你好，请问你的商品库存还有多少？多少件以上包邮？价格能不能打个折？" });
            buyers.Add(new GetMessage { operation = "buyer", buyer_id = "2", buyer_name = "李四", message_id = "2", message = "你的商品做的不错，还有没有其他商品可推荐" });
            buyers.Add(new GetMessage { operation = "buyer", buyer_id = "3", buyer_name = "王五", message_id = "3", message = "你好，请问多少件以上包邮？你的商品库存还有多少？价格能不能打个折？" });
            //对象转Json
            string str = JsonConvert.SerializeObject(buyers);
            tb_ListToJson.Text = str;
            //json转对象
            List<GetMessage> getMessage = JsonConvert.DeserializeObject<List<GetMessage>>(str);
            tb_JsonToList.Text = getMessage.ToString() + "\r\n";
            foreach (GetMessage message in getMessage)
            {
                tb_JsonToList.Text += message.operation.ToString() + "," + message.buyer_name+"\r\n";
            }
        }


    }
}
