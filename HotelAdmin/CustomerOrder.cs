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
    /// <summary>
    /// 顾客开单窗口
    /// </summary>
    public partial class CustomerOrder : Form
    {
        public OrderTable frm = null;
        /// <summary>
        /// 服务员编号
        /// </summary>
        public int waiterID = -1;
        /// <summary>
        /// 顾客业务处理对象
        /// </summary>
        UserManager userManager = new UserManager();
        /// <summary>
        /// 订单业务处理对象
        /// </summary>
        OrderManager orderManager = new OrderManager();
        /// <summary>
        /// 房间类型列表
        /// </summary>
        List<RoomTypeTable> roomType = new List<RoomTypeTable>();
        /// <summary>
        /// 会员等级列表
        /// </summary>
        List<MembershipTable> MemberType = new List<MembershipTable>();

        public CustomerOrder()
        {
            InitializeComponent();
        }
        // 加载初始化数据信息
        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            if (frm != null)
            {
                this.Text = "新增预约订单";
            }
            GetRoomTypeManager();                                       // 获取会员等级列表信息
            GetMembershipTable();                                       // 获取房间类型列表信息
        }
        // 加载会员等级信息列表
        private void GetMembershipTable()
        {
            // 遍历会员等级数据表
            foreach (DataRow row in new UserManager().GetMembershipRecord().Rows)
            {
                MemberType.Add(new MembershipTable {                    // 向数据会员等级列表添加信息
                    MembershipLevel = row["MembershipLevel"].ToString().Trim(),
                    MemberNumber = (int)row["MemberNumber"],
                    Discount = (double)row["Discount"],
                });
                // 向控件会员等级列表添加信息
                cbox_members.Items.Add(row["MembershipLevel"].ToString().Trim());
            }
            cbox_members.Text = cbox_members.Items[0].ToString();       // 显示会员等级默认选项
        }
        // 加载房间类型信息列表
        private void GetRoomTypeManager()
        {
            // 遍历房间类型数据表
            foreach (DataRow row in new RoomTypeManager().TypeTable().Rows)
            {
                this.roomType.Add(new RoomTypeTable {                   // 向数据房间类型列表添加信息
                    Name = row["Name"].ToString(),
                    Price = (double)row["Price"],
                    No = (int)row["No"]
                });
                cbox_roomClass.Items.Add(row["Name"].ToString().Trim());// 向控件房间类型列表添加信息             
            }
            cbox_roomClass.Text = cbox_roomClass.Items[0].ToString();   // 显示房间类型默认选项
        }
        // 根据房间类型显示满足条件的信息
        private void Cbox_roomClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {                                                       // 查询指定房间类型的房间信息
                var table = from row in new RoomManager().RoomTable(cbox_roomClass.Text.Equals("全部") ? "" : cbox_roomClass.Text).AsEnumerable()
                            join arr in roomType on row["Name"].ToString() equals arr.Name
                            //.Skip().Take()
                            select new {
                                RoomNumber = row["RoomNumber"],
                                Floor = row["Floor"],
                                arr.Name,
                                arr.Price,
                            };

                Dgv_RoomList.DataSource = table.ToArray();              // 上传到显示控件
            } catch {
                Dgv_RoomList.DataSource = null;                         // 未找到信息清除之前的记录
            }
        }
        // 根据会员等级显示对应的折扣
        private void Cbox_members_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_members.Text.Equals("普通客户")) {                 // 显示普通用户折扣
                Discount.Text = "1";
            } else if (cbox_members.Text.Equals("会员")) {             // 显示会员用户折扣
                Discount.Text = "0.9";
            } else {                                                   // 显示大会员折扣
                Discount.Text = "0.7";
            }
        }
        // 顾客开单
        private void Btn_Billing_Click(object sender, EventArgs e)
        {
            if (userManager.CompareUserIDCard(txt_IDcard.Text) != null) // 判断该用户是否已经入住
            {
                MessageBox.Show("该顾客以入住，无法再开订单！", "提示");
                return;
            }
            try                                                         // 向数据库添加相应的信息
            {
                SubmitNewClient();
                SubmitNewOrder();
                if (frm != null)
                {
                    MessageBox.Show("预约成功！", "提示");
                }
                else
                {
                    MessageBox.Show("添加成功！", "提示");
                }
            }
            catch {
                MessageBox.Show("必要信息未填写或填写错误！", "提示");
            }
        }
        // 提交顾客信息
        private void SubmitNewClient()
        {
            UserTable user = new UserTable
            {
                UserName = txt_name.Text,
                Gender = rbtn_male.Checked ? "男" : "女",
                Age = int.Parse(txt_age.Text),
                Balance = double.Parse(txt_bmikece.Text),
                IDCard = txt_IDcard.Text,
                Member = GetMembership(cbox_members.Text),
                TelephoneNumber = txt_phone.Text
            };
            userManager.AddUserRecord(user);
        }
        // 上传新订单
        private void SubmitNewOrder()
        {
            StatementTable order = new StatementTable()             // 创建订单对象
            {
                IDCard = txt_IDcard.Text,
                PaymentMethod = cbox_payWay.Text,
                CheckInTime = (DateTime)dtpicker_begin.Value,
                CheckoutTime = (DateTime)dtpicker_leave.Value,
                Room = new RoomSchedules {
                    Floor = Dgv_RoomList.SelectedCells[1].Value.ToString().Trim(),
                    RoomNumber = Dgv_RoomList.SelectedCells[0].Value.ToString().Trim(),
                    RoomType = GetRoomStatus(Dgv_RoomList.SelectedCells[2].Value.ToString().Trim()),
                    RoomStatus = new RoomStatus { No = 2, StatusName = "占用" }
                },
                Status = new OrderStatusTable { Number = frm==null?2:1, State = frm==null?"开始":"未开始" },
                OperationManager = waiterID,
                TotalConsumption = (double)Dgv_RoomList.SelectedCells[3].Value * double.Parse(Discount.Text),
                Days = 1
            };
            orderManager.AddOrderRecord(order);                     // 向数据库添加本次订单记录
        }
        // 根据会员名称获取对应的会员等级信息
        private MembershipTable GetMembership(string name)
        {
            // 查找指定会员等级名称的会员等级信息
            return MemberType.Where(arr => name.Equals(arr.MembershipLevel)).FirstOrDefault();
        }
        // 根据房间类型名称获取相应房间类型
        private RoomTypeTable GetRoomStatus(string name)
        {
            // 查找指定房间类型名称的房间类型信息
            return roomType.Where(arr => name.Equals(arr.Name)).FirstOrDefault();
        }
        ~CustomerOrder()
        {
            this.userManager = null;
            this.orderManager = null;
            this.roomType = null;
            this.MemberType = null;
        }
    }
}
