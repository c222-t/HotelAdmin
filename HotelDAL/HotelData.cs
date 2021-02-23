using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HotelModel;

namespace HotelDAL
{
    ///<summary>
    /// 系统数据库
    ///</summary>
    static class HotelData
    {
        /// <summary>
        /// 临时数据库  (在程序运行中临时存储数据库中的数据)
        /// </summary>
        public static DataSet ConsignData = new DataSet();
        /// <summary>
        /// 数据库访问对象
        /// </summary>
        static DBHelper gain = new DBHelper();

        // 初始化操作（加载酒店的数据库信息）
        static HotelData()
        {
            DataTable[] tables = {
                gain.GetTable("select * from RoomSchedules", null, "RoomSchedules"),    // 获取数据库的 房间 数据信息
                gain.GetTable("select * from CommodityTable", null, "CommodityTable"),  // 获取数据库的 商品 数据信息
                gain.GetTable("select * from StatementTable", null, "StatementTable"),  // 获取数据库的 订单 数据信息
                gain.GetTable("select * from UserTable", null, "UserTable")             // 获取数据库的 顾客 数据信息
            };
            // 向程序的临时数据库上传获得的各项数据表
            foreach (DataTable arr in tables) {
                ConsignData.Tables.Add(arr.Copy());
            }
        }
        /// <summary>
        /// 更新数据库（将操作后的数据上传到数据库）
        /// </summary>
        public static void UploadData()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter();                  // 更新调用对象
            SqlCommandBuilder sqls = new SqlCommandBuilder(sqlData);        // 更新操作对象

            // 将临时数据库中的每张数据表保存到数据库对应的数据表中
            foreach (DataTable arr in ConsignData.Tables) {
                DataSet set = new DataSet();                                // 创建临时数据集对象
                set.Tables.Add(arr.Copy());                                 // 获取临时数据库的数据表
                sqlData.Update(set, arr.TableName);                         // 向数据库表上传操作后的数据
            }
        }
    }
}
