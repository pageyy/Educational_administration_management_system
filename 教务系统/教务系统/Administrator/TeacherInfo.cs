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
    public partial class TeacherInfo : Form
    {
        public TeacherInfo()
        {
            InitializeComponent();
        }

        private void TeacherInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“teachersInfoDateSet.教师信息”中。您可以根据需要移动或删除它。
            this.教师信息TableAdapter.Fill(this.teachersInfoDateSet.教师信息);

        }

        #region ToolBar按钮点击事件
        private void tbTeacherInfo_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
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
            教师信息BindingSource.MoveFirst();
            dgvTeacherInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转上一行记录
        /// </summary>
        private void 上一行_1()
        {
            教师信息BindingSource.MovePrevious();
            dgvTeacherInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转下一行记录
        /// </summary>
        private void 下一行_1()
        {
            教师信息BindingSource.MoveNext();
            dgvTeacherInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转末行记录
        /// </summary>
        private void 末行_1()
        {
            教师信息BindingSource.MoveLast();
            dgvTeacherInfo.CurrentRow.Selected = true;
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
            //职工号
            txtNo.ReadOnly = false;
            txtNo.Text = "";
            //姓名
            txtName.ReadOnly = false;
            txtName.Text = "";
            //性别
            cmbGender.Enabled = true;
            cmbGender.Text = "";
            //职称
            cmbZhiChen.Enabled = true;
            cmbZhiChen.Text = "";
            SQLHelper.CmbExecuteReader("select 职称编号,职称名称 from 职称代码表", cmbZhiChen);
            //政治面貌
            cmbZhengzhimianmao.Enabled = true;
            cmbZhengzhimianmao.Text = "";
            SQLHelper.CmbExecuteReader("select 政治面貌编号,政治面貌 from 政治面貌代码表", cmbZhengzhimianmao);
            //民族
            cmbMinzu.Enabled = true;
            cmbMinzu.Text = "";
            SQLHelper.CmbExecuteReader("select 民族编号,民族 from 民族代码表", cmbMinzu);
            //籍贯
            cmbJiguan.Enabled = true;
            cmbJiguan.Text = "";
            SQLHelper.CmbExecuteReader("select 籍贯编号,籍贯 from 籍贯代码表", cmbJiguan);
            //身份证号
            txtShenfenzheng.ReadOnly = false;
            txtShenfenzheng.Text = "";

            return;
        }

        /// <summary>
        /// 修改操作
        /// </summary>
        private void 修改_1()
        {
            Judge = "修改";
            if (dgvTeacherInfo.CurrentRow.Cells[0].Value.ToString() != "")//此处还有问题！！！！！！！！！！
            {
                //职工号
                //txtNo.ReadOnly = false;不让修改，防止脏数据
                //姓名
                txtName.ReadOnly = false;
                //性别
                cmbGender.Enabled = true;
                //职称
                cmbZhiChen.Enabled = true;
                SQLHelper.CmbExecuteReader("select 职称编号,职称名称 from 职称代码表", cmbZhiChen);
                //政治面貌
                cmbZhengzhimianmao.Enabled = true;
                SQLHelper.CmbExecuteReader("select 政治面貌编号,政治面貌 from 政治面貌代码表", cmbZhengzhimianmao);
                //民族
                cmbMinzu.Enabled = true;
                SQLHelper.CmbExecuteReader("select 民族编号,民族 from 民族代码表", cmbMinzu);
                //籍贯
                cmbJiguan.Enabled = true;
                SQLHelper.CmbExecuteReader("select 籍贯编号,籍贯 from 籍贯代码表", cmbJiguan);
                //身份证号
                txtShenfenzheng.ReadOnly = false;

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
            if (txtName.ReadOnly == true)
                return;
            if (txtNo.Text == "")
            {
                MessageBox.Show("职工号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                string 职工号 = txtNo.Text.Trim();
                string 姓名 = txtName.Text.Trim();
                string 性别 = cmbGender.Text.Trim();

                string 职称;
                if (cmbZhiChen.SelectedItem != null)
                {
                    职称 = cmbZhiChen.SelectedItem.ToString();
                }
                else
                {
                    职称 = cmbZhiChen.Text.Trim();
                }
                string 职称编号 = SQLHelper.ExecuteScalar("select 职称编号 from 职称代码表 where 职称名称=@职称", new SqlParameter("职称", 职称)).ToString();

                string 政治面貌;
                if (cmbZhengzhimianmao.SelectedItem != null)
                {
                    政治面貌 = cmbZhengzhimianmao.SelectedItem.ToString();
                }
                else
                {
                    政治面貌 = cmbZhengzhimianmao.Text.Trim();
                }
                string 政治面貌编号 = SQLHelper.ExecuteScalar("select 政治面貌编号 from 政治面貌代码表 where 政治面貌=@政治面貌", new SqlParameter("政治面貌", 政治面貌)).ToString();

                string 民族;
                if (cmbMinzu.SelectedItem != null)
                {
                    民族 = cmbMinzu.SelectedItem.ToString();
                }
                else
                {
                    民族 = cmbMinzu.Text.Trim();
                }
                string 民族编号 = SQLHelper.ExecuteScalar("select 民族编号 from 民族代码表 where 民族=@民族", new SqlParameter("民族", 民族)).ToString();

                string 籍贯;
                if (cmbJiguan.SelectedItem != null)
                {
                    籍贯 = cmbJiguan.SelectedItem.ToString();
                }
                else
                {
                    籍贯 = cmbJiguan.Text.Trim();
                }
                string 籍贯编号 = SQLHelper.ExecuteScalar("select 籍贯编号 from 籍贯代码表 where 籍贯=@籍贯", new SqlParameter("籍贯", 籍贯)).ToString();

                string 身份证号 = txtShenfenzheng.Text.Trim();

                if (Judge == "新增")
                {
                    SQLHelper.ExecuteNonQuery("Insert into 教师信息 values(@职工号,@姓名,@性别,@职称编号,@政治面貌编号,@民族编号,@籍贯编号,@身份证号)", new SqlParameter("职工号", 职工号), new SqlParameter("姓名", 姓名), new SqlParameter("性别", 性别), new SqlParameter("职称编号", 职称编号), new SqlParameter("政治面貌编号", 政治面貌编号), new SqlParameter("民族编号", 民族编号), new SqlParameter("籍贯编号", 籍贯编号), new SqlParameter("身份证号", 身份证号));
                    Judge = null;
                    updateLoginTea();//新增的同时将教师信息作为登录信息
                }
                else if (Judge == "修改")
                {
                    SQLHelper.ExecuteNonQuery("update 教师信息 set 职工号=@职工号,姓名=@姓名,性别=@性别,职称编号=@职称编号,政治面貌编号=@政治面貌编号,民族编号=@民族编号,籍贯编号=@籍贯编号,身份证号=@身份证号 where 职工号=@职工号", new SqlParameter("职工号", 职工号), new SqlParameter("姓名", 姓名), new SqlParameter("性别", 性别), new SqlParameter("职称编号", 职称编号), new SqlParameter("政治面貌编号", 政治面貌编号), new SqlParameter("民族编号", 民族编号), new SqlParameter("籍贯编号", 籍贯编号), new SqlParameter("身份证号", 身份证号));
                    Judge = null;
                }
                dgvTeacherInfo.DataSource = SQLHelper.ExecuteDataTable("select * from 教师信息");
                ReadOnly();
                MessageBox.Show("提交成功！");
                return;
            }

        }

        /// <summary>
        /// 恢复txt,cmb为只读状态
        /// </summary>
        private void ReadOnly()
        {
            txtNo.ReadOnly = true;
            txtName.ReadOnly = true;
            cmbGender.Enabled = false;
            cmbZhiChen.Enabled = false;
            cmbZhengzhimianmao.Enabled = false;
            cmbMinzu.Enabled = false;
            cmbJiguan.Enabled = false;
            txtShenfenzheng.ReadOnly = true;

            return;
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        private void 删除_1()
        {
            string 职工号 = this.dgvTeacherInfo.CurrentRow.Cells[0].Value.ToString();
            if (职工号 != "")
            {
                if (MessageBox.Show("删除后将无法恢复，确认删除吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SQLHelper.ExecuteNonQuery("delete  from 教师信息 where 职工号=@职工号", new SqlParameter("职工号", 职工号));
                    dgvTeacherInfo.DataSource = SQLHelper.ExecuteDataTable("select * from 教师信息");
                    MessageBox.Show("信息已成功删除！");
                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("请先选中要删除的行！");
            }
        }

        private void 取消_1()
        {
            ReadOnly();
            return;
        }
        #endregion

        #region 获取datagridview中点击数据
        private void dgvTeacherInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = -1;
            count = e.RowIndex;
            if (count != -1)
            {
                string 职工号 = this.dgvTeacherInfo.Rows[count].Cells[0].Value.ToString();//直接用
                if (职工号 != "")
                {
                    string 姓名 = this.dgvTeacherInfo.Rows[count].Cells[1].Value.ToString();//直接用
                    string 性别 = this.dgvTeacherInfo.Rows[count].Cells[2].Value.ToString();//直接用
                    string 职称编号 = this.dgvTeacherInfo.Rows[count].Cells[3].Value.ToString();//到职称代码表中查职称名称
                    string 政治面貌编号 = this.dgvTeacherInfo.Rows[count].Cells[4].Value.ToString();//到政治面貌表查政治面貌
                    string 民族编号 = this.dgvTeacherInfo.Rows[count].Cells[5].Value.ToString();//到民族表查名族
                    string 籍贯编号 = this.dgvTeacherInfo.Rows[count].Cells[6].Value.ToString();//到籍贯表查籍贯
                    string 身份证号 = this.dgvTeacherInfo.Rows[count].Cells[7].Value.ToString();//直接用

                    string 职称名称;
                    string 政治面貌;
                    string 民族;
                    string 籍贯;

                    职称名称 = SQLHelper.ExecuteScalar("select 职称名称 from 职称代码表 where 职称编号=@职称编号", new SqlParameter("职称编号", 职称编号)).ToString();
                    政治面貌 = SQLHelper.ExecuteScalar("select 政治面貌 from 政治面貌代码表 where 政治面貌编号=@政治面貌编号", new SqlParameter("政治面貌编号", 政治面貌编号)).ToString();
                    民族 = SQLHelper.ExecuteScalar("select 民族 from 民族代码表 where 民族编号=@民族编号", new SqlParameter("民族编号", 民族编号)).ToString();
                    籍贯 = SQLHelper.ExecuteScalar("select 籍贯 from 籍贯代码表 where 籍贯编号=@籍贯编号", new SqlParameter("籍贯编号", 籍贯编号)).ToString();

                    txtNo.Text = 职工号;
                    txtName.Text = 姓名;
                    cmbGender.Text = 性别;
                    cmbZhiChen.Text = 职称名称;
                    cmbZhengzhimianmao.Text = 政治面貌;
                    cmbMinzu.Text = 民族;
                    cmbJiguan.Text = 籍贯;
                    txtShenfenzheng.Text = 身份证号;
                }
            }
        }
        #endregion

        #region 搜索
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (txtSearchNo.Text != "" || txtSearchName.Text != "")
            {
                dt = SQLHelper.ExecuteDataTable("select * from 教师信息 where 职工号=@职工号 or 姓名=@姓名", new SqlParameter("职工号", txtSearchNo.Text.Trim()), new SqlParameter("姓名", txtSearchName.Text.Trim()));
            }
            else
            {
                dt = SQLHelper.ExecuteDataTable("select * from 教师信息");
            }
            dgvTeacherInfo.DataSource = dt;
        }
        #endregion

        #region 在教师登录表中插入新教师信息，初试用户名为职工号，密码为职工号
        private void updateLoginTea()
        {
            string no = txtNo.Text.Trim();
            //string name = txtName.Text.Trim();

            SQLHelper.ExecuteNonQuery("insert into Teacher_Login values(@Id,@UserName,@Password,0)", new SqlParameter("Id", Guid.NewGuid()), new SqlParameter("UserName", no), new SqlParameter("Password", no));
        }
        #endregion

    }
}
