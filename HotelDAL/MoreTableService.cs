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
    public class MoreTableService
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 用在房间管理
        /// </summary>
        /// <returns></returns>
        public DataTable MoreMore(string roomType)
        {
            StringBuilder sql = new StringBuilder("SELECT UserName,u.[IDCard],[TotalConsumption],[CheckInTime],[RoomNumber],TelephoneNumber,MembershipLevel FROM [StatementTable] st join UserTable u on u.IDCard =st.IDCard  join MembershipTable mt on mt.MemberNumber=u.Member where 1=1");

            if (roomType != "")
            {
                sql.Append(" and RoomNumber=@Name");
                SqlParameter[] sp = {
                    new SqlParameter ("@Name",roomType)
                };
                return db.GetTable(sql.ToString (),sp, "MoreMore");
            }

            return db.GetTable(sql.ToString(), null, "MoreMore");
        }

    }
}
