using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo22
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //label1.Text = dateTimePicker1.Value.Year.ToString();
            string tg = "甲乙丙丁戊己庚辛壬癸";
            string dz = "子丑寅卯辰巳午未申酉戌亥";
            string sx = "鼠牛虎兔龙蛇马羊猴鸡狗猪";
            int year= dateTimePicker1.Value.Year;
            label1.Text = "你选择的年农历："+tg[(year-4)%10]+dz[(year-4)%12]+"年，是"+ sx[(year-4)%12] + "年";
        }
    }
}
