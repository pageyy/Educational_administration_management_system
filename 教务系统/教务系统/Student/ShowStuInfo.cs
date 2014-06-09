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
    public partial class ShowStuInfo : Form
    {
        string stuId;
        public ShowStuInfo(string userid)
        {
            InitializeComponent();
            stuId = userid;
            getStuInfo();
        }

        #region 获得学生信息
        private void getStuInfo()
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from [eisbook].[dbo].[学生信息] where 学号=@id", new SqlParameter("id", stuId));
            txtNo.Text = stuId;

            txtName.Text = dt.Rows[0][1].ToString();

            string classNo = dt.Rows[0][2].ToString();
            //getclassname
            txtClass.Text = SQLHelper.ExecuteDataTable("select 班级名称 from [eisbook].[dbo].[班级信息] where 班级编号=@no", new SqlParameter("no", classNo)).Rows[0][0].ToString();

            txtGrade.Text = dt.Rows[0][4].ToString();

            string zhengzhimianmao = dt.Rows[0][5].ToString();
            //get
            txtZhengzhimianmao.Text = SQLHelper.ExecuteDataTable("select 政治面貌 from [eisbook].[dbo].[政治面貌代码表] where 政治面貌编号=@no", new SqlParameter("no", zhengzhimianmao)).Rows[0][0].ToString();

            string minzu = dt.Rows[0][6].ToString();
            txtMinzu.Text = SQLHelper.ExecuteDataTable("select 民族 from [eisbook].[dbo].[民族代码表] where 民族编号=@no", new SqlParameter("no", minzu)).Rows[0][0].ToString();

            string jigaun = dt.Rows[0][7].ToString();
            txtJiguan.Text = SQLHelper.ExecuteDataTable("select 籍贯 from [eisbook].[dbo].[籍贯代码表] where 籍贯编号=@no", new SqlParameter("no", jigaun)).Rows[0][0].ToString();

            txtShenfenzheng.Text = dt.Rows[0][8].ToString();
        }
        #endregion 
    }
}
