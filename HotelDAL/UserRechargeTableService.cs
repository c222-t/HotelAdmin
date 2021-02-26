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
    public class UserRechargeTableService
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 查询用户充值
        /// </summary>
        /// <param name="kai"></param>
        /// <param name="jie"></param>
        /// <returns></returns>
        public DataTable UserRechargeTable(string kai="",string jie="")
        {
            StringBuilder sql = new StringBuilder("SELECT [UserRechargeID],[RechargeTime],[RechargeBalance],[IDCard],[GiftGiving] FROM [UserRechargeTable] where 1=1");

            if (kai != "" && jie != "")
            {
                sql.Append(" and RechargeTime>@RechargeTime and RechargeTime<@RechargeTimes");
                SqlParameter[] sp = {
                    new SqlParameter ("RechargeTime",kai),
                    new SqlParameter ("RechargeTimes",jie)
                };
                return db.GetTable(sql.ToString(), sp, "UserRechargeTable");
            }
            return db.GetTable(sql.ToString(), null, "UserRechargeTable");
        }




    }
}
