using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelModel;
using HotelBLL;

namespace HotelAdmin
{
    public partial class CustomerManage : Form
    {
        /// <summary>
        /// 顾客业务处理对象
        /// </summary>
        UserManager manager = new UserManager();
        /// <summary>
        /// 会员等级信息列表
        /// </summary>
        List<MembershipTable> member = new List<MembershipTable>();

        public CustomerManage()
        {
            InitializeComponent();
        }
        // 初始化窗口数据
        private void CustomerManage_Load(object sender, EventArgs e)
        {
            DataTable table = manager.GetMembershipRecord();            // 获取所有会员等级信息

            foreach (DataRow row in table.Rows)                         // 遍历得到的会员等级信息
            {
                MembershipTable unit = new MembershipTable {            // 创建对象获取信息
                    MemberNumber = (int)row["MemberNumber"],
                    MembershipLevel = row["MembershipLevel"].ToString(),
                    Discount = (double)row["Discount"]
                };
                member.Add(unit);                                       // 加载顾客会员等级信息
            }
        }
        // 当搜索框输入内容时隐藏文本提示
        private void Txt_InquireBox_TextChanged(object sender, EventArgs e)
        {
            Lab_Remind.Visible = Txt_InquireBox.Text.Equals(string.Empty);
        }
        // 查询顾客信息
        private void Btn_Inquire_Click(object sender, EventArgs e)
        {
            // 根据顾客的会员编号获取完整的顾客信息
            try {
                var table = from row in manager.SeeUserRecord(Txt_InquireBox.Text).AsEnumerable()
                            join arr in member on (int)row["Member"] equals arr.MemberNumber
                            select new {
                                UserName = row["UserName"],
                                Gender = row["Gender"],
                                Age = row["Age"],
                                IDCard = row["IDCard"],
                                TelephoneNumber = row["TelephoneNumber"],
                                Balance = row["Balance"],
                                arr.MembershipLevel,
                                arr.Discount
                            };

                Dgv_UserShow.DataSource = table.ToArray();                  // 上传到显示控件
            }
            catch {
                Dgv_UserShow.DataSource = null;                             // 未找到信息清除之前的记录
            }
        }
        // 删除指定的顾客信息
        private void Option_Delete_Click(object sender, EventArgs e)
        {
            // 删除指定的顾客信息
            manager.DeleteUserRecord(Dgv_UserShow.SelectedCells[3].Value.ToString());

            Btn_Inquire_Click(sender, e);                                   // 重新刷新显示记录
        }
        // 修改指定的顾客信息
        private void Option_Alter_Click(object sender, EventArgs e)
        {
            UserTable user = new UserTable()                                // 获取要修改的顾客对象
            {
                UserName = Dgv_UserShow.SelectedCells[0].Value.ToString().Trim(),
                IDCard = Dgv_UserShow.SelectedCells[3].Value.ToString(),
                Age = (int)Dgv_UserShow.SelectedCells[2].Value,
                Gender = Dgv_UserShow.SelectedCells[1].Value.ToString().Trim(),
                TelephoneNumber = Dgv_UserShow.SelectedCells[4].Value.ToString(),
                Balance = (double)Dgv_UserShow.SelectedCells[5].Value,
                Member = new MembershipTable {
                    MembershipLevel = Dgv_UserShow.SelectedCells[6].Value.ToString(),
                    Discount = (double)Dgv_UserShow.SelectedCells[7].Value
                }
            };
            // 激活顾客修改窗口并打开
            new CustomerAlter() { user = user, member = this.member }.Show();
        }
    }
}
