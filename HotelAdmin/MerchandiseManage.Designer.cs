
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.Dgv_GoodsList.ContextMenuStrip = this.Menu_goodsList;
            this.Dgv_GoodsList.Location = new System.Drawing.Point(116, 71);
            this.Dgv_GoodsList.MultiSelect = false;
            this.Dgv_GoodsList.Name = "Dgv_GoodsList";
            this.Dgv_GoodsList.ReadOnly = true;
            this.Dgv_GoodsList.RowHeadersVisible = false;
            this.Dgv_GoodsList.RowTemplate.Height = 23;
            this.Dgv_GoodsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_GoodsList.Size = new System.Drawing.Size(942, 567);
            this.Dgv_GoodsList.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Number";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CommodityName";
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CommodityUnit";
            this.Column3.HeaderText = "单位";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Quantity";
            this.Column4.HeaderText = "数量";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PurchasePice";
            this.Column5.HeaderText = "进价";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "retail";
            this.Column6.HeaderText = "零售";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TypeNumber";
            this.Column7.HeaderText = "类型";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Path";
            this.Column8.HeaderText = "图片路径";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
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
            this.BackColor = System.Drawing.Color.WhiteSmoke;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}