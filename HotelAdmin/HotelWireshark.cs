using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAdmin
{
    public partial class HotelWireshark : Form
    {
        /// <summary>
        /// 操作界面
        /// </summary>
        private Form CurrentWindow;

        public HotelWireshark()
        {
            InitializeComponent();
        }
        /*---------------- 显示或切换操作界面 ----------------*/
        // 加载初始化信息
        private void HotelWireshark_Load(object sender, EventArgs e)
        {
            Pl_MessageLists.Visible = Pl_MessageLists.Visible;
        }
        // 打开消息列表界面
        private void Btn_MessageLists_Click(object sender, EventArgs e)
        {
            
        }
        // 打开营业查询界面
        private void Btn_OpenInquire_Click_1(object sender, EventArgs e)
        {

        }
        // 打开顾客开单界面
        private void Btn_SalesOrders_Click(object sender, EventArgs e)
        {
            CurrentWindow = new CustomerOrder();
            CurrentWindow.Show();
            CurrentWindow.Location = new System.Drawing.Point(Pl_Interface.Location.X + 105, Pl_Interface.Location.Y + 64);
        }
        // 打开顾客结账界面
        private void Btn_CheckOut_Click(object sender, EventArgs e)
        {

        }
        // 打开预定管理界面
        private void Btn_Reserve_Click(object sender, EventArgs e)
        {

        }
        // 打开充值管理界面
        private void Btn_TopUp_Click(object sender, EventArgs e)
        {

        }
        // 打开房间管理界面
        private void Btn_RoomKeeper_Click(object sender, EventArgs e)
        {

        }
        // 打开客户管理界面
        private void Btn_Customer_Click(object sender, EventArgs e)
        {

        }
        // 打开员工管理界面
        private void Btn_Personnel_Click(object sender, EventArgs e)
        {

        }
        // 打开商品管理界面
        private void Btn_Commodity_Click(object sender, EventArgs e)
        {

        }

        /*---------------- 界面显示效果 ----------------*/
    }
}
