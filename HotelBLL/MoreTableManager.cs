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
    public class MoreTableManager
    {
        MoreTableService mts = new MoreTableService();
        /// <summary>
        /// 用在房间管理
        /// </summary>
        /// <param name="roomType"></param>
        /// <returns></returns>
        public DataTable MoreMore(string roomType="")
        {
            return mts.MoreMore(roomType);
        }

    }
}
