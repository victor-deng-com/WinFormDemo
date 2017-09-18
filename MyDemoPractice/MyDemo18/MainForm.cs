using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo18
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int i = 0;//图片索引参数
        //获取指定文件夹下所有文件的全路径
        public string[] path = Directory.GetFiles(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo18\Images\");
        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo18\Images\1.png");
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = path.Length-1;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i > path.Length-1)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }
    }
}
