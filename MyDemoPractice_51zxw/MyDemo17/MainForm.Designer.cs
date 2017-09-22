namespace MyDemo17
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ZoomRadio = new System.Windows.Forms.RadioButton();
            this.CenterImageRadio = new System.Windows.Forms.RadioButton();
            this.AutoSizeRadio = new System.Windows.Forms.RadioButton();
            this.StretchImageRadio = new System.Windows.Forms.RadioButton();
            this.NormalRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "操作结果";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "原图";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyDemo17.Properties.Resources._0;
            this.pictureBox1.Location = new System.Drawing.Point(45, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 73);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyDemo17.Properties.Resources._0;
            this.pictureBox2.Location = new System.Drawing.Point(383, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 88);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ZoomRadio);
            this.groupBox1.Controls.Add(this.CenterImageRadio);
            this.groupBox1.Controls.Add(this.AutoSizeRadio);
            this.groupBox1.Controls.Add(this.StretchImageRadio);
            this.groupBox1.Controls.Add(this.NormalRadio);
            this.groupBox1.Location = new System.Drawing.Point(135, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SizeMode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "图片去适应控件，但图片宽高比不变";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "图片出于控件中心";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "控件调整大小去适应图片";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "图片调整大小去适应控件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "图片置于控件左上角，图片大于部分会被裁掉";
            // 
            // ZoomRadio
            // 
            this.ZoomRadio.AutoSize = true;
            this.ZoomRadio.Location = new System.Drawing.Point(30, 140);
            this.ZoomRadio.Name = "ZoomRadio";
            this.ZoomRadio.Size = new System.Drawing.Size(60, 19);
            this.ZoomRadio.TabIndex = 4;
            this.ZoomRadio.TabStop = true;
            this.ZoomRadio.Text = "Zoom";
            this.ZoomRadio.UseVisualStyleBackColor = true;
            this.ZoomRadio.CheckedChanged += new System.EventHandler(this.ZoomRadio_CheckedChanged);
            // 
            // CenterImageRadio
            // 
            this.CenterImageRadio.AutoSize = true;
            this.CenterImageRadio.Location = new System.Drawing.Point(30, 113);
            this.CenterImageRadio.Name = "CenterImageRadio";
            this.CenterImageRadio.Size = new System.Drawing.Size(116, 19);
            this.CenterImageRadio.TabIndex = 3;
            this.CenterImageRadio.TabStop = true;
            this.CenterImageRadio.Text = "CenterImage";
            this.CenterImageRadio.UseVisualStyleBackColor = true;
            this.CenterImageRadio.CheckedChanged += new System.EventHandler(this.CenterImageRadio_CheckedChanged);
            // 
            // AutoSizeRadio
            // 
            this.AutoSizeRadio.AutoSize = true;
            this.AutoSizeRadio.Location = new System.Drawing.Point(30, 86);
            this.AutoSizeRadio.Name = "AutoSizeRadio";
            this.AutoSizeRadio.Size = new System.Drawing.Size(92, 19);
            this.AutoSizeRadio.TabIndex = 2;
            this.AutoSizeRadio.TabStop = true;
            this.AutoSizeRadio.Text = "AutoSize";
            this.AutoSizeRadio.UseVisualStyleBackColor = true;
            this.AutoSizeRadio.CheckedChanged += new System.EventHandler(this.AutoSizeRadio_CheckedChanged);
            // 
            // StretchImageRadio
            // 
            this.StretchImageRadio.AutoSize = true;
            this.StretchImageRadio.Location = new System.Drawing.Point(30, 59);
            this.StretchImageRadio.Name = "StretchImageRadio";
            this.StretchImageRadio.Size = new System.Drawing.Size(124, 19);
            this.StretchImageRadio.TabIndex = 1;
            this.StretchImageRadio.TabStop = true;
            this.StretchImageRadio.Text = "StretchImage";
            this.StretchImageRadio.UseVisualStyleBackColor = true;
            this.StretchImageRadio.CheckedChanged += new System.EventHandler(this.StretchImageRadio_CheckedChanged);
            // 
            // NormalRadio
            // 
            this.NormalRadio.AutoSize = true;
            this.NormalRadio.Location = new System.Drawing.Point(30, 32);
            this.NormalRadio.Name = "NormalRadio";
            this.NormalRadio.Size = new System.Drawing.Size(76, 19);
            this.NormalRadio.TabIndex = 0;
            this.NormalRadio.TabStop = true;
            this.NormalRadio.Text = "Normal";
            this.NormalRadio.UseVisualStyleBackColor = true;
            this.NormalRadio.CheckedChanged += new System.EventHandler(this.NormalRadio_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "PictureBox实例";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton ZoomRadio;
        private System.Windows.Forms.RadioButton CenterImageRadio;
        private System.Windows.Forms.RadioButton AutoSizeRadio;
        private System.Windows.Forms.RadioButton StretchImageRadio;
        private System.Windows.Forms.RadioButton NormalRadio;
    }
}