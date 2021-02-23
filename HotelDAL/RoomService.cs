using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HotelDAL
{
    public class RoomService
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 返回房间表
        /// </summary>
        /// <param name="leiXing">房间类型编号</param>
        /// <returns></returns>
        public DataTable RoomTable(string leiXing="")
        {
            StringBuilder sql = new StringBuilder("SELECT [RoomNumber],[Floor],[RoomType],[RoomStatus] FROM [RoomSchedules] where 1=1");

            SqlParameter[] sp = null;
            if (leiXing != "")
            {
                sql.Append("RoomType=@RoomType");
                sp = new SqlParameter[] {new SqlParameter("@RoomType", leiXing) };
            }

            DataTable dt = db.GetTable(sql.ToString (),sp,"RoomTable");
            return dt;
        }


    }
}
