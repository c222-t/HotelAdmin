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
        /// 创建节点对象
        /// </summary>
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        /// <summary>
        /// 接收客户消息业务
        /// </summary>
        static Thread listenTo = new Thread(new ParameterizedThreadStart(ReceiveAMessage));
        /// <summary>
        /// 当前操作界面
        /// </summary>
        private Form currentWindow = new Form();

                    //如果获取的IP地址族格式等于IP4地址格式
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        //返回获得的IP4地址
                        return IpEntry.AddressList[i].ToString();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取本机IP出错:" + ex.Message);
                return "";
            }
        }
        /// <summary>
        /// 程序启动执行操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Service()
        {
            //使CPU不检查线程
            Control.CheckForIllegalCrossThreadCalls = false;
            //调用IP的方法使他的返回值赋予txtIP.text
            ip = IP();
        }
        #endregion
        public HotelWireshark()
        {
            InitializeComponent();
        }
        // 加载初始化信息
        private void HotelWireshark_Load(object sender, EventArgs e)
        {
            this.lab_name.Text = Cun.Name;                                  // 获取当前用户名称
            listenTo.IsBackground = true;                                   // 将收听消息设为后台服务
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
            CloseTheMessageScreen();
            currentWindow.Close();
            currentWindow = new RevenueTable();
            OpenTheWindow();
        }
        // 打开顾客开单界面
        private void Btn_SalesOrders_Click(object sender, EventArgs e)
        {
            CloseTheMessageScreen();
            currentWindow.Close();
            currentWindow = new CustomerOrder();
            OpenTheWindow();
        }
        // 打开顾客结账界面
        private void Btn_CheckOut_Click(object sender, EventArgs e)
        {
            CloseTheMessageScreen();
            currentWindow.Close();
            currentWindow = new CheckOutTable();
            OpenTheWindow();
        }
        // 打开预定管理界面
        private void Btn_Reserve_Click(object sender, EventArgs e)
        {
            CloseTheMessageScreen();
            currentWindow.Close();
            currentWindow = new OrderTable();
            OpenTheWindow();
        }
        // 打开充值管理界面
        private void Btn_TopUp_Click(object sender, EventArgs e)
        {
            CloseTheMessageScreen();
            currentWindow.Close();
            currentWindow = new ClientTopUp();
            OpenTheWindow();
        }
        // 打开房间管理界面
        private void Btn_RoomKeeper_Click(object sender, EventArgs e)
        {
            CloseTheMessageScreen();
            currentWindow.Close();
            currentWindow = new RoomRegulate();
            OpenTheWindow();
        }
        // 打开客户管理界面
        private void Btn_Customer_Click(object sender, EventArgs e)
        {
            CloseTheMessageScreen();
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
        /// 关闭消息显示界面
        /// </summary>
        private void CloseTheMessageScreen()
        {
            if (Pl_MessageLists.Visible) { Pl_MessageLists.Visible = false; }
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

        // 接收来自客户发送的需求信息
        private static void ReceiveAMessage(object obj)
        {
            socket.Listen(10);                                              // 开始监听,且指定监听数量
            listenTo.Start();                                               // 开始接收

            Socket newSocket = (Socket)obj;
            while (true)
            {
                byte[] resMsg = new byte[1024];
                int resMsgLenght = newSocket.Receive(resMsg, resMsg.Length, 0);
                MessageBox.Show(Encoding.UTF8.GetString(resMsg, 0, resMsgLenght), "客户");
            }
        }
        // 主界面关闭时将系统临时数据上传到数据库
        private void HotelWireshark_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AdministratorManager().UploadData();
        }
    }
}
