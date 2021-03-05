using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HotelAdmin
{
    public partial class LockScreen : Form
    {
        Hook h = new Hook();

        public LockScreen()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPwd.Text == Cun.Pwd)
                {
                    this.Close();
                }
                else
                {
                    txtPwd.Text = "";
                    lblPwd.Visible = true;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void LockScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
            {
                e.Handled = true;
            }
        }

        private void TrmCloseTaskmgr_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Activate();
                Process[] myProcess = Process.GetProcesses();
                foreach (Process p in myProcess)
                {
                    if (p.ProcessName == "taskmgr")
                    {
                        p.Kill();
                        return;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void LockScreen_Load(object sender, EventArgs e)
        {
            trmCloseTaskmgr.Start();
            h.InstallHook();
        }

        private void LockScreen_LocationChanged(object sender, EventArgs e)
        {
            this.trmCloseTaskmgr.Stop();
            h.UnInstallHook();
        }

        private void TxtPwd_Click(object sender, EventArgs e)
        {
            lblPwd.Visible = false;
        }

        private void TxtPwd_TextChanged(object sender, EventArgs e)
        {
            lblPwd.Visible = false;
        }
    }
}
