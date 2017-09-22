namespace MyDemo21
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1年级");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("2年级");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("3年级");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("4年级");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("5年级");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("6年级");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("小学", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("7年级");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("8年级");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("9年级");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("初中", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("高一");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("高二");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("高三");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("高中", 2, 0, new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("大一");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("大二");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("大三");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("大四");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("大学", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(24, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点4";
            treeNode1.Text = "1年级";
            treeNode2.Name = "节点5";
            treeNode2.Text = "2年级";
            treeNode3.Name = "节点6";
            treeNode3.Text = "3年级";
            treeNode4.Name = "节点7";
            treeNode4.Text = "4年级";
            treeNode5.Name = "节点8";
            treeNode5.Text = "5年级";
            treeNode6.Name = "节点9";
            treeNode6.Text = "6年级";
            treeNode7.Name = "节点0";
            treeNode7.Text = "小学";
            treeNode8.Name = "节点10";
            treeNode8.Text = "7年级";
            treeNode9.Name = "节点11";
            treeNode9.Text = "8年级";
            treeNode10.Name = "节点12";
            treeNode10.Text = "9年级";
            treeNode11.ImageIndex = 1;
            treeNode11.Name = "节点1";
            treeNode11.SelectedImageKey = "02.png";
            treeNode11.Text = "初中";
            treeNode12.Name = "节点13";
            treeNode12.Text = "高一";
            treeNode13.Name = "节点14";
            treeNode13.Text = "高二";
            treeNode14.Name = "节点15";
            treeNode14.Text = "高三";
            treeNode15.ImageIndex = 2;
            treeNode15.Name = "节点2";
            treeNode15.SelectedImageIndex = 0;
            treeNode15.Text = "高中";
            treeNode16.Name = "节点16";
            treeNode16.Text = "大一";
            treeNode17.Name = "节点17";
            treeNode17.Text = "大二";
            treeNode18.Name = "节点18";
            treeNode18.Text = "大三";
            treeNode19.Name = "节点19";
            treeNode19.Text = "大四";
            treeNode20.ImageIndex = 3;
            treeNode20.Name = "节点3";
            treeNode20.SelectedImageIndex = 3;
            treeNode20.Text = "大学";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode11,
            treeNode15,
            treeNode20});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(373, 145);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加根节点";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "添加子节点";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(280, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "删除选中节点";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 25);
            this.textBox1.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "01.png");
            this.imageList1.Images.SetKeyName(1, "02.png");
            this.imageList1.Images.SetKeyName(2, "03.png");
            this.imageList1.Images.SetKeyName(3, "04.png");
            this.imageList1.Images.SetKeyName(4, "05.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 292);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}