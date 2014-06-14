using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using JWSys.Model;

namespace 教务系统
{
    public partial class CourseInfo : Form
    {
        public CourseInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化操作 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CourseInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“courseInfoDateSet.课程信息”中。您可以根据需要移动或删除它。
            this.课程信息TableAdapter.Fill(this.courseInfoDateSet.课程信息);

        }

        #region 搜索课程信息
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (txt1.Text != "" || txt2.Text != "" || txt3.Text != "")
            {
                dt = SQLHelper.ExecuteDataTable("select * from 课程信息 where 课程编号=@课程编号 or 课程名称=@课程名称 or 拼音码=@拼音码", new SqlParameter("课程编号", txt1.Text.Trim()), new SqlParameter("课程名称", txt2.Text.Trim()), new SqlParameter("拼音码", txt3.Text.Trim()));
            }
            else
            {
                dt = SQLHelper.ExecuteDataTable("select * from 课程信息");
            }
            dgvCourseInfo.DataSource = dt;
        }
        #endregion

        #region 获取datagridview中点击数据
        private void dgvCourseInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = -1;
            count = e.RowIndex;
            if (count != -1)
            {
                string 课程编号 = this.dgvCourseInfo.Rows[count].Cells[0].Value.ToString();
                string 课程名称 = this.dgvCourseInfo.Rows[count].Cells[1].Value.ToString();
                string 课程简称 = this.dgvCourseInfo.Rows[count].Cells[2].Value.ToString();
                string 拼音码 = this.dgvCourseInfo.Rows[count].Cells[3].Value.ToString();
                string 本学期课程 = this.dgvCourseInfo.Rows[count].Cells[4].Value.ToString();
                string 教师 = this.dgvCourseInfo.Rows[count].Cells[5].Value.ToString();
                string 开课系别 = this.dgvCourseInfo.Rows[count].Cells[6].Value.ToString();
                string 学分 = this.dgvCourseInfo.Rows[count].Cells[7].Value.ToString();
                string 课程容量 = this.dgvCourseInfo.Rows[count].Cells[8].Value.ToString();

                txt4.Text = 课程编号;
                txt5.Text = 课程名称;
                txt6.Text = 课程简称;
                txt7.Text = 拼音码;
                cmb1.Text = 本学期课程;
                cmbTeaName.Text = 教师;
                txt9.Text = 开课系别;
                txt10.Text = 学分;
                txt12.Text = 课程容量;
            }
            return;
        }
        #endregion

        #region ToolBar按钮点击事件
        private void tbCourseInfo_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (e.Button.Name)
            {
                //首记录
                case "toolBarButton1":
                    首行_1();
                    break;
                //上一记录
                case "toolBarButton2":
                    上一行_1();
                    break;
                //下一记录
                case "toolBarButton3":
                    下一行_1();
                    break;
                //尾记录
                case "toolBarButton4":
                    末行_1();
                    break;
                //新增
                case "toolBarButton5":
                    新增_1();
                    break;
                //修改
                case "toolBarButton6":
                    修改_1();
                    break;
                //删除
                case "toolBarButton7":
                    删除_1();
                    break;
                //提交
                case "toolBarButton8":
                    提交_1();
                    break;
                //取消
                case "toolBarButton9":
                    取消_1();
                    break;
                //退出
                case "toolBarButton10":
                    this.Close();
                    break;
                default:
                    return;
            }
        }

        /// <summary>
        /// 跳转首行记录
        /// </summary>
        private void 首行_1()
        {
            课程信息BindingSource.MoveFirst();
            dgvCourseInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转上一行记录
        /// </summary>
        private void 上一行_1()
        {
            课程信息BindingSource.MovePrevious();
            dgvCourseInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转下一行记录
        /// </summary>
        private void 下一行_1()
        {
            课程信息BindingSource.MoveNext();
            dgvCourseInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转末行记录
        /// </summary>
        private void 末行_1()
        {
            课程信息BindingSource.MoveLast();
            dgvCourseInfo.CurrentRow.Selected = true;
            return;
        }

        //判断是新增还是修改
        string Judge = null;

        /// <summary>
        /// 新增记录
        /// </summary>
        /// <returns></returns>
        private void 新增_1()
        {
            Judge = "新增";
            //课程编号;
            txt4.ReadOnly = false;
            txt4.Text = "";
            //课程名称
            txt5.ReadOnly = false;
            txt5.Text = "";
            //课程简称
            txt6.ReadOnly = false;
            txt6.Text = "";
            //拼音码
            txt7.ReadOnly = false;
            txt7.Text = "";
            //本学期课程
            cmb1.Enabled = true;
            cmb1.Text = "";
            //教师
            cmbTeaName.Enabled = true;
            SQLHelper.CmbExecuteReader("select 职工号,姓名 from [eisbook].[dbo].[教师信息]", cmbTeaName);
            cmbTeaName.Text = "";
            //开课系别
            txt9.ReadOnly = false;
            txt9.Text = "";
            //学分
            txt10.ReadOnly = false;
            txt10.Text = "";
            //课程容量
            txt12.ReadOnly = false;
            txt12.Text = "";
           
            return;
        }

        /// <summary>
        /// 修改操作
        /// </summary>
        private void 修改_1()
        {
            Judge = "修改";
            if (dgvCourseInfo.CurrentRow.Cells[0].Value.ToString() != "")//此处还有问题！！！！！！！！！！
            {
                txt4.ReadOnly = false;
                txt5.ReadOnly = false;
                txt6.ReadOnly = false;
                txt7.ReadOnly = false;
                cmb1.Enabled = true;
                cmbTeaName.Enabled = true;
                SQLHelper.CmbExecuteReader("select 职工号,姓名 from [eisbook].[dbo].[教师信息]", cmbTeaName);
                txt9.ReadOnly = false;
                txt10.ReadOnly = false;
                txt12.ReadOnly = false;
                return;
            }
            else
            {
                MessageBox.Show("请先选择修改行！");
                return;
            }
        }

        /// <summary>
        /// 提交记录:有问题：修改的combobox不能选，提交出问题，，，，，
        /// </summary>
        private void 提交_1()
        {
            if (txt4.ReadOnly == true)
                return;
            if (txt4.Text == "")
            {
                MessageBox.Show("学号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                string 课程编号 = txt4.Text.Trim();
                string 课程名称 = txt5.Text.Trim();
                string 课程简称 = txt6.Text.Trim();
                string 拼音码 = txt7.Text.Trim();
                string 本学期课程 = cmb1.Text.Trim();
                string 教师 = cmbTeaName.Text.Trim();
                string 开课系别 = txt9.Text.Trim();
                string 学分 = txt10.Text.Trim();
                string 课程容量 = txt12.Text.Trim();
                //找到选中item的教师职工号
                int selected = 0;
                for (int i = 0; i < cmbTeaName.Items.Count; i++)
                {
                    if (((CmbAttributes)cmbTeaName.Items[i]).name == 教师)
                    {
                        selected = i;
                    }
                }
                string 教职工号 = ((CmbAttributes)cmbTeaName.Items[selected]).id;
                
                if (Judge == "新增")
                {
                    SQLHelper.ExecuteNonQuery("Insert into 课程信息 values(@课程编号,@课程名称,@课程简称,@拼音码,@本学期课程,@教师,@开课系别,@学分,@课程容量,@教职工号,@剩余容量)", new SqlParameter("课程编号", 课程编号), new SqlParameter("课程名称", 课程名称), new SqlParameter("课程简称", 课程简称), new SqlParameter("拼音码", 拼音码), new SqlParameter("本学期课程", 本学期课程), new SqlParameter("教师", 教师), new SqlParameter("开课系别", 开课系别), new SqlParameter("学分", 学分), new SqlParameter("课程容量", 课程容量), new SqlParameter("教职工号", 教职工号),new SqlParameter("剩余容量",课程容量));
                    Judge = null;
                }
                else if (Judge == "修改")
                {
                    SQLHelper.ExecuteNonQuery("update 课程信息 set 课程编号=@课程编号,课程名称=@课程名称,课程简称=@课程简称,拼音码=@拼音码,本学期课程=@本学期课程,教师=@教师,开课系别=@开课系别,学分=@学分,课程容量=@课程容量,教职工号=@教职工号,剩余容量=@剩余容量 where 课程编号=@课程编号", new SqlParameter("课程编号", 课程编号), new SqlParameter("课程名称", 课程名称), new SqlParameter("课程简称", 课程简称), new SqlParameter("拼音码", 拼音码), new SqlParameter("本学期课程", 本学期课程), new SqlParameter("教师", 教师), new SqlParameter("开课系别", 开课系别), new SqlParameter("学分", 学分), new SqlParameter("课程容量", 课程容量), new SqlParameter("教职工号", 教职工号), new SqlParameter("剩余容量", 课程容量));
                    Judge = null;
                }
                dgvCourseInfo.DataSource = SQLHelper.ExecuteDataTable("select * from 课程信息");
                ReadOnly();
                MessageBox.Show("提交成功！");
                return;
            }
        }

        /// <summary>
        /// 恢复txtb4-txtb7,cmb1-cmb6为只读状态
        /// </summary>
        private void ReadOnly()
        {
            txt4.ReadOnly = true;
            txt5.ReadOnly = true;
            txt6.ReadOnly = true;
            txt7.ReadOnly = true;
            cmb1.Enabled = false;
            cmbTeaName.Enabled = false;
            txt9.ReadOnly = true;
            txt10.ReadOnly = true;
            cmbTeaName.Enabled = false;
            txt12.ReadOnly = true;
            return;
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        private void 删除_1()
        {
            string 课程编号 = this.dgvCourseInfo.CurrentRow.Cells[0].Value.ToString();

            int JudgeCourse = SQLHelper.SelectExecuteReader("Select * from 课程表 where 课程编号=@课程编号", new SqlParameter("课程编号", 课程编号));
            if (JudgeCourse > 0)
            {
                MessageBox.Show("该课程已有学生选修，不可以删除！");
                return;
            }
            else
            {
                if (MessageBox.Show("删除后将无法恢复，确认删除吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SQLHelper.ExecuteNonQuery("delete  from 课程信息 where 课程编号=@课程编号", new SqlParameter("课程编号", 课程编号));
                    dgvCourseInfo.DataSource = SQLHelper.ExecuteDataTable("select * from 课程信息");
                    MessageBox.Show("信息已成功删除！");
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// 取消操作
        /// </summary>
        private void 取消_1()
        {
            ReadOnly();
            return;
        }
        #endregion
    }
}
