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
        
        private delegate DataTable GetOrderTables(DataTable dataTable, StatementTable table);

        /// <summary>
        /// 搜索满足条件或全部的订单信息
        /// </summary>
        /// <param name="statement">查询的订单信息</param>
        /// <returns>返回满足条件的订单列表</returns>
        public DataTable SeekOrderRecord(StatementTable statement)
        {
            DataTable table = HotelData.ConsignData.Tables["StatementTable"];

            StringBuilder sql = new StringBuilder(
                "select orderNumber, IDCard, TotalConsumption, CheckInTime, CheckoutTime, OperationManaer, Status from StatementTable where 1 = 1"
            );
            

            if (!statement.OrderNumber.Equals(null)) {
                sql.Append(" and orderNumber = " + statement.OrderNumber);
            } if (!statement.IDCard.Equals(string.Empty)) {
                sql.Append(" and IDCard = " + statement.IDCard);
            } if (!statement.Status.Number.Equals(null)) {
                sql.Append(" and Status = " + statement.Status.Number);
            }
            return table;
        }
    }
}
