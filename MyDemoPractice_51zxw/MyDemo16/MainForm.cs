using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo16
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            int maxVal = 0;
            foreach (Form myForm in this.MdiChildren)
            {
                int index = Convert.ToInt32(myForm.Text.Substring(4,1));
                if (index > maxVal) { maxVal = index; }
            }

            RegForm myRF = new RegForm();
            myRF.MdiParent = this;
            myRF.BringToFront();
            myRF.Text = "登记信息" + Convert.ToString(maxVal+1);
            myRF.Show();
        }

        private void toolStripMenuItemHelp_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "欢迎使用本系统，使用前请先登录";
            toolStripStatusLabel2.Text = "作者的网站：victor-deng.com";
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
            menuStrip1.Visible = false;
            toolStrip1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pwd = textBox2.Text;
            if (name == "admin" && pwd == "admin")
            {
                MessageBox.Show("欢迎进入本系统", "登录成功");
                this.panel1.Visible = false;
                this.menuStrip1.Visible = true;
                toolStripStatusLabel1.Text = "欢迎您："+name;
                toolStripMenuItemShow.Enabled = true;
                toolStripMenuItemHide.Enabled = false;
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入","登录失败");
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void toolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            Form activeForm = this.ActiveMdiChild;
            activeForm.Close();
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("退出请注意保存好所有文件\n请确认是否退出，退出请点是，取消请点否","退出提示",MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripMenuItemCas_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItemHor_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripMenuItemVer_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripMenuItemShow_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            toolStripMenuItemShow.Enabled = false;
            toolStripMenuItemHide.Enabled = true;
        }

        private void toolStripMenuItemHide_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            toolStripMenuItemShow.Enabled = true;
            toolStripMenuItemHide.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int maxVal = 0;
            foreach (Form myForm in this.MdiChildren)
            {
                int index = Convert.ToInt32(myForm.Text.Substring(4, 1));
                if (index > maxVal) { maxVal = index; }
            }

            RegForm myRF = new RegForm();
            myRF.MdiParent = this;
            myRF.BringToFront();
            myRF.Text = "登记信息" + Convert.ToString(maxVal + 1);
            myRF.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form activeForm = this.ActiveMdiChild;
            activeForm.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("退出请注意保存好所有文件\n请确认是否退出，退出请点是，取消请点否", "退出提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("制作人：Victor");
        }
    }
}
