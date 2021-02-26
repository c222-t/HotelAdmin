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
    public class ConsumptionRecordManager
    {
        ConsumptionRecordService crs = new ConsumptionRecordService();
        /// <summary>
        /// 查询消费记录表
        /// </summary>
        /// <param name="kai"></param>
        /// <param name="jie"></param>
        /// <returns></returns>
        public DataTable ConsumptionRecord(string kai="",string jie="")
        {
            return crs.ConsumptionRecord(kai,jie);
        }

    }
}
