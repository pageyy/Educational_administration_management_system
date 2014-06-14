using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 教务系统.Teacher
{
    public partial class ShowCourseSelectedInfo : Form
    {
        string teaId;
        public ShowCourseSelectedInfo(string teaid)
        {
            InitializeComponent();

            teaId=teaid;
            dgvCourseElected.DataSource = SQLHelper.ExecuteDataTable("select 教职工号, 课程编号, 课序号, 课程名称, 学号, 姓名 from CourseElectedForTeacher where 教职工号=@教职工号", new SqlParameter("教职工号", teaId));
        }

        private void ShowCourseSelectedInfo_Load(object sender, EventArgs e)
        {
            SQLHelper.CmbExecuteReader("select 课程编号,课程名称 from CourseElectedForTeacher where 教职工号=@教职工号", cmbName, new SqlParameter("教职工号", teaId));
        }

        #region 搜索该教师上的某课程选课信息
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbName.Text != "")
            {
                int capacity = (int)SQLHelper.ExecuteScalar("select 课程容量 from CourseElectedForTeacher where 教职工号=@教职工号 and 课程名称=@课程名称", new SqlParameter("教职工号", teaId), new SqlParameter("课程名称", cmbName.Text.Trim()));
                int left = (int)SQLHelper.ExecuteScalar("select 剩余容量 from CourseElectedForTeacher where 教职工号=@教职工号 and 课程名称=@课程名称", new SqlParameter("教职工号", teaId), new SqlParameter("课程名称", cmbName.Text.Trim()));

                lblCapacityTxt.Text = capacity.ToString();
                lblLeftTxt.Text = left.ToString();

                dgvCourseElected.DataSource = SQLHelper.ExecuteDataTable("select 教职工号, 课程编号, 课序号, 课程名称, 学号, 姓名 from CourseElectedForTeacher where 教职工号=@教职工号 and 课程名称=@课程名称", new SqlParameter("教职工号", teaId), new SqlParameter("课程名称", cmbName.Text.Trim()));
            }
        }
        #endregion
    }
}
