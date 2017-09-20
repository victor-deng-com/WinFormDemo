using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo21
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                TreeNode tn = new TreeNode();
                tn.Text = textBox1.Text.Trim();
                treeView1.Nodes.Add(tn);
            }
            else
            {
                MessageBox.Show("不能添加空节点");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                TreeNode tn = new TreeNode();
                tn.Text = textBox1.Text.Trim();
                treeView1.SelectedNode.Nodes.Add(tn);
            }
            else
            {
                MessageBox.Show("不能添加空节点");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode();
            tn = treeView1.SelectedNode;
            if (tn.Nodes.Count > 0)
            {
                DialogResult myDR = MessageBox.Show("该节点包含子节点，你确定删除吗？\n确定请按是，取消请按否","删除提示",MessageBoxButtons.YesNo);
                if (myDR == DialogResult.Yes)
                {
                    tn.Remove();
                }
            }
        }

    }
}
