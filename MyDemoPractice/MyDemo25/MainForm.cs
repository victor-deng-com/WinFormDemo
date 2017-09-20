using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo25
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            ListViewItem myLVI = LV.Items.Add((LV.Items.Count+1).ToString());
            myLVI.SubItems.Add(TBname.Text);
            myLVI.SubItems.Add(CB.Text);
            myLVI.SubItems.Add(TBphone.Text);
            myLVI.SubItems.Add(TBsection.Text);
            myLVI.SubItems.Add(DTP.Value.ToString("yyyy年MM月dd日"));
            TBname.Clear();
            CB.Text = "";
            TBphone.Clear();
            TBsection.Clear();
            DTP.Value = DTP.MaxDate;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DTP.MaxDate = DateTime.Now;
            DTP.Value = DTP.MaxDate;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo25\banner\我要自学网.PNG");
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            if (LV.SelectedItems.Count > 0)
            {
                LV.SelectedItems[0].SubItems[1].Text = TBname.Text;
                LV.SelectedItems[0].SubItems[2].Text = CB.Text;
                LV.SelectedItems[0].SubItems[3].Text = TBphone.Text;
                LV.SelectedItems[0].SubItems[4].Text = TBsection.Text;
                LV.SelectedItems[0].SubItems[5].Text = DTP.Value.ToString("yyyy年MM月dd日");
            }
        }

        private void DelBTN_Click(object sender, EventArgs e)
        {
            if (LV.SelectedItems.Count>0)
            {
                LV.SelectedItems[0].Remove();
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            LV.Items.Clear();
        }

        string[] path = System.IO.Directory.GetFiles(@"D:\workspace\visual studio\Projects\Github_private\WinFormDemo\MyDemoPractice\MyDemo25\banner");
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(path[r.Next(0,path.Length)]);

            int num = 0;
            if (TBname.Text.Trim() != "") num++;
            if (CB.Text.Trim() != "") num++;
            if (TBphone.Text.Trim() != "") num++;
            if (TBsection.Text.Trim() != "") num++;
            if (DTP.Value != DTP.MaxDate) num++;
            PB.Value = num;
        }

        private void lookupBTN_Click(object sender, EventArgs e)
        {
            ListViewItem checkItem = LV.FindItemWithText(TBlookup.Text);
            if (checkItem != null)
            {
                this.LV.TopItem = checkItem;
                checkItem.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("未找到该姓名");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
