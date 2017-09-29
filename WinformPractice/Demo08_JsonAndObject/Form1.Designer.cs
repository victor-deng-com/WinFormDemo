namespace Demo08_JsonAndObject
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
            this.btn_object = new System.Windows.Forms.Button();
            this.tb_objectToJson = new System.Windows.Forms.TextBox();
            this.tb_JsonToObject = new System.Windows.Forms.TextBox();
            this.tb_ListToJson = new System.Windows.Forms.TextBox();
            this.tb_JsonToList = new System.Windows.Forms.TextBox();
            this.btn_list = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_object
            // 
            this.btn_object.Location = new System.Drawing.Point(122, 12);
            this.btn_object.Name = "btn_object";
            this.btn_object.Size = new System.Drawing.Size(150, 41);
            this.btn_object.TabIndex = 0;
            this.btn_object.Text = "Json和对象转换";
            this.btn_object.UseVisualStyleBackColor = true;
            this.btn_object.Click += new System.EventHandler(this.btn_object_Click);
            // 
            // tb_objectToJson
            // 
            this.tb_objectToJson.Location = new System.Drawing.Point(122, 72);
            this.tb_objectToJson.Multiline = true;
            this.tb_objectToJson.Name = "tb_objectToJson";
            this.tb_objectToJson.Size = new System.Drawing.Size(912, 144);
            this.tb_objectToJson.TabIndex = 1;
            // 
            // tb_JsonToObject
            // 
            this.tb_JsonToObject.Location = new System.Drawing.Point(122, 234);
            this.tb_JsonToObject.Multiline = true;
            this.tb_JsonToObject.Name = "tb_JsonToObject";
            this.tb_JsonToObject.Size = new System.Drawing.Size(912, 144);
            this.tb_JsonToObject.TabIndex = 2;
            // 
            // tb_ListToJson
            // 
            this.tb_ListToJson.Location = new System.Drawing.Point(122, 396);
            this.tb_ListToJson.Multiline = true;
            this.tb_ListToJson.Name = "tb_ListToJson";
            this.tb_ListToJson.Size = new System.Drawing.Size(912, 144);
            this.tb_ListToJson.TabIndex = 3;
            // 
            // tb_JsonToList
            // 
            this.tb_JsonToList.Location = new System.Drawing.Point(122, 558);
            this.tb_JsonToList.Multiline = true;
            this.tb_JsonToList.Name = "tb_JsonToList";
            this.tb_JsonToList.Size = new System.Drawing.Size(912, 144);
            this.tb_JsonToList.TabIndex = 4;
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(290, 12);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(140, 41);
            this.btn_list.TabIndex = 5;
            this.btn_list.Text = "Json和队列转换";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "json字符串";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "对象";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "json字符串";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 716);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.tb_JsonToList);
            this.Controls.Add(this.tb_ListToJson);
            this.Controls.Add(this.tb_JsonToObject);
            this.Controls.Add(this.tb_objectToJson);
            this.Controls.Add(this.btn_object);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_object;
        private System.Windows.Forms.TextBox tb_objectToJson;
        private System.Windows.Forms.TextBox tb_JsonToObject;
        private System.Windows.Forms.TextBox tb_ListToJson;
        private System.Windows.Forms.TextBox tb_JsonToList;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

