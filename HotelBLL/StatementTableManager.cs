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
        StatementTableService sts = new StatementTableService();
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

        /// <summary>
        /// 用于结账窗体
        /// </summary>
        /// <param name="roomName"></param>
        /// <returns></returns>
        public DataTable Statement(string roomName = "")
        {
            return sts.Statement(roomName);
        }

        /// <summary>
        /// 修改usele中More表的状态
        /// </summary>
        /// <param name="MoreID"></param>
        public void Update(string MoreID)
        {
            sts.Update(MoreID);
        }

        /// <summary>
        /// 用于预约窗体
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public DataTable StatementNew(string userName = "")
        {
            return sts.StatementNew(userName);
        }

    }
}
