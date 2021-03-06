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
                catch (Exception ee){
                    return null;
                }
            }
            return HotelData.Data.Tables["UserRechargeTable"];
        }
        /// <summary>
        /// 根据身份证查询指定顾客的充值记录
        /// </summary>
        /// <param name="IDCard">顾客身份证</param>
        public DataTable SeekRechargeIDCard(string IDCard)
        {
            // 遍历充值记录列表根据身份证获取指定用户的充值记录
            return HotelData.Data.Tables["UserRechargeTable"].AsEnumerable()
                   .Where(row => IDCard.Equals(row["IDCard"].ToString()))
                   .CopyToDataTable();
        }
        /// <summary>
        /// 删除用户充值记录
        /// </summary>
        /// <param name="ID">充值记录编号</param>
        public void DeleteUserRecharge(int ID)
        {
            // 遍历充值记录列表
            foreach (DataRow row in HotelData.Data.Tables["UserRechargeTable"].Rows)
            {
                if (ID == (int)row["UserRechargeID"]) {                         // 根据编号删除指定的充值记录
                    HotelData.Data.Tables["UserRechargeTable"].Rows.Remove(row);
                    break;
                }
            }
        }
        /// <summary>
        /// 添加用户充值记录
        /// </summary>
        /// <param name="record">充值记录信息</param>
        public void AddUserRecharge(UserRechargeTable record)
        {
            if (record != null)
            {
                DataRow row = HotelData.Data.Tables["UserRechargeTable"].NewRow();
                row["UserRechargeID"] = HotelData.Data.Tables["UserRechargeTable"].Rows.Count + 1;
                row["RechargeTime"] = record.RechargeTime;
                row["RechargeBalance"] = record.RechargeBalance;
                row["IDCard"] = record.IDCard;
                row["GiftGiving"] = record.GiftGiving.CommodityName;
                HotelData.Data.Tables["UserRechargeTable"].Rows.Add(row);
            }
        }
    }
}
