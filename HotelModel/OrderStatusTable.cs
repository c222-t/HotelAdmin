using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    /// <summary>
    /// 订单状态
    /// </summary>
    public class OrderStatusTable
    {
        /// <summary>
        /// 订单状态编号
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 订单状态名称
        /// </summary>
        public string State { get; set; }
    }
}
