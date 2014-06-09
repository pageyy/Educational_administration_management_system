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
        string userName;//此处用户名即为学生学号

        public StuMainForm(string username)
        {
            InitializeComponent();

            userName = username;
            sbEduStu.Panels[1].Text = username + "，欢迎您登录教务管理系统！当前为学生用户状态。";
            sbEduStu.Panels[2].Text = "当前系统时间为：" + DateTime.Now.ToString();
        }

        #region 查询MDI子窗体是否存在
        private bool checkChildFrmExist(string childFrmName)
        {
            foreach (Form childFrm in this.MdiChildren)
            {
                if (childFrm.WindowState == FormWindowState.Minimized)
                {
                    childFrm.WindowState = FormWindowState.Normal;
                }
                childFrm.Activate();
                return true;
            }
            return false;
        }
        #endregion

        #region 个人信息
        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //通过窗体名称查询该窗体是否已经存在，如存在则显示，否则就新创建一个
            if (this.checkChildFrmExist("ShowStuInfo") == true)
            {
                return;
            }
            ShowStuInfo ssi = new ShowStuInfo(userName);
            ssi.MdiParent = this;
            ssi.Show();
        }
        #endregion 

        #region 密码修改
        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 学生个人课表查询
        private void 学生个人课表查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //通过窗体名称查询该窗体是否已经存在，如存在则显示，否则就新创建一个
            if (this.checkChildFrmExist("CurriculumSchedule") == true)
            {
                return;
            }
            CurriculumSchedule cur = new CurriculumSchedule(userName);
            cur.MdiParent = this;
            cur.Show();
        }
        #endregion 

        #region 成绩查询
        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //通过窗体名称查询该窗体是否已经存在，如存在则显示，否则就新创建一个
            if (this.checkChildFrmExist("ViewScore") == true)
            {
                return;
            }
            ViewScore vs = new ViewScore(userName);
            vs.MdiParent = this;
            vs.Show();
        }
        #endregion

        #region 网上选课
        private void 网上选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //通过窗体名称查询该窗体是否已经存在，如存在则显示，否则就新创建一个
            if (this.checkChildFrmExist("CourseElect") == true)
            {
                return;
            }
            CourseElect ce = new CourseElect(userName);
            ce.MdiParent = this;
            ce.Show();
        }
        #endregion 

        #region 退出
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
