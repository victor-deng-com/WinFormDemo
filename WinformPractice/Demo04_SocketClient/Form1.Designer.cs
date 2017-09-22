namespace Demo04_SocketClient
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
            this.BTNconnect = new System.Windows.Forms.Button();
            this.BTNsend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBservice = new System.Windows.Forms.TextBox();
            this.TBpoint = new System.Windows.Forms.TextBox();
            this.TBlog = new System.Windows.Forms.TextBox();
            this.TBsendMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNconnect
            // 
            this.BTNconnect.Location = new System.Drawing.Point(378, 51);
            this.BTNconnect.Name = "BTNconnect";
            this.BTNconnect.Size = new System.Drawing.Size(78, 25);
            this.BTNconnect.TabIndex = 0;
            this.BTNconnect.Text = "连接";
            this.BTNconnect.UseVisualStyleBackColor = true;
            this.BTNconnect.Click += new System.EventHandler(this.BTNconnect_Click);
            // 
            // BTNsend
            // 
            this.BTNsend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTNsend.Location = new System.Drawing.Point(544, 275);
            this.BTNsend.Name = "BTNsend";
            this.BTNsend.Size = new System.Drawing.Size(104, 120);
            this.BTNsend.TabIndex = 1;
            this.BTNsend.Text = "发  送";
            this.BTNsend.UseVisualStyleBackColor = true;
            this.BTNsend.Click += new System.EventHandler(this.BTNsend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "服务器IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "服务器端口";
            // 
            // TBservice
            // 
            this.TBservice.Location = new System.Drawing.Point(30, 51);
            this.TBservice.Name = "TBservice";
            this.TBservice.Size = new System.Drawing.Size(204, 25);
            this.TBservice.TabIndex = 4;
            this.TBservice.Text = "192.168.0.222";
            // 
            // TBpoint
            // 
            this.TBpoint.Location = new System.Drawing.Point(254, 51);
            this.TBpoint.Name = "TBpoint";
            this.TBpoint.Size = new System.Drawing.Size(100, 25);
            this.TBpoint.TabIndex = 5;
            this.TBpoint.Text = "8885";
            // 
            // TBlog
            // 
            this.TBlog.Enabled = false;
            this.TBlog.Location = new System.Drawing.Point(27, 94);
            this.TBlog.Multiline = true;
            this.TBlog.Name = "TBlog";
            this.TBlog.Size = new System.Drawing.Size(621, 164);
            this.TBlog.TabIndex = 6;
            // 
            // TBsendMessage
            // 
            this.TBsendMessage.Location = new System.Drawing.Point(27, 275);
            this.TBsendMessage.Multiline = true;
            this.TBsendMessage.Name = "TBsendMessage";
            this.TBsendMessage.Size = new System.Drawing.Size(508, 120);
            this.TBsendMessage.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 416);
            this.Controls.Add(this.TBsendMessage);
            this.Controls.Add(this.TBlog);
            this.Controls.Add(this.TBpoint);
            this.Controls.Add(this.TBservice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNsend);
            this.Controls.Add(this.BTNconnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNconnect;
        private System.Windows.Forms.Button BTNsend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBservice;
        private System.Windows.Forms.TextBox TBpoint;
        private System.Windows.Forms.TextBox TBlog;
        private System.Windows.Forms.TextBox TBsendMessage;
    }
}

