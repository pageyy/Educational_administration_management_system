using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 教务系统.Administrator;

namespace 教务系统
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        #region 专业信息维护
        private void MenuItem12_Click(object sender, EventArgs e)
        {
            //通过窗体名称查询该窗体是否已经存在，如存在则显示，否则就新创建一个
            if (this.checkChildFrmExist("ProfessionInfo") == true)
            {
                return;
            }
            ProfessionInfo pro = new ProfessionInfo();
            pro.MdiParent = this;
            pro.Show();
        }
        #endregion

        #region  班级信息维护
        private void MenuItem13_Click(object sender, EventArgs e)
        {
            if (this.checkChildFrmExist("ClassInfo") == true)
            {
                return;
            }
            ClassInfo cla = new ClassInfo();
            cla.MdiParent = this;
            cla.Show();
        }
        #endregion

        #region 关闭
        private void MenuItem6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 教师信息维护 待实现。。。。。。。。。。。。。。。。。。
        private void MenuItem2_Click(object sender, EventArgs e)
        {
            //待实现。。。。。。。。。。。。。。。。。。
        }
        #endregion

        #region 学生信息维护
        private void MenuItem3_Click(object sender, EventArgs e)
        {
            if (this.checkChildFrmExist("StudentsInfo") == true)
            {
                return;
            }
            StudentsInfo stu = new StudentsInfo();
            stu.MdiParent = this;
            stu.Show();
        }
        #endregion

        #region 课程信息维护
        private void MenuItem4_Click(object sender, EventArgs e)
        {
            if (this.checkChildFrmExist("CourseInfo") == true)
            {
                return;
            }
            CourseInfo cou = new CourseInfo();
            cou.MdiParent = this;
            cou.Show();
        }
        #endregion

        

        

        
        /*
        /// <summary>
        /// 显示学生信息设置窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem6_Click(object sender, EventArgs e)
        {
            if (this.checkChildFrmExist("CourseElect") == true)
            {
                return;
            }
            CourseElect newFrm = new CourseElect();
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        /// <summary>
        /// 显示课表信息设置窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem7_Click(object sender, EventArgs e)
        {
            if (this.checkChildFrmExist("CurriculumSchedule") == true)
            {
                return;
            }
            CurriculumSchedule newFrm = new CurriculumSchedule("");
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        /// <summary>
        /// 显示成绩信息录入窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem8_Click(object sender, EventArgs e)
        {
            if (this.checkChildFrmExist("ScoreInput") == true)
            {
                return;
            }
            ScoreInput newFrm = new ScoreInput();
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        /// <summary>
        /// 显示打印成绩单窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem10_Click(object sender, EventArgs e)
        {
            if (this.checkChildFrmExist("ViewScore") == true)
            {
                return;
            }
            ViewScore newFrm = new ViewScore();
            newFrm.MdiParent = this;
            newFrm.Show();
        }
        */
       
        
    }
}
