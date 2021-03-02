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
    public class AdministratorManager
    {
        AdministratorService ams = new AdministratorService();

        /// <summary>
        /// 用于登录
        /// </summary>
        /// <param name="password"></param>
        /// <param name="AdministratorName"></param>
        /// <returns></returns>
        public int Administr(string password, string AdministratorName)
        {
            return ams.Administr(password, AdministratorName);
        }

        /// <summary>
        /// 返回所有员工
        /// </summary>
        /// <param name="zh"></param>
        /// <returns></returns>
        public DataTable AdministrTable(string zh="")
        {
            return ams.AdminisreTable(zh);
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="at"></param>
        /// <returns></returns>
        public int AdminisreInsert(AdministratorTable at)
        {
            return ams.AdminisreInsert(at);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="hao"></param>
        /// <returns></returns>
        public int AdminisreDelect(string hao)
        {
            return ams.AdminisreDelect(hao);
        }

    }
}
