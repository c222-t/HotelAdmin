using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    /// <summary>
    /// 操作用户
    /// </summary>
    public class AdministratorTable
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string AdministratorName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public long Password { get; set; }
        /// <summary>
        /// 用户权限（0.普通用户 1.管理员）
        /// </summary>
        public int jurisdiction { get; set; }
    }
}
