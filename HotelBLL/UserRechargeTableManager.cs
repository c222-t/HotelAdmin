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
    public class UserRechargeTableManager
    {
        UserRechargeTableService urts = new UserRechargeTableService();
        /// <summary>
        /// 查询用户充值表
        /// </summary>
        /// <param name="kai"></param>
        /// <param name="jie"></param>
        /// <returns></returns>
        public DataTable UserRechargeTable(string kai = "", string jie = "")
        {
            return urts.UserRechargeTable(kai,jie);
        }

    }
}
