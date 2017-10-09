using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo11_TextboxBubble
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

        //private System.Windows.Forms.Panel panel_bubble_point;
        //private System.Windows.Forms.Panel panel_message_bubble;
        //private System.Windows.Forms.Panel panel_messageBox_right;
        //private System.Windows.Forms.TextBox tb_putMessage;
        //private System.Windows.Forms.Panel panel_messageBox;
        private void btn_send_Click(object sender, EventArgs e)
        {
            Label messageSize = new Label();
            messageSize.MaximumSize = new Size(panel_message.Width, 999);
            messageSize.AutoSize = true;
            messageSize.Text = tb_sendMessage.Text;
            // 
            // tb_putMessage
            // 
            TextBox tb_putMessage = new System.Windows.Forms.TextBox();
            tb_putMessage.Location = new System.Drawing.Point(3, 7);
            tb_putMessage.Multiline = true;
            tb_putMessage.Name = "tb_putMessage";
            //tb_putMessage.Dock = DockStyle.Right;
            tb_putMessage.Size = new Size(messageSize.Width, messageSize.Height);
            //tb_putMessage.AutoSize = true;
            tb_putMessage.MaximumSize = new Size(panel_message.Width, 999);
            tb_putMessage.TabIndex = 0;
            tb_putMessage.Text = tb_sendMessage.Text;
            //textBox转label
            tb_putMessage.ReadOnly = true;
            tb_putMessage.BorderStyle = 0;
            tb_putMessage.BackColor = this.BackColor;
            tb_putMessage.TabStop = false;
            // 
            // tb_putName
            // 
            TextBox tb_putName = new System.Windows.Forms.TextBox();
            tb_putName.Location = new System.Drawing.Point(3, 3);
            tb_putName.Name = "tb_putName";
            tb_putName.Size = new System.Drawing.Size(617, 25);
            tb_putName.TabIndex = 0;
            tb_putName.Text = "店小二 | " + DateTime.Now.ToString();
            //textBox转label
            tb_putName.ReadOnly = true;
            tb_putName.BorderStyle = 0;
            tb_putName.BackColor = this.BackColor;
            tb_putName.TabStop = false;
            // 
            // panel_messageBox_name
            // 
            Panel panel_messageBox_name = new System.Windows.Forms.Panel();
            panel_messageBox_name.SuspendLayout();
            panel_messageBox_name.AutoSize = true;
            panel_messageBox_name.Location = new System.Drawing.Point(3, 1);
            panel_messageBox_name.Name = "panel_messageBox_name";
            panel_messageBox_name.Size = new System.Drawing.Size(623, 34);
            panel_messageBox_name.TabIndex = 0;
            panel_messageBox_name.ResumeLayout(false);
            panel_messageBox_name.PerformLayout();
            panel_messageBox_name.Controls.Add(tb_putName);
            // 
            // panel_bubble_point
            // 
            Panel panel_bubble_point = new System.Windows.Forms.Panel();
            panel_bubble_point.AutoSize = true;
            panel_bubble_point.Location = new System.Drawing.Point(3, 40);
            panel_bubble_point.Name = "panel_bubble_point";
            panel_bubble_point.Size = new System.Drawing.Size(623, 32);
            panel_bubble_point.TabIndex = 1;
            // 
            // panel_message_bubble
            // 
            Panel panel_message_bubble = new System.Windows.Forms.Panel();
            panel_message_bubble.SuspendLayout();
            panel_message_bubble.AutoSize = true;
            panel_message_bubble.Controls.Add(tb_putMessage);
            panel_message_bubble.Location = new System.Drawing.Point(3, 71);
            panel_message_bubble.Name = "panel_message_bubble";
            panel_message_bubble.Size = new System.Drawing.Size(623, 38);
            panel_message_bubble.TabIndex = 2;
            panel_message_bubble.ResumeLayout(false);
            panel_message_bubble.PerformLayout();
            // 
            // panel_messageBox_right
            // 
            Panel panel_messageBox_right = new System.Windows.Forms.Panel();
            panel_messageBox_right.SuspendLayout();
            panel_messageBox_right.AutoSize = true;
            panel_messageBox_right.Location = new System.Drawing.Point(82, 4);
            panel_messageBox_right.Name = "panel_messageBox_right";
            panel_messageBox_right.Size = new System.Drawing.Size(629, 114);
            panel_messageBox_right.TabIndex = 0;
            panel_messageBox_right.ResumeLayout(false);
            panel_messageBox_right.PerformLayout();

            panel_messageBox_right.Controls.Add(panel_bubble_point);
            panel_messageBox_right.Controls.Add(panel_message_bubble);
            panel_messageBox_right.Controls.Add(panel_messageBox_name);
            // 
            // panel_messageBox
            // 
            Panel panel_messageBox = new System.Windows.Forms.Panel();
            panel_messageBox.SuspendLayout();
            panel_messageBox.AutoSize = true;
            panel_messageBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_messageBox.Location = new System.Drawing.Point(0, 411);
            panel_messageBox.Name = "panel_messageBox";
            panel_messageBox.Size = new System.Drawing.Size(714, 121);
            panel_messageBox.TabIndex = 0;
            panel_messageBox.ResumeLayout(false);
            panel_messageBox.PerformLayout();
            panel_messageBox.Controls.Add(panel_messageBox_right);

            panel_message.Controls.Add(panel_messageBox);

        }
    }
}
