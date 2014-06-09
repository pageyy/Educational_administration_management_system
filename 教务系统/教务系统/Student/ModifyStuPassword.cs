using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 教务系统.Student
{
    public partial class ModifyStuPassword : Form
    {
        string stuId;
        public ModifyStuPassword(string userid)
        {
            InitializeComponent();

            stuId = userid;
            txtUsername.Text = userid;
        }

        
        private void btnModify_Click(object sender, EventArgs e)
        {
            string oldPassword = SQLHelper.ExecuteDataTable("select Password from Student_Login where UserName=@username", new SqlParameter("username", stuId)).Rows[0][0].ToString();
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
                SQLHelper.ExecuteNonQuery("update Student_Login set Password=@pw where UserName=@username", new SqlParameter("pw", txtNew.Text.Trim()), new SqlParameter("username", stuId));
                MessageBox.Show("修改成功！");
            }
        }

        
    }
}
