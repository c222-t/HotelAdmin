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
    public partial class Form1 : Form
    {
        AdministratorManager atm = new AdministratorManager();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录时判断是否输入
        /// </summary>
        /// <returns></returns>
        public bool PanDuan()
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名");
                txtName.Focus();
                return false;
            }
            else if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码");
                txtPwd.Focus();
                return false;
            }
            return true;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (PanDuan())
            {
                if (atm.Administr(txtPwd.Text.Trim(), txtName.Text.Trim()) > 0)
                {
                    MessageBox.Show("登录成功");
                    Cun.Pwd = txtPwd.Text.Trim();
                    MainInterface frm = new MainInterface();
                    frm.Show();
                    this.Hide();//隐藏登录界面
                }
                else
                {
                    MessageBox.Show("登录失败，用户名或密码错误");
                }
            }


        }
    }
}
