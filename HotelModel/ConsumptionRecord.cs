using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    /// <summary>
    /// 消费记录
    /// </summary>
    public class ConsumptionRecord
    {
        /// <summary>
        /// 消费记录编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 该消费的顾客身份证
        /// </summary>
        public string IDCard { get; set; }
        /// <summary>
        /// 消费描述
        /// </summary>
        public string Describe { get; set; }
        /// <summary>
        /// 消费金额
        /// </summary>
        public double Money { get; set; }
        /// <summary>
        /// 该消费的时间
        /// </summary>
        public DateTime SpendingTime { get; set; }

        public ConsumptionRecord() {
            this.SpendingTime = DateTime.Now;                               // 获取当前该消费记录的时间
        }
    }
}
