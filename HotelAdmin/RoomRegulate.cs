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
    /// <summary>
    /// 房间管理窗口
    /// </summary>
    public partial class RoomRegulate : Form
    {
        DataTable dt = new DataTable();//暂时保存数据
        RoomTypeManager rtm = new RoomTypeManager();
        RoomManager rm = new RoomManager();
        MoreTableManager mtm = new MoreTableManager();

        public RoomRegulate()
        {
            InitializeComponent();
            dgvRoom.AutoGenerateColumns = false;
            dgvUser.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 刷新
        /// </summary>
        public void ShuaXin()
        {
            if (tvCaiDan.SelectedNode == null)
            {
                return;
            }

            if (tvCaiDan.SelectedNode.Level == 0)
            {
                DataTable dt = rm.RoomTable();
                dgvRoom.DataSource = dt;
            }
            else if (tvCaiDan.SelectedNode.Level == 1)
            {
                DataTable dt = rm.RoomTable(tvCaiDan.SelectedNode.Text);
                dgvRoom.DataSource = dt;
            }
        }

        /// <summary>
        /// 窗体加载时运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomRegulate_Load(object sender, EventArgs e)
        {
            //添加树形菜单内容
            DataTable dt = rtm.TypeTable();

            foreach (DataRow item in dt.Rows)
            {
                TreeNode tn = new TreeNode();
                tn.Text = item["Name"].ToString().Trim();
                tn.Tag = item;

                tvCaiDan.Nodes[0].Nodes.Add(tn);
            }
        }

        /// <summary>
        /// 选中房间类型显示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TvCaiDan_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShuaXin();
        }

        /// <summary>
        /// 选中查看用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRoom.SelectedRows.Count == 0)
            {
                return;
            }

            if (dgvRoom.SelectedRows[0].Cells[2].Value.ToString().Trim() == "空闲")
            {
                return;
            }

            dgvUser.DataSource = mtm.MoreMore(dgvRoom.SelectedRows[0].Cells[1].Value.ToString());
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            RoomInsertAndUpdate riau = new RoomInsertAndUpdate();
            riau.frm = this;
            riau.asd = toolStripButton1.Text;
            riau.Show();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中");
                return;
            }

            if (dgvRoom.SelectedRows[0].Cells[2].Value.ToString ().Trim() == "占用")
            {
                MessageBox.Show("已有顾客!");
                return;
            }

            rm.RoomDelect(dgvRoom.SelectedRows[0].Cells[1].Value.ToString());
            ShuaXin();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows[0].Cells[2].Value.ToString().Trim() == "占用")
            {
                MessageBox.Show("已有顾客!");
                return;
            }

            RoomInsertAndUpdate riau = new RoomInsertAndUpdate();
            riau.frm = this;
            riau.asd = toolStripButton3.Text;
            RoomSchedules room = new RoomSchedules()
            {
                Floor = dgvRoom.SelectedRows[0].Cells[3].Value.ToString(),
                RoomNumber = dgvRoom.SelectedRows[0].Cells[1].Value.ToString(),
                RoomStatus = new RoomStatus()
                {
                    StatusName = dgvRoom.SelectedRows[0].Cells[2].Value.ToString()
                },
                RoomType = new RoomTypeTable()
                {
                    Name = dgvRoom.SelectedRows[0].Cells[4].Value.ToString()
                }
            };
            riau.roo = room;
            riau.Show();
        }
        ~RoomRegulate()
        {
            this.dt = null;
            this.rtm = null;
            this.rm = null;
            this.mtm = null;
        }
    }
}
