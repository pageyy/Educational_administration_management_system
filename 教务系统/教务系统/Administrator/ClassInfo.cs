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
    public partial class ClassInfo : Form
    {
        public ClassInfo()
        {
            InitializeComponent();
        }

        private void ClassInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“eisbookDataSet.班级信息”中。您可以根据需要移动或删除它。
            this.班级信息TableAdapter.Fill(this.eisbookDataSet.班级信息);
        }


        /// <summary>
        /// 搜索班级信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (txtb1.Text != "" || txtb2.Text != "" || txtb3.Text != "")
            {
                dt = SQLHelper.ExecuteDataTable("select * from 班级信息 where 班级编号=@班级编号 or 年级=@年级 or 班级名称=@班级名称", new SqlParameter("班级编号", txtb1.Text.Trim()), new SqlParameter("年级", txtb2.Text.Trim()), new SqlParameter("班级名称", txtb3.Text.Trim()));
            }
            else
            {
                dt = SQLHelper.ExecuteDataTable("select * from 班级信息");
            }
            dGVClassInfo.DataSource = dt; 
        }

        /// <summary>
        /// 获取datagridview中点击数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGVClassInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = -1;
            count = e.RowIndex;
            if (count != -1)
            {
                string 班级编号 = this.dGVClassInfo.Rows[count].Cells[0].Value.ToString();
                string 年级 = this.dGVClassInfo.Rows[count].Cells[1].Value.ToString();
                string 班级名称 = this.dGVClassInfo.Rows[count].Cells[2].Value.ToString();
                string 班级简称 = this.dGVClassInfo.Rows[count].Cells[3].Value.ToString();
                string 人数 = this.dGVClassInfo.Rows[count].Cells[4].Value.ToString();
                string 班主任 = this.dGVClassInfo.Rows[count].Cells[5].Value.ToString();

                txtb4.Text = 班级编号;
                txtb5.Text = 年级;
                txtb6.Text = 班级名称;
                txtb7.Text = 班级简称;
                txtb8.Text = 人数;
                txtb9.Text = 班主任;
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// ToolBar按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbClassInfo_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
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
            班级信息BindingSource.MoveFirst();
            dGVClassInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转上一行记录
        /// </summary>
        private void 上一行_1()
        {
            班级信息BindingSource.MovePrevious();
            dGVClassInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转下一行记录
        /// </summary>
        private void 下一行_1()
        {
            班级信息BindingSource.MoveNext();
            dGVClassInfo.CurrentRow.Selected = true;
            return;
        }

        /// <summary>
        /// 跳转末行记录
        /// </summary>
        private void 末行_1()
        {
            班级信息BindingSource.MoveLast();
            dGVClassInfo.CurrentRow.Selected = true;
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
            txtb4.ReadOnly = false;
            txtb4.Text = "";
            txtb5.ReadOnly = false;
            txtb5.Text = "";
            txtb6.ReadOnly = false;
            txtb6.Text = "";
            txtb7.ReadOnly = false;
            txtb7.Text = "";
            txtb8.ReadOnly = false;
            txtb8.Text = "";
            txtb9.ReadOnly = false;
            txtb9.Text = "";

            return ;
        }
        
        /// <summary>
        /// 修改操作
        /// </summary>
        private void 修改_1()
        {
            Judge = "修改";
            if (dGVClassInfo.CurrentRow.Cells[0].Value.ToString() != "")//此处还有问题！！！！！！！！！！
            {
                txtb4.ReadOnly = false;
                txtb5.ReadOnly = false;
                txtb6.ReadOnly = false;
                txtb7.ReadOnly = false;
                txtb8.ReadOnly = false;
                txtb9.ReadOnly = false;
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
            
            if (txtb4.ReadOnly == true)
                return;
            if (txtb4.Text == "")
            {
                MessageBox.Show("班级编号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                if (Judge == "新增")
                {
                    SQLHelper.ExecuteNonQuery("Insert into 班级信息(班级编号,年级,班级名称,班级简称,人数,班主任) values(@班级编号,@年级,@班级名称,@班级简称,@人数,@班主任)", new SqlParameter("班级编号", txtb4.Text.Trim()), new SqlParameter("年级", txtb5.Text.Trim()), new SqlParameter("班级名称", txtb6.Text.Trim()), new SqlParameter("班级简称", txtb7.Text.Trim()), new SqlParameter("人数", txtb8.Text.Trim()), new SqlParameter("班主任", txtb9.Text.Trim()));
                }
                else if(Judge=="修改")
                {
                    SQLHelper.ExecuteNonQuery("update 班级信息 set 班级编号=@班级编号,年级=@年级,班级名称=@班级名称,班级简称=@班级简称,人数=@人数,班主任=@班主任 where 班级编号=@班级编号", new SqlParameter("班级编号", txtb4.Text.Trim()), new SqlParameter("年级", txtb5.Text.Trim()), new SqlParameter("班级名称", txtb6.Text.Trim()), new SqlParameter("班级简称", txtb7.Text.Trim()), new SqlParameter("人数", txtb8.Text.Trim()), new SqlParameter("班主任", txtb9.Text.Trim()));
                }
                dGVClassInfo.DataSource = SQLHelper.ExecuteDataTable("select * from 班级信息");
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
            txtb4.ReadOnly = true;
            txtb5.ReadOnly = true;
            txtb6.ReadOnly = true;
            txtb7.ReadOnly = true;
            txtb8.ReadOnly = true;
            txtb9.ReadOnly = true;
            return;
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        private void 删除_1()
        {
            string 班级编号 = this.dGVClassInfo.CurrentRow.Cells[0].Value.ToString();

            int Judge = SQLHelper.SelectExecuteReader("Select * from 学生信息 where 班级编号=@班级编号", new SqlParameter("班级编号", 班级编号));
            if (Judge > 0)
            {
                MessageBox.Show("该班级内仍有学生，不可以删除！");
                return;
            }
            else 
            {
                if (MessageBox.Show("删除后将无法恢复，确认删除吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SQLHelper.ExecuteNonQuery("delete  from 班级信息 where 班级编号=@班级编号", new SqlParameter("班级编号", 班级编号));
                    dGVClassInfo.DataSource = SQLHelper.ExecuteDataTable("select * from 班级信息");
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
        
    }
}
