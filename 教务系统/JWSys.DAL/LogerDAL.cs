using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JWSys.Model;
using System.Data;
using System.Data.SqlClient;

namespace JWSys.DAL
{
    public class LogerDAL
    {
        #region Tologer
        private Loger ToLoger(DataRow row)
        {
            Loger log = new Loger();
            log.Id = (Guid)row["Id"];
            log.UserName = (string)row["UserName"];
            log.Password = (string)row["Password"];
            return log;
        }
        #endregion

        #region Admin
        public Loger GetByAdminName(string userName)
        {
            DataTable table = SQLHelper.ExecuteDataTable("select * from [eisbook].[dbo].[Admin_Login] where UserName=@UserName", new SqlParameter("@UserName", userName));
            if (table.Rows.Count <= 0)
            {
                return null;
            }
            else if (table.Rows.Count > 1)
            {
                throw new Exception("存在重名用户！");
            }
            else
            {
                return ToLoger(table.Rows[0]);
            }
        }
        #endregion

        #region student
        public Loger GetByStudentName(string userName)
        {
            DataTable table = SQLHelper.ExecuteDataTable("select * from [eisbook].[dbo].[Student_Login] where UserName=@UserName", new SqlParameter("@UserName", userName));
            if (table.Rows.Count <= 0)
            {
                return null;
            }
            else if (table.Rows.Count > 1)
            {
                throw new Exception("存在重名用户！");
            }
            else
            {
                return ToLoger(table.Rows[0]);
            }
        }
        #endregion

        #region teacher
        public Loger GetByTeacherName(string userName)
        {
            DataTable table = SQLHelper.ExecuteDataTable("select * from [eisbook].[dbo].[Teacher_Login] where UserName=@UserName", new SqlParameter("@UserName", userName));
            if (table.Rows.Count <= 0)
            {
                return null;
            }
            else if (table.Rows.Count > 1)
            {
                throw new Exception("存在重名用户！");
            }
            else
            {
                return ToLoger(table.Rows[0]);
            }
        }
        #endregion
    }
}
