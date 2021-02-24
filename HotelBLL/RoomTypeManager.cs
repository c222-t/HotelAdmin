using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HotelDAL;
using HotelModel;

namespace HotelBLL
{
    public class RoomTypeManager
    {
        RoomTypeService rts = new RoomTypeService();
        /// <summary>
        /// 转换房间编号
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int TypeID(string name)
        {
            return rts.TypeID(name);
        }

        /// <summary>
        /// 返回房间表
        /// </summary>
        /// <param name="type">可选参数，可指定房间编号</param>
        /// <returns></returns>
        public DataTable TypeTable(string type="")
        {
            return rts.TypeTable(type);
        }

    }
}
