namespace MyDemo25
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
            this.components = new System.ComponentModel.Container();
            this.LV = new System.Windows.Forms.ListView();
            this.idCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sexCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sectionCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.joinTimeCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearBTN = new System.Windows.Forms.Button();
            this.PB = new System.Windows.Forms.ProgressBar();
            this.DelBTN = new System.Windows.Forms.Button();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.EditBTN = new System.Windows.Forms.Button();
            this.CB = new System.Windows.Forms.ComboBox();
            this.AddBTN = new System.Windows.Forms.Button();
            this.TBsection = new System.Windows.Forms.TextBox();
            this.TBphone = new System.Windows.Forms.TextBox();
            this.TBname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lookupBTN = new System.Windows.Forms.Button();
            this.TBlookup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LV
            // 
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCH,
            this.nameCH,
            this.sexCH,
            this.telCH,
            this.sectionCH,
            this.joinTimeCH});
            this.LV.FullRowSelect = true;
            this.LV.GridLines = true;
            this.LV.Location = new System.Drawing.Point(13, 13);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(631, 301);
            this.LV.TabIndex = 0;
            this.LV.UseCompatibleStateImageBehavior = false;
            this.LV.View = System.Windows.Forms.View.Details;
            this.LV.SelectedIndexChanged += new System.EventHandler(this.LV_SelectedIndexChanged);
            // 
            // idCH
            // 
            this.idCH.Text = "序号";
            // 
            // nameCH
            // 
            this.nameCH.Text = "姓名";
            this.nameCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameCH.Width = 114;
            // 
            // sexCH
            // 
            this.sexCH.Text = "性别";
            this.sexCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sexCH.Width = 49;
            // 
            // telCH
            // 
            this.telCH.Text = "电话";
            this.telCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.telCH.Width = 123;
            // 
            // sectionCH
            // 
            this.sectionCH.Text = "部门";
            this.sectionCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sectionCH.Width = 112;
            // 
            // joinTimeCH
            // 
            this.joinTimeCH.Text = "入职时间";
            this.joinTimeCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.joinTimeCH.Width = 126;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearBTN);
            this.groupBox1.Controls.Add(this.PB);
            this.groupBox1.Controls.Add(this.DelBTN);
            this.groupBox1.Controls.Add(this.DTP);
            this.groupBox1.Controls.Add(this.EditBTN);
            this.groupBox1.Controls.Add(this.CB);
            this.groupBox1.Controls.Add(this.AddBTN);
            this.groupBox1.Controls.Add(this.TBsection);
            this.groupBox1.Controls.Add(this.TBphone);
            this.groupBox1.Controls.Add(this.TBname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑操作";
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(255, 177);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(92, 32);
            this.clearBTN.TabIndex = 3;
            this.clearBTN.Text = "清空记录";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(103, 224);
            this.PB.Maximum = 5;
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(242, 23);
            this.PB.Step = 1;
            this.PB.TabIndex = 11;
            // 
            // DelBTN
            // 
            this.DelBTN.Location = new System.Drawing.Point(255, 128);
            this.DelBTN.Name = "DelBTN";
            this.DelBTN.Size = new System.Drawing.Size(92, 32);
            this.DelBTN.TabIndex = 2;
            this.DelBTN.Text = "删除选定行";
            this.DelBTN.UseVisualStyleBackColor = true;
            this.DelBTN.Click += new System.EventHandler(this.DelBTN_Click);
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(103, 185);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(150, 25);
            this.DTP.TabIndex = 10;
            // 
            // EditBTN
            // 
            this.EditBTN.Location = new System.Drawing.Point(255, 79);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(92, 32);
            this.EditBTN.TabIndex = 1;
            this.EditBTN.Text = "修 改";
            this.EditBTN.UseVisualStyleBackColor = true;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // CB
            // 
            this.CB.FormattingEnabled = true;
            this.CB.Items.AddRange(new object[] {
            "男",
            "女"});
            this.CB.Location = new System.Drawing.Point(103, 70);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(67, 23);
            this.CB.TabIndex = 9;
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(255, 30);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(92, 32);
            this.AddBTN.TabIndex = 0;
            this.AddBTN.Text = "新 增";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // TBsection
            // 
            this.TBsection.Location = new System.Drawing.Point(103, 146);
            this.TBsection.Name = "TBsection";
            this.TBsection.Size = new System.Drawing.Size(150, 25);
            this.TBsection.TabIndex = 8;
            // 
            // TBphone
            // 
            this.TBphone.Location = new System.Drawing.Point(103, 107);
            this.TBphone.Name = "TBphone";
            this.TBphone.Size = new System.Drawing.Size(150, 25);
            this.TBphone.TabIndex = 7;
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(103, 31);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(150, 25);
            this.TBname.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "信息完整度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "入职时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "部  门";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "电  话";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "性  别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓  名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lookupBTN);
            this.groupBox2.Controls.Add(this.TBlookup);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 594);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 68);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询";
            // 
            // lookupBTN
            // 
            this.lookupBTN.Location = new System.Drawing.Point(256, 20);
            this.lookupBTN.Name = "lookupBTN";
            this.lookupBTN.Size = new System.Drawing.Size(92, 32);
            this.lookupBTN.TabIndex = 2;
            this.lookupBTN.Text = "查 询";
            this.lookupBTN.UseVisualStyleBackColor = true;
            this.lookupBTN.Click += new System.EventHandler(this.lookupBTN_Click);
            // 
            // TBlookup
            // 
            this.TBlookup.Location = new System.Drawing.Point(79, 25);
            this.TBlookup.Name = "TBlookup";
            this.TBlookup.Size = new System.Drawing.Size(165, 25);
            this.TBlookup.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "姓  名";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.monthCalendar1);
            this.groupBox3.Location = new System.Drawing.Point(370, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 344);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "日历及提示";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 72);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(6, 31);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 677);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LV);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "职员信息登记";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.TextBox TBsection;
        private System.Windows.Forms.TextBox TBphone;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button DelBTN;
        private System.Windows.Forms.Button EditBTN;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button lookupBTN;
        private System.Windows.Forms.TextBox TBlookup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ColumnHeader idCH;
        private System.Windows.Forms.ColumnHeader nameCH;
        private System.Windows.Forms.ColumnHeader sexCH;
        private System.Windows.Forms.ColumnHeader telCH;
        private System.Windows.Forms.ColumnHeader sectionCH;
        private System.Windows.Forms.ColumnHeader joinTimeCH;
        private System.Windows.Forms.Timer timer1;
    }
}