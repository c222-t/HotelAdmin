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

        private void 取消预定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderManager om = new OrderManager();
            om.DeleteOrderRecord(new StatementTable() { OrderNumber = dgvYY.SelectedRows[0].Cells[0].Value.ToString() });
            ShuaXin();
        }
    }
}
