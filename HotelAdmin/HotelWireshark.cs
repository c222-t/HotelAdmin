using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using HotelModel;
using HotelBLL;

namespace HotelAdmin
{
    public partial class HotelWireshark : Form
    {
        /// <summary>
        /// 当前操作界面
        /// </summary>
        private Form currentWindow = new Form();

        public HotelWireshark()
        {
            InitializeComponent();
        }
        // 加载初始化信息
        private void HotelWireshark_Load(object sender, EventArgs e)
        {
            
        }

        #region 显示或切换操作界面

        // 挂起窗口
        private void HungWindow(object sender, EventArgs e)
        {
            new LockScreen().Show();
        }
        // 打开系统信息窗口
        private void Label5_Click(object sender, EventArgs e)
        {
            new Regard().ShowDialog();
        }
        // 打开消息列表界面
        private void Btn_MessageLists_Click_1(object sender, EventArgs e)
        {
            Pl_MessageLists.Visible = !Pl_MessageLists.Visible;
        }
        // 打开营业查询界面
        private void Btn_OpenInquire_Click_1(object sender, EventArgs e)
        {
            currentWindow.Close();
            currentWindow = new RevenueTable();
            OpenTheWindow();
        }
        // 打开顾客开单界面
        private void Btn_SalesOrders_Click(object sender, EventArgs e)
        {
            currentWindow.Close();
            currentWindow = new CustomerOrder();
            OpenTheWindow();
        }
        // 打开顾客结账界面
        private void Btn_CheckOut_Click(object sender, EventArgs e)
        {
            currentWindow.Close();
            currentWindow = new CheckOutTable();
            OpenTheWindow();
        }
        // 打开预定管理界面
        private void Btn_Reserve_Click(object sender, EventArgs e)
        {
            currentWindow.Close();
            currentWindow = new OrderTable();
            OpenTheWindow();
        }
        // 打开充值管理界面
        private void Btn_TopUp_Click(object sender, EventArgs e)
        {
            currentWindow.Close();
            currentWindow = new ClientTopUp();
            OpenTheWindow();
        }
        // 打开房间管理界面
        private void Btn_RoomKeeper_Click(object sender, EventArgs e)
        {
            currentWindow.Close();
            currentWindow = new RoomRegulate();
            OpenTheWindow();
        }
        // 打开客户管理界面
        private void Btn_Customer_Click(object sender, EventArgs e)
        {
            currentWindow.Close();
            currentWindow = new CustomerManage();
            OpenTheWindow();
        }
        // 打开员工管理界面
        private void Btn_Personnel_Click(object sender, EventArgs e)
        {
            currentWindow.Close();
            currentWindow = new StaffManagement();
            OpenTheWindow();
        }
        // 打开商品管理界面
        private void Btn_Commodity_Click(object sender, EventArgs e)
        {
            currentWindow.Close();
            currentWindow = new MerchandiseManage();
            OpenTheWindow();
        }
        /// <summary>
        /// 打开指定的窗口界面
        /// </summary>
        private void OpenTheWindow()
        {
            // 将业务窗口绑定到操作面板中
            currentWindow.TopLevel = false;                                 // 设置操作窗口不显示为顶级窗口
            currentWindow.FormBorderStyle = FormBorderStyle.None;           // 窗口样式无标题栏
            currentWindow.Dock = DockStyle.Fill;                            // 填充
            this.Pl_Interface.Controls.Clear();                             // 清空之前操作界面的控件
            this.Pl_Interface.Controls.Add(currentWindow);                  // 加入操作窗口
            currentWindow.Show();
        }

        #endregion

        #region 界面显示效果

        private void Btn_MessageLists_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_MessageLists.ForeColor = Color.FromArgb(116, 77, 255);
            Btn_MessageLists.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void Btn_MessageLists_Leave(object sender, EventArgs e)
        {
            Btn_MessageLists.ForeColor = Color.FromArgb(255, 255, 255);
            Btn_MessageLists.BackColor = Color.FromArgb(116, 77, 255);
        }

        private void Btn_OpenInquire_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_OpenInquire.ForeColor = Color.FromArgb(116, 77, 255);
            Btn_OpenInquire.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void Btn_OpenInquire_Leave(object sender, EventArgs e)
        {
            Btn_OpenInquire.ForeColor = Color.FromArgb(255, 255, 255);
            Btn_OpenInquire.BackColor = Color.FromArgb(116, 77, 255);
        }

        private void Btn_SalesOrders_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_SalesOrders.ForeColor = Color.FromArgb(116, 77, 255);
            Btn_SalesOrders.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void Btn_SalesOrders_Leave(object sender, EventArgs e)
        {
            Btn_SalesOrders.ForeColor = Color.FromArgb(255, 255, 255);
            Btn_SalesOrders.BackColor = Color.FromArgb(116, 77, 255);
        }

        private void Btn_CheckOut_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_CheckOut.ForeColor = Color.FromArgb(116, 77, 255);
            Btn_CheckOut.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void Btn_CheckOut_Leave(object sender, EventArgs e)
        {
            Btn_CheckOut.ForeColor = Color.FromArgb(255, 255, 255);
            Btn_CheckOut.BackColor = Color.FromArgb(116, 77, 255);
        }

        private void Btn_Reserve_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_Reserve.ForeColor = Color.FromArgb(116, 77, 255);
            Btn_Reserve.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void Btn_Reserve_Leave(object sender, EventArgs e)
        {
            Btn_Reserve.ForeColor = Color.FromArgb(255, 255, 255);
            Btn_Reserve.BackColor = Color.FromArgb(116, 77, 255);
        }

        private void Btn_TopUp_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_TopUp.ForeColor = Color.FromArgb(116, 77, 255);
            Btn_TopUp.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void Btn_TopUp_Leave(object sender, EventArgs e)
        {
            Btn_TopUp.ForeColor = Color.FromArgb(255, 255, 255);
            Btn_TopUp.BackColor = Color.FromArgb(116, 77, 255);
        }

        private void Btn_RoomKeeper_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_RoomKeeper.ForeColor = Color.FromArgb(116, 77, 255);
            Btn_RoomKeeper.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void Btn_RoomKeeper_Leave(object sender, EventArgs e)
        {
            Btn_RoomKeeper.ForeColor = Color.FromArgb(255, 255, 255);
            Btn_RoomKeeper.BackColor = Color.FromArgb(116, 77, 255);
        }

        private void Btn_Customer_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_Customer.ForeColor = Color.FromArgb(116, 77, 255);
            Btn_Customer.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void Btn_Customer_Leave(object sender, EventArgs e)
        {
            Btn_Customer.ForeColor = Color.FromArgb(255, 255, 255);
            Btn_Customer.BackColor = Color.FromArgb(116, 77, 255);
        }

        private void Btn_Personnel_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_Personnel.ForeColor = Color.FromArgb(116, 77, 255);
            Btn_Personnel.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void Btn_Personnel_Leave(object sender, EventArgs e)
        {
            Btn_Personnel.ForeColor = Color.FromArgb(255, 255, 255);
            Btn_Personnel.BackColor = Color.FromArgb(116, 77, 255);
        }

        private void Btn_Commodity_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_Commodity.ForeColor = Color.FromArgb(116, 77, 255);
            Btn_Commodity.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void Btn_Commodity_Leave(object sender, EventArgs e)
        {
            Btn_Commodity.ForeColor = Color.FromArgb(255, 255, 255);
            Btn_Commodity.BackColor = Color.FromArgb(116, 77, 255);
        }

        #endregion

    }
}
