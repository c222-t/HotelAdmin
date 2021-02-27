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
    public partial class CheckOutTable : Form
    {
        StatementTableManager stm = new StatementTableManager();
        public CheckOutTable()
        {
            InitializeComponent();
            dgvRoom.AutoGenerateColumns = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dgvRoom.DataSource = stm.Statement(txtRoomName.Text.Trim());
        }

        private void DgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUser.DataSource = stm.Statement(dgvRoom.SelectedRows[0].Cells[1].Value.ToString());
        }
    }
}
