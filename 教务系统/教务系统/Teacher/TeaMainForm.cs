using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 教务系统.Teacher
{
    public partial class TeaMainForm : Form
    {
        public TeaMainForm(string username)
        {
            InitializeComponent();

            sbEduTea.Panels[1].Text = username + "，欢迎您登录教务管理系统！当前为教师用户状态。";
            sbEduTea.Panels[2].Text = "当前系统时间为：" + DateTime.Now.ToString();
        }
    }
}
