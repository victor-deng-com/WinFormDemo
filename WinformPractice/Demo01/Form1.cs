using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //用来存储音乐文件的全路径
        List<string> listSongs = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.InitialDirectory = @"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\WinformPractice\Demo01\Music";
            ofd.Multiselect = true;
            ofd.Filter = "音乐文件|*.wav|所有文件|*.*";
            ofd.ShowDialog();
            //获得在文件夹中选择所有文件的全路径
            string[] path=ofd.FileNames;
            for (int i=0;i<path.Length;i++)
            {
                //音乐文件的文件名加载到ListBox中
                listBox1.Items.Add(Path.GetFileName(path[i]));
                //将音乐文件的名字存到泛型变量中
                listSongs.Add(path[i]);
            }
        }

        SoundPlayer sp = new SoundPlayer();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            sp.SoundLocation = listSongs[listBox1.SelectedIndex];
            sp.Play();
        }

        //下一首
        private void button3_Click(object sender, EventArgs e)
        {
            //获取当前选中歌曲的索引
            int index = listBox1.SelectedIndex;
            index++;
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            //将改变后的索引重新赋值给单钱选中项的索引
            listBox1.SelectedIndex = index;

            sp.SoundLocation = listSongs[index];
            sp.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //获取当前选中歌曲的索引
            int index = listBox1.SelectedIndex;
            index--;
            if (index < 0)
            {
                index = listBox1.Items.Count-1;
            }
            //将改变后的索引重新赋值给单钱选中项的索引
            listBox1.SelectedIndex = index;

            sp.SoundLocation = listSongs[index];
            sp.Play();
        }
    }
}
