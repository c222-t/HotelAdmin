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
        string ip = "";
        /// <summary>
        /// 当前操作界面
        /// </summary>
        private Form currentWindow = new Form();
        public HotelWireshark()
        {
            InitializeComponent();
        }

        #region 服务器
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

        /// <summary>
        /// 自动获取本机IP4地址
        /// </summary>
        /// <returns>返回IP地址</returns>
        static string IP()
        {
            try
            {
                //得到主机名
                string HostName = Dns.GetHostName();
                //提供一个IP地址容器
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                //对IP地址列表进行循环
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型

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
        //创建一个Socket
        Socket socketWatch;
        private void ListenNew()
        {
            try
            {
                //点击开始侦听的时候，在服务器创建一个负责侦听IP地址跟端口号的Socket
                socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                IPAddress iP = IPAddress.Any;
                //创建端口号对象
                IPEndPoint point = new IPEndPoint(iP, Convert.ToInt32("52000"));
                //侦听   绑定侦听端口point
                socketWatch.Bind(point);
                //调用ShowMsg方法把“侦听开始”显示到文本框上
                ShowMsg("连接服务器成功！！");
                //设置1S内最大的连接数
                socketWatch.Listen(100);
            }
            catch
            { }


            try
            {
                //创建一个新的子线程
                Thread th = new Thread(Listen);
                //设置该线程为后台线程
                th.IsBackground = true;

                th.Start(socketWatch);
            }
            catch //(Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }

        }
        Socket socketSend;
        //将所有的IP地址和端口号存入集合中
        Dictionary<string, Socket> dicsocket = new Dictionary<string, Socket>();

        /// <summary>
        /// 给文本框添加内容
        /// </summary>
        /// <param name="str">字符串</param>
        void ShowMsg(string str)
        {
            //显示在txtContenr文本框上
            txtContent.AppendText(str + "\r\n\n");
        }


        /// <summary>
        /// 等待客户端的链接  并且创建一个负责通信的Socket
        /// </summary>
        /// <param name="o"></param>
        void Listen(object o)
        {
            socketWatch = o as Socket;
            //等待客户端的链接  并且创建一个负责通信的Socket
            while (true)
            {
                try
                {
                    socketSend = socketWatch.Accept();//错误执行此操作前必须使用Bing方法
                    //将所有的IP地址和端口号添加到集合中
                    dicsocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    //IP:链接成功
                    ShowMsg("链接成功");
                    pbMessage.Visible = true;
                    //开启一个新线程不停的接收客户端发送过来的消息
                    Thread th = new Thread(Recive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
                catch//(Exception e)
                {
                    //MessageBox.Show(e.ToString());
                }

            }
        }

        /// <summary>
        /// 服务器端不停的接受客户端发来的信息
        /// </summary>
        /// <param name="o"></param>
        void Recive(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                try

                {
                    //客户端链接成功后，服务器应该接受客户端发来的消息
                    byte[] buffet = new byte[1024 * 1024 * 2];
                    //实际接受到的有效字节数
                    int r = socketSend.Receive(buffet);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffet, 0, r);
                    ShowMsg(str+"\n");
                }
                catch//(Exception e)
                {
                    //MessageBox.Show(e.ToString());
                }
            }
        }

        #endregion

        // 加载初始化信息
        private void HotelWireshark_Load(object sender, EventArgs e)
        {
            Service();
            ListenNew();
            this.lab_name.Text = Cun.Name;                                  // 获取当前用户名称
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
            pbMessage.Visible = false;
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

        // 主界面关闭时将系统临时数据上传到数据库
        private void HotelWireshark_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AdministratorManager().UploadData();
        }
    }
}
