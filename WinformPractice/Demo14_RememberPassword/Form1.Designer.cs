namespace Demo14_RememberPassword
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
            this.cb_remember = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.cb_username = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_remember
            // 
            this.cb_remember.AutoSize = true;
            this.cb_remember.Location = new System.Drawing.Point(146, 217);
            this.cb_remember.Name = "cb_remember";
            this.cb_remember.Size = new System.Drawing.Size(89, 19);
            this.cb_remember.TabIndex = 0;
            this.cb_remember.Text = "记住密码";
            this.cb_remember.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(121, 257);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(128, 35);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "登  录";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(93, 158);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(192, 25);
            this.tb_password.TabIndex = 3;
            // 
            // cb_username
            // 
            this.cb_username.FormattingEnabled = true;
            this.cb_username.Location = new System.Drawing.Point(93, 98);
            this.cb_username.Name = "cb_username";
            this.cb_username.Size = new System.Drawing.Size(192, 23);
            this.cb_username.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 378);
            this.Controls.Add(this.cb_username);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.cb_remember);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_remember;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.ComboBox cb_username;
    }
}

