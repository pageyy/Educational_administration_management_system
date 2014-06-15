using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 教务系统.Administrator
{
    public partial class GrantToTeacherInputScore : Form
    {
        public GrantToTeacherInputScore()
        {
            InitializeComponent();

            getHasGrantedTea();
            getNoGrantedTea();
        }

        #region 已授权
        private void getHasGrantedTea()
        {
            DataTable dt;
            dt = SQLHelper.ExecuteDataTable("select 课程编号,课程名称,教职工号,教师 from 课程信息 where 允许登录成绩=1 and 本学期课程='Y'");
            dgvYesGranted.DataSource = dt;
        }
        #endregion

        #region 未授权
        private void getNoGrantedTea()
        {
            DataTable dt;
            dt = SQLHelper.ExecuteDataTable("select 课程编号,课程名称,教职工号,教师 from 课程信息 where 允许登录成绩=0 and 本学期课程='Y'");
            dgvNoGranted.DataSource = dt;
        }
        #endregion

        #region 收权处理
        private void pbRevoke_Click(object sender, EventArgs e)
        {
            string courseNo = dgvYesGranted.CurrentRow.Cells[0].Value.ToString();
            if (courseNo != "")
            {
                SQLHelper.ExecuteNonQuery("update 课程信息 set 允许登录成绩=0 where 课程编号=@课程编号", new SqlParameter("课程编号", courseNo));
                getHasGrantedTea();
                getNoGrantedTea();
            }
            else
            {
                MessageBox.Show("请选中要操作的行！");
            }
        }
        #endregion

        #region 授权处理
        private void pbGrant_Click(object sender, EventArgs e)
        {
            string courseNo = dgvNoGranted.CurrentRow.Cells[0].Value.ToString();
            if (courseNo != "")
            {
                SQLHelper.ExecuteNonQuery("update 课程信息 set 允许登录成绩=1 where 课程编号=@课程编号", new SqlParameter("课程编号", courseNo));
                getHasGrantedTea();
                getNoGrantedTea();
            }
            else
            {
                MessageBox.Show("请选中要操作的行！");
            }
        }
        #endregion
    }
}
