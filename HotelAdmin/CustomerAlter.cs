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
    public partial class CustomerAlter : Form
    {
        public CustomerManage manager = null;                              // 将操作传递给修改窗口
        /// <summary>
        /// 会员等级信息列表
        /// </summary>
        public List<MembershipTable> member = null;
        /// <summary>
        /// 要修改的顾客信息
        /// </summary>
        public UserTable user = null;

        public CustomerAlter()
        {
            InitializeComponent();
        }
        // 初始化窗口信息
        private void CustomerAlter_Load(object sender, EventArgs e)
        {
            ToLoadMemberList();                                         // 加载会员等级列表
            Cbox_Member_SelectedIndexChanged(sender, e);                // 显示当前顾客的折扣

            if (this.user != null)                                      // 向控件上传要修改的顾客信息
            {
                txt_Name.Text = user.UserName;
                txt_IDCard.Text = user.IDCard;
                txt_Balance.Text = user.Balance.ToString();
                cbox_Member.Text = user.Member.MembershipLevel;
                lab_Discount.Text = user.Member.Discount.ToString();
            }
        }
        // 修改顾客信息
        private void Alter_Click(object sender, EventArgs e)
        {
            UserTable user = new UserTable() {                          // 创建修改后的顾客对象
                UserName = txt_Name.Text,
                IDCard = txt_IDCard.Text,
                Age = this.user.Age,
                Gender = this.user.Gender,
                TelephoneNumber = this.user.TelephoneNumber,
                Balance = double.Parse(txt_Balance.Text),
                Member = GetMembership()
            };
            new UserManager().AmendUserRecord(user);                    // 查找该顾客进行修改
            manager.Btn_Inquire_Click(sender, e);                       // 调用顾客查询操作

            // 修改后是否继续操作
            if (MessageBox.Show("修改完毕，是否继续？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // 加载会员等级信息
        private void ToLoadMemberList()
        {
            foreach (MembershipTable arr in member)                     // 遍历会员等级列表
            {
                cbox_Member.Items.Add(arr.MembershipLevel);             // 向控件中添加会员信息
            }
            cbox_Member.Text = cbox_Member.Items[0].ToString();         // 显示默认的会员信息
        }
        // 显示对应会员等级的折扣
        private void Cbox_Member_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (MembershipTable arr in member)                     // 遍历会员等级列表
            {
                if (cbox_Member.Text.Equals(arr.MembershipLevel))       // 查找当前的会员等级
                {
                    lab_Discount.Text = arr.Discount.ToString();        // 显示和会员等级对应的折扣
                    break;
                }
            }
        }
        // 根据会员等级名称获取对应的会员等级对象
        private MembershipTable GetMembership()
        {
            foreach (MembershipTable arr in member)                     // 遍历会员等级列表
            {
                if (cbox_Member.Text.Equals(arr.MembershipLevel)) {     // 查找当前的会员等级
                    return arr;
                }
            }
            return null;
        }
    }
}
