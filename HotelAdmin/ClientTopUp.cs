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
    public partial class ClientTopUp : Form
    {
        /// <summary>
        /// 会员等级列表
        /// </summary>
        List<MembershipTable> memberships = new List<MembershipTable>();
        /// <summary>
        /// 充值业务处理对象
        /// </summary>
        UserRechargeTableManager rechargeManager = new UserRechargeTableManager();
        /// <summary>
        /// 顾客业务处理对象
        /// </summary>
        UserManager userManager = new UserManager();

        public ClientTopUp()
        {
            InitializeComponent();
        }
        // 加载初始化信息
        private void ClientTopUp_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in userManager.GetMembershipRecord().Rows)      // 遍历会员等级信息
            {
                memberships.Add(new MembershipTable                              // 向会员等级列表上传信息
                {
                    MembershipLevel = row["MembershipLevel"].ToString().Trim(),
                    MemberNumber = (int)row["MemberNumber"],
                    Discount = (double)row["Discount"]
                });
            }
        }
        // 根据名称搜索顾客
        private void Txt_NameInquire_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // 根据名称查询满足条件的顾客
                var gain = from row in userManager.CompareUserName(Txt_Name.Text).AsEnumerable()
                           join arr in memberships on row["Member"] equals arr.MemberNumber
                           select new {
                               UserName = row["UserName"].ToString().Trim(),
                               IDCard = row["IDCard"],
                               Balance = row["Balance"],
                               arr.MembershipLevel,
                               arr.Discount
                           };

                dgv_Client.DataSource = gain.ToArray();                          // 获取得到的记录
            }
            catch {
                dgv_Client.DataSource = null;                                    // 未找到清除之前的信息
            }
        }
        // 根据充值时间查找充值记录
        private void PhoneTime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // 根据充值时间查询满足条件的充值记录
                var gain = from row in rechargeManager.UserRechargeTable(PhoneTime.ToString(), DateTime.Now.AddDays(1).ToString()).AsEnumerable()
                           join arr in new CommodityManager().GetCommodityRecord(-1).AsEnumerable()
                           on row["GiftGiving"] equals arr["CommodityName"]
                           select new {
                               编号 = row["UserRechargeID"],
                               充值金额 = row["RechargeBalance"],
                               身份证 = row["IDCard"],
                               充值时间 = row["RechargeTime"],
                               赠送商品 = arr["CommodityName"].ToString().Trim()
                           };

                dgv_topUpRecord.DataSource = gain.ToArray();                     // 获取得到的记录
            }
            catch {
                dgv_topUpRecord.DataSource = null;                               // 未找到清除之前的信息
            }
        }
        // 根据顾客身份证获取该顾客的充值记录
        private void Dgv_Client_Click(object sender, EventArgs e)
        {
            EnablePrepaidPhone();                                                // 激活充值选项控件
            try
            {
                // 根据顾客身份证查询满足条件的充值记录
                var gain = from row in rechargeManager.SeekRechargeIDCard(dgv_Client.SelectedCells[1].Value.ToString()).AsEnumerable()
                           join arr in new CommodityManager().GetCommodityRecord(-1).AsEnumerable()
                           on row["GiftGiving"] equals arr["CommodityName"]
                           select new {
                               编号 = row["UserRechargeID"],
                               充值金额 = row["RechargeBalance"],
                               身份证 = row["IDCard"],
                               充值时间 = row["RechargeTime"],
                               赠送商品 = arr["CommodityName"].ToString().Trim()
                           };
                
                dgv_topUpRecord.DataSource = gain.ToArray();                     // 获取得到的记录
            }
            catch {
                dgv_topUpRecord.DataSource = null;                               // 未找到清除之前的信息
            }
        }
        // 激活充值控件选项
        private void EnablePrepaidPhone()
        {
            // 激活充值控件并显示用户余额
            lab_balance.Text = dgv_Client.SelectedCells[2].Value.ToString();
            cbox_Member.Text = dgv_Client.SelectedCells[3].Value.ToString();
            txt_Balance.ReadOnly = false;
            cbox_Member.Enabled = true;
            recharge.Enabled = true;

            // 显示当前用户能充值的会员等级
            if (dgv_Client.SelectedCells[3].Value.ToString().Equals("普通客户"))
            {
                cbox_Member.Items.AddRange((from arr in memberships select new { arr.MembershipLevel }).ToArray());
            }
            else if (dgv_Client.SelectedCells[3].Value.ToString().Equals("会员"))
            {
                cbox_Member.Items.Add("大会员");
            }
            else
            {
                cbox_Member.Enabled = false;
            }

            // 显示赠送商品列表
            dgv_Commodity.DataSource = (
                from row in new CommodityManager().GetCommodityRecord(-1).AsEnumerable()
                select new { CommodityName = row["CommodityName"] }
                ).ToArray();
        }
        // 充值余额文本框输入控制
        private void Txt_Balance_KeyPress(object sender, KeyPressEventArgs e)
        {
            int num = e.KeyChar;

            e.Handled = ((num < '0' || num > '9') && num != 8 && num != 46);
        }
        // 计算本次充值的总消费
        private void Txt_Balance_TextChanged(object sender, EventArgs e)
        {
            // 根据充值的会员等级获取充值价格
            if (dgv_Client.SelectedCells[3].Value.ToString().Equals(cbox_Member.Text))
            {
                lab_Recharge.Text = txt_Balance.Text.Equals("") ? "0" : txt_Balance.Text;
            }
            else
            {
                // 获取本次会员等级充值价格
                int member = cbox_Member.Text.Equals("会员") ? 100 : cbox_Member.Text.Equals("大会员") ? 200 : 0;
                // 获取余额充值价格
                double money = txt_Balance.Text.Equals("") ? 0 : double.Parse(txt_Balance.Text);
                // 求出本次充值消费
                lab_Recharge.Text = (member + money).ToString();
            }
        }
        // 获取选中的赠送商品
        private void Dgv_Commodity_Click(object sender, EventArgs e)
        {
            lab_gift.Text = dgv_Commodity.SelectedCells[0].Value.ToString();
        }
        // 删除指定的充值记录
        private void Delete_Click(object sender, EventArgs e)
        {
            rechargeManager.DeleteUserRecharge((int)dgv_topUpRecord.SelectedCells[0].Value);

            Dgv_Client_Click(sender, e);                                        // 重新刷新显示
        }
        // 顾客充值
        private void Recharge_Click(object sender, EventArgs e)
        {
            rechargeManager.AddUserRecharge(new UserRechargeTable               // 生成并上传本次充值记录
            {
                IDCard = dgv_Client.SelectedCells[1].Value.ToString(),
                RechargeTime = DateTime.Now,
                RechargeBalance = double.Parse(lab_Recharge.Text),
                GiftGiving = new CommodityTable { CommodityName = lab_gift.Text }
            });
            AlterPitchOnUser(sender, e);                                        // 上传该顾客充值后的信息
        }
        // 修改顾客会员等级和余额
        private void AlterPitchOnUser(object sender, EventArgs e)
        {
            // 获取充值的顾客信息
            var table = userManager.CompareUserIDCard(dgv_Client.SelectedCells[1].Value.ToString());

            foreach (DataRow row in table.AsEnumerable().CopyToDataTable().Rows)
            {
                userManager.AmendUserRecord(new UserTable                       // 获取修改充值后的顾客信息
                {
                    UserName = row["UserName"].ToString(),
                    IDCard = row["IDCard"].ToString(),
                    TelephoneNumber = row["TelephoneNumber"].ToString(),
                    Gender = row["Gender"].ToString(),
                    Age = (int)row["Age"],
                    Member = GetMembership((int)row["Member"]),
                    Balance = (double)row["Balance"]
                });
            }
            Dgv_Client_Click(sender, e);                                        // 删除后重新刷新
        }
        // 根据会员等级编号获取指定的等级对象
        public MembershipTable GetMembership(int ID)
        {
            foreach (MembershipTable arr in memberships)                        // 遍历会员等级列表
            {
                if (ID == arr.MemberNumber) { return arr; }                     // 根据编号返回指定对象
            }
            return null;                                                        // 未找到返回空
        }
        ~ClientTopUp()
        {
            this.memberships = null;
            this.rechargeManager = null;
            this.userManager = null;
            this.Close();
        }
    }
}
