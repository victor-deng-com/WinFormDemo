namespace MyDemo1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新建窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.层叠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建窗体ToolStripMenuItem,
            this.层叠ToolStripMenuItem,
            this.水平ToolStripMenuItem,
            this.垂直ToolStripMenuItem,
            this.guangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新建窗体ToolStripMenuItem
            // 
            this.新建窗体ToolStripMenuItem.Name = "新建窗体ToolStripMenuItem";
            this.新建窗体ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.新建窗体ToolStripMenuItem.Text = "新建窗体";
            this.新建窗体ToolStripMenuItem.Click += new System.EventHandler(this.新建窗体ToolStripMenuItem_Click);
            // 
            // 层叠ToolStripMenuItem
            // 
            this.层叠ToolStripMenuItem.Name = "层叠ToolStripMenuItem";
            this.层叠ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.层叠ToolStripMenuItem.Text = "层叠";
            this.层叠ToolStripMenuItem.Click += new System.EventHandler(this.层叠ToolStripMenuItem_Click);
            // 
            // 水平ToolStripMenuItem
            // 
            this.水平ToolStripMenuItem.Name = "水平ToolStripMenuItem";
            this.水平ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.水平ToolStripMenuItem.Text = "水平";
            this.水平ToolStripMenuItem.Click += new System.EventHandler(this.水平ToolStripMenuItem_Click);
            // 
            // 垂直ToolStripMenuItem
            // 
            this.垂直ToolStripMenuItem.Name = "垂直ToolStripMenuItem";
            this.垂直ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.垂直ToolStripMenuItem.Text = "垂直";
            this.垂直ToolStripMenuItem.Click += new System.EventHandler(this.垂直ToolStripMenuItem_Click);
            // 
            // guangToolStripMenuItem
            // 
            this.guangToolStripMenuItem.Name = "guangToolStripMenuItem";
            this.guangToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.guangToolStripMenuItem.Text = "关闭";
            this.guangToolStripMenuItem.Click += new System.EventHandler(this.guangToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MDI窗体";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建窗体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 层叠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guangToolStripMenuItem;
    }
}