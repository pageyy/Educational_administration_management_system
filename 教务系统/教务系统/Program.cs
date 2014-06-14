using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 教务系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 教务系统.Teacher.TeaMainForm("T080002"));
            //教务系统.Student.StuMainForm("08113398")
            //教务系统.Student.StuMainForm("08113401")
            //Login()  
            //教务系统.Teacher.TeaMainForm("T080002")  
            //MainForm("admin")
        }
    }
}
