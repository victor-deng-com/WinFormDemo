using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo09_buttonShortcuts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Alt+*（一般控件快捷键）
        //设置Text属性,为该控件的Text属性声明时加上”(&A)”,”(&D)”的标识，则为Alt+A和Alt+D快捷键

        //Ctrl+*(快捷键)
        //添加menuStrip，然后添加一个ToolStripMenuItem选项，为这个选项添加快捷键。如果没找到想添加的快捷键，可在添加快捷键之后打开Form1.Designer.cs，例如：把前面添加的Keys.B 改成Keys.Enter就OK了
        //为该选项添加一个点击事件，这样当按下定义好的快捷键后就会执行该点击事件。
        //将menuStrip的Visible属性设置为false隐藏该菜单
        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //触发按钮事件
            btn_send.PerformClick();
        }

        
        //命名后会改变该属性
        private void btn_send_Click(object sender, EventArgs e)
        {
            tb_log.Text += "发送内容：" + tb_sendMessage.Text.ToString() + "\r\n";
        }
    }
}
