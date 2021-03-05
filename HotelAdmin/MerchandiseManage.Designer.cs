
namespace HotelAdmin
{
    partial class MerchandiseManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Dgv_GoodsList = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommodityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommodityUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu_goodsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GoodsAlter = new System.Windows.Forms.ToolStripMenuItem();
            this.GoodsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbox_GoodsType = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_GoodsList)).BeginInit();
            this.Menu_goodsList.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_GoodsList
            // 
            this.Dgv_GoodsList.AllowUserToAddRows = false;
            this.Dgv_GoodsList.AllowUserToDeleteRows = false;
            this.Dgv_GoodsList.AllowUserToResizeColumns = false;
            this.Dgv_GoodsList.AllowUserToResizeRows = false;
            this.Dgv_GoodsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_GoodsList.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_GoodsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_GoodsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.CommodityName,
            this.CommodityUnit,
            this.Quantity,
            this.PurchasePice,
            this.retail,
            this.TypeName,
            this.Path});
            this.Dgv_GoodsList.ContextMenuStrip = this.Menu_goodsList;
            this.Dgv_GoodsList.Location = new System.Drawing.Point(116, 71);
            this.Dgv_GoodsList.MultiSelect = false;
            this.Dgv_GoodsList.Name = "Dgv_GoodsList";
            this.Dgv_GoodsList.ReadOnly = true;
            this.Dgv_GoodsList.RowTemplate.Height = 23;
            this.Dgv_GoodsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_GoodsList.Size = new System.Drawing.Size(942, 414);
            this.Dgv_GoodsList.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.Frozen = true;
            this.Number.HeaderText = "编号";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Visible = false;
            // 
            // CommodityName
            // 
            this.CommodityName.DataPropertyName = "CommodityName";
            this.CommodityName.HeaderText = "名称";
            this.CommodityName.Name = "CommodityName";
            this.CommodityName.ReadOnly = true;
            // 
            // CommodityUnit
            // 
            this.CommodityUnit.DataPropertyName = "CommodityUnit";
            this.CommodityUnit.HeaderText = "单位";
            this.CommodityUnit.Name = "CommodityUnit";
            this.CommodityUnit.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "数量";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // PurchasePice
            // 
            this.PurchasePice.DataPropertyName = "PurchasePice";
            this.PurchasePice.HeaderText = "进价";
            this.PurchasePice.Name = "PurchasePice";
            this.PurchasePice.ReadOnly = true;
            // 
            // retail
            // 
            this.retail.DataPropertyName = "retail";
            this.retail.HeaderText = "零售";
            this.retail.Name = "retail";
            this.retail.ReadOnly = true;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "类型";
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            // 
            // Path
            // 
            this.Path.HeaderText = "图片路径";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Visible = false;
            // 
            // Menu_goodsList
            // 
            this.Menu_goodsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GoodsAlter,
            this.GoodsDelete});
            this.Menu_goodsList.Name = "Menu_goodsList";
            this.Menu_goodsList.Size = new System.Drawing.Size(101, 48);
            // 
            // GoodsAlter
            // 
            this.GoodsAlter.Name = "GoodsAlter";
            this.GoodsAlter.Size = new System.Drawing.Size(100, 22);
            this.GoodsAlter.Text = "修改";
            this.GoodsAlter.Click += new System.EventHandler(this.GoodsAlter_Click);
            // 
            // GoodsDelete
            // 
            this.GoodsDelete.Name = "GoodsDelete";
            this.GoodsDelete.Size = new System.Drawing.Size(100, 22);
            this.GoodsDelete.Text = "删除";
            this.GoodsDelete.Click += new System.EventHandler(this.GoodsDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(112, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "商品列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(798, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "商品类型：";
            // 
            // Cbox_GoodsType
            // 
            this.Cbox_GoodsType.BackColor = System.Drawing.Color.White;
            this.Cbox_GoodsType.FormattingEnabled = true;
            this.Cbox_GoodsType.Items.AddRange(new object[] {
            "全部"});
            this.Cbox_GoodsType.Location = new System.Drawing.Point(894, 37);
            this.Cbox_GoodsType.Name = "Cbox_GoodsType";
            this.Cbox_GoodsType.Size = new System.Drawing.Size(164, 20);
            this.Cbox_GoodsType.TabIndex = 4;
            this.Cbox_GoodsType.SelectedIndexChanged += new System.EventHandler(this.Cbox_GoodsType_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddGoods,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddGoods
            // 
            this.AddGoods.Name = "AddGoods";
            this.AddGoods.Size = new System.Drawing.Size(68, 21);
            this.AddGoods.Text = "添加商品";
            this.AddGoods.Click += new System.EventHandler(this.AddGoods_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(44, 21);
            this.Exit.Text = "返回";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MerchandiseManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1168, 708);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Cbox_GoodsType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_GoodsList);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MerchandiseManage";
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.MerchandiseManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_GoodsList)).EndInit();
            this.Menu_goodsList.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_GoodsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbox_GoodsType;
        private System.Windows.Forms.ContextMenuStrip Menu_goodsList;
        private System.Windows.Forms.ToolStripMenuItem GoodsAlter;
        private System.Windows.Forms.ToolStripMenuItem GoodsDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddGoods;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommodityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommodityUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePice;
        private System.Windows.Forms.DataGridViewTextBoxColumn retail;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
    }
}