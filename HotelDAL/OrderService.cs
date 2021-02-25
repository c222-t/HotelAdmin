using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HotelModel;

namespace HotelDAL
{
    /// <summary>
    /// 订单数据处理
    /// </summary>
    public class OrderService
    {
        /// <summary>
        /// 根据订单编号查询指定记录
        /// </summary>
        /// <param name="dataTable">订单记录表</param>
        /// <param name="order">要查询的订单条件</param>
        /// <returns>返回满足条件的订单记录</returns>
        public DataTable CompareStatementNo(DataTable dataTable, StatementTable order)
        {
            // 根据指定订单编号查询记录
            var table = from row in dataTable.AsEnumerable()
                        where row["OrderNumber"].ToString().Trim().Equals(order.OrderNumber.ToString())
                        select row;

            return table.CopyToDataTable();                             // 返回得到的记录
        }
        /// <summary>
        /// 根据订单身份证查询指定记录
        /// </summary>
        /// <param name="dataTable">订单记录表</param>
        /// <param name="order">要查询的订单条件</param>
        /// <returns>返回满足条件的订单记录</returns>
        public DataTable CompareStatementIDCard(DataTable dataTable, StatementTable order)
        {
            // 根据指定身份证查询订单记录
            var table = from row in dataTable.AsEnumerable()
                        where row["IDCard"].Equals(order.IDCard)
                        select row;

            return table.CopyToDataTable();                             // 返回得到的记录
        }
        /// <summary>
        /// 根据订单状态查询指定记录
        /// </summary>
        /// <param name="dataTable">订单记录表</param>
        /// <param name="order">要查询的订单条件</param>
        /// <returns>返回满足条件的订单记录</returns>
        public DataTable CompareStatementStatus(DataTable dataTable, StatementTable order)
        {
            // 查询满足指定状态的订单记录
            var table = from row in dataTable.AsEnumerable()
                        where row["Status"].Equals(order.Status.Number)
                        select row;

            return table.CopyToDataTable();                             // 返回得到的记录
        }
        /// <summary>
        /// 删除指定的订单记录
        /// </summary>
        /// <param name="order">要删除的订单信息</param>
        public void DeleteOrderRecord(StatementTable order)
        {
            // 遍历系统临时数据库搜索满足条件的记录
            foreach (DataRow row in HotelData.Data.Tables["StatementTable"].Rows)
            {
                // 根据订单编号删除记录
                if (order.OrderNumber.Equals(row["OrderNumber"].ToString().Trim()))
                {
                    HotelData.Data.Tables["StatementTable"].Rows.Remove(row);
                    break;
                }
            }
        }
        /// <summary>
        /// 修改指定的订单记录 (修改时必须传入订单的所有信息)
        /// </summary>
        /// <param name="order">要修改的订单信息</param>
        public void AmendOrderRecord(StatementTable order)
        {
            // 遍历系统临时数据库搜索满足条件的记录
            foreach (DataRow row in HotelData.Data.Tables["StatementTable"].Rows)
            {
                // 根据订单编号修改指定的记录
                if (order.OrderNumber.Equals(row["OrderNumber"].ToString().Trim()))
                {
                    row["IDCard"] = order.IDCard;
                    row["TotalConsumption"] = order.TotalConsumption;
                    row["PaymentMethod"] = order.PaymentMethod;
                    row["CheckInTime"] = order.CheckInTime.ToString();
                    row["CheckoutTime"] = order.CheckoutTime.ToString();
                    row["OperationManaer"] = order.OperationManager;
                    row["Status"] = order.Status.Number;
                    row["RoomNumber"] = order.Room.RoomNumber;
                    break;
                }
            }
        }
        /// <summary>
        /// 添加需要的订单记录
        /// </summary>
        /// <param name="order">需要添加的订单记录</param>
        public void AddOrderRecord(StatementTable order)
        {
            if (order.OrderNumber != null)                              // 判断记录是否满足条件
            {
                DataRow row = HotelData.Data.Tables["StatementTable"].NewRow();
                row["OrderNumber"] = order.OrderNumber;
                row["IDCard"] = order.IDCard;
                row["TotalConsumption"] = order.TotalConsumption;
                row["PaymentMethod"] = order.PaymentMethod;
                row["CheckInTime"] = order.CheckInTime.ToString();
                row["CheckoutTime"] = order.CheckoutTime.ToString();
                row["OperationManaer"] = order.OperationManager;
                row["Status"] = order.Status.Number;
                row["RoomNumber"] = order.Room.RoomNumber;
                HotelData.Data.Tables["StatementTable"].Rows.Add(row);
            }
        }
    }
}
