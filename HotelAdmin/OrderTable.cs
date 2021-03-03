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

        private void OrderTable_Load(object sender, EventArgs e)
        {
            dgvYY.DataSource = stm.StatementNew(txtUserName.Text.Trim());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dgvYY.DataSource = stm.StatementNew(txtUserName.Text.Trim());
        }

        private void DgvYY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
