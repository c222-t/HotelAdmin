using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel;
using System.Data.SqlClient;

namespace HotelDAL
{
    public class AdministratorService
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 用于登录
        /// </summary>
        /// <param name="password"></param>
        /// <param name="AdministratorName"></param>
        /// <returns></returns>
        public int Administr(string password,string AdministratorName)
        {
            StringBuilder sql = new StringBuilder("SELECT [No],[password],[AdministratorName],[jurisdiction] FROM [AdministratorTable] where password=@password and AdministratorName=@AdministratorName");

            SqlParameter[] sp = {
                new SqlParameter ("@password",password),
                new SqlParameter ("@AdministratorName",AdministratorName)
            };
            object a = db.ExecuteScalar(sql.ToString(), sp);
            return a==null?0:(int)a;
        }

        /// <summary>
        /// 返回所有员工
        /// </summary>
        /// <param name="zh"></param>
        /// <returns></returns>
        public DataTable AdminisreTable(string zh="")
        {
            StringBuilder sql = new StringBuilder("SELECT [No],[password],[AdministratorName],[jurisdiction] FROM [AdministratorTable] where 1=1");

            if (zh != "")
            {
                sql.Append(" and AdministratorName=@AdministratorName");
                SqlParameter[] sp ={
                    new SqlParameter ("@AdministratorName",zh)
                };
                return db.GetTable(sql.ToString(), sp, "AdministratorTable");
            }
            return db.GetTable(sql.ToString (),null, "AdministratorTable");
        }


    }
}
