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
        /// 当前操作界面
        /// </summary>
        private Form currentWindow = new Form();

        public HotelWireshark()
        {
            InitializeComponent();
        }

        #region 显示或切换操作界面

        // 加载初始化信息
        private void HotelWireshark_Load(object sender, EventArgs e)
        {

        }
        // 挂起窗口
        private void HungWindow(object sender, EventArgs e)
        {
            LockScreen ls = new LockScreen();
            ls.Show();
        }
        // 打开系统信息窗口
        private void Label5_Click(object sender, EventArgs e)
        {
            Regard frm = new Regard();
            frm.ShowDialog();
        }
        // 打开消息列表界面
        private void Btn_MessageLists_Click(object sender, EventArgs e)
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

        private void Btn_MessageLists_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_MessageLists_Leave(object sender, EventArgs e)
        {

        }

        private void Btn_MessageLists_MouseMove(object sender, MouseEventArgs e)
        {

        }

        #endregion

        /*---------------- 界面显示效果 ----------------*/
        // 设计鼠标移动到选项列表时显示的效果


    }
}
