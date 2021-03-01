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
    public class StatementTableService
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 用于结账窗体
        /// </summary>
        /// <param name="roomName"></param>
        /// <returns></returns>
        public DataTable Statement(string roomName="")
        {
            StringBuilder sql = new StringBuilder("SELECT RoomType,st.IDCard,Floor,orderNumber,st.[RoomNumber],UserName,TelephoneNumber,[CheckInTime],[TotalConsumption]+Price*[Days] TotalConsumptions,PaymentMethod,Discount,([TotalConsumption]+Price*[Days])*Discount Prices,[Days],Balance FROM [StatementTable] st join UserTable u on u.IDCard =st.IDCard join MembershipTable mt on mt.MemberNumber=u.Member join RoomSchedules rs on rs.RoomNumber=st.RoomNumber join RoomTypeTable rt on rt.[No]=rs.RoomType where 1=1 and st.[Status]=2");

            if (roomName != "")
            {
                sql.Append(" and st.RoomNumber=@RoomNumber");
                SqlParameter[] sp = {
                    new SqlParameter ("@RoomNumber",roomName)
                };
                return db.GetTable(sql.ToString (),sp,"More");
            }
            return db.GetTable(sql.ToString (),null,"More");
        }

    }
}
