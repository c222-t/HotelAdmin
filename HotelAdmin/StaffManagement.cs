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
    /// 员工管理窗口
    /// </summary>
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

        private void 新增员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBan.Visible = true;
            cbQuan.SelectedIndex = 0;
        }

        private void 辞退员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAdministr.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择一项");
                return;
            }

            if (am.AdminisreDelect(dgvAdministr.SelectedRows[0].Cells[0].Value.ToString().Trim()) > 0)
            {
                MessageBox.Show("操作成功");
                dgvAdministr.DataSource = am.AdministrTable(txtZH.Text.Trim());
                pnBan.Visible = false;
            }
            else
            {
                MessageBox.Show("操作失败");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pnBan.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (txtZHnew.Text.Trim() == "")
            {
                MessageBox.Show("请输入账号！");
                txtZHnew.Focus();
                return;
            }
            else if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！");
                txtPwd.Focus();
                return;
            }

            AdministratorTable at = new AdministratorTable()
            {
                AdministratorName = txtZHnew.Text.Trim(),
                Password = int.Parse(txtPwd.Text.Trim()),
                jurisdiction = int.Parse(cbQuan.Text.Trim())
            };

            if (am.AdminisreInsert(at) > 0)
            {
                MessageBox.Show("操作成功");
                dgvAdministr.DataSource = am.AdministrTable(txtZH.Text.Trim());
                pnBan.Visible = false;
            }
            else
            {
                MessageBox.Show("操作失败");
            }
                    
        }
        ~StaffManagement()
        {
            this.am = null;
        }
    }
}
