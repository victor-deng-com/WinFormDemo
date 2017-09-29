namespace Demo06_substringCount
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
            this.btn_count = new System.Windows.Forms.Button();
            this.tb_string = new System.Windows.Forms.TextBox();
            this.tb_substring = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_notice = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(265, 234);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(153, 56);
            this.btn_count.TabIndex = 0;
            this.btn_count.Text = "计算子串数";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // tb_string
            // 
            this.tb_string.Location = new System.Drawing.Point(131, 65);
            this.tb_string.Multiline = true;
            this.tb_string.Name = "tb_string";
            this.tb_string.Size = new System.Drawing.Size(287, 136);
            this.tb_string.TabIndex = 1;
            // 
            // tb_substring
            // 
            this.tb_substring.Location = new System.Drawing.Point(131, 263);
            this.tb_substring.Name = "tb_substring";
            this.tb_substring.Size = new System.Drawing.Size(128, 25);
            this.tb_substring.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "原字符串:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "包含的子串:";
            // 
            // label_notice
            // 
            this.label_notice.AutoSize = true;
            this.label_notice.Location = new System.Drawing.Point(132, 306);
            this.label_notice.Name = "label_notice";
            this.label_notice.Size = new System.Drawing.Size(97, 15);
            this.label_notice.TabIndex = 5;
            this.label_notice.Text = "含有子串数：";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(236, 306);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 15);
            this.label_result.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 356);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_notice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_substring);
            this.Controls.Add(this.tb_string);
            this.Controls.Add(this.btn_count);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.TextBox tb_string;
        private System.Windows.Forms.TextBox tb_substring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_notice;
        private System.Windows.Forms.Label label_result;
    }
}

