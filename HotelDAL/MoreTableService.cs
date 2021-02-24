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
            StringBuilder sql = new StringBuilder("SELECT StatusName,Name,UserName,st.[IDCard],Gender,CheckInTime,TelephoneNumber,[CheckoutTime],MembershipLevel,st.[RoomNumber],[TotalConsumption] FROM [StatementTable] st join UserTable u on u.IDCard = st.IDCard join RoomSchedules r on r.RoomNumber = st.RoomNumber join MembershipTable m on m.MemberNumber = u.Member join RoomTypeTable rt on rt.[No] = r.RoomType join RoomStatus rs on rs.[No] = r.RoomStatus where 1=1");

            if (roomType != "")
            {
                sql.Append(string.Format (" and rt.Name='{0}' or st.IDCard='{0}'", roomType));
                return db.GetTable(sql.ToString (),null,"MoreMore");
            }

            return db.GetTable(sql.ToString(), null, "MoreMore");
        }

    }
}
