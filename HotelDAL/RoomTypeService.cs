using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel;
using System.Data.SqlClient;
using System.Data;

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

            return (int)db.ExecuteScalar(sql.ToString(), sp);
        }

        /// <summary>
        /// 返回房间类型表
        /// </summary>
        /// <param name="type">可选参数，可指定房间编号</param>
        /// <returns></returns>
        public DataTable TypeTable(string type="")
        {
            StringBuilder sql = new StringBuilder("SELECT [No],[Name],[Price] FROM [RoomTypeTable] where 1=1");

            if (type != "")
            {
                sql.Append(" and No=@No");
                SqlParameter[] sp = {
                    new SqlParameter ("@No",type)
                };
                return db.GetTable(sql.ToString(), null, "RoomTypeTable");
            }

            return db.GetTable(sql.ToString (),null, "RoomTypeTable");
        }

    }
}
