using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    /// <summary>
    /// 支出记录
    /// </summary>
    public class ExpenditureTable
    {
        /// <summary>
        /// 支出记录编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 支出时间
        /// </summary>
        public DateTime SpendingTime { get; set; }
        /// <summary>
        /// 所用金额
        /// </summary>
        public double ExpenditureAmount { get; set; }
        /// <summary>
        /// 支出原因
        /// </summary>
        public string ExpenditureReasons { get; set; }

        public ExpenditureTable() {
            this.SpendingTime = DateTime.Now;                               // 获取当前该支出记录的时间
        }
    }
}
