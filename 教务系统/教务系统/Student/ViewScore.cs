using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace 教务系统
{
    public partial class ViewScore : Form
    {
        //学生学号
        private string studentID;
        //学生的成绩单
        private DataTable ScoreList;

        public ViewScore(string userid)
        {
            InitializeComponent();

            studentID = userid;
            txt1.Text = userid;
            getScore();
        }

        private void getScore()
        {
            string connStr = ConfigurationManager.ConnectionStrings["教务系统.Properties.Settings.eisbookConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select a.姓名,b.班级名称 from 学生信息 a,班级信息 b where (a.班级编号=b.班级编号) and (学号='" + studentID + "')";
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (!dr.HasRows)//此处提示语得修改
            {
                MessageBox.Show("无此学生，请重新输入学号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dr.Close();
                return;
             }
             txt2.Text = dr.GetValue(0).ToString().Trim();
             dr.Close();
             ScoreList = SQLHelper.ExecuteDataTable("select b.课程名称,b.开课系别,a.成绩,b.教师 from 成绩表 a,课程信息 b where 学号=@学号 and a.课程编号=b.课程编号 and a.是否已确定成绩='Y'", new SqlParameter("学号", studentID));
             dgvGrade.DataSource = ScoreList;
             //da1.SelectCommand.Parameters[0].Value = txt1.Text.Trim();
             //da1.Fill(DataSetGradeList);
        }

        /// <summary>
        /// 打印成绩单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txt2.Text.Trim() == "")
            {
                MessageBox.Show("请先输入正确的学号", "提示");
                return;
            }
            CrystalReport newfrm = new CrystalReport();
            CrystalReport.studentID = txt1.Text.Trim();//向报表预览窗体中传递学号
            newfrm.Text = txt2.Text + " 同学成绩表";
            newfrm.ShowDialog();
        }
    }
}
