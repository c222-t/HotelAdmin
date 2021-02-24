using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel;
using System.Data.SqlClient;

namespace HotelDAL
{
    public class RoomTypeService
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 转换房间类型编号
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int TypeID(string name)
        {
            StringBuilder sql = new StringBuilder("SELECT [No] FROM [RoomTypeTable] where Name=@Name");

            SqlParameter[] sp = {
                new SqlParameter ("@Name",name)
            };

            return (int)db.ExecuteScalar(sql.ToString(),sp);
        }


    }
}
