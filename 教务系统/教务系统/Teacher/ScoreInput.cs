using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 教务系统
{
    public partial class ScoreInput : Form
    {
        //学生成绩表
        private DataTable ScoreTable;
        //课程编号
        private string CourseID;

        private string teaId;

        public ScoreInput(string userid)
        {
            InitializeComponent();

            teaId = userid;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScoreInput_Load(object sender, EventArgs e)
        {
            dgvScore.DataSource = this.ScoreTable;
        }

        /// <summary>
        /// 结束选课
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEndScoreElect_Click(object sender, EventArgs e)
        {
            try
            {
                SQLHelper.ExecuteNonQuery("exec sf_终止选课");
                MessageBox.Show("终止选课成功,将生成新的空成绩单", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception express)
            {
                MessageBox.Show (express .ToString (),"操作失败",MessageBoxButtons.OK ,MessageBoxIcon .Information );
            }
        }

        //查询所有未确定成绩的课程信息
        string sql = "select a.编号,a.课程编号,b.课程名称,a.学号,c.姓名,a.成绩 from 成绩表 a,课程信息 b,学生信息 c "+ "where(a.课程编号=b.课程编号)and(a.学号=c.学号)and(a.是否已确定成绩='N')";

        /// <summary>
        /// 查询课程成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //ScoreTable.Clear();
            string sql1 = sql + "and (a.课程编号 like '%" + txt2.Text.Trim() + "%')and(b.拼音码 like '%" + txt1.Text.Trim() + "%')and(b.课程名称 like '%" + txt3.Text.Trim() + "%')";
            ScoreTable = SQLHelper.ExecuteDataTable(sql1);
            if (ScoreTable.Rows.Count > 0)
            {
                this.CourseID = this.ScoreTable.Rows[0][1].ToString().Trim();
                dgvScore.DataSource = ScoreTable;
            }
            else
            {
                string msg = "该表中没有数据，可能原因有：\n" + "1.本学期没有该门课程\n" + "2.该课程无学生选课\n"+"3.该课程所有学生成绩已经被最终提交，不可再修改";
                MessageBox.Show(msg, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt4.DataBindings.Clear();
            //绑定成绩显示
            txt4.DataBindings.Add("Text", this.ScoreTable, "成绩");
        }

        /// <summary>
        /// 最终提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("最终提交后学生成绩将不可修改，是否确定提交", "提交成绩", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (rs == DialogResult.OK)
            {
                try
                {
                    this.CourseID = dgvScore.CurrentRow.Cells[1].Value.ToString().Trim();
                    string sql2 = "exec sf_成绩提交 " + this.CourseID;
                    SQLHelper.ExecuteNonQuery(sql2);
                    MessageBox.Show("成绩最终提交成功！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception express)
                {
                    MessageBox.Show(express.ToString(), "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //更新成绩单信息
                this.ScoreTable.Clear();
                ScoreTable = SQLHelper.ExecuteDataTable(sql);
                dgvScore.DataSource = ScoreTable;
            }
        }

        /// <summary>
        /// 修改成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //检查成绩单中是否有学生名单
            if (this.ScoreTable.Rows.Count == 0)
            {
                MessageBox.Show("该门课程成绩单为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //检查成绩字段
            if (txt4.Text.Trim() == "")
            {
                MessageBox.Show("必须输入学生成绩", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string studentNum = dgvScore.CurrentRow.Cells[0].Value.ToString().Trim();
            SQLHelper.ExecuteNonQuery("update 成绩表 set 成绩=@成绩 where 编号=@编号", new SqlParameter("成绩", txt4.Text.Trim()), new SqlParameter("编号", studentNum));
            //更新成绩单信息
            this.ScoreTable.Clear();
            ScoreTable = SQLHelper.ExecuteDataTable(sql);
            dgvScore.DataSource = ScoreTable;
        }

        /// <summary>
        /// 在【成绩】文本框中只允许输入数字和小数点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果按下键不是数字或者小数点或者删除键，则不响应
            if (!((e.KeyChar <= '9' && e.KeyChar >= '0') || e.KeyChar == '.' || e.KeyChar == 8))
                e.Handled = true;
        }

        

        
    }
}
