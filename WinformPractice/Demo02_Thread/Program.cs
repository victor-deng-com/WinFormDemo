using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo02_Thread
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //通过进程去打开应用程序
            //Process.GetProcesses;
            //Process.Start("notepad");
            //Process.Start("iexplore","http://www.baidu.com");

            //通过进程打开指定的文件
            //ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Gary\Desktop\20170911-20170917 Victor工作报告.xlsx");
            //Process p = new Process();
            //p.StartInfo = psi;
            //p.Start();

            //进程和线程的关系：一个进程包含多个线程


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
