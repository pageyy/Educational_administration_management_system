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
using System.Reflection;
using System.Collections;

namespace 教务系统
{
    public partial class CurriculumSchedule : Form
    {
        //课表
        private DataTable scheduleTable;
        //保存学生的课程信息
        private DataTable curriculumTable;

        public CurriculumSchedule(string viewID)
        {
            InitializeComponent();

            if (viewID != "")
            {
                this.curriculumTable = new DataTable();
                this.DataGridStateControl();

                this.LoadStudentInfo(viewID);//读入学生信息和选课信息
                this.LoadCurriculumInfo(viewID);
                this.curriculmToSchedule();

                this.AutoSizeGrid();
                txt1.Text = viewID;//显示学号
                gbStudentInfo.Enabled = false;//不允许改变显示的信息
            }
            else
            {
                this.curriculumTable = new DataTable();
                this.DataGridStateControl();
                this.AutoSizeGrid();
            }
        }

        

        /// <summary>
        /// 课程表格式设计
        /// </summary>
        private void DataGridStateControl()
        {
            scheduleTable = new DataTable();
            scheduleTable.Columns.Add("星期一", typeof(string));
            scheduleTable.Columns.Add("星期二", typeof(string));
            scheduleTable.Columns.Add("星期三", typeof(string));
            scheduleTable.Columns.Add("星期四", typeof(string));
            scheduleTable.Columns.Add("星期五", typeof(string));
            scheduleTable.Columns.Add("星期六", typeof(string));
            scheduleTable.Columns.Add("星期日", typeof(string));

            this.dgCourseElected.DataSource = scheduleTable;
            //向表中添加5行，代表一天共有五节大课
            for (int i = 0; i < 5; i++)
            {
                scheduleTable.Rows.Add(scheduleTable.NewRow());
            }

            //设计表格样式
            //DataGridViewCellStyle ds = new DataGridViewCellStyle();
            //DataGridViewTextBoxColumn aColumnTextColumn;
            DataGridTableStyle ts = new DataGridTableStyle();
            DataGridTextBoxColumn aColumnTextColumn;
            ts.AllowSorting = false;
            ts.AlternatingBackColor = Color.LightGray;
            ts.MappingName = scheduleTable.TableName;

            for (int i = 0; i < 7; i++)
            {
                aColumnTextColumn = new DataGridTextBoxColumn();
                aColumnTextColumn.ReadOnly = true;
                aColumnTextColumn.Width = dgCourseElected.Size.Width / 7;
                aColumnTextColumn.TextBox.Height = dgCourseElected.Size.Height / 5;
                
                aColumnTextColumn.MappingName = scheduleTable.Columns[i].ColumnName;
                aColumnTextColumn.HeaderText = scheduleTable.Columns[i].ColumnName;
                aColumnTextColumn.NullText = "";
                aColumnTextColumn.Format = "N";//设置为数字格式显示
                ts.GridColumnStyles.Add(aColumnTextColumn);
                
            }
            dgCourseElected.TableStyles.Add(ts);
        }

        /// <summary>
        /// 读取学生课表信息
        /// </summary>
        /// <param name="id"></param>
        private void LoadCurriculumInfo(string id)
        {
            this.curriculumTable.Clear();
            curriculumTable = SQLHelper.ExecuteDataTable("select 课程名称,教师,上课时间天,上课时间节,上课地点 from CourseElected where 学号=@学号", new SqlParameter("学号", id));
            //dgCourseElected.DataSource = curriculumTable;
        }

        /// <summary>
        /// 读取学生信息
        /// </summary>
        /// <param name="id"></param>
        private void LoadStudentInfo(string id)
        {
            //清空学生信息
            txt2.Clear();
            txt3.Clear();

            //判断学生身份及在籍状况
            string connStr = ConfigurationManager.ConnectionStrings["教务系统.Properties.Settings.eisbookConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText ="select a.姓名,b.班级名称,a.学籍编号 from 学生信息 a,班级信息 b where(a.班级编号=b.班级编号)and(学号='"+id+"')";
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (!dr.HasRows)
            {
                MessageBox.Show("无此学生，请重新输入学号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dr.Close();
                return;
            }
            if (dr.GetValue(2).ToString().Trim() != "1")
            {
                MessageBox.Show("该学生并非在籍学生，无课表", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //姓名
            txt2.Text = dr.GetValue(0).ToString().Trim();
            //班级名称
            txt3.Text = dr.GetValue(1).ToString().Trim();
            dr.Close();
        }

        /// <summary>
        /// 将所选课程信息填充在课表中
        /// </summary>
        private void curriculmToSchedule()
        {
            this.scheduleTable.Clear();
            for (int i = 0; i < 5; i++)
            {
                scheduleTable.Rows.Add(scheduleTable.NewRow());
            }
            foreach (DataRow aRow in this.curriculumTable.Rows)
            {
                int day = Convert.ToInt32(aRow["上课时间天"]);
                int sec = Convert.ToInt32(aRow["上课时间节"]);
                this.scheduleTable.Rows[sec - 1][day - 1] = aRow["课程名称"].ToString().Trim() +"\n"+ aRow["上课地点"].ToString().Trim() +"\n"+ aRow["教师"].ToString().Trim();
            }
        }

        /// <summary>
        /// 自动设置dataGrid中的行宽度
        /// </summary>
        public void AutoSizeGrid()
        {
            int numRows = ((DataTable)dgCourseElected.DataSource).Rows.Count;
            Graphics g = Graphics.FromHwnd(dgCourseElected.Handle);
            StringFormat sf = new StringFormat(StringFormat.GenericTypographic);
            SizeF size;
            //由于DataGrid没有提供对DataGridRows[]的直接调用，因此我们使用一个反射（relection）来实现它
            //这个方法实际上取得dataGrid中行的集合，通过get_DataGridRows方法返回Rows的集合
            //并转化为一个System.Array对象 
            MethodInfo mi = dgCourseElected.GetType().GetMethod("get_DataGridRows", BindingFlags.FlattenHierarchy | BindingFlags.IgnoreCase | BindingFlags.Instance|BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
            System.Array dgra = (System.Array)mi.Invoke(dgCourseElected, null);

            // 将其转换为ArrayList
            ArrayList DataGridRows = new ArrayList();
            foreach (object dgrr in dgra)
            {
                if (dgrr.ToString().EndsWith("DataGridRelationshipRow") == true)
                    DataGridRows.Add(dgrr);
            }
            //枚举dataGrid中的所有行 
            for (int i = 0; i < numRows; ++i)
            {
                size = g.MeasureString(dgCourseElected[i, 1].ToString(), dgCourseElected.Font, 400, sf);
                int h = Convert.ToInt32(80);//直接将每行的行高设置为40
                //用下面这行代码可以根据dataGrid中字体自动调整行高
                //int h = Convert.ToInt32(size.Height); 
                // 考虑到表格表头的高度，可以适当加高 
                h = h + 8;

                // 将定好的行高设置回dataGrid中 
                PropertyInfo pi = DataGridRows[i].GetType().GetProperty("Height");
                pi.SetValue(DataGridRows[i], h, null);
            }
            g.Dispose();
        }

        /// <summary>
        /// 输入学号后回车，显示课表信息和学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt1.Text.Trim() != "" && e.KeyChar == 13)
            {
                this.LoadStudentInfo(txt1.Text.Trim());//读入学生信息
                this.LoadCurriculumInfo(txt1.Text.Trim());//读入选课表信息
                this.curriculmToSchedule();//将选课内容显示在课表中
                this.AutoSizeGrid();
            }
        }     
    }
}
