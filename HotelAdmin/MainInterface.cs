using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using HotelBLL;
using HotelModel;

namespace HotelAdmin
{
    public partial class MainInterface : Form
    {
        RoomManager rm = new RoomManager();
        public MainInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 管理员操作界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainInterface_Load(object sender, EventArgs e)
        {
            RoomLayout();
        }
        /// <summary>
        /// 开单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Billing_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 结账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckOut_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 预定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Book_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopUp_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 营业查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InquiringThe_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 房间管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomKeeper_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 客户管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerCRM_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 员工管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonnelManage_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 商品管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommodityManager_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 系统设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemSetup_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 挂起
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Suspend_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AsFor_Click(object sender, EventArgs e)
        {
            Regard frm = new Regard();
            frm.ShowDialog();
        }

        public void RoomLayout()
        {
            DataTable dt = rm.RoomTable(tpTabs.Text);
        }

        /// <summary>
        /// 选择选项卡发生改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControl2_Selecting(object sender, TabControlCancelEventArgs e)
        {
            MessageBox.Show("a");
        }

        /// <summary>
        /// 关闭窗体同时关闭程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
