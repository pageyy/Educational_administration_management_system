using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using System.Data.SqlClient;

namespace 教务系统
{
    public partial class CourseElect : Form
    {
        private DataTable electTable = new DataTable();//保存学生的选课信息
        private DataTable courseTable = new DataTable();//保存可选课程信息
        
        private string studentID;//保存选课的学生信息
        private string stduentName;//选课的学生的姓名

        public CourseElect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化操作 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CourseElect_Load(object sender, EventArgs e)
        {
            courseTable = SQLHelper.ExecuteDataTable("select * from CourseElectIs_Y ");
            dgvCourse.DataSource = courseTable;
        }

        /// <summary>
        /// 输入学号后，按确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txt1.Text.Trim() != "")//输入学号后回车，查询学生信息和选课信息
            {
                this.electTable.Clear();//先清空选课表
                txt2.Clear();
                txt3.Clear();
                //关闭选课，删课等许可
                btnElect.Enabled = false;
                btnDelete.Enabled = false;
                btnView.Enabled = false;
                this.ShowInfo();
            }
        }

        /// <summary>
        /// 显示学生已选修的课程信息
        /// </summary>
        private void ShowInfo()
        {
            //******************************此处待改******************************
            string connStr = ConfigurationManager.ConnectionStrings["教务系统.Properties.Settings.eisbookConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select a.姓名,b.班级名称,a.学籍编号 from 学生信息 a,班级信息 b where (a.班级编号=b.班级编号) and (学号='" + txt1.Text.Trim() + "')";
            SqlDataReader dr = cmd.ExecuteReader(); 
            //SqlDataReader dr = SQLHelper.ExecuteReader("select a.姓名,b.班级名称,a.学籍编号 from 学生信息 a,班级信息 b where (a.班级编号=b.班级编号) and 学号=@学号", new SqlParameter("学号", txt1.Text.Trim()));
            //读入数据
            dr.Read();
            if (!dr.HasRows)
            {
                MessageBox.Show("无此学生，请重新输入学号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dr.Close();
                return;
            }
            //判断是否为在籍学生
            if (dr.GetValue(2).ToString().Trim() != "1")
            {
                MessageBox.Show("该学生并非在籍学生，不能选课", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //姓名
            txt2.Text = dr.GetValue(0).ToString().Trim();
            //班级名称
            txt3.Text = dr.GetValue(1).ToString().Trim();
            dr.Close();

            //读入选课信息
            electTable = SQLHelper.ExecuteDataTable("select * from CourseElected where 学号=@学号", new SqlParameter("学号", txt1.Text.Trim()));
            dgvElectedCourse.DataSource = electTable;
            this.studentID = txt1.Text.Trim();//保存获准选课的学生学号
            this.stduentName = txt2.Text.Trim();//保存学生姓名
            //允许选课，删课，查课表等操作
            btnElect.Enabled = true;
            btnDelete.Enabled = true;
            btnView.Enabled = true;
        }

        /// <summary>
        /// 筛选课程：此处运用视图：CourseElectIs_Y
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = "select * from CourseElectIs_Y where 1=1";
            if (txt4.Text.Trim() != "")
            {
                filter += " and 拼音码 like '%" + txt4.Text.Trim() + "%'";
            }
            if (txt5.Text.Trim() != "")
            {
                filter += " and 课程名称 like '%" + txt5.Text.Trim() + "%'";
            }
            if (txt6.Text.Trim() != "")
            {
                filter += " and 课程编号='" + txt6.Text.Trim() + "'";
            }
            if (txt7.Text.Trim() != "")
            {
                filter += " and 课序号 like '%" + txt7.Text.Trim() + "%'";
            }
            dgvCourse.DataSource = SQLHelper.ExecuteDataTable(filter);    
        }

        /// <summary>
        /// 选课操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnElect_Click(object sender, EventArgs e)
        {
            //可选课程表为空，不能选课
            if (courseTable.Rows.Count == 0)
            {
                MessageBox.Show("可选课表为空，无法选课", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //当前所选的课序号
            string courseID = dgvCourse.CurrentRow.Cells[0].Value.ToString().Trim();
            //所选课程的上课时间天
            string courseDay = dgvCourse.CurrentRow.Cells[6].Value.ToString().Trim();
            //所选课程的上课时间节
            string courseSec = dgvCourse.CurrentRow.Cells[7].Value.ToString().Trim();
            foreach (DataRow aRow in this.electTable.Rows)
            {
                if (aRow["课序号"].ToString().Trim() == courseID)
                {
                    MessageBox.Show("所选课程已经在课程表中", "课程重复", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (aRow["上课时间天"].ToString().Trim() == courseDay && aRow["上课时间节"].ToString().Trim() == courseSec)
                {
                    string msg = "所选课程和已选课程:" + aRow["课程名称"].ToString().Trim() + " 上课时间冲突";
                    MessageBox.Show(msg, "时间冲突", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            SQLHelper.ExecuteNonQuery("insert into 选课表([学号],[课序号]) values(@学号,@课序号)", new SqlParameter("学号", this.studentID), new SqlParameter("课序号", courseID));
            //重新读入学生的选课信息
            this.electTable.Clear();
            electTable = SQLHelper.ExecuteDataTable("select * from CourseElected where 学号=@学号", new SqlParameter("学号", txt1.Text.Trim()));
            dgvElectedCourse.DataSource = electTable;
            MessageBox.Show("成功选修该课程！");
            return;
        }

        /// <summary>
        /// 删除已选修的课程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.electTable.Rows.Count == 0)
            {
                return;
            }
            //要删除的课序号
            string deleteID = dgvElectedCourse.CurrentRow.Cells[1].Value.ToString().Trim();
            //要删除的课名称
			string deleteName = dgvElectedCourse.CurrentRow.Cells[2].Value.ToString().Trim();
			string msg="是否确认删除已选课程:"+deleteName+" ?";
			DialogResult result=MessageBox.Show(msg,"删除课程",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                SQLHelper.ExecuteNonQuery("delete from 选课表 where 学号=@学号 and 课序号=@课序号", new SqlParameter("学号", txt1.Text.Trim()),new SqlParameter("课序号",deleteID));
                //重新读入学生的选课信息
                this.electTable.Clear();
                electTable = SQLHelper.ExecuteDataTable("select * from CourseElected where 学号=@学号", new SqlParameter("学号", txt1.Text.Trim()));
                dgvElectedCourse.DataSource = electTable;
                MessageBox.Show("已成功删除该选修课程！");
                return;
            }

        }

        /// <summary>
        /// 查看课程表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            CurriculumSchedule newFrm = new CurriculumSchedule(this.studentID);
            newFrm.Text += "学生：" + this.stduentName;
            newFrm.Show();
        }

        

        

        
    }
}
