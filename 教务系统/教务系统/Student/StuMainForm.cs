using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 教务系统.Student
{
    public partial class StuMainForm : Form
    {
        public StuMainForm(string username)
        {
            InitializeComponent();

            sbEduStu.Panels[1].Text = username + "，欢迎您登录教务管理系统！当前为学生用户状态。";
            sbEduStu.Panels[2].Text = "当前系统时间为：" + DateTime.Now.ToString();
        }
    }
}
