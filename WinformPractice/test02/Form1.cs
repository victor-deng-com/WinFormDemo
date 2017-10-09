using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Drawing2D;

namespace SplitButton_CustomStyle
{
    public partial class Form1 : MetroForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
            this.radioButton3.Checked = true;

        }

        #endregion

        CustomRenderer renderer = new CustomRenderer();

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //To set SplitButton custom style
            if (this.radioButton3.Checked)
            {
                this.splitButton1.Renderer = renderer;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //To set SplitButton default style
            if (this.radioButton1.Checked)
            {
                this.splitButton1.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Default;
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //To set SplitButton Metro style
            if (this.radioButton2.Checked)
            {
                this.splitButton1.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro;

            }
        }
    }

    public class CustomRenderer : ISplitButtonRenderer
    {
        #region Variables

        private SplitButton splitButton;
        private SolidBrush ArrowColorDefault;
        private Color color1 = ColorTranslator.FromHtml("#bbcee6");
        private Color color2 = ColorTranslator.FromHtml("#bbcee6");

        #endregion

        #region ISplitButtonRenderer Members

        public void DrawText(PaintEventArgs e, string text, Font font, Color color, int totalwidth, int totalheight, int splitwidth)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            StringFormat format = new StringFormat();
            format.Trimming = StringTrimming.EllipsisCharacter;
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Rectangle textArea = new Rectangle(7, 1, totalwidth - splitwidth, totalheight);
            e.Graphics.DrawString(text, font, brush, textArea, format);
            brush.Dispose();
        }

        public void DrawBorder(PaintEventArgs e, int width, int height, int splitwidth, Color outerColor, Color innerColor, Color arrowOuter, Color arrowInner, Color buttonInner)
        {
            // Can Customize the Border Color of the SplitButton 
            // Outer Color is Changed 
            Brush linearGradientBrush = new LinearGradientBrush(new Rectangle(0, 0, width, height), color1, color2, 90);
            e.Graphics.FillRectangle(linearGradientBrush, new Rectangle(0, 0, width, height));
            linearGradientBrush.Dispose();
            Pen outercolor = new Pen(ColorTranslator.FromHtml("#bbcee6"));
            Pen innercolor = new Pen(ColorTranslator.FromHtml("#bbcee6"));
            Pen arrowinner = new Pen(Color.Transparent);
            Pen arrowouter = new Pen(arrowOuter);
            Pen buttoninner = new Pen(buttonInner);

            e.Graphics.DrawLine(innercolor, new Point(1, 1), new Point(width - 2, 1));
            e.Graphics.DrawLine(innercolor, new Point(width - 2, 1), new Point(width - 2, height - 2));
            e.Graphics.DrawLine(innercolor, new Point(1, height - 2), new Point(width - 2, height - 2));
            e.Graphics.DrawLine(innercolor, new Point(1, 1), new Point(1, height - 2));

            e.Graphics.DrawLine(arrowouter, new Point(width - splitwidth, 0), new Point(width - splitwidth, height - 1));

            e.Graphics.DrawLine(buttoninner, new Point(width - splitwidth - 1, 2), new Point(width - splitwidth - 1, height - 3));

            e.Graphics.DrawRectangle(arrowinner, width - splitwidth + 1, 1, splitwidth - 3, height - 3);

            e.Graphics.DrawLine(outercolor, new Point(1, 0), new Point(width - 2, 0));
            e.Graphics.DrawLine(outercolor, new Point(width - 2, 0), new Point(width - 2, 1));
            e.Graphics.DrawLine(outercolor, new Point(width - 1, 1), new Point(width - 1, height - 2));
            e.Graphics.DrawLine(outercolor, new Point(width - 2, height - 2), new Point(width - 2, height - 1));
            e.Graphics.DrawLine(outercolor, new Point(1, height - 1), new Point(width - 2, height - 1));
            e.Graphics.DrawLine(outercolor, new Point(1, height - 1), new Point(1, height - 2));
            e.Graphics.DrawLine(outercolor, new Point(0, 1), new Point(0, height - 2));
            e.Graphics.DrawLine(outercolor, new Point(1, 0), new Point(1, 1));


            buttoninner.Dispose();
            innercolor.Dispose();
            arrowinner.Dispose();
            arrowinner.Dispose();
            outercolor.Dispose();

        }

        public void DrawArrow(int left, int top, int width, int height, PaintEventArgs e, Color ArrowColor)
        {
            int StartPoint = left + 5;
            int EndPoint = StartPoint + width / 2;
            int HeightPoint = height;
            int TopPoint = height / 2 - 6;
            ArrowColorDefault = new SolidBrush(Color.Red);
            e.Graphics.FillPolygon(ArrowColorDefault, new Point[] { new Point(StartPoint, TopPoint ), new Point(StartPoint, TopPoint + 12 ),
                                                         new Point(StartPoint + 7 , TopPoint  + 6) });
        }

        #endregion

        #region ISplitButtonRenderer Members

        public SplitButton SplitButton
        {
            get
            {
                return splitButton;
            }
            set
            {
                splitButton = value;
            }
        }

        #endregion
    }

}
