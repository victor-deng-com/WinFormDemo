namespace Demo03_SocketService
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
            this.TBserver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBport = new System.Windows.Forms.TextBox();
            this.TBlog = new System.Windows.Forms.TextBox();
            this.TBsendMessage = new System.Windows.Forms.TextBox();
            this.TBpath = new System.Windows.Forms.TextBox();
            this.BTNstart = new System.Windows.Forms.Button();
            this.BTNsendMessage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BTNchose = new System.Windows.Forms.Button();
            this.BTNsendFile = new System.Windows.Forms.Button();
            this.BTNstop = new System.Windows.Forms.Button();
            this.CBuserIP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TBserver
            // 
            this.TBserver.Location = new System.Drawing.Point(22, 42);
            this.TBserver.Name = "TBserver";
            this.TBserver.Size = new System.Drawing.Size(189, 25);
            this.TBserver.TabIndex = 0;
            this.TBserver.Text = "192.168.0.222";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "监听的IP地址（服务器IP）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口号";
            // 
            // TBport
            // 
            this.TBport.Location = new System.Drawing.Point(217, 42);
            this.TBport.Name = "TBport";
            this.TBport.Size = new System.Drawing.Size(52, 25);
            this.TBport.TabIndex = 3;
            this.TBport.Text = "8885";
            // 
            // TBlog
            // 
            this.TBlog.Enabled = false;
            this.TBlog.Location = new System.Drawing.Point(22, 87);
            this.TBlog.Multiline = true;
            this.TBlog.Name = "TBlog";
            this.TBlog.Size = new System.Drawing.Size(628, 137);
            this.TBlog.TabIndex = 4;
            // 
            // TBsendMessage
            // 
            this.TBsendMessage.Location = new System.Drawing.Point(22, 230);
            this.TBsendMessage.Multiline = true;
            this.TBsendMessage.Name = "TBsendMessage";
            this.TBsendMessage.Size = new System.Drawing.Size(524, 134);
            this.TBsendMessage.TabIndex = 5;
            // 
            // TBpath
            // 
            this.TBpath.Location = new System.Drawing.Point(22, 379);
            this.TBpath.Name = "TBpath";
            this.TBpath.Size = new System.Drawing.Size(319, 25);
            this.TBpath.TabIndex = 6;
            // 
            // BTNstart
            // 
            this.BTNstart.Location = new System.Drawing.Point(275, 40);
            this.BTNstart.Name = "BTNstart";
            this.BTNstart.Size = new System.Drawing.Size(88, 25);
            this.BTNstart.TabIndex = 7;
            this.BTNstart.Text = "开始监听";
            this.BTNstart.UseVisualStyleBackColor = true;
            this.BTNstart.Click += new System.EventHandler(this.BTNstart_Click);
            // 
            // BTNsendMessage
            // 
            this.BTNsendMessage.Location = new System.Drawing.Point(552, 230);
            this.BTNsendMessage.Name = "BTNsendMessage";
            this.BTNsendMessage.Size = new System.Drawing.Size(98, 61);
            this.BTNsendMessage.TabIndex = 8;
            this.BTNsendMessage.Text = "发  送";
            this.BTNsendMessage.UseVisualStyleBackColor = true;
            this.BTNsendMessage.Click += new System.EventHandler(this.BTNsendMessage_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(552, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 61);
            this.button3.TabIndex = 9;
            this.button3.Text = "震  动";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTNchose
            // 
            this.BTNchose.Location = new System.Drawing.Point(350, 372);
            this.BTNchose.Name = "BTNchose";
            this.BTNchose.Size = new System.Drawing.Size(95, 35);
            this.BTNchose.TabIndex = 10;
            this.BTNchose.Text = "选  择";
            this.BTNchose.UseVisualStyleBackColor = true;
            this.BTNchose.Click += new System.EventHandler(this.BTNchose_Click);
            // 
            // BTNsendFile
            // 
            this.BTNsendFile.Location = new System.Drawing.Point(451, 372);
            this.BTNsendFile.Name = "BTNsendFile";
            this.BTNsendFile.Size = new System.Drawing.Size(95, 35);
            this.BTNsendFile.TabIndex = 11;
            this.BTNsendFile.Text = "发送文件";
            this.BTNsendFile.UseVisualStyleBackColor = true;
            this.BTNsendFile.Click += new System.EventHandler(this.BTNsendFile_Click);
            // 
            // BTNstop
            // 
            this.BTNstop.Enabled = false;
            this.BTNstop.Location = new System.Drawing.Point(367, 40);
            this.BTNstop.Name = "BTNstop";
            this.BTNstop.Size = new System.Drawing.Size(89, 25);
            this.BTNstop.TabIndex = 12;
            this.BTNstop.Text = "暂停监听";
            this.BTNstop.UseVisualStyleBackColor = true;
            this.BTNstop.Click += new System.EventHandler(this.BTNstop_Click);
            // 
            // CBuserIP
            // 
            this.CBuserIP.FormattingEnabled = true;
            this.CBuserIP.Location = new System.Drawing.Point(474, 42);
            this.CBuserIP.Name = "CBuserIP";
            this.CBuserIP.Size = new System.Drawing.Size(176, 23);
            this.CBuserIP.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 419);
            this.Controls.Add(this.CBuserIP);
            this.Controls.Add(this.BTNstop);
            this.Controls.Add(this.BTNsendFile);
            this.Controls.Add(this.BTNchose);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTNsendMessage);
            this.Controls.Add(this.BTNstart);
            this.Controls.Add(this.TBpath);
            this.Controls.Add(this.TBsendMessage);
            this.Controls.Add(this.TBlog);
            this.Controls.Add(this.TBport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBserver);
            this.Name = "Form1";
            this.Text = "PC软件服务器监听程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBserver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBport;
        private System.Windows.Forms.TextBox TBlog;
        private System.Windows.Forms.TextBox TBsendMessage;
        private System.Windows.Forms.TextBox TBpath;
        private System.Windows.Forms.Button BTNstart;
        private System.Windows.Forms.Button BTNsendMessage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTNchose;
        private System.Windows.Forms.Button BTNsendFile;
        private System.Windows.Forms.Button BTNstop;
        private System.Windows.Forms.ComboBox CBuserIP;
    }
}

