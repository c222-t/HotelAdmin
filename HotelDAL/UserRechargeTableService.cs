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
    public class UserRechargeTableService
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 查询用户充值
        /// </summary>
        /// <param name="kai"></param>
        /// <param name="jie"></param>
        /// <returns></returns>
        public DataTable UserRechargeTable(string kai="",string jie="")
        {
            if (kai != "" && jie != "")
            {
                try
                {
                    var table = from row in HotelData.Data.Tables["UserRechargeTable"].AsEnumerable()
                                where DateTime.Parse(row["RechargeTime"].ToString()) > DateTime.Parse(kai) && DateTime.Parse(row["RechargeTime"].ToString()) < DateTime.Parse(jie)
                                select row;
                    return table.CopyToDataTable();
                }
                catch
                {
                    return null;
                }
            }
            return HotelData.Data.Tables["UserRechargeTable"];
        }




    }
}
