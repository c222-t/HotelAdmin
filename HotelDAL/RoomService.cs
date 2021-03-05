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
            
            var table = from rs in HotelData.Data.Tables["RoomSchedules"].AsEnumerable()
                        join rtt in new RoomTypeService().TypeTable().AsEnumerable()
                        on rs.Field<Int32>("RoomType") equals rtt.Field<Int32>("No")
                        join r in new RoomTypeService().RoomStatus ().AsEnumerable ()
                        on rs.Field <Int32>("RoomStatus") equals r.Field <Int32>("No")
                        select new
                        {
                            RoomNumber = rs.Field<string>("RoomNumber"),
                            Floor = rs.Field<string>("Floor"),
                            RoomType = rtt.Field<string>("name"),
                            RoomStatus = rs.Field<Int32>("RoomStatus"),
                            StatusName=r.Field <string>("StatusName"),
                            Price = rtt.Field<double>("Price")
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("RoomNumber", typeof(string));
            dt.Columns.Add("StatusName", typeof(Int32));
            dt.Columns.Add("Floor", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("statusName", typeof(string));

            DataTable dtNew = dt.Copy();

            foreach (var item in table)
            {
                dtNew.Rows.Add(item.RoomNumber.Trim(), item.RoomStatus, item.Floor.Trim(), item.RoomType.Trim(), item.Price, item.StatusName.Trim());
            }

            try
            {
                var tableNew = from row in dtNew.AsEnumerable()
                               where row["StatusName"].ToString().Equals("1")
                               select row;

                if (leiXing != "")
                {
                    try
                    {
                        var tableN = from row in tableNew.CopyToDataTable().AsEnumerable()
                                     where row["Name"].Equals(leiXing)
                                     select row;
                        return tableN.CopyToDataTable();
                    }
                    catch (Exception ee)
                    {
                        return null;
                    }
                }
                return tableNew.CopyToDataTable();
            }
            catch (Exception ee)
            {
                return null;
            }
                
        }

        /// <summary>
        /// 为房间表插入一行数据并返回,需要提供房间对象
        /// </summary>
        /// <param name="room">插入的房间信息</param>
        /// <returns></returns>
        public DataTable RoomInsert(RoomSchedules room)
        {
            DataRow dr = HotelData.Data.Tables["RoomSchedules"].NewRow();

            dr["RoomNumber"] = room.RoomNumber;
            dr["Floor"] = room.Floor;
            dr["RoomType"] = room.RoomType.No;
            dr["RoomStatus"] = room.RoomStatus.No;

            HotelData.Data.Tables["RoomSchedules"].Rows.Add(dr);
            HotelData.UploadData();

            return HotelData.Data.Tables["RoomSchedules"];
        }

        /// <summary>
        /// 为房间表删除一行数据并返回，需要提供房间编号(名称)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable RoomDelect(string name)
        {
            foreach (DataRow item in HotelData.Data.Tables["RoomSchedules"].Rows)
            {
                if (item["RoomNumber"].ToString().Trim() == name.Trim ())
                {
                    item.Delete();
                    break;
                }
            }
            HotelData.UploadData();
            return HotelData.Data.Tables["RoomSchedules"];
        }

        /// <summary>
        /// 为房间表修改一行数据并返回，需要提供房间编号(名称),以及修改的内容
        /// </summary>
        /// <param name="num"></param>
        /// <param name="room"></param>
        /// <returns></returns>
        public DataTable RoomUpdate(string num,RoomSchedules room)
        {
            for (int i = 0; i < HotelData.Data.Tables["RoomSchedules"].Rows.Count; i++)
            {
                if (HotelData.Data.Tables["RoomSchedules"].Rows[i]["RoomNumber"].ToString().Trim() == num.Trim ())
                {
                    HotelData.Data.Tables["RoomSchedules"].Rows[i]["Floor"] = room.Floor;
                    HotelData.Data.Tables["RoomSchedules"].Rows[i]["RoomNumber"] = room.RoomNumber;
                    HotelData.Data.Tables["RoomSchedules"].Rows[i]["RoomStatus"] = room.RoomStatus.No;
                    HotelData.Data.Tables["RoomSchedules"].Rows[i]["RoomType"] = room.RoomType.No;
                    break;
                }
            }

            return HotelData.Data.Tables["RoomSchedules"];
        }



    }
}
