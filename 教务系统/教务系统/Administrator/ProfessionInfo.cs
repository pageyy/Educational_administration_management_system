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
    public partial class ProfessionInfo : Form
    {
        public ProfessionInfo()
        {
            InitializeComponent();
        }

        private void ProfessionInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“eisbookDataSet1.专业信息表”中。您可以根据需要移动或删除它。
            this.专业信息表TableAdapter.Fill(this.eisbookDataSet1.专业信息表);

            SQLHelper.CmbExecuteReader("Select 专业名称 from [eisbook].[dbo].[专业信息表]", cmbSearch);

            //dgvProfessionInfo.DataSource = SQLHelper.ExecuteDataTable("select * from [eisbook].[dbo].[专业信息表]");
        }

        #region 菜单栏功能
        private void tbProfessionInfo_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
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
            专业信息表BindingSource.MoveFirst();
            dgvProfessionInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转上一行记录
        /// </summary>
        private void 上一行_1()
        {
            专业信息表BindingSource.MovePrevious();
            dgvProfessionInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转下一行记录
        /// </summary>
        private void 下一行_1()
        {
            专业信息表BindingSource.MoveNext();
            dgvProfessionInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转末行记录
        /// </summary>
        private void 末行_1()
        {
            专业信息表BindingSource.MoveLast();
            dgvProfessionInfo.CurrentRow.Selected = true;
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
            txtNo.ReadOnly = false;
            txtNo.Text = "";
            txtName.ReadOnly = false;
            txtName.Text = "";
            
            return;
        }

        /// <summary>
        /// 修改操作
        /// </summary>
        private void 修改_1()
        {
            Judge = "修改";
            if (dgvProfessionInfo.CurrentRow.Cells[0].Value.ToString() != "")//此处还有问题！！！！！！！！！！
            {
                txtNo.ReadOnly = false;
                txtName.ReadOnly = false;
                return;
            }
            else
            {
                MessageBox.Show("请先选择修改行！");
                return;
            }
        }

        /// <summary>
        /// 提交记录
        /// </summary>
        private void 提交_1()
        {

            if (txtNo.ReadOnly == true)
                return;
            if (txtNo.Text == "")
            {
                MessageBox.Show("专业编号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                if (Judge == "新增")
                {
                    SQLHelper.ExecuteNonQuery("Insert into [eisbook].[dbo].[专业信息表](专业编号,专业名称) values(@专业编号,@专业名称)", new SqlParameter("专业编号", txtNo.Text.Trim()), new SqlParameter("专业名称", txtName.Text.Trim()));
                }
                else if (Judge == "修改")
                {
                    SQLHelper.ExecuteNonQuery("update [eisbook].[dbo].[专业信息表] set 专业编号=@专业编号,专业名称=@专业名称 where 专业编号=@专业编号", new SqlParameter("专业编号", txtNo.Text.Trim()), new SqlParameter("专业名称", txtName.Text.Trim()));
                }
                dgvProfessionInfo.DataSource = SQLHelper.ExecuteDataTable("select * from [eisbook].[dbo].[专业信息表]");
                TxtReadOnly();
                MessageBox.Show("提交成功！");
                return;
            }
        }

        /// <summary>
        /// 恢复txtb4-txtb9为只读状态
        /// </summary>
        private void TxtReadOnly()
        {
            txtNo.ReadOnly = true;
            txtName.ReadOnly = true;
            
            return;
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        private void 删除_1()
        {
            string 专业编号 = this.dgvProfessionInfo.CurrentRow.Cells[0].Value.ToString();

            int Judge = SQLHelper.SelectExecuteReader("Select * from [eisbook].[dbo].[班级信息] where 专业编号=@专业编号", new SqlParameter("专业编号", 专业编号));
            if (Judge > 0)
            {
                MessageBox.Show("该专业内仍有班级存在，不可以删除！若确定要删除，请先删除该专业内所有班级信息！");
                return;
            }
            else
            {
                if (MessageBox.Show("删除后将无法恢复，确认删除吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SQLHelper.ExecuteNonQuery("delete  from [eisbook].[dbo].[专业信息表] where 专业编号=@专业编号", new SqlParameter("专业编号", 专业编号));
                    dgvProfessionInfo.DataSource = SQLHelper.ExecuteDataTable("select * from [eisbook].[dbo].[专业信息表]");
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
            TxtReadOnly();
            return;
        }
        #endregion

        //搜索功能
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }



    }
}
