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
    public partial class MainInterface : Form
    {
        RoomManager rm = new RoomManager();
        RoomTypeManager rtm = new RoomTypeManager();
        public MainInterface()
        {
            InitializeComponent();
        }

        /*------------------ 打开其他窗口 ------------------*/
        /// <summary>
        /// 管理员操作界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainInterface_Load(object sender, EventArgs e)
        {
            RoomLayout();
            TypePrice();
            RoomStatus();
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

        /// <summary>
        /// 选项卡中房间布局
        /// </summary>
        public void RoomLayout()
        {
            tcXuanXiang.SelectedTab.Controls.Clear();
            DataTable dt = rm.RoomTable(tcXuanXiang.SelectedTab.Text == "全部" ? "" : rtm.TypeID(tcXuanXiang.SelectedTab.Text).ToString());

            for (int row = 0; row < (dt.Rows.Count % 5 == 0 ? dt.Rows.Count / 5 : dt.Rows.Count / 5 + 1); row++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (row * 5 + i >= dt.Rows.Count)
                    {
                        break;
                    }
                    Label lbl = new Label();
                    lbl.Size = new System.Drawing.Size(81, 31);
                    int x = (i + 1) * (lbl.Size.Width + 10) + 100;
                    int y = (row + 1) * (lbl.Size.Height + 15) + 30;
                    lbl.AutoSize = true;
                    lbl.BackColor = System.Drawing.Color.Yellow;
                    lbl.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    lbl.Location = new System.Drawing.Point(x, y);
                    lbl.Name = "lbl_" + dt.Rows[row*5 + i]["RoomNumber"].ToString().Trim();
                    lbl.TabIndex = 0;
                    lbl.Text = dt.Rows[row*5 + i]["RoomNumber"].ToString().Trim();
                    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    this.tcXuanXiang.SelectedTab.Controls.Add(lbl);
                }
            }
        }

        /// <summary>
        /// 今日房态
        /// </summary>
        public void RoomStatus()
        {
            DataTable dt = rm.RoomTable();

            int kong = 0;
            int zhan = 0;
            int yu = 0;
            lblCount.Text = dt.Rows.Count.ToString();
            foreach (DataRow item in dt.Rows)
            {
                if (item["RoomStatus"].ToString() == "1")
                {
                    kong++;
                }
                else if (item["RoomStatus"].ToString() == "2")
                {
                    zhan++;
                }
                else if (item["RoomStatus"].ToString() == "3")
                {
                    yu++;
                }
            }
            lblKong.Text = kong.ToString();
            lblZhan.Text = zhan.ToString();
            lblYu.Text = yu.ToString();
            prbLv.Value = (yu + zhan) / dt.Rows.Count;
        }

        /// <summary>
        /// 今日房价
        /// </summary>
        public void TypePrice()
        {
            DataTable dt = rtm.TypeTable();
            lblSoLo.Text = dt.Rows[0]["Price"].ToString();
            lblBigBed.Text = dt.Rows[1]["Price"].ToString();
            lblDouble.Text = dt.Rows[2]["Price"].ToString();
            lblLuxury.Text = dt.Rows[3]["Price"].ToString();
            lblPres.Text = dt.Rows[4]["Price"].ToString();
        }

        /// <summary>
        /// 选择选项卡发生改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControl2_Selecting(object sender, TabControlCancelEventArgs e)
        {
            RoomLayout();
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
