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
    /// 顾客业务处理
    /// </summary>
    public class UserManager
    {
        /// <summary>
        /// 顾客数据处理对象
        /// </summary>
        UserService service = new UserService();

        /// <summary>
        /// 查询指定或全部的顾客信息 (传入顾客身份证或姓名)
        /// </summary>
        /// <param name="trait">进行查询的顾客条件</param>
        /// <returns>返回满足条件的顾客信息</returns>
        public DataTable SeeUserRecord(string trait)
        {
            DataTable table;                                            // 创建临时数据表获取数据

            if (trait == null) {                                        // 是否获取所有的顾客信息
                return HotelData.Data.Tables["UserTable"];
            } else {                                                    // 根据顾客名称查询
                table = CompareUserName(trait);
            } if (table == null) {                                      // 根据顾客身份证查询
                return CompareUserIDCard(trait);
            }
            return table;                                               // 返回得到的顾客信息
        }
        /// <summary>
        /// 根据顾客名称查询指定的顾客信息 (支持模糊查询)
        /// </summary>
        /// <param name="name">要查询的顾客姓名</param>
        /// <returns>返回满足条件的顾客信息</returns>
        public DataTable CompareUserName(string name)
        {
            try {
                return service.CompareUserName(name);                   // 根据顾客名称查询
            } catch {
                return null;                                            // 未找到记录返回空
            }
        }
        /// <summary>
        /// 根据顾客身份证查询顾客信息
        /// </summary>
        /// <param name="IDCard">要查询的顾客身份证</param>
        /// <returns>返回满足条件的顾客信息</returns>
        public DataTable CompareUserIDCard(string IDCard)
        {
            try {
                return service.CompareUserIDCard(IDCard);               // 根据顾客身份证查询
            } catch {
                return null;                                            // 未找到记录返回空
            }
        }
        /// <summary>
        /// 查询指定顾客的消费记录
        /// </summary>
        /// <param name="idCard">顾客身份证</param>
        /// <returns>返回指定的顾客消费列表</returns>
        public DataTable GetConsumeRecord(string IDCard)
        {
            return service.GetConsumeRecord(IDCard);
        }
        /// <summary>
        /// 获取顾客会员等级信息
        /// </summary>
        public DataTable GetMembershipRecord()
        {
            return service.GetMembershipRecord();
        }
        /// <summary>
        /// 删除指定的顾客信息
        /// </summary>
        /// <param name="IDCard">顾客身份证</param>
        public void DeleteUserRecord(string IDCard)
        {
            service.DeleteUserRecord(IDCard);
        }
        /// <summary>
        /// 修改指定的顾客信息 (修改时必须传入顾客的所有信息)
        /// </summary>
        /// <param name="user">更新信息</param>
        public void AmendUserRecord(UserTable user)
        {
            service.AmendUserRecord(user);
        }
    }
}
