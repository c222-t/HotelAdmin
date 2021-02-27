using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HotelModel;

namespace HotelDAL
{
    public class ExpenditureTableService
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 支出表
        /// </summary>
        /// <param name="kai"></param>
        /// <param name="jie"></param>
        /// <returns></returns>
        public DataTable ExpenditureTable(string kai="",string jie="")
        {
            StringBuilder sql = new StringBuilder("SELECT [SpendingTime],[ExpenditureAmount],[ExpenditureReasons] FROM [ExpenditureTable] where 1=1");

            if (kai != "" && jie != "")
            {
                sql.Append(" and [SpendingTime]>@SpendingTime and SpendingTime<@SpendingTimes");
                SqlParameter[] sp = {
                    new SqlParameter ("@SpendingTime",kai),
                    new SqlParameter ("@SpendingTimes",jie)
                };
                return db.GetTable(sql.ToString(), sp, "ExpenditureTable");
            }
            return db.GetTable(sql.ToString(), null, "ExpenditureTable");
        }

        /// <summary>
        /// 支出表增加
        /// </summary>
        /// <param name="et"></param>
        /// <returns></returns>
        public int ExpenditureInsert(ExpenditureTable et)
        {
            StringBuilder sql = new StringBuilder("INSERT INTO [ExpenditureTable]([SpendingTime],[ExpenditureAmount],[ExpenditureReasons]) VALUES (@SpendingTime,@ExpenditureAmount,@ExpenditureReasons)");

            SqlParameter[] sp = {
                new SqlParameter ("@SpendingTime",et.SpendingTime),
                new SqlParameter ("@ExpenditureAmount",et.ExpenditureAmount),
                new SqlParameter ("@ExpenditureReasons",et.ExpenditureReasons)
            };

            return db.ExecuteNonQuery(sql.ToString(), sp);
        }


    }
}
