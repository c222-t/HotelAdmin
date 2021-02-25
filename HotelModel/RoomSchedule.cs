using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    /// <summary>
    /// 房间
    /// </summary>
    public class RoomSchedules
    {
        /// <summary>
        /// 房间编号
        /// </summary>
        public string RoomNumber { get; set; }
        /// <summary>
        /// 房间类型
        /// </summary>
        public RoomTypeTable RoomType { get; set; }
        /// <summary>
        /// 房间状态
        /// </summary>
        public RoomStatus RoomStatus { get; set; }
        /// <summary>
        /// 房间楼层名称
        /// </summary>
        public string Floor { get; set; }
    }
}
