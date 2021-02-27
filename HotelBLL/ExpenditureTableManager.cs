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
    public class ExpenditureTableManager
    {
        ExpenditureTableService ets = new ExpenditureTableService();
        /// <summary>
        /// 返回支出表
        /// </summary>
        /// <param name="kai"></param>
        /// <param name="jie"></param>
        /// <returns></returns>
        public DataTable ExpenditureTable(string kai = "", string jie = "")
        {
            return ets.ExpenditureTable(kai,jie);
        }

        /// <summary>
        /// 增加支出表
        /// </summary>
        /// <param name="et"></param>
        /// <returns></returns>
        public int ExpenditureInsert(ExpenditureTable et)
        {
            return ets.ExpenditureInsert(et);
        }


    }
}
