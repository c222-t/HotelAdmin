using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBLL;
using HotelModel;

namespace HotelAdmin
{
    public partial class CheckOutTable : Form
    {
        StatementTableManager stm = new StatementTableManager();
        public CheckOutTable()
        {
            InitializeComponent();
            dgvRoom.AutoGenerateColumns = false;
            dgvUser.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 点击查看显示占用房间表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            dgvRoom .DataSource = stm.Statement(txtRoomName.Text.Trim());
        }

        /// <summary>
        /// 点击选中房间表显示房客表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUser.DataSource = stm.Statement(dgvRoom.SelectedRows[0].Cells[1].Value.ToString());
        }

        /// <summary>
        /// 点击选中房客显示结账信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtYinFu.Text = dgvUser.SelectedRows[0].Cells[9].Value.ToString();
            txtDingDan.Text = dgvUser.SelectedRows[0].Cells[0].Value.ToString().Trim();
            cbFuKuan.Enabled = true;
            cbFuKuan.SelectedIndex = 0;

        }

        /// <summary>
        /// 设置文本框只能输入数字与小数点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtZon_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = e.KeyChar;
            if ((key < '0' || key > '9') && (key != 8 && key != 46))
                e.Handled = true;
        }

        /// <summary>
        /// 选择收款方式来计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbFuKuan_TextChanged(object sender, EventArgs e)
        {
            if (cbFuKuan.Text == "现金支付")
            {
                lblLing.Text = "找    零：";
                txtZon.Enabled = true;
            }
            else if (cbFuKuan.Text == "余额支付")
            {
                lblLing.Text = "余额剩余：";
                txtZon.Enabled = false;
                txtLing.Text = (Double.Parse(dgvUser .SelectedRows [0].Cells [3].Value.ToString ())  - Double.Parse(txtYinFu.Text)) + "";
            }


        }

        /// <summary>
        /// 输入金额计算找零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtZon_TextChanged(object sender, EventArgs e)
        {
            txtLing.Text = (txtZon.Text == "" ? 0 : (Double.Parse(txtZon.Text) - Double.Parse(txtYinFu.Text))) + "";
            if (Double.Parse(txtLing.Text) < 0)
            {
                txtLing.ForeColor = Color.Red;
            }

        }

        /// <summary>
        /// 确定按钮，同时修改用户表，订单表，房间表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            UserManager um = new UserManager();//用户表修改

            DataTable dt= um.CompareUserIDCard(dgvUser.SelectedRows[0].Cells[10].Value.ToString());
            UserTable ut = new UserTable();
            ut.Age = int.Parse(dt.Rows[0]["Age"].ToString());
            ut.Gender = dt.Rows[0]["Gender"].ToString();
            ut.IDCard = dt.Rows[0]["IDCard"].ToString();
            ut.Member = new MembershipTable()
            {
                MemberNumber = int.Parse(dt.Rows[0]["Member"].ToString())
            };
            ut.TelephoneNumber = dt.Rows[0]["TelephoneNumber"].ToString();
            ut.UserName = dt.Rows[0]["UserName"].ToString();
            if (cbFuKuan.Text == "余额支付")
            {
                ut.Balance = double.Parse(txtLing.Text) < 0 ? 0 : double.Parse(txtLing.Text);
            }

            RoomManager rm = new RoomManager();//房间表修改

            RoomSchedules rs = new RoomSchedules()
            {
                Floor =dgvUser .SelectedRows [0].Cells [11].Value .ToString (),
                RoomNumber =dgvUser .SelectedRows [0].Cells [1].Value .ToString (),
                RoomType =new RoomTypeTable()
                {
                    No =int.Parse(dgvUser .SelectedRows [0].Cells [12].Value .ToString ())
                },
                RoomStatus =new RoomStatus()
                {
                    No =1,
                    StatusName ="空闲"
                }
            };

            OrderManager om = new OrderManager();//订单表修改
            DataTable ad = om.SeekOrderRecord(new StatementTable() { OrderNumber = dgvUser.SelectedRows[0].Cells[0].Value.ToString().Trim() });

            StatementTable st = new StatementTable()
            {
                CheckInTime = DateTime.Parse(ad.Rows[0]["CheckInTime"].ToString()),
                CheckoutTime = DateTime.Now,
                IDCard = ad.Rows[0]["IDCard"].ToString(),
                OperationManager = int.Parse(ad.Rows[0]["OperationManaer"].ToString()),
                OrderNumber = ad.Rows[0]["OrderNumber"].ToString(),
                PaymentMethod = cbFuKuan.Text,
                Room = new RoomSchedules()
                {
                    RoomNumber = ad.Rows[0]["RoomNumber"].ToString()
                },
                TotalConsumption = double.Parse(txtYinFu.Text),
                Status = new OrderStatusTable()
                {
                    Number = 3,
                    State = "结束"
                }
            };

            //集中修改三张表
            um.AmendUserRecord(ut);
            om.AmendOrderRecord(st);
            rm.RoomUpdate(rs.RoomNumber, rs);
            dgvRoom.DataSource = stm.Statement(txtRoomName.Text.Trim());

        }
    }
}
