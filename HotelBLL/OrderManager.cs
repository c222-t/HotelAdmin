using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HotelModel;
using HotelDAL;

namespace HotelBLL
{
    /// <summary>
    /// 订单业务处理
    /// </summary>
    public class OrderManager
    {
        /// <summary>
        /// 订单数据处理对象
        /// </summary>
        OrderService service = new OrderService();

        /// <summary>
        /// 搜索满足条件或全部的订单信息
        /// </summary>
        /// <param name="order">查询的订单信息</param>
        /// <returns>返回满足条件的订单列表</returns>
        public DataTable SeekOrderRecord(StatementTable order)
        {
            return service.SeekOrderRecord(order);
        }
        /// <summary>
        /// 删除指定的订单记录
        /// </summary>
        /// <param name="order">要删除的订单信息</param>
        public void DeleteOrderRecord(StatementTable order)
        {
            service.DeleteOrderRecord(order);
        }
        /// <summary>
        /// 修改指定的订单记录
        /// </summary>
        /// <param name="order">要修改的订单信息</param>
        public void AmendOrderRecord(StatementTable order)
        {
            service.AmendOrderRecord(order);
        }
        /// <summary>
        /// 添加需要的订单记录
        /// </summary>
        /// <param name="order">需要添加的订单记录</param>
        public void AddOrderRecord(StatementTable order)
        {
            service.AddOrderRecord(order);
        }
    }
}
