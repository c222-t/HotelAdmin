using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    /// <summary>
    /// 消息记录
    /// </summary>
    public class MessageTable
    {
        /// <summary>
        /// 消息信息编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 房间名称
        /// </summary>
        public string RoomName { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string ConsumptionContent { get; set; }
        /// <summary>
        /// 消息处理情况
        /// </summary>
        public string HandleSituation { get; set; }
        /// <summary>
        /// 消息发送时间
        /// </summary>
        public DateTime MessageSendingTime { get; set; }
        /// <summary>
        /// 商品列表
        /// </summary>
        public List<CommodityTable> Gogoods { get; set; }


        public MessageTable() {
            this.MessageSendingTime = DateTime.Now;                           // 获取当前消息发送时间
        }
    }
}
