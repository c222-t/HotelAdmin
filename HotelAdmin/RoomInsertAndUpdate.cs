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
    public partial class RoomInsertAndUpdate : Form
    {
        public RoomRegulate frm = null;
        public string asd = "";
        RoomTypeManager rtm = new RoomTypeManager();
        RoomManager rm = new RoomManager();
        public RoomInsertAndUpdate()
        {
            InitializeComponent();
        }

        public bool PanDuan()
        {
            if (txtRoomName.Text.Trim() == "")
            {
                MessageBox.Show("请输入房间名称");
                txtRoomName.Focus();
                return false;
            }
            else if (txtLou.Text.Trim() == "")
            {
                MessageBox.Show("请输入楼层");
                txtLou.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 窗体加载时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomInsertAndUpdate_Load(object sender, EventArgs e)
        {
            DataTable dt = rtm.TypeTable();

            cbRoomType.DataSource = dt;
            cbRoomType.DisplayMember = "Name";
            cbRoomType.ValueMember = "No";

            if (asd == "新增")
            {
                this.Text = "增加房间";
            }
            else
            {
                this.Text = "修改房间信息";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (PanDuan())
            {
                RoomSchedules room = new RoomSchedules()
                {
                    Floor = txtLou.Text,
                    RoomNumber = txtRoomName.Text,
                    RoomStatus = new RoomStatus()
                    {
                        No=1
                    },
                    RoomType =new RoomTypeTable()
                    {
                        Name = cbRoomType.Text,
                        No = rtm.TypeID(cbRoomType.Text)
                    }
                };
                rm.RoomInsert(room);
                frm.ShuaXin();
                this.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
