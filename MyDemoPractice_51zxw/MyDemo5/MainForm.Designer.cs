namespace MyDemo5
{
    partial class MainForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bluebtn = new System.Windows.Forms.Button();
            this.redbtn = new System.Windows.Forms.Button();
            this.btnls18 = new System.Windows.Forms.Button();
            this.btnls20 = new System.Windows.Forms.Button();
            this.btnkt18 = new System.Windows.Forms.Button();
            this.btnkt20 = new System.Windows.Forms.Button();
            this.btnxmfh = new System.Windows.Forms.Button();
            this.btndw = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(517, 479);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(60, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "文本输入区（操作时请先选中文本）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(573, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "操作区";
            // 
            // bluebtn
            // 
            this.bluebtn.Location = new System.Drawing.Point(553, 67);
            this.bluebtn.Name = "bluebtn";
            this.bluebtn.Size = new System.Drawing.Size(100, 35);
            this.bluebtn.TabIndex = 3;
            this.bluebtn.Text = "蓝色";
            this.bluebtn.UseVisualStyleBackColor = true;
            this.bluebtn.Click += new System.EventHandler(this.bluebtn_Click);
            // 
            // redbtn
            // 
            this.redbtn.Location = new System.Drawing.Point(553, 119);
            this.redbtn.Name = "redbtn";
            this.redbtn.Size = new System.Drawing.Size(100, 35);
            this.redbtn.TabIndex = 4;
            this.redbtn.Text = "红色";
            this.redbtn.UseVisualStyleBackColor = true;
            this.redbtn.Click += new System.EventHandler(this.redbtn_Click);
            // 
            // btnls18
            // 
            this.btnls18.Location = new System.Drawing.Point(553, 171);
            this.btnls18.Name = "btnls18";
            this.btnls18.Size = new System.Drawing.Size(100, 35);
            this.btnls18.TabIndex = 5;
            this.btnls18.Text = "隶书 18";
            this.btnls18.UseVisualStyleBackColor = true;
            this.btnls18.Click += new System.EventHandler(this.btnls18_Click);
            // 
            // btnls20
            // 
            this.btnls20.Location = new System.Drawing.Point(553, 223);
            this.btnls20.Name = "btnls20";
            this.btnls20.Size = new System.Drawing.Size(100, 35);
            this.btnls20.TabIndex = 6;
            this.btnls20.Text = "隶书 20";
            this.btnls20.UseVisualStyleBackColor = true;
            this.btnls20.Click += new System.EventHandler(this.btnls20_Click);
            // 
            // btnkt18
            // 
            this.btnkt18.Location = new System.Drawing.Point(553, 275);
            this.btnkt18.Name = "btnkt18";
            this.btnkt18.Size = new System.Drawing.Size(100, 35);
            this.btnkt18.TabIndex = 7;
            this.btnkt18.Text = "楷体 18";
            this.btnkt18.UseVisualStyleBackColor = true;
            this.btnkt18.Click += new System.EventHandler(this.btnkt18_Click);
            // 
            // btnkt20
            // 
            this.btnkt20.Location = new System.Drawing.Point(553, 327);
            this.btnkt20.Name = "btnkt20";
            this.btnkt20.Size = new System.Drawing.Size(100, 35);
            this.btnkt20.TabIndex = 8;
            this.btnkt20.Text = "楷体 20";
            this.btnkt20.UseVisualStyleBackColor = true;
            this.btnkt20.Click += new System.EventHandler(this.btnkt20_Click);
            // 
            // btnxmfh
            // 
            this.btnxmfh.Location = new System.Drawing.Point(553, 379);
            this.btnxmfh.Name = "btnxmfh";
            this.btnxmfh.Size = new System.Drawing.Size(100, 35);
            this.btnxmfh.TabIndex = 9;
            this.btnxmfh.Text = "项目符号";
            this.btnxmfh.UseVisualStyleBackColor = true;
            this.btnxmfh.Click += new System.EventHandler(this.btnxmfh_Click);
            // 
            // btndw
            // 
            this.btndw.Location = new System.Drawing.Point(553, 431);
            this.btndw.Name = "btndw";
            this.btndw.Size = new System.Drawing.Size(100, 35);
            this.btndw.TabIndex = 10;
            this.btndw.Text = "底纹";
            this.btndw.UseVisualStyleBackColor = true;
            this.btndw.Click += new System.EventHandler(this.btndw_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(553, 483);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(100, 35);
            this.btnreset.TabIndex = 11;
            this.btnreset.Text = "复原";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 542);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btndw);
            this.Controls.Add(this.btnxmfh);
            this.Controls.Add(this.btnkt20);
            this.Controls.Add(this.btnkt18);
            this.Controls.Add(this.btnls20);
            this.Controls.Add(this.btnls18);
            this.Controls.Add(this.redbtn);
            this.Controls.Add(this.bluebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bluebtn;
        private System.Windows.Forms.Button redbtn;
        private System.Windows.Forms.Button btnls18;
        private System.Windows.Forms.Button btnls20;
        private System.Windows.Forms.Button btnkt18;
        private System.Windows.Forms.Button btnkt20;
        private System.Windows.Forms.Button btnxmfh;
        private System.Windows.Forms.Button btndw;
        private System.Windows.Forms.Button btnreset;
    }
}

