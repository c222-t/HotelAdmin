using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelModel;
using HotelBLL;

namespace HotelAdmin
{
    /// <summary>
    /// 商品管理窗口
    /// </summary>
    public partial class MerchandiseManage : Form
    {
        /// <summary>
        /// 商品类型列表
        /// </summary>
        public List<CommodityTypeTable> typeList = new List<CommodityTypeTable>();
        /// <summary>
        /// 商品业务处理对象
        /// </summary>
        public CommodityManager manager = new CommodityManager();
        /// <summary>
        /// 商品编辑窗口
        /// </summary>
        GoodsRedact goodsRedact = null;

        public MerchandiseManage()
        {
            InitializeComponent();
        }
        // 加载商品类型列表
        private void MerchandiseManage_Load(object sender, EventArgs e)
        {
            // 遍历商品类型信息
            foreach (DataRow row in manager.GetAllCommodityType().Rows)
            {
                typeList.Add(new CommodityTypeTable                     // 添加到数据商品类型列表
                {
                    TypeName = row["TypeName"].ToString().Trim(),
                    TypeNumber = (int)row["TypeNumber"]
                });
                // 添加到控件商品类型列表
                Cbox_GoodsType.Items.Add(row["TypeName"].ToString().Trim());
            }
            Cbox_GoodsType.Text = Cbox_GoodsType.Items[0].ToString();   // 显示默认选项
        }
        // 根据商品类型名称查询商品
        public void Cbox_GoodsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // 遍历商品类型列表和指定类型的商品信息
                var table = from row in manager.GetCommodityRecord(GetGoodsTypeID()).AsEnumerable()
                            join arr in typeList on row["TypeNumber"] equals arr.TypeNumber
                            select new {
                                Number = row["Number"],
                                CommodityName = row["CommodityName"],
                                CommodityUnit = row["CommodityUnit"],
                                PurchasePice = row["PurchasePice"],
                                Quantity = row["Quantity"],
                                Retail = row["Retail"],
                                arr.TypeName
                            };

                Dgv_GoodsList.DataSource = table.ToArray();             // 获取得到的信息
            }
            catch {
                Dgv_GoodsList.DataSource = null;                        // 未找到清除之前的信息
            }
        }
        // 修改指定的商品
        private void GoodsAlter_Click(object sender, EventArgs e)
        {
            goodsRedact = new GoodsRedact()                             // 激活商品编辑窗口
            {
                commodity = new CommodityTable                          // 获取选中的商品对象
                {
                    Number = (int)Dgv_GoodsList.SelectedCells[0].Value,
                    CommodityName = Dgv_GoodsList.SelectedCells[1].Value.ToString().Trim(),
                    CommodityUnit = Dgv_GoodsList.SelectedCells[2].Value.ToString(),
                    Quantity = int.Parse(Dgv_GoodsList.SelectedCells[3].Value.ToString()),
                    PurchasePice = double.Parse(Dgv_GoodsList.SelectedCells[4].Value.ToString()),
                    Retail = double.Parse(Dgv_GoodsList.SelectedCells[5].Value.ToString()),
                    Type = new CommodityTypeTable { TypeName = Dgv_GoodsList.SelectedCells[6].Value.ToString() },
                    Path = Dgv_GoodsList.SelectedCells[7].Value.ToString()
                },
                Manage = this,
            };
            goodsRedact.Show();
        }
        // 删除指定的商品
        private void GoodsDelete_Click(object sender, EventArgs e)
        {
            // 根据编号删除指定商品
            manager.DeleteCommodity((int)Dgv_GoodsList.SelectedCells[0].Value);
            // 删除后重新刷新
            Cbox_GoodsType_SelectedIndexChanged(sender, e);
        }
        // 添加新商品
        private void AddGoods_Click(object sender, EventArgs e)
        {
            goodsRedact = new GoodsRedact() { Manage = this };          // 激活商品编辑窗口并打开
            goodsRedact.Show();
        }
        // 退出窗口
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // 获取相应的商品类型编号
        private int GetGoodsTypeID()
        {
            foreach (CommodityTypeTable arr in typeList)                // 遍历商品类型列表
            {
                if (Cbox_GoodsType.Text.Equals(arr.TypeName)) {         // 查找指定名称的商品类型
                    return arr.TypeNumber;
                }
            }
            return -1;                                                  // 未找到返回-1
        }
        ~MerchandiseManage()
        {
            this.typeList = null;
            this.manager = null;
            this.goodsRedact = null;
        }
    }
}
