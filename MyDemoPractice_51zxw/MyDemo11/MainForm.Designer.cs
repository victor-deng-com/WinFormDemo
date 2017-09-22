namespace MyDemo11
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
            this.routineBTN = new System.Windows.Forms.Button();
            this.downloadBTN = new System.Windows.Forms.Button();
            this.exteriorBTN = new System.Windows.Forms.Button();
            this.remoteBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // routineBTN
            // 
            this.routineBTN.FlatAppearance.BorderSize = 0;
            this.routineBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.routineBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.routineBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.routineBTN.Location = new System.Drawing.Point(50, 56);
            this.routineBTN.Name = "routineBTN";
            this.routineBTN.Size = new System.Drawing.Size(95, 40);
            this.routineBTN.TabIndex = 0;
            this.routineBTN.Text = "常规";
            this.routineBTN.UseVisualStyleBackColor = true;
            this.routineBTN.Click += new System.EventHandler(this.routineBTN_Click);
            // 
            // downloadBTN
            // 
            this.downloadBTN.FlatAppearance.BorderSize = 0;
            this.downloadBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.downloadBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.downloadBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadBTN.Location = new System.Drawing.Point(50, 161);
            this.downloadBTN.Name = "downloadBTN";
            this.downloadBTN.Size = new System.Drawing.Size(95, 40);
            this.downloadBTN.TabIndex = 1;
            this.downloadBTN.Text = "下载";
            this.downloadBTN.UseVisualStyleBackColor = true;
            this.downloadBTN.Click += new System.EventHandler(this.downloadBTN_Click);
            // 
            // exteriorBTN
            // 
            this.exteriorBTN.FlatAppearance.BorderSize = 0;
            this.exteriorBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exteriorBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.exteriorBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exteriorBTN.Location = new System.Drawing.Point(50, 266);
            this.exteriorBTN.Name = "exteriorBTN";
            this.exteriorBTN.Size = new System.Drawing.Size(95, 40);
            this.exteriorBTN.TabIndex = 2;
            this.exteriorBTN.Text = "外观";
            this.exteriorBTN.UseVisualStyleBackColor = true;
            this.exteriorBTN.Click += new System.EventHandler(this.exteriorBTN_Click);
            // 
            // remoteBTN
            // 
            this.remoteBTN.FlatAppearance.BorderSize = 0;
            this.remoteBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.remoteBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.remoteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remoteBTN.Location = new System.Drawing.Point(50, 371);
            this.remoteBTN.Name = "remoteBTN";
            this.remoteBTN.Size = new System.Drawing.Size(95, 40);
            this.remoteBTN.TabIndex = 3;
            this.remoteBTN.Text = "远程下载";
            this.remoteBTN.UseVisualStyleBackColor = true;
            this.remoteBTN.Click += new System.EventHandler(this.remoteBTN_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(200, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 450);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.remoteBTN);
            this.Controls.Add(this.exteriorBTN);
            this.Controls.Add(this.downloadBTN);
            this.Controls.Add(this.routineBTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button routineBTN;
        private System.Windows.Forms.Button downloadBTN;
        private System.Windows.Forms.Button exteriorBTN;
        private System.Windows.Forms.Button remoteBTN;
        private System.Windows.Forms.Panel panel1;
    }
}