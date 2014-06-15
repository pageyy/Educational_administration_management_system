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
        string userName;//教师职工号

        #region 构造函数
        public TeaMainForm(string username)
        {
            InitializeComponent();

            userName = username;
            sbEduTea.Panels[1].Text = username + "，欢迎您登录教务管理系统！当前为教师用户状态。";
            sbEduTea.Panels[2].Text = "当前系统时间为：" + DateTime.Now.ToString();
        }
        #endregion

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

        #region 退出
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion 

        #region 修改密码
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //通过窗体名称查询该窗体是否已经存在，如存在则显示，否则就新创建一个
            if (this.checkChildFrmExist("ModifyTeaPassword") == true)
            {
                return;
            }
            ModifyTeaPassword mtp = new ModifyTeaPassword(userName);
            mtp.MdiParent = this;
            mtp.Show();
        }
        #endregion 

        #region 个人信息
        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //通过窗体名称查询该窗体是否已经存在，如存在则显示，否则就新创建一个
            if (this.checkChildFrmExist("TeaInfo") == true)
            {
                return;
            }
            TeaInfo ti = new TeaInfo(userName);
            ti.MdiParent = this;
            ti.Show();
        }
        #endregion

        #region 成绩录入
        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //通过窗体名称查询该窗体是否已经存在，如存在则显示，否则就新创建一个
            if (this.checkChildFrmExist("ScoreInput") == true)
            {
                return;
            }
            ScoreInput si = new ScoreInput(userName);
            si.MdiParent = this;
            si.Show();
        }
        #endregion

        #region 选课查询
        private void 选课查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //通过窗体名称查询该窗体是否已经存在，如存在则显示，否则就新创建一个
            if (this.checkChildFrmExist("ShowCourseSelectedInfo") == true)
            {
                return;
            }
            ShowCourseSelectedInfo scsi = new ShowCourseSelectedInfo(userName);
            scsi.MdiParent = this;
            scsi.Show();
        }
        #endregion

        #region 课表查询
        private void 课表查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //通过窗体名称查询该窗体是否已经存在，如存在则显示，否则就新创建一个
            if (this.checkChildFrmExist("ShowCourseTable") == true)
            {
                return;
            }
            ShowCourseTable sct = new ShowCourseTable(userName);
            sct.MdiParent = this;
            sct.Show();
        }
        #endregion
    }
}
