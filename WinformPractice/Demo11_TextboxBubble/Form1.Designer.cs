namespace Demo11_TextboxBubble
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_page = new System.Windows.Forms.Panel();
            this.panel_message = new System.Windows.Forms.Panel();
            this.panel_messageBox = new System.Windows.Forms.Panel();
            this.panel_messageBox_right = new System.Windows.Forms.Panel();
            this.panel_message_bubble = new System.Windows.Forms.Panel();
            this.tb_putMessage = new System.Windows.Forms.TextBox();
            this.panel_bubble_point = new System.Windows.Forms.Panel();
            this.panel_messageBox_name = new System.Windows.Forms.Panel();
            this.tb_putName = new System.Windows.Forms.TextBox();
            this.tb_sendMessage = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.panel_page.SuspendLayout();
            this.panel_message.SuspendLayout();
            this.panel_messageBox.SuspendLayout();
            this.panel_messageBox_right.SuspendLayout();
            this.panel_message_bubble.SuspendLayout();
            this.panel_messageBox_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_page
            // 
            this.panel_page.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_page.Controls.Add(this.panel_message);
            this.panel_page.Location = new System.Drawing.Point(13, 13);
            this.panel_page.Name = "panel_page";
            this.panel_page.Size = new System.Drawing.Size(751, 538);
            this.panel_page.TabIndex = 0;
            // 
            // panel_message
            // 
            this.panel_message.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_message.Controls.Add(this.panel_messageBox);
            this.panel_message.Location = new System.Drawing.Point(3, 3);
            this.panel_message.Name = "panel_message";
            this.panel_message.Size = new System.Drawing.Size(714, 532);
            this.panel_message.TabIndex = 0;
            // 
            // panel_messageBox
            // 
            this.panel_messageBox.AutoSize = true;
            this.panel_messageBox.Controls.Add(this.panel_messageBox_right);
            this.panel_messageBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_messageBox.Location = new System.Drawing.Point(0, 439);
            this.panel_messageBox.Name = "panel_messageBox";
            this.panel_messageBox.Size = new System.Drawing.Size(714, 93);
            this.panel_messageBox.TabIndex = 0;
            // 
            // panel_messageBox_right
            // 
            this.panel_messageBox_right.AutoSize = true;
            this.panel_messageBox_right.Controls.Add(this.panel_message_bubble);
            this.panel_messageBox_right.Controls.Add(this.panel_bubble_point);
            this.panel_messageBox_right.Controls.Add(this.panel_messageBox_name);
            this.panel_messageBox_right.Location = new System.Drawing.Point(82, 4);
            this.panel_messageBox_right.Name = "panel_messageBox_right";
            this.panel_messageBox_right.Size = new System.Drawing.Size(629, 86);
            this.panel_messageBox_right.TabIndex = 0;
            // 
            // panel_message_bubble
            // 
            this.panel_message_bubble.AutoSize = true;
            this.panel_message_bubble.Controls.Add(this.tb_putMessage);
            this.panel_message_bubble.Location = new System.Drawing.Point(3, 53);
            this.panel_message_bubble.Name = "panel_message_bubble";
            this.panel_message_bubble.Size = new System.Drawing.Size(623, 29);
            this.panel_message_bubble.TabIndex = 2;
            // 
            // tb_putMessage
            // 
            this.tb_putMessage.Location = new System.Drawing.Point(3, 1);
            this.tb_putMessage.Multiline = true;
            this.tb_putMessage.Name = "tb_putMessage";
            this.tb_putMessage.Size = new System.Drawing.Size(617, 25);
            this.tb_putMessage.TabIndex = 0;
            // 
            // panel_bubble_point
            // 
            this.panel_bubble_point.AutoSize = true;
            this.panel_bubble_point.Location = new System.Drawing.Point(3, 38);
            this.panel_bubble_point.Name = "panel_bubble_point";
            this.panel_bubble_point.Size = new System.Drawing.Size(623, 18);
            this.panel_bubble_point.TabIndex = 1;
            // 
            // panel_messageBox_name
            // 
            this.panel_messageBox_name.AutoSize = true;
            this.panel_messageBox_name.Controls.Add(this.tb_putName);
            this.panel_messageBox_name.Location = new System.Drawing.Point(3, 1);
            this.panel_messageBox_name.Name = "panel_messageBox_name";
            this.panel_messageBox_name.Size = new System.Drawing.Size(623, 34);
            this.panel_messageBox_name.TabIndex = 0;
            // 
            // tb_putName
            // 
            this.tb_putName.Location = new System.Drawing.Point(3, 3);
            this.tb_putName.Name = "tb_putName";
            this.tb_putName.Size = new System.Drawing.Size(617, 25);
            this.tb_putName.TabIndex = 0;
            // 
            // tb_sendMessage
            // 
            this.tb_sendMessage.Location = new System.Drawing.Point(13, 558);
            this.tb_sendMessage.Multiline = true;
            this.tb_sendMessage.Name = "tb_sendMessage";
            this.tb_sendMessage.Size = new System.Drawing.Size(614, 122);
            this.tb_sendMessage.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(634, 558);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(130, 122);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "发  送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 692);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_sendMessage);
            this.Controls.Add(this.panel_page);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_page.ResumeLayout(false);
            this.panel_message.ResumeLayout(false);
            this.panel_message.PerformLayout();
            this.panel_messageBox.ResumeLayout(false);
            this.panel_messageBox.PerformLayout();
            this.panel_messageBox_right.ResumeLayout(false);
            this.panel_messageBox_right.PerformLayout();
            this.panel_message_bubble.ResumeLayout(false);
            this.panel_message_bubble.PerformLayout();
            this.panel_messageBox_name.ResumeLayout(false);
            this.panel_messageBox_name.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_page;
        private System.Windows.Forms.Panel panel_message;
        private System.Windows.Forms.Panel panel_messageBox;
        private System.Windows.Forms.Panel panel_messageBox_right;
        private System.Windows.Forms.Panel panel_message_bubble;
        private System.Windows.Forms.TextBox tb_putMessage;
        private System.Windows.Forms.Panel panel_bubble_point;
        private System.Windows.Forms.Panel panel_messageBox_name;
        private System.Windows.Forms.TextBox tb_putName;
        private System.Windows.Forms.TextBox tb_sendMessage;
        private System.Windows.Forms.Button btn_send;
    }
}

