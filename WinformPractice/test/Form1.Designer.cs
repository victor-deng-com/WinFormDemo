namespace test
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_messageBox = new System.Windows.Forms.Panel();
            this.panel_messageBox_right = new System.Windows.Forms.Panel();
            this.tb_sendMessage = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_messageBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel_messageBox);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 502);
            this.panel1.TabIndex = 0;
            // 
            // panel_messageBox
            // 
            this.panel_messageBox.Controls.Add(this.panel_messageBox_right);
            this.panel_messageBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_messageBox.Location = new System.Drawing.Point(0, 386);
            this.panel_messageBox.Name = "panel_messageBox";
            this.panel_messageBox.Size = new System.Drawing.Size(715, 116);
            this.panel_messageBox.TabIndex = 0;
            // 
            // panel_messageBox_right
            // 
            this.panel_messageBox_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_messageBox_right.Location = new System.Drawing.Point(391, 0);
            this.panel_messageBox_right.Name = "panel_messageBox_right";
            this.panel_messageBox_right.Size = new System.Drawing.Size(324, 116);
            this.panel_messageBox_right.TabIndex = 0;
            // 
            // tb_sendMessage
            // 
            this.tb_sendMessage.Location = new System.Drawing.Point(13, 522);
            this.tb_sendMessage.Multiline = true;
            this.tb_sendMessage.Name = "tb_sendMessage";
            this.tb_sendMessage.Size = new System.Drawing.Size(569, 123);
            this.tb_sendMessage.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(588, 522);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(140, 123);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "发  送";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 657);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_sendMessage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel_messageBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_messageBox;
        private System.Windows.Forms.Panel panel_messageBox_right;
        private System.Windows.Forms.TextBox tb_sendMessage;
        private System.Windows.Forms.Button btn_send;
    }
}

