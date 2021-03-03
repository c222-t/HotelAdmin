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
        /// 根据顾客名称查询指定的顾客信息 (支持模糊查询)
        /// </summary>
        /// <param name="name">要查询的顾客姓名</param>
        /// <returns>返回满足条件的顾客信息</returns>
        public DataTable CompareUserName(string name = "")
        {
            if (!name.Equals(""))                                    // 根据顾客名称查询
                return service.CompareUserName(name);
            else
                return HotelData.Data.Tables["UserTable"];           // 返回所有记录
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
        /// <summary>
        /// 提交新的顾客信息
        /// </summary>
        /// <param name="user">要添加的顾客信息</param>
        public void AddUserRecord(UserTable user)
        {
            service.AddUserRecord(user);
        }
    }
}
