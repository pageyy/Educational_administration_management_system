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
    public partial class GrantToTeacher : Form
    {
        public GrantToTeacher()
        {
            InitializeComponent();

            getHasGrantedTea();
            getNoGrantedTea();
        }

        #region 已授权
        private void getHasGrantedTea()
        {
            DataTable dt;
            dt = SQLHelper.ExecuteDataTable("select UserName as 用户姓名 from Teacher_Login where IsGranted=1");
            dgvYesGranted.DataSource = dt;
        }
        #endregion

        #region 未授权
        private void getNoGrantedTea()
        {
            DataTable dt;
            dt = SQLHelper.ExecuteDataTable("select UserName as 用户姓名 from Teacher_Login where IsGranted=0");
            dgvNoGranted.DataSource = dt;
        }
        #endregion

        #region 收权处理
        private void pbRevoke_Click(object sender, EventArgs e)
        {
            string name = dgvYesGranted.CurrentRow.Cells[0].Value.ToString();
            if (name != "")
            {
                SQLHelper.ExecuteNonQuery("update Teacher_Login set IsGranted=0 where UserName=@UserName", new SqlParameter("UserName", name));
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
            string name = dgvNoGranted.CurrentRow.Cells[0].Value.ToString();
            if (name != "")
            {
                SQLHelper.ExecuteNonQuery("update Teacher_Login set IsGranted=1 where UserName=@UserName", new SqlParameter("UserName", name));
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
