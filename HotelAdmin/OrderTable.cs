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
    /// 预定管理窗口
    /// </summary>
    public partial class OrderTable : Form
    {
        StatementTableManager stm = new StatementTableManager();

        public OrderTable()
        {
            InitializeComponent();
        }

        public void ShuaXin()
        {
            dgvYY.DataSource = stm.StatementNew(txtUserName.Text.Trim());
        }

        private void OrderTable_Load(object sender, EventArgs e)
        {
            ShuaXin();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ShuaXin();
        }

        private void 预定房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerOrder frm = new CustomerOrder();
            frm.frm = this;
            frm.Show();
        }
        ~OrderTable()
        {
            this.stm = null;
        }
    }
}
