using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
