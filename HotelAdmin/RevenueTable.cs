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
    /// 酒店营收记录窗口
    /// </summary>
    public partial class RevenueTable : Form
    {
        UserRechargeTableManager urtm = new UserRechargeTableManager();
        ExpenditureTableManager etm = new ExpenditureTableManager();
        ConsumptionRecordManager crm = new ConsumptionRecordManager();
        StatementTableManager stm = new StatementTableManager();

        public RevenueTable()
        {
            InitializeComponent();
            dgvUR.AutoGenerateColumns = false;
            dgvZhiChu.AutoGenerateColumns = false;
            dgvShang.AutoGenerateColumns = false;
            dgvRoom.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 用户充值表刷新
        /// </summary>
        public void UserRechargeTable()
        {
            if (dtpKai.Value == dtpJie.Value)
            {
                dgvUR.DataSource = urtm.UserRechargeTable();
                dgvZhiChu.DataSource = etm.ExpenditureTable();
                dgvShang.DataSource = crm.ConsumptionRecord();
                dgvRoom.DataSource = stm.StatementTable();
            }
            else
            {
                dgvUR.DataSource = urtm.UserRechargeTable(dtpKai.Value.ToString(), dtpJie.Value.ToString());
                dgvZhiChu.DataSource = etm.ExpenditureTable(dtpKai.Value.ToString(), dtpJie.Value.ToString());
                dgvShang.DataSource = crm.ConsumptionRecord(dtpKai.Value.ToString(), dtpJie.Value.ToString());
                dgvRoom.DataSource = stm.StatementTable(dtpKai.Value.ToString(), dtpJie.Value.ToString());
            }
            txtZhiChu.Text = "0";
            txtChongZhi.Text = "0";
            txtShang.Text = "0";
            txtXZ.Text = "0";
            txtYuE.Text = "0";

            //计算充值营收总额
            for (int i = 0; i < dgvUR.Rows.Count; i++)
            {
                txtChongZhi.Text = (Convert.ToDouble(txtChongZhi.Text) + Convert.ToDouble(dgvUR.Rows[i].Cells[2].Value)).ToString();
            }

            //计算支出费用总额
            for (int i = 0; i < dgvZhiChu.Rows.Count; i++)
            {
                txtZhiChu.Text = (Convert.ToDouble(txtZhiChu.Text) + Convert.ToDouble(dgvZhiChu.Rows[i].Cells[1].Value)).ToString();
            }

            //计算商品营收总额
            for (int i = 0; i < dgvShang.Rows.Count; i++)
            {
                txtShang.Text = (Convert.ToDouble(txtShang.Text) + Convert.ToDouble(dgvShang.Rows[i].Cells[1].Value)).ToString();
            }

            //计算房间营收总额
            for (int i = 0; i < dgvRoom.Rows.Count; i++)
            {
                if (dgvRoom.Rows[i].Cells[2].Value.ToString() == "现金支付")
                {
                    txtXZ.Text = (Convert.ToDouble(txtXZ.Text) + Convert.ToDouble(dgvRoom.Rows[i].Cells[1].Value)).ToString();
                }
                else
                {
                    txtYuE.Text = (Convert.ToDouble(txtYuE.Text) + Convert.ToDouble(dgvRoom.Rows[i].Cells[1].Value)).ToString();
                }
            }

        }

        /// <summary>
        /// 窗体加载时运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RevenueTable_Load(object sender, EventArgs e)
        {
            UserRechargeTable();
        }

        /// <summary>
        /// 开始时间改变时运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtpKai_ValueChanged(object sender, EventArgs e)
        {
            UserRechargeTable();
        }

        /// <summary>
        /// 结束时间改变时运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtpJie_ValueChanged(object sender, EventArgs e)
        {
            UserRechargeTable();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ExpendInsert ei = new ExpendInsert();
            ei.rt = this;
            ei.Show();
        }
        ~RevenueTable()
        {
            this.urtm = null;
            this.etm = null;
            this.crm = null;
            this.stm = null;
        }
    }
}
