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
    public partial class GoodsRedact : Form
    {
        /// <summary>
        /// 商品管理窗口
        /// </summary>
        public MerchandiseManage Manage = null;
        /// <summary>
        /// 进行编辑的商品信息
        /// </summary>
        public CommodityTable commodity = null;

        public GoodsRedact()
        {
            InitializeComponent();
        }
        // 加载初始化信息
        private void GoodsRedact_Load(object sender, EventArgs e)
        {
            foreach (CommodityTypeTable arr in Manage.typeList)             // 遍历商品类型列表
            {
                Type.Items.Add(arr.TypeName);
            }
            // 遍历商品信息列表获取商品的所有单位
            foreach (DataRow row in Manage.manager.GetCommodityRecord(-1).AsEnumerable().CopyToDataTable().Rows)
            {
                if (!unit.Items.Contains(row["CommodityUnit"].ToString()))  // 判断商品单位是否重复
                {
                    unit.Items.Add(row["CommodityUnit"].ToString().Trim());
                }
            }
            if (commodity != null)                                          // 是否显示为修改效果
            {
                txt_name.Text = commodity.CommodityName;
                unit.Text = commodity.CommodityUnit;
                txt_conut.Text = commodity.Quantity.ToString();
                importPrice.Text = commodity.PurchasePice.ToString();
                Retail.Text = commodity.Retail.ToString();
                Type.Text = commodity.Type.TypeName;
                Pic_Goods.Image = Image.FromFile(commodity.Path);
            }
        }
        // 进行修改或添加操作
        private void Btn_Preserve_Click(object sender, EventArgs e)
        {
            try
            {
                if (commodity == null)                                   // 判断进行添加还是修改
                    AddNewCommodity();
                else
                    AlterCommodity();

                Manage.Cbox_GoodsType_SelectedIndexChanged(sender, e);   // 操作后刷新商品显示界面
                this.Close();
            }
            catch {
                MessageBox.Show("信息填写错误！", "提示");
            }
        }
        // 进行修改商品
        private void AlterCommodity()
        {
            Manage.manager.AlterCommodity(new CommodityTable            // 进行修改操作
            {
                Number = this.commodity.Number,
                CommodityName = txt_name.Text,
                CommodityUnit = unit.Text,
                PurchasePice = double.Parse(importPrice.Text),
                Quantity = int.Parse(txt_conut.Text),
                Retail = double.Parse(Retail.Text),
                Type = GetCommodityType(Type.Text),
                Path = fileName.Text
            });
        }
        // 进行添加商品
        private void AddNewCommodity()
        {
            Manage.manager.AddNewCommodity(new CommodityTable           // 进行添加操作
            {
                CommodityName = txt_name.Text,
                CommodityUnit = unit.Text,
                PurchasePice = double.Parse(importPrice.Text),
                Quantity = int.Parse(txt_conut.Text),
                Retail = double.Parse(Retail.Text),
                Type = GetCommodityType(Type.Text),
                Path = fileName.Text
            });
        }
        // 根据类型名称返回商品类型信息
        private CommodityTypeTable GetCommodityType(string name)
        {
            foreach (CommodityTypeTable arr in Manage.typeList)             // 遍历商品类型列表
            {
                if (name.Equals(arr.TypeName)) { return arr; }              // 查找指定类型名称的商品
            }
            return null;                                                    // 未找到返回空
        }
        // 商品数量文本框输入控制
        private void Txt_conut_KeyPress(object sender, KeyPressEventArgs e)
        {
            int num = e.KeyChar;

            e.Handled = ((num < '0' || num > '9') && num != 8 && num != 46);
        }
        // 商品零售文本框输入控制
        private void ImportPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            int num = e.KeyChar;

            e.Handled = ((num < '0' || num > '9' || num == '.') && num != 8 && num != 46);
        }
        // 商品进价文本框输入控制
        private void Retail_KeyPress(object sender, KeyPressEventArgs e)
        {
            int num = e.KeyChar;

            e.Handled = ((num < '0' || num > '9' || num == '.') && num != 8 && num != 46);
        }
        // 获取商品图片路径
        private void Btn_SelectionPath_Click(object sender, EventArgs e)
        {
            this.Folder_ImgPath.ShowDialog();                               // 选择路径
            this.fileName.Text = Folder_ImgPath.SelectedPath;               // 获取路径
        }
    }
}
