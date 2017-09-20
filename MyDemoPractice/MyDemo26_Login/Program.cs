using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo26_Login
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm fl = new LoginForm();
            fl.ShowDialog();
            if (fl.DialogResult == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else
            {
                return;
            }
        }
    }
}
