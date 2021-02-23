using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    /// <summary>
    /// 业务订单
    /// </summary>
    public class StatementTable
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public int OrderNumber { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string IDCard { get; set; }
        /// <summary>
        /// 总消费
        /// </summary>
        public double TotalConsumption { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public string PaymentMethod { get; set; }
        /// <summary>
        /// 开单时间
        /// </summary>
        public DateTime CheckInTime { get; set; }
        /// <summary>
        /// 结账时间
        /// </summary>
        public DateTime CheckoutTime { get; set; }
        /// <summary>
        /// 接待服务员编号
        /// </summary>
        public int OperationManager { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public OrderStatusTable Status { get; set; }
    }
}
