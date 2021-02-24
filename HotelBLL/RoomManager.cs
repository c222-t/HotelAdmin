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
    /// 房间业务处理
    /// </summary>
    public class RoomManager
    {
        /// <summary>
        /// 房间数据处理对象
        /// </summary>
        RoomService service = new RoomService();

        /// <summary>
        /// 返回房间表
        /// </summary>
        /// <param name="leiXing">房间类型编号</param>
        /// <returns></returns>
        public DataTable RoomTable(string leiXing="")
        {
            return service.RoomTable(leiXing);
        }

        public DataTable RoomInsert(RoomSchedules room)
        {
            return service.RoomInsert(room);
        }

    }
}
