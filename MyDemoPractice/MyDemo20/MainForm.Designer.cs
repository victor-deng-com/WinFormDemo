namespace MyDemo20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEngName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCapital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LargeIL = new System.Windows.Forms.ImageList(this.components);
            this.smallIL = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chEngName,
            this.chCountry,
            this.chCapital});
            this.listView1.LargeImageList = this.LargeIL;
            this.listView1.Location = new System.Drawing.Point(12, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(720, 446);
            this.listView1.SmallImageList = this.smallIL;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "序号";
            this.chID.Width = 93;
            // 
            // chEngName
            // 
            this.chEngName.Text = "英文名";
            this.chEngName.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(245, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "查看方式";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "LargeIcon",
            "SmallIcon",
            "List",
            "Details",
            "Tile"});
            this.comboBox1.Location = new System.Drawing.Point(360, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 26);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chCountry
            // 
            this.chCountry.Text = "国家";
            this.chCountry.Width = 172;
            // 
            // chCapital
            // 
            this.chCapital.Text = "首都";
            this.chCapital.Width = 212;
            // 
            // LargeIL
            // 
            this.LargeIL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeIL.ImageStream")));
            this.LargeIL.TransparentColor = System.Drawing.Color.Transparent;
            this.LargeIL.Images.SetKeyName(0, "中国.png");
            this.LargeIL.Images.SetKeyName(1, "韩国.ico");
            this.LargeIL.Images.SetKeyName(2, "加拿大.ico");
            this.LargeIL.Images.SetKeyName(3, "美国.png");
            this.LargeIL.Images.SetKeyName(4, "日本.png");
            this.LargeIL.Images.SetKeyName(5, "新加坡.png");
            this.LargeIL.Images.SetKeyName(6, "英国.png");
            this.LargeIL.Images.SetKeyName(7, "越南.png");
            // 
            // smallIL
            // 
            this.smallIL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallIL.ImageStream")));
            this.smallIL.TransparentColor = System.Drawing.Color.Transparent;
            this.smallIL.Images.SetKeyName(0, "中国.png");
            this.smallIL.Images.SetKeyName(1, "韩国.ico");
            this.smallIL.Images.SetKeyName(2, "加拿大.ico");
            this.smallIL.Images.SetKeyName(3, "美国.png");
            this.smallIL.Images.SetKeyName(4, "日本.png");
            this.smallIL.Images.SetKeyName(5, "新加坡.png");
            this.smallIL.Images.SetKeyName(6, "英国.png");
            this.smallIL.Images.SetKeyName(7, "越南.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 557);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chEngName;
        private System.Windows.Forms.ColumnHeader chCountry;
        private System.Windows.Forms.ColumnHeader chCapital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ImageList LargeIL;
        private System.Windows.Forms.ImageList smallIL;
    }
}