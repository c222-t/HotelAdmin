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
    public partial class StaffManagement : Form
    {
        AdministratorManager am = new AdministratorManager();
        public StaffManagement()
        {
            InitializeComponent();
        }


        private void StaffManagement_Load(object sender, EventArgs e)
        {
            dgvAdministr.DataSource = am.AdministrTable(txtZH.Text.Trim());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dgvAdministr.DataSource = am.AdministrTable(txtZH.Text.Trim());
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
