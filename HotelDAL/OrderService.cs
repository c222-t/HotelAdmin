using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq.Expressions;
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
        /// 搜索满足条件或全部的订单信息
        /// </summary>
        /// <param name="order">查询的订单信息</param>
        /// <returns>返回满足条件的订单列表</returns>
        public DataTable SeekOrderRecord(StatementTable order)
        {
            // 创建临时数据表获取所有订单记录
            DataTable table = HotelData.Data.Tables["StatementTable"];

            // 根据指定的条件执行相应的查询方式
            if (order.OrderNumber.Equals(string.Empty)) {               // 是否根据编号查询订单
                CompareStatementNo(table, order);
            }
            else if (!order.IDCard.Equals(string.Empty)) {              // 是否根据身份证查询订单
                CompareStatementIDCard(table, order);
            }
            else if (!order.Status.Number.Equals(0)) {                  // 是否根据订单状态查询订单
                CompareStatementStatus(table, order);
            }
            return table;                                               // 返回得到的订单记录
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
                if (order.OrderNumber.Equals(row["orderNumber"])) {     // 删除指定条件的记录
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
                if (order.OrderNumber.Equals(row["orderNumber"]))       // 修改指定的条件的记录
                {
                    row[1] = order.IDCard;
                    row[2] = order.TotalConsumption;
                    row[3] = order.PaymentMethod;
                    row[4] = order.CheckInTime.ToString();
                    row[5] = order.CheckoutTime.ToString();
                    row[6] = order.OperationManager;
                    row[7] = order.Status.Number;
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
            if (order.OrderNumber.Equals(string.Empty))                 // 判断记录是否满足条件
            {
                DataRow row = HotelData.Data.Tables["StatementTable"].NewRow();
                row[0] = order.OrderNumber;
                row[1] = order.IDCard;
                row[2] = order.TotalConsumption;
                row[3] = order.PaymentMethod;
                row[4] = order.CheckInTime.ToString();
                row[5] = order.CheckoutTime.ToString();
                row[6] = order.OperationManager;
                row[7] = order.Status.Number;
                HotelData.Data.Tables["StatementTable"].Rows.Add(row);
            }
        }
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
                        where row["orderNumber"].Equals(order.OrderNumber.ToString())
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
                        where row["Number"].Equals(order.Status.Number)
                        select row;

            return table.CopyToDataTable();                             // 返回得到的记录
        }
    }
}
