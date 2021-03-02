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
                StringBuilder sql = new StringBuilder("SELECT st.[Status],RoomType,st.IDCard,Floor,orderNumber,st.[RoomNumber],UserName,TelephoneNumber,[CheckInTime],[TotalConsumption]+Price*[Days] TotalConsumptions,PaymentMethod,Discount,([TotalConsumption]+Price*[Days])*Discount Prices,[Days],Balance FROM [StatementTable] st join UserTable u on u.IDCard =st.IDCard join MembershipTable mt on mt.MemberNumber=u.Member join RoomSchedules rs on rs.RoomNumber=st.RoomNumber join RoomTypeTable rt on rt.[No]=rs.RoomType where 1=1 and st.[Status]=2");

                HotelData.Data.Tables.Add(db.GetTable(sql.ToString(), null, "More").Copy());
            }

            if (roomName != "")
            {
                try
                {
                    var table = from row in HotelData.Data.Tables["More"].AsEnumerable()
                                where row["RoomNumber"].Equals(roomName)
                                select row;
                    return table.CopyToDataTable();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

            }

            try
            {
                var table = from row in HotelData.Data.Tables["More"].AsEnumerable()
                            where (int)row["Status"]==2
                            select row;
                return table.CopyToDataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 通过订单号来改变订单状态
        /// </summary>
        /// <param name="MoreID"></param>
        public void Update(string MoreID)
        {
            foreach (DataRow item in HotelData .Data .Tables ["More"].Rows)
            {
                if (item["orderNumber"].ToString().Trim() == MoreID.Trim())
                {
                    item["Status"] = 3;
                    break;
                }
            }
        }


    }
}
