using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HotelModel;

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
            StringBuilder sql = new StringBuilder("SELECT TOP 1000 [RoomNumber],[Floor],[RoomType],[RoomStatus] FROM [RoomSchedules] where 1=1");

            if (leiXing != "")
            {
                sql.Append(" and RoomType=@RoomType");
                SqlParameter[] sp = {
                    new SqlParameter ("@RoomType",leiXing)
                };

                return db.GetTable(sql.ToString(), sp, "RoomSchedules");
            }
            HotelData.ConsignData.Tables.Remove(HotelData.ConsignData.Tables["RoomSchedules"]);
            DataTable dt = db.GetTable(sql.ToString (),null, "RoomSchedules");
            HotelData.ConsignData.Tables.Add(dt.Copy());
            return HotelData.ConsignData.Tables["RoomSchedules"];
        }

        /// <summary>
        /// 为房间表插入一行数据并返回,需要提供房间对象
        /// </summary>
        /// <param name="room">插入的房间信息</param>
        /// <returns></returns>
        public DataTable RoomInsert(RoomSchedules room)
        {
            DataRow dr = HotelData.ConsignData.Tables["RoomSchedules"].NewRow();

            dr["RoomNumber"] = room.RoomNumber;
            dr["Floor"] = room.Floor;
            dr["RoomType"] = room.RoomType.No;
            dr["RoomStatus"] = room.RoomStatus.No;

            HotelData.ConsignData.Tables["RoomSchedules"].Rows.Add(dr);

            return HotelData.ConsignData.Tables["RoomSchedules"];
        }

        /// <summary>
        /// 为房间表删除一行数据并返回，需要提供房间编号(名称)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable RoomDelect(string name)
        {
            foreach (DataRow item in HotelData.ConsignData.Tables["RoomSchedules"].Rows)
            {
                if (item["RoomNumber"].ToString() == name)
                {
                    HotelData.ConsignData.Tables["RoomSchedules"].Rows.Remove(item);
                    break;
                }
            }
            return HotelData.ConsignData.Tables["RoomSchedules"];
        }

        /// <summary>
        /// 为房间表修改一行数据并返回，需要提供房间编号(名称),以及修改的内容
        /// </summary>
        /// <param name="num"></param>
        /// <param name="room"></param>
        /// <returns></returns>
        public DataTable RoomUpdate(string num,RoomSchedules room)
        {
            for (int i=0;i< HotelData.ConsignData.Tables["RoomSchedules"].Rows.Count;i++)
            {
                if (HotelData.ConsignData.Tables["RoomSchedules"].Rows[i]["RoomNumber"].ToString() == num)
                {
                    HotelData.ConsignData.Tables["RoomSchedules"].Rows[i]["RoomType"] = room.RoomType.No;
                    HotelData.ConsignData.Tables["RoomSchedules"].Rows[i]["RoomStatus"] = room.RoomStatus.No;
                    break;
                }
            }
            return HotelData.ConsignData.Tables["RoomSchedules"];
        }


    }
}
