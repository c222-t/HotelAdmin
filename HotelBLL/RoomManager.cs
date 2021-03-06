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

        /// <summary>
        /// 为房间表插入一行数据并返回,需要提供房间对象
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public DataTable RoomInsert(RoomSchedules room)
        {
            return service.RoomInsert(room);
        }

        /// <summary>
        /// 为房间表删除一行数据并返回，需要提供房间编号(名称)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable RoomDelect(string num)
        {
            return service.RoomDelect(num);
        }

        /// <summary>
        /// 为房间表修改一行数据并返回，需要提供房间编号(名称),以及修改的内容
        /// </summary>
        /// <param name="num"></param>
        /// <param name="room"></param>
        /// <returns></returns>
        public DataTable RoomUpdate(string num, RoomSchedules room)
        {
            return service.RoomUpdate(num,room);
        }

        /// <summary>
        /// 返回整个房间表
        /// </summary>
        /// <returns></returns>
        public DataTable Room()
        {
            return service.Room();
        }

    }
}
