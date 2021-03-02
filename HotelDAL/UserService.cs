using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HotelModel;

namespace HotelDAL
{
    /// <summary>
    /// 顾客数据处理
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// 根据顾客名称查询指定的顾客信息 (支持模糊查询)
        /// </summary>
        /// <param name="name">要查询的顾客姓名</param>
        /// <returns>返回满足条件的顾客信息</returns>
        public DataTable CompareUserName(string name)
        {
            // 搜索系统临时数据库中满足名称条件的顾客信息
            var table = from row in HotelData.Data.Tables["UserTable"].AsEnumerable()
                        where row["UserName"].ToString().Trim().StartsWith(name)
                        select row;

            return table.CopyToDataTable();                             // 返回得到的记录
        }
        /// <summary>
        /// 根据顾客身份证查询顾客信息
        /// </summary>
        /// <param name="IDCard">要查询的顾客身份证</param>
        /// <returns>返回满足条件的顾客信息</returns>
        public DataTable CompareUserIDCard(string IDCard)
        {
            // 搜索系统临时数据库中满足身份证信息的顾客信息
            var table = HotelData.Data.Tables["UserTable"].AsEnumerable().Where(u => u["IDCard"].Equals(IDCard));

            return table.CopyToDataTable();                             // 返回得到的记录
        }
        /// <summary>
        /// 查询指定顾客的消费记录
        /// </summary>
        /// <param name="idCard">顾客身份证</param>
        /// <returns>返回指定的顾客消费列表</returns>
        public DataTable GetConsumeRecord(string IDCard)
        {
            // 查询系统临时数据库中指定顾客的消费记录
            var table = from row in HotelData.Data.Tables["ConsumptionRecord"].AsEnumerable()
                        where row["IDCard"].Equals(IDCard)
                        select row;

            return table.CopyToDataTable();                             // 返回得到的记录
        }
        /// <summary>
        /// 获取顾客会员等级信息
        /// </summary>
        public DataTable GetMembershipRecord()
        {
            // 获取所有顾客会员信息
            return new DBHelper().GetTable("select * from MembershipTable", null, "MembershipTable");
        }
        /// <summary>
        /// 删除指定的顾客信息
        /// </summary>
        /// <param name="IDCard">顾客身份证</param>
        public void DeleteUserRecord(string IDCard)
        {
            // 遍历系统临时数据库搜索满足条件的记录
            foreach (DataRow row in HotelData.Data.Tables["UserTable"].Rows)
            {
                if (IDCard.Equals(row["IDCard"])) {                     // 根据身份证删除指定的顾客信息
                    HotelData.Data.Tables["UserTable"].Rows.Remove(row);
                    break;
                }
            }
        }
        /// <summary>
        /// 修改指定的顾客信息 (修改时必须传入顾客的所有信息)
        /// </summary>
        /// <param name="user">更新信息</param>
        public void AmendUserRecord(UserTable user)
        {
            // 遍历系统临时数据库搜索满足条件的记录
            foreach (DataRow row in HotelData.Data.Tables["UserTable"].Rows)
            {
                if (user.IDCard.Equals(row["IDCard"]))                  // 修改指定的顾客信息
                {
                    row["UserName"] = user.UserName;
                    row["TelephoneNumber"] = user.TelephoneNumber;
                    row["Balance"] = user.Balance == null ? row["Balance"] : user.Balance;
                    row["Member"] = user.Member.MemberNumber;
                    row["Gender"] = user.Gender;
                    row["Age"] = user.Age;
                    break;
                }
            }
        }
        /// <summary>
        /// 提交新的顾客信息
        /// </summary>
        /// <param name="user">要添加的顾客信息</param>
        public void AddUserRecord(UserTable user)
        {
            if (user != null)                                           // 判断顾客信息是否填写
            {
                DataRow row = HotelData.Data.Tables["UserTable"].NewRow();
                row["UserName"] = user.UserName;
                row["IDCard"] = user.IDCard;
                row["TelephoneNumber"] = user.TelephoneNumber;
                row["Balance"] = user.Balance;
                row["Member"] = user.Member.MemberNumber;
                row["Gender"] = user.Gender;
                row["Age"] = user.Age;
                HotelData.Data.Tables["UserTable"].Rows.Add(row);       // 向顾客表添加该顾客
            }
        }
    }
}
