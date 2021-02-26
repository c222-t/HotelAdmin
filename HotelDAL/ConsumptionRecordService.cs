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
    public class ConsumptionRecordService
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 查询消费记录
        /// </summary>
        /// <param name="kai"></param>
        /// <param name="jie"></param>
        /// <returns></returns>
        public DataTable ConsumptionRecord(string kai = "", string jie = "")
        {
            StringBuilder sql = new StringBuilder("SELECT [RecordID],[IDCard],[money],[SpendingTime],[Describe] FROM [ConsumptionRecord] where 1=1");

            if (kai != "" && jie != "")
            {
                sql.Append(" and [SpendingTime]>@SpendingTime and [SpendingTime]<@SpendingTimes");

                SqlParameter[] sp = {
                    new SqlParameter ("@SpendingTime",kai),
                    new SqlParameter ("@SpendingTimes",jie)
                };
                return db.GetTable(sql.ToString (),sp, "ConsumptionRecord");
            }
            return db.GetTable(sql.ToString(), null, "ConsumptionRecord");
        }

    }
}
