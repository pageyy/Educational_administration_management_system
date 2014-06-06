using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace 教务系统
{
    class SQLHelper
    {
        /// <summary>
        /// sql语句执行函数:inert,delete,update
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            string connStr = ConfigurationManager.ConnectionStrings["教务系统.Properties.Settings.eisbookConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// sql语句执行函数：select专业，返回受影响行数，由于ExecuteNonQuery只能在执行Update、Insert 和 Delete时，返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int SelectExecuteReader(string sql, params SqlParameter[] parameters)
        {
            string connStr = ConfigurationManager.ConnectionStrings["教务系统.Properties.Settings.eisbookConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count++;
                    }
                    //MessageBox.Show(count.ToString());
                    return count;
                }
            }
        }


        /// <summary>
        /// 返回dataTable数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {
            string connStr = ConfigurationManager.ConnectionStrings["教务系统.Properties.Settings.eisbookConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }
        }

        /// <summary>
        /// ExecuteScalar
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            string connStr = ConfigurationManager.ConnectionStrings["教务系统.Properties.Settings.eisbookConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// sql语句执行函数：为ComboBox赋值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static void CmbExecuteReader(string sql, ComboBox cmb, params SqlParameter[] parameters)
        {
            string connStr = ConfigurationManager.ConnectionStrings["教务系统.Properties.Settings.eisbookConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Item item = new Item();
                        item.Id = reader[0].ToString();
                        item.Name = reader[1].ToString();
                        cmb.Items.Add(item.Name);//如何解决item的问题？？？？？？？？？？
                    }
                    return;
                }
            }
        }

        //专业信息管理定制cmb绑定
        public static void CmbExecuteReaderForProfession(string sql, ComboBox cmb, params SqlParameter[] parameters)
        {
            string connStr = ConfigurationManager.ConnectionStrings["教务系统.Properties.Settings.eisbookConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Item item = new Item();
                        item.Name = reader[0].ToString();
                        cmb.Items.Add(item.Name);
                    }
                    Item tmp = new Item();
                    tmp.Name = "显示全部";
                    cmb.Items.Add(tmp.Name);
                    return;
                }
            }
        }

        /// <summary>
        /// sql语句执行函数:返回SqlDataReader型  可能这种方法一般用不到，因为返回的datareader型的不能再操作了
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] parameters)
        {
            string connStr = ConfigurationManager.ConnectionStrings["教务系统.Properties.Settings.eisbookConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    return cmd.ExecuteReader();
                }
            }
        }

        class Item
        {
            public string Name { get; set; }
            public string Id { get; set; }
        }
    }
}