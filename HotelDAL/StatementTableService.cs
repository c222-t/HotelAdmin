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
               /* StringBuilder sql = new StringBuilder("SELECT st.[Status],RoomType,st.IDCard,Floor,orderNumber,st.[RoomNumber],UserName,TelephoneNumber,[CheckInTime],[TotalConsumption]+Price*[Days] TotalConsumptions,PaymentMethod,Discount,([TotalConsumption]+Price*[Days])*Discount Prices,[Days],Balance FROM [StatementTable] st join UserTable u on u.IDCard =st.IDCard join MembershipTable mt on mt.MemberNumber=u.Member join RoomSchedules rs on rs.RoomNumber=st.RoomNumber join RoomTypeTable rt on rt.[No]=rs.RoomType where 1=1 and st.[Status]=2");*/

            var table = from st in HotelData.Data.Tables["StatementTable"].AsEnumerable()
                        join u in HotelData.Data.Tables["UserTable"].AsEnumerable()
                        on st.Field<string>("IDCard") equals u.Field<string>("IDCard")
                        join mt in new UserService().MembershipTable().AsEnumerable()
                        on u.Field<Int32>("Member") equals mt.Field<Int32>("MemberNumber")
                        join rs in HotelData.Data.Tables["RoomSchedules"].AsEnumerable()
                        on st.Field<string>("RoomNumber") equals rs.Field<string>("RoomNumber")
                        join rt in new RoomTypeService().TypeTable().AsEnumerable()
                        on rs.Field<Int32>("RoomType") equals rt.Field<Int32>("No")
                        select new
                        {
                            orderNumber = st.Field<string>("orderNumber"),
                            RoomNumber = rs.Field<string>("RoomNumber"),
                            UserName = u.Field<string>("UserName"),
                            TelephoneNumber = u.Field<string>("TelephoneNumber"),
                            CheckInTime = st.Field<DateTime>("CheckInTime"),
                            TotalConsumptions = st.Field<double>("TotalConsumption"),
                            PaymentMethod = st.Field<string>("PaymentMethod"),
                            Discount = mt.Field<double>("Discount"),
                            Price=rt.Field <double>("Price"),
                            Balance = u.Field<double>("Balance"),
                            Days = st.Field<Int32>("Days"),
                            IDCard = st.Field<string>("IDCard"),
                            Floor = rs.Field<string>("Floor"),
                            RoomType = rs.Field<Int32>("RoomType"),
                            Status=st.Field <Int32>("Status")
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("orderNumber", typeof(string));
            dt.Columns.Add("RoomNumber", typeof(string));
            dt.Columns.Add("UserName", typeof(string));
            dt.Columns.Add("TelephoneNumber", typeof(string));
            dt.Columns.Add("CheckInTime", typeof(DateTime));
            dt.Columns.Add("TotalConsumptions", typeof(double));
            dt.Columns.Add("PaymentMethod", typeof(string));
            dt.Columns.Add("Discount", typeof(double));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Balance", typeof(double));
            dt.Columns.Add("Days", typeof(Int32));
            dt.Columns.Add("IDCard", typeof(string));
            dt.Columns.Add("Floor", typeof(string));
            dt.Columns.Add("RoomType", typeof(Int32));
            dt.Columns.Add("Status", typeof(Int32));
            dt.Columns.Add("Prices", typeof(Int32));

            DataTable dtNew = dt.Copy();

            foreach (var item in table)
            {
                dtNew.Rows.Add(item.orderNumber.Trim(), item.RoomNumber.Trim(), item.UserName.Trim(), item.TelephoneNumber.Trim(), item.CheckInTime, item.TotalConsumptions, item.PaymentMethod, item.Discount, item.Price, item.Balance, item.Days, item.IDCard.Trim(), item.Floor.Trim(), item.RoomType,item.Status,item.TotalConsumptions+item.Price *item.Days);
            }

            try
            {
                var dtNewNew = from row in dtNew.AsEnumerable()
                               where int.Parse(row["Status"].ToString()) == 2
                               select row;

                if (roomName != "")
                {
                    try
                    {
                        var dtNewNewNew = from row in dtNewNew.AsEnumerable()
                                    where row["RoomNumber"].ToString().Trim().Equals(roomName.Trim())
                                    select row;
                        return dtNewNewNew.CopyToDataTable();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return null;
                    }
                }
                return dtNewNew.CopyToDataTable();
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
            foreach (DataRow item in HotelData .Usele .Tables ["More"].Rows)
            {
                if (item["orderNumber"].ToString().Trim() == MoreID.Trim())
                {
                    item["Status"] = 3;
                    break;
                }
            }
        }

        /// <summary>
        /// 用于预约窗体
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public DataTable StatementNew(string userName="")
        {
            var table = from st in HotelData.Data.Tables["StatementTable"].AsEnumerable()
                        join u in HotelData.Data.Tables["UserTable"].AsEnumerable()
                        on st.Field<string>("IDCard").Trim() equals u.Field<string>("IDCard").Trim()
                        join rs in HotelData.Data.Tables["RoomSchedules"].AsEnumerable()
                        on st.Field<string>("RoomNumber").Trim() equals rs.Field<string>("RoomNumber").Trim()
                        join os in StatementZT().AsEnumerable()
                        on st.Field<int>("Status") equals os.Field<int>("Number")
                        join rt in new RoomTypeService().TypeTable().AsEnumerable()
                        on rs.Field<int>("RoomType") equals rt.Field<int>("No")
                        select new
                        {
                            orderNumber = st.Field<string>("orderNumber"),
                            UserName = u.Field<string>("UserName"),
                            TelephoneNumber = u.Field<string>("TelephoneNumber"),
                            RoomNumber = rs.Field<string>("RoomNumber"),
                            Name = rt.Field<string>("Name"),
                            CheckInTime = st.Field<DateTime>("CheckInTime"),
                            CheckOutTime = st.Field<DateTime>("CheckOutTime"),
                            OperationManaer = st.Field<Int32>("OperationManaer"),
                            Price = rt.Field<double>("Price"),
                            State = os.Field<string>("State"),
                            IDCard = st.Field<string>("IDCard")
                        };
            DataTable dt = new DataTable();
            dt.Columns.Add("orderNumber", typeof(string));
            dt.Columns.Add("UserName", typeof(string));
            dt.Columns.Add("TelephoneNumber", typeof(string));
            dt.Columns.Add("RoomNumber", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("CheckInTime", typeof(DateTime));
            dt.Columns.Add("CheckOutTime", typeof(DateTime));
            dt.Columns.Add("OperationManaer", typeof(Int32));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("State", typeof(string));
            dt.Columns.Add("IDCard", typeof(string));

            DataTable dtNew = dt.Copy();

            foreach (var item in table)
            {
                dtNew.Rows.Add(item.orderNumber.Trim(), item.UserName.Trim(), item.TelephoneNumber.Trim(), item.RoomNumber.Trim(), item.Name.Trim(), item.CheckInTime, item.CheckOutTime, item.OperationManaer, item.Price, item.State.Trim(), item.IDCard.Trim());
            }

            try
            {
                var tableNew = from row in dtNew.AsEnumerable()
                               where row["State"].ToString() == "未开始"
                               select row;

                if (userName != "")
                {
                    try
                    {
                        var tableNewNew = from row in tableNew.AsEnumerable()
                                          where row["UserName"].ToString().Equals(userName)
                                          select row;

                        return tableNewNew.CopyToDataTable();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return null;
                    }
                }

                return tableNew.CopyToDataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        /// <summary>
        /// 返回所有订单状态
        /// </summary>
        /// <returns></returns>
        public DataTable StatementZT()
        {
            string sql = "SELECT [Number],[State] FROM [OrderStatusTable]";

            return db.GetTable(sql,null, "OrderStatusTable");
        }

    }
}
