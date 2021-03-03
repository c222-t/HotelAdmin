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
    /// <summary>
    /// 充值业务处理
    /// </summary>
    public class UserRechargeTableManager
    {
        /// <summary>
        /// 充值数据处理
        /// </summary>
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
        /// <summary>
        /// 根据身份证查询指定顾客的充值记录
        /// </summary>
        /// <param name="IDCard">顾客身份证</param>
        public DataTable SeekRechargeIDCard(string IDCard)
        {
            return urts.SeekRechargeIDCard(IDCard);
        }
        /// <summary>
        /// 删除用户充值记录
        /// </summary>
        /// <param name="ID">充值记录编号</param>
        public void DeleteUserRecharge(int ID)
        {
            urts.DeleteUserRecharge(ID);
        }
        /// <summary>
        /// 添加用户充值记录
        /// </summary>
        /// <param name="record">充值记录信息</param>
        public void AddUserRecharge(UserRechargeTable record)
        {
            urts.AddUserRecharge(record);
        }
    }
}
