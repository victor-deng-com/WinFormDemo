using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo19
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //初始化imageList1
            int count = imageList1.Images.Count;
            for (int i=0;i< count; i++)
            {
                imageList1.Images.RemoveAt(count-1-i);
            }

            //声明了图像变量
            Image img1 = Image.FromFile(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo19\Imagelist\1.PNG");
            Image img2 = Image.FromFile(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo19\Imagelist\2.PNG");
            Image img3 = Image.FromFile(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo19\Imagelist\3.PNG");
            Image img4 = Image.FromFile(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo19\Imagelist\4.PNG");
            Image img5 = Image.FromFile(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo19\Imagelist\5.PNG");
            Image img6 = Image.FromFile(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo19\Imagelist\6.PNG");

            //imageList控件添加元素的第1种方法
            //imageList1.Images.Add(img1);
            //imageList控件添加元素的第2种方法
            //imageList1.Images.AddRange(new Image[] { img1,img2,img3,img4,img5,img6});
            //imageList控件添加元素的第3种方法
            imageList1.Images.AddStrip(img1);
            imageList1.Images.AddStrip(img2);
            imageList1.Images.AddStrip(img3);
            imageList1.Images.AddStrip(img4);
            imageList1.Images.AddStrip(img5);
            imageList1.Images.AddStrip(img6);

            //创建了一个窗口句柄
            Graphics mygph = Graphics.FromHwnd(this.Handle);
            for (int i=0;i<imageList1.Images.Count;i++)
            {
                imageList1.Draw(mygph, new Point(50, 50), i);
                button1.Enabled = false;
                button2.Enabled = false;
                System.Threading.Thread.Sleep(500);
            }
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //初始化imageList1
            int count = imageList1.Images.Count;
            for (int i = 0; i < count; i++)
            {
                imageList1.Images.RemoveAt(count - 1 - i);
            }

            Image img1 = Image.FromFile(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo19\Imagelist\1.PNG");
            Image img2 = Image.FromFile(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo19\Imagelist\2.PNG");
            imageList1.Images.AddRange(new Image[] { img1, img2});
            Graphics mygph = Graphics.FromHwnd(this.Handle);
            for (int i = 0; i < 2; i++)
            {
                //Draw有三种重载方式
                //1.（graphics对象名，左上角点坐标，索引值）
                //2.（graphics对象名，水平坐标，垂直坐标，索引值）
                //3.（graphics对象名，水平坐标，垂直坐标，图像宽度，图像高度，索引值）
                imageList1.Draw(mygph, new Point(50, 50), i);
                button1.Enabled = false;
                button2.Enabled = false;
                System.Threading.Thread.Sleep(500);
            }
            button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}
