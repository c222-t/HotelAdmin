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
            DataTable dt = HotelData.Data.Tables["StatementTable"].Clone();

            DataRow[] dr = null;
            if (kai != "" && jie != "")
            {
                dr = HotelData.Data.Tables["StatementTable"].Select(string.Format(" CheckInTime > #{0}# and CheckInTime < #{1}#", kai, jie));
            }
            else
            {
                dr = HotelData.Data.Tables["StatementTable"].Select();
            }

            for (int i = 0; i < dr.Length; i++)
            {
                dt.ImportRow(dr[i]);
            }

            return dt;
        }

    }
}
