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
    public class StatementTableManager
    {
        /// <summary>
        /// 查询订单表
        /// </summary>
        /// <param name="kai"></param>
        /// <param name="jie"></param>
        /// <returns></returns>
        public DataTable StatementTable(string kai="",string jie="")
        {
            DataTable dt = HotelData.Data.Tables["StatementTable"].Copy();
            if (kai != "" && jie != "")
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (DateTime.Parse(item["CheckInTime"].ToString()) > DateTime.Parse(kai) && DateTime.Parse(item["CheckInTime"].ToString()) < DateTime.Parse(jie))
                    {
                        dt.Rows.Remove(item);
                    }
                }
            }
            return dt;
        }

    }
}
