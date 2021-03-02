using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HotelModel;
using HotelDAL;

namespace HotelBLL
{
    /// <summary>
    /// 商品业务处理
    /// </summary>
    public class CommodityManager
    {
        /// <summary>
        /// 商品数据处理对象
        /// </summary>
        CommodityService service = new CommodityService();

        /// <summary>
        /// 获取指定类型的商品信息
        /// </summary>
        /// <param name="typeID">类型编号</param>
        public DataTable GetCommodityRecord(int typeID)
        {
            if (typeID == -1)
                return service.AllCommodityRecord();
            else
                return service.CommodityTypeQuery(typeID);
        }
        /// <summary>
        /// 获取所有商品类型信息
        /// </summary>
        public DataTable GetAllCommodityType() {
            return service.GetAllCommodityType();
        }
        /// <summary>
        /// 添加酒店商品
        /// </summary>
        /// <param name="commodity">要添加的商品信息</param>
        public void AddNewCommodity(CommodityTable commodity) {
            service.AddNewCommodity(commodity);
        }
        /// <summary>
        /// 删除指定的商品
        /// </summary>
        /// <param name="ID">商品编号</param>
        public void DeleteCommodity(int ID) {
            service.DeleteCommodity(ID);
        }
        /// <summary>
        /// 修改指定的商品
        /// </summary>
        /// <param name="commodity">商品编号</param>
        public void AlterCommodity(CommodityTable commodity) {
            service.AlterCommodity(commodity);
        }
    }
}
