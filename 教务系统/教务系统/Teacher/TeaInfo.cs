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
    public partial class TeaInfo : Form
    {
        string teaId;

        public TeaInfo(string userid)
        {
            InitializeComponent();

            teaId = userid;
            getTeaInfo();
        }

        #region 获得教师信息
        private void getTeaInfo()
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from [eisbook].[dbo].[教师信息] where 职工号=@id", new SqlParameter("id", teaId));
            txtNo.Text = teaId;

            txtName.Text = dt.Rows[0][1].ToString();
            txtGender.Text = dt.Rows[0][2].ToString();

            string zhichengNo = dt.Rows[0][3].ToString();
            //getclassname
            txtZhicheng.Text = SQLHelper.ExecuteDataTable("select 职称名称 from [eisbook].[dbo].[职称代码表] where 职称编号=@no", new SqlParameter("no", zhichengNo)).Rows[0][0].ToString();

            string zhengzhimianmao = dt.Rows[0][4].ToString();
            //get
            txtZhengzhimianmao.Text = SQLHelper.ExecuteDataTable("select 政治面貌 from [eisbook].[dbo].[政治面貌代码表] where 政治面貌编号=@no", new SqlParameter("no", zhengzhimianmao)).Rows[0][0].ToString();

            string minzu = dt.Rows[0][5].ToString();
            txtMinzu.Text = SQLHelper.ExecuteDataTable("select 民族 from [eisbook].[dbo].[民族代码表] where 民族编号=@no", new SqlParameter("no", minzu)).Rows[0][0].ToString();

            string jigaun = dt.Rows[0][6].ToString();
            txtJiguan.Text = SQLHelper.ExecuteDataTable("select 籍贯 from [eisbook].[dbo].[籍贯代码表] where 籍贯编号=@no", new SqlParameter("no", jigaun)).Rows[0][0].ToString();

            txtShenfenzheng.Text = dt.Rows[0][7].ToString();
        }
        #endregion 

    }
}
