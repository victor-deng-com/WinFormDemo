using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo15_ComboBoxWithBorder
{
    public partial class Form1 : Form
    {
        public SolidBrush ArrowColorDefault { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox1.BorderColor = Color.Blue;
            //comboBox1.DropDow
            //comboBox1.BorderStyle = ButtonBorderStyle.None;
            //comboBox1.DropDownStyle = ComboBoxStyle.Simple;
            //comboBox1.DropDownStyle = ComboBoxStyle;

            DrawArrow(10,10,100,20, comboBox1, Color.Blue);

        }

        private void DrawArrow(int v1, int v2, int v3, int v4, ComboBoxWithBorder comboBox1, Color blue)
        {
            throw new NotImplementedException();
        }

        public void DrawArrow(int left, int top, int width, int height, PaintEventArgs e, Color ArrowColor)
        {
            int StartPoint = left + 5;
            int EndPoint = StartPoint + width / 2;
            int HeightPoint = height;
            int TopPoint = height / 2 - 6;
            ArrowColorDefault = new SolidBrush(Color.Red);
            e.Graphics.FillPolygon(ArrowColorDefault, new Point[] { new Point(StartPoint, TopPoint), new Point(StartPoint, TopPoint + 12), new Point(StartPoint + 7, TopPoint + 6) });
        }




    }
}
