using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HotelModel;

namespace HotelDAL
{
    /// <summary>
    /// 商品数据处理
    /// </summary>
    public class CommodityService
    {
        /// <summary>
        /// 获取所有商品信息
        /// </summary>
        public DataTable AllCommodityRecord()
        {
            // 获取所有商品信息
            return (HotelData.Data.Tables["CommodityTable"].AsEnumerable()).CopyToDataTable();
        }
        /// <summary>
        /// 根据商品名称查找指定的商品
        /// </summary>
        /// <param name="name">商品名称</param>
        public DataTable CommodityNameQuery(string name)
        {
            // 查找与指定名称相符的商品信息
            return (from row in HotelData.Data.Tables["CommodityTable"].AsEnumerable()
                    where name.Equals(row["CommodityName"].ToString())
                    select row).CopyToDataTable();
        }
        /// <summary>
        /// 根据商品类型查找满足条件的商品
        /// </summary>
        /// <param name="typeID">商品类型编号</param>
        public DataTable CommodityTypeQuery(int typeID)
        {
            // 查找与类型编号相符的商品信息
            return (from row in HotelData.Data.Tables["CommodityTable"].AsEnumerable()
                    where typeID == (int)row["TypeNumber"]
                    select row).CopyToDataTable();
        }
        /// <summary>
        /// 获取所有商品类型信息
        /// </summary>
        public DataTable GetAllCommodityType()
        {
            return new DBHelper().GetTable("select * from CommodityTypeTable", null, "CommodityTable");
        }
        /// <summary>
        /// 添加酒店商品
        /// </summary>
        /// <param name="commodity">要添加的商品信息</param>
        public void AddNewCommodity(CommodityTable commodity)
        {
            if (commodity != null)
            {
                DataRow row = HotelData.Data.Tables["CommodityTable"].NewRow();
                row["Number"] = HotelData.Data.Tables["CommodityTable"].Rows.Count + 1;
                row["CommodityName"] = commodity.CommodityName;
                row["CommodityUnit"] = commodity.CommodityUnit;
                row["Quantity"] = commodity.Quantity;
                row["PurchasePice"] = commodity.PurchasePice;
                row["retail"] = commodity.Retail;
                row["TypeNumber"] = commodity.Type.TypeNumber;
                row["Path"] = commodity.Path;
                HotelData.Data.Tables["CommodityTable"].Rows.Add(row);
            }
        }
        /// <summary>
        /// 删除指定的商品
        /// </summary>
        /// <param name="ID">商品编号</param>
        public void DeleteCommodity(int ID)
        {
            // 遍历商品列表
            foreach (DataRow row in HotelData.Data.Tables["CommodityTable"].Rows)
            {
                if (ID == (int)row["Number"]) {                     // 根据编号删除指定的商品
                    HotelData.Data.Tables["CommodityTable"].Rows.Remove(row);
                    break;
                }
            }
        }
        /// <summary>
        /// 修改指定的商品
        /// </summary>
        /// <param name="commodity">商品编号</param>
        public void AlterCommodity(CommodityTable commodity)
        {
            // 遍历商品列表
            foreach (DataRow row in HotelData.Data.Tables["CommodityTable"].Rows)
            {
                if (commodity.Number == (int)row["Number"])         // 根据编号修改指定的商品
                {
                    row["CommodityName"] = commodity.CommodityName;
                    row["CommodityUnit"] = commodity.CommodityUnit;
                    row["Quantity"] = commodity.Quantity;
                    row["PurchasePice"] = commodity.PurchasePice;
                    row["retail"] = commodity.Retail;
                    row["TypeNumber"] = commodity.Type.TypeNumber;
                    row["Path"] = commodity.Path;
                    break;
                }
            }
        }
    }
}
