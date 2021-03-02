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
            if (!(HotelData .Data .Tables.Contains ("More")) )
            {
                StringBuilder sql = new StringBuilder("SELECT RoomType,st.IDCard,Floor,orderNumber,st.[RoomNumber],UserName,TelephoneNumber,[CheckInTime],[TotalConsumption]+Price*[Days] TotalConsumptions,PaymentMethod,Discount,([TotalConsumption]+Price*[Days])*Discount Prices,[Days],Balance FROM [StatementTable] st join UserTable u on u.IDCard =st.IDCard join MembershipTable mt on mt.MemberNumber=u.Member join RoomSchedules rs on rs.RoomNumber=st.RoomNumber join RoomTypeTable rt on rt.[No]=rs.RoomType where 1=1 and st.[Status]=2");

                HotelData.Data.Tables.Add(db.GetTable(sql.ToString(), null, "More").Copy());
            }

            if (roomName != "")
            {
                try
                {
                    var table = from row in HotelData.Data.Tables["More"].AsEnumerable()
                                where row["RoomNumber"].Equals(roomName)
                                select row;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

            }
            return HotelData.Data.Tables["More"];
        }

    }
}
