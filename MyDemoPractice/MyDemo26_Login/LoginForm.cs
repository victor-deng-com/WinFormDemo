using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo26_Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            if (TBusername.Text =="admin" && TBpassword.Text =="admin")
            {
                this.DialogResult = DialogResult.OK;    //返回一个登录成功的对话框状态
                this.Close();    //关闭登录窗口
            }
        }
    }
}
