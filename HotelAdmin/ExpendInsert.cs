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
    public partial class ExpendInsert : Form
    {
        public RevenueTable rt = null;
        ExpenditureTableManager etm = new ExpenditureTableManager();
        public ExpendInsert()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 判断
        /// </summary>
        /// <returns></returns>
        public bool PanDuan()
        {
            if (txtJinE.Text.Trim() == "")
            {
                MessageBox.Show("请输入消费金额");
                txtJinE.Focus();
                return false;
            }
            else if (txtYuan.Text.Trim() == "")
            {
                MessageBox.Show("请输入支出原因");
                txtYuan.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            if (PanDuan())
            {
                ExpenditureTable et = new ExpenditureTable()
                {
                    ExpenditureAmount = Double.Parse(txtJinE.Text),
                    ExpenditureReasons = txtYuan.Text
                };
                if (etm.ExpenditureInsert(et) > 0)
                {
                    MessageBox.Show("操作成功");
                    rt.UserRechargeTable();
                    this.Close();
                }
            }
        }

        private void TxtJinE_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = e.KeyChar;
            if ((key < '0' || key > '9') && (key != 8 && key != 46))
                e.Handled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
