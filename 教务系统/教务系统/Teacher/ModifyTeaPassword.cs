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
    public partial class ModifyTeaPassword : Form
    {
        string teaId;

        public ModifyTeaPassword(string userid)
        {
            InitializeComponent();

            teaId = userid;
            txtUsername.Text = userid;
        }

        #region 修改密码
        private void btnModify_Click(object sender, EventArgs e)
        {
            string oldPassword = SQLHelper.ExecuteDataTable("select Password from Teacher_Login where UserName=@username", new SqlParameter("username", teaId)).Rows[0][0].ToString();
            if (oldPassword.Trim() != txtOld.Text.Trim())
            {
                MessageBox.Show("旧密码不正确？！");
            }
            else if (txtNew.Text.Trim() != txtRenew.Text.Trim())
            {
                MessageBox.Show("两次输入的新密码不相同？！");
            }
            else
            {
                SQLHelper.ExecuteNonQuery("update Teacher_Login set Password=@pw where UserName=@username", new SqlParameter("pw", txtNew.Text.Trim()), new SqlParameter("username", teaId));
                MessageBox.Show("修改成功！");
            }
        }
        #endregion
    }
}
