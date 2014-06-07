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
    public partial class StudentsInfo : Form
    {
        public StudentsInfo()
        {
            InitializeComponent();
        }

        private void StudentsInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“eisbookDataSet.学生信息”中。您可以根据需要移动或删除它。
            this.学生信息TableAdapter.Fill(this.eisbookDataSet.学生信息);

        }

        public MainForm MidParent
        {
            get;
            set;
        }

        #region 搜索学生信息
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (txt1.Text != "" || txt2.Text != "" || txt3.Text != "")
            {
                dt = SQLHelper.ExecuteDataTable("select * from 学生信息 where 学号=@学号 or 姓名=@姓名 or 年级=@年级", new SqlParameter("学号", txt1.Text.Trim()), new SqlParameter("姓名", txt2.Text.Trim()), new SqlParameter("年级", txt3.Text.Trim()));
            }
            else
            {
                dt = SQLHelper.ExecuteDataTable("select * from 学生信息");
            }
            dgvStudentsInfo.DataSource = dt;
        }

        #endregion

        #region 获取datagridview中点击数据
        private void dgvStudentsInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = -1;
            count = e.RowIndex;
            if (count != -1)
            {
                string 学号 = this.dgvStudentsInfo.Rows[count].Cells[0].Value.ToString();//直接用
                if (学号 != "")
                {
                    string 姓名 = this.dgvStudentsInfo.Rows[count].Cells[1].Value.ToString();//直接用
                    string 班级编号 = this.dgvStudentsInfo.Rows[count].Cells[2].Value.ToString();//到班级课表查班级名称
                    string 性别 = this.dgvStudentsInfo.Rows[count].Cells[3].Value.ToString();//直接用
                    string 年级 = this.dgvStudentsInfo.Rows[count].Cells[4].Value.ToString();//直接用
                    string 政治面貌编号 = this.dgvStudentsInfo.Rows[count].Cells[5].Value.ToString();//到政治面貌表查政治面貌
                    string 民族编号 = this.dgvStudentsInfo.Rows[count].Cells[6].Value.ToString();//到民族表查名族
                    string 籍贯编号 = this.dgvStudentsInfo.Rows[count].Cells[7].Value.ToString();//到籍贯表查籍贯
                    string 身份证号 = this.dgvStudentsInfo.Rows[count].Cells[8].Value.ToString();//直接用
                    string 学籍编号 = this.dgvStudentsInfo.Rows[count].Cells[9].Value.ToString();//到学籍表查学籍

                    string 班级名称;
                    string 政治面貌;
                    string 民族;
                    string 籍贯;
                    string 学籍;

                    班级名称 = SQLHelper.ExecuteScalar("select 班级名称 from 班级信息 where 班级编号=@班级编号", new SqlParameter("班级编号", 班级编号)).ToString();
                    政治面貌 = SQLHelper.ExecuteScalar("select 政治面貌 from 政治面貌代码表 where 政治面貌编号=@政治面貌编号", new SqlParameter("政治面貌编号", 政治面貌编号)).ToString();
                    民族 = SQLHelper.ExecuteScalar("select 民族 from 民族代码表 where 民族编号=@民族编号", new SqlParameter("民族编号", 民族编号)).ToString();
                    籍贯 = SQLHelper.ExecuteScalar("select 籍贯 from 籍贯代码表 where 籍贯编号=@籍贯编号", new SqlParameter("籍贯编号", 籍贯编号)).ToString();
                    学籍 = SQLHelper.ExecuteScalar("select 学籍名称 from 学籍代码表 where 学籍编号=@学籍编号", new SqlParameter("学籍编号", 学籍编号)).ToString();

                    txt4.Text = 学号;
                    txt5.Text = 姓名;
                    cmb1.Text = 性别;
                    txt6.Text = 年级;
                    cmb2.Text = 班级名称;
                    txt7.Text = 身份证号;
                    cmb3.Text = 政治面貌;
                    cmb4.Text = 民族;
                    cmb5.Text = 籍贯;
                    cmb6.Text = 学籍;
                }
            }
        }
        #endregion

        #region ToolBar按钮点击事件
        private void tbStudentsInfo_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
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
            学生信息BindingSource.MoveFirst();
            dgvStudentsInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转上一行记录
        /// </summary>
        private void 上一行_1()
        {
            学生信息BindingSource.MovePrevious();
            dgvStudentsInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转下一行记录
        /// </summary>
        private void 下一行_1()
        {
            学生信息BindingSource.MoveNext();
            dgvStudentsInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转末行记录
        /// </summary>
        private void 末行_1()
        {
            学生信息BindingSource.MoveLast();
            dgvStudentsInfo.CurrentRow.Selected = true;
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
            //学号
            txt4.ReadOnly = false;
            txt4.Text = "";
            //姓名
            txt5.ReadOnly = false;
            txt5.Text = "";
            //性别
            cmb1.Enabled = true;
            cmb1.Text = "";
            //年级
            txt6.ReadOnly = false;
            txt6.Text = "";
            //班级名称
            cmb2.Enabled = true;
            cmb2.Text = "";
            SQLHelper.CmbExecuteReader("select distinct 班级编号,班级名称 from 班级信息", cmb2);
            //身份证号
            txt7.ReadOnly = false;
            txt7.Text = "";
            //政治面貌
            cmb3.Enabled = true;
            cmb3.Text = "";
            SQLHelper.CmbExecuteReader("select 政治面貌编号,政治面貌 from 政治面貌代码表", cmb3);
            //民族
            cmb4.Enabled = true;
            cmb4.Text = "";
            SQLHelper.CmbExecuteReader("select 民族编号,民族 from 民族代码表", cmb4);
            //籍贯
            cmb5.Enabled = true;
            cmb5.Text = "";
            SQLHelper.CmbExecuteReader("select 籍贯编号,籍贯 from 籍贯代码表", cmb5);
            //学籍
            cmb6.Enabled = true;
            cmb6.Text = "";
            SQLHelper.CmbExecuteReader("select 学籍编号,学籍名称 from 学籍代码表", cmb6);

            return;
        }

        /// <summary>
        /// 修改操作
        /// </summary>
        private void 修改_1()
        {
            Judge = "修改";
            if (dgvStudentsInfo.CurrentRow.Cells[0].Value.ToString() != "")//此处还有问题！！！！！！！！！！
            {
                txt4.ReadOnly = false;
                txt5.ReadOnly = false;
                cmb1.Enabled = true;
                txt6.ReadOnly = false;
                cmb2.Enabled = true;
                SQLHelper.CmbExecuteReader("select 班级编号,班级名称 from 班级信息", cmb2);
                txt7.ReadOnly = false;
                cmb3.Enabled = true;
                SQLHelper.CmbExecuteReader("select 政治面貌编号,政治面貌 from 政治面貌代码表", cmb3);
                cmb4.Enabled = true;
                SQLHelper.CmbExecuteReader("select 民族编号,民族 from 民族代码表", cmb4);
                cmb5.Enabled = true;
                SQLHelper.CmbExecuteReader("select 籍贯编号,籍贯 from 籍贯代码表", cmb5);
                cmb6.Enabled = true;
                SQLHelper.CmbExecuteReader("select 学籍编号,学籍名称 from 学籍代码表", cmb6);
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
            //if (Judge == "新增")
            //{
            if (txt4.Text == "")
            {
                MessageBox.Show("学号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                string 学号 = txt4.Text.Trim();
                string 姓名 = txt5.Text.Trim();
                string 班级名称;
                if (cmb2.SelectedItem != null)
                {
                    班级名称 = cmb2.SelectedItem.ToString();
                }
                else
                {
                    班级名称 = cmb2.Text.Trim();
                }
                string 班级编号 = SQLHelper.ExecuteScalar("select 班级编号 from 班级信息 where 班级名称=@班级名称", new SqlParameter("班级名称", 班级名称)).ToString();
                string 性别 = cmb1.Text.Trim();
                string 年级 = txt6.Text.Trim();
                string 政治面貌;
                if (cmb3.SelectedItem != null)
                {
                    政治面貌 = cmb3.SelectedItem.ToString();
                }
                else
                {
                    政治面貌 = cmb3.Text.Trim();
                }
                string 政治面貌编号 = SQLHelper.ExecuteScalar("select 政治面貌编号 from 政治面貌代码表 where 政治面貌=@政治面貌", new SqlParameter("政治面貌", 政治面貌)).ToString();
                string 民族;
                if (cmb4.SelectedItem != null)
                {
                    民族 = cmb4.SelectedItem.ToString();
                }
                else
                {
                    民族 = cmb4.Text.Trim();
                }
                string 民族编号 = SQLHelper.ExecuteScalar("select 民族编号 from 民族代码表 where 民族=@民族", new SqlParameter("民族", 民族)).ToString();
                string 籍贯;
                if (cmb5.SelectedItem != null)
                {
                    籍贯 = cmb5.SelectedItem.ToString();
                }
                else
                {
                    籍贯 = cmb5.Text.Trim();
                }
                string 籍贯编号 = SQLHelper.ExecuteScalar("select 籍贯编号 from 籍贯代码表 where 籍贯=@籍贯", new SqlParameter("籍贯", 籍贯)).ToString();
                string 身份证号 = txt7.Text.Trim();
                string 学籍名称;
                if (cmb6.SelectedItem != null)
                {
                    学籍名称 = cmb6.SelectedItem.ToString();
                }
                else
                {
                    学籍名称 = cmb6.Text.Trim();
                }
                string 学籍编号 = SQLHelper.ExecuteScalar("select 学籍编号 from 学籍代码表 where 学籍名称=@学籍名称", new SqlParameter("学籍名称", 学籍名称)).ToString();
                if (Judge == "新增")
                {
                    SQLHelper.ExecuteNonQuery("Insert into 学生信息 values(@学号,@姓名,@班级编号,@性别,@年级,@政治面貌编号,@民族编号,@籍贯编号,@身份证号,@学籍编号)", new SqlParameter("学号", 学号), new SqlParameter("姓名", 姓名), new SqlParameter("班级编号", 班级编号), new SqlParameter("性别", 性别), new SqlParameter("年级", 年级), new SqlParameter("政治面貌编号", 政治面貌编号), new SqlParameter("民族编号", 民族编号), new SqlParameter("籍贯编号", 籍贯编号), new SqlParameter("身份证号", 身份证号), new SqlParameter("学籍编号", 学籍编号));
                    Judge = null;
                    updateLoginStu();//更新loginStu表，注意不能这句不能放在最后，防止每次修改时都新增用户信息到登录表
                }
                else if (Judge == "修改")
                {
                    SQLHelper.ExecuteNonQuery("update 学生信息 set 学号=@学号,姓名=@姓名,班级编号=@班级编号,性别=@性别,年级=@年级,政治面貌编号=@政治面貌编号,民族编号=@民族编号,籍贯编号=@籍贯编号,身份证号=@身份证号,学籍编号=@学籍编号 where 学号=@学号", new SqlParameter("学号", 学号), new SqlParameter("姓名", 姓名), new SqlParameter("班级编号", 班级编号), new SqlParameter("性别", 性别), new SqlParameter("年级", 年级), new SqlParameter("政治面貌编号", 政治面貌编号), new SqlParameter("民族编号", 民族编号), new SqlParameter("籍贯编号", 籍贯编号), new SqlParameter("身份证号", 身份证号), new SqlParameter("学籍编号", 学籍编号));
                    Judge = null;
                }
                dgvStudentsInfo.DataSource = SQLHelper.ExecuteDataTable("select * from 学生信息");
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
            cmb2.Enabled = false;
            cmb3.Enabled = false;
            cmb4.Enabled = false;
            cmb5.Enabled = false;
            cmb6.Enabled = false;
            return;
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        private void 删除_1()
        {
            string 学号 = this.dgvStudentsInfo.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("删除后将无法恢复，确认删除吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLHelper.ExecuteNonQuery("delete  from 学生信息 where 学号=@学号", new SqlParameter("学号", 学号));
                dgvStudentsInfo.DataSource = SQLHelper.ExecuteDataTable("select * from 学生信息");
                MessageBox.Show("信息已成功删除！");
                return;
            }
            else
            {
                return;
            }
        }


        private void 取消_1()
        {
            ReadOnly();
            return;
        }
        #endregion

        #region 在学生登录表中插入新生信息，初试用户名为姓名，密码为学号
        private void updateLoginStu()
        {
            string no = txt4.Text.Trim();
            string name = txt5.Text.Trim();

            SQLHelper.ExecuteNonQuery("insert into Student_Login values(@Id,@UserName,@Password,0)", new SqlParameter("Id", Guid.NewGuid()), new SqlParameter("UserName", name), new SqlParameter("Password", no));
        }
        #endregion

    }
}

