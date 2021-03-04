
namespace HotelAdmin
{
    partial class ClientTopUp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_Commodity = new System.Windows.Forms.DataGridView();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PhoneTime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lab_Recharge = new System.Windows.Forms.Label();
            this.lab_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recharge = new System.Windows.Forms.Button();
            this.lab_gift = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.cbox_Member = new System.Windows.Forms.ComboBox();
            this.lab_balance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.inquire = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_Client = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_topUpRecord = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.UserRechargeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechargeBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechargeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommodityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Commodity)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_topUpRecord)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(815, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 773);
            this.panel1.TabIndex = 61;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_Commodity);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(12, 478);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 279);
            this.groupBox4.TabIndex = 77;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "商品列表";
            // 
            // dgv_Commodity
            // 
            this.dgv_Commodity.AllowUserToAddRows = false;
            this.dgv_Commodity.AllowUserToDeleteRows = false;
            this.dgv_Commodity.AllowUserToResizeColumns = false;
            this.dgv_Commodity.AllowUserToResizeRows = false;
            this.dgv_Commodity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Commodity.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Commodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Commodity.ColumnHeadersVisible = false;
            this.dgv_Commodity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodsName});
            this.dgv_Commodity.Location = new System.Drawing.Point(10, 25);
            this.dgv_Commodity.MultiSelect = false;
            this.dgv_Commodity.Name = "dgv_Commodity";
            this.dgv_Commodity.ReadOnly = true;
            this.dgv_Commodity.RowHeadersVisible = false;
            this.dgv_Commodity.RowTemplate.Height = 23;
            this.dgv_Commodity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Commodity.Size = new System.Drawing.Size(260, 221);
            this.dgv_Commodity.TabIndex = 0;
            this.dgv_Commodity.Click += new System.EventHandler(this.Dgv_Commodity_Click);
            // 
            // GoodsName
            // 
            this.GoodsName.DataPropertyName = "CommodityName";
            this.GoodsName.HeaderText = "商品名称";
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PhoneTime);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(12, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 100);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "充值时间";
            // 
            // PhoneTime
            // 
            this.PhoneTime.Location = new System.Drawing.Point(10, 34);
            this.PhoneTime.Name = "PhoneTime";
            this.PhoneTime.Size = new System.Drawing.Size(260, 26);
            this.PhoneTime.TabIndex = 72;
            this.PhoneTime.ValueChanged += new System.EventHandler(this.PhoneTime_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(13, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 17);
            this.label11.TabIndex = 73;
            this.label11.Text = "根据充值时间查询充值记录";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lab_Recharge);
            this.groupBox2.Controls.Add(this.lab_1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.recharge);
            this.groupBox2.Controls.Add(this.lab_gift);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Balance);
            this.groupBox2.Controls.Add(this.cbox_Member);
            this.groupBox2.Controls.Add(this.lab_balance);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 259);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "顾客充值";
            // 
            // lab_Recharge
            // 
            this.lab_Recharge.AutoSize = true;
            this.lab_Recharge.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Recharge.Location = new System.Drawing.Point(97, 105);
            this.lab_Recharge.Name = "lab_Recharge";
            this.lab_Recharge.Size = new System.Drawing.Size(23, 20);
            this.lab_Recharge.TabIndex = 77;
            this.lab_Recharge.Text = "无";
            // 
            // lab_1
            // 
            this.lab_1.AutoSize = true;
            this.lab_1.Location = new System.Drawing.Point(12, 105);
            this.lab_1.Name = "lab_1";
            this.lab_1.Size = new System.Drawing.Size(79, 20);
            this.lab_1.TabIndex = 76;
            this.lab_1.Text = "充值金额：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "顾客余额：";
            // 
            // recharge
            // 
            this.recharge.Enabled = false;
            this.recharge.Location = new System.Drawing.Point(97, 214);
            this.recharge.Name = "recharge";
            this.recharge.Size = new System.Drawing.Size(75, 34);
            this.recharge.TabIndex = 75;
            this.recharge.Text = "充 值";
            this.recharge.UseVisualStyleBackColor = true;
            this.recharge.Click += new System.EventHandler(this.Recharge_Click);
            // 
            // lab_gift
            // 
            this.lab_gift.AutoSize = true;
            this.lab_gift.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gift.Location = new System.Drawing.Point(97, 69);
            this.lab_gift.Name = "lab_gift";
            this.lab_gift.Size = new System.Drawing.Size(23, 20);
            this.lab_gift.TabIndex = 74;
            this.lab_gift.Text = "无";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "余额充值：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(12, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 73;
            this.label8.Text = "赠送礼品：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "会员等级：";
            // 
            // txt_Balance
            // 
            this.txt_Balance.Location = new System.Drawing.Point(97, 138);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.ReadOnly = true;
            this.txt_Balance.Size = new System.Drawing.Size(143, 26);
            this.txt_Balance.TabIndex = 65;
            this.txt_Balance.TextChanged += new System.EventHandler(this.Txt_Balance_TextChanged);
            this.txt_Balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Balance_KeyPress);
            // 
            // cbox_Member
            // 
            this.cbox_Member.Enabled = false;
            this.cbox_Member.FormattingEnabled = true;
            this.cbox_Member.Location = new System.Drawing.Point(97, 173);
            this.cbox_Member.Name = "cbox_Member";
            this.cbox_Member.Size = new System.Drawing.Size(143, 28);
            this.cbox_Member.TabIndex = 66;
            this.cbox_Member.TextChanged += new System.EventHandler(this.Txt_Balance_TextChanged);
            // 
            // lab_balance
            // 
            this.lab_balance.AutoSize = true;
            this.lab_balance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_balance.Location = new System.Drawing.Point(97, 32);
            this.lab_balance.Name = "lab_balance";
            this.lab_balance.Size = new System.Drawing.Size(23, 20);
            this.lab_balance.TabIndex = 67;
            this.lab_balance.Text = "无";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Txt_Name);
            this.groupBox1.Controls.Add(this.inquire);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 90);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "名称查询";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(13, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 74;
            this.label10.Text = "根据名称查询顾客";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(10, 30);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(179, 26);
            this.Txt_Name.TabIndex = 61;
            this.Txt_Name.TextChanged += new System.EventHandler(this.Txt_NameInquire_TextChanged);
            // 
            // inquire
            // 
            this.inquire.Location = new System.Drawing.Point(195, 29);
            this.inquire.Name = "inquire";
            this.inquire.Size = new System.Drawing.Size(75, 27);
            this.inquire.TabIndex = 69;
            this.inquire.Text = "查 询";
            this.inquire.UseVisualStyleBackColor = true;
            this.inquire.Click += new System.EventHandler(this.Txt_NameInquire_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dgv_Client);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 371);
            this.panel2.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(16, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 66;
            this.label7.Text = "顾客信息";
            // 
            // dgv_Client
            // 
            this.dgv_Client.AllowUserToAddRows = false;
            this.dgv_Client.AllowUserToDeleteRows = false;
            this.dgv_Client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Client.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Client.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.IDCard,
            this.Balance,
            this.Discount,
            this.MembershipLevel});
            this.dgv_Client.Location = new System.Drawing.Point(20, 37);
            this.dgv_Client.MultiSelect = false;
            this.dgv_Client.Name = "dgv_Client";
            this.dgv_Client.ReadOnly = true;
            this.dgv_Client.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Client.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Client.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Client.RowTemplate.Height = 23;
            this.dgv_Client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Client.Size = new System.Drawing.Size(747, 301);
            this.dgv_Client.TabIndex = 65;
            this.dgv_Client.Click += new System.EventHandler(this.Dgv_Client_Click);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "顾客姓名";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // IDCard
            // 
            this.IDCard.DataPropertyName = "IDCard";
            this.IDCard.HeaderText = "身份证";
            this.IDCard.Name = "IDCard";
            this.IDCard.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "余额";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "折扣";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // MembershipLevel
            // 
            this.MembershipLevel.DataPropertyName = "MembershipLevel";
            this.MembershipLevel.HeaderText = "会员等级";
            this.MembershipLevel.Name = "MembershipLevel";
            this.MembershipLevel.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dgv_topUpRecord);
            this.panel3.Location = new System.Drawing.Point(12, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 384);
            this.panel3.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(16, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 71;
            this.label9.Text = "充值记录";
            // 
            // dgv_topUpRecord
            // 
            this.dgv_topUpRecord.AllowUserToAddRows = false;
            this.dgv_topUpRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_topUpRecord.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_topUpRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_topUpRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_topUpRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserRechargeID,
            this.RechargeBalance,
            this.identity,
            this.RechargeTime,
            this.CommodityName});
            this.dgv_topUpRecord.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_topUpRecord.Location = new System.Drawing.Point(20, 34);
            this.dgv_topUpRecord.MultiSelect = false;
            this.dgv_topUpRecord.Name = "dgv_topUpRecord";
            this.dgv_topUpRecord.ReadOnly = true;
            this.dgv_topUpRecord.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_topUpRecord.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_topUpRecord.RowTemplate.Height = 23;
            this.dgv_topUpRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_topUpRecord.Size = new System.Drawing.Size(747, 301);
            this.dgv_topUpRecord.TabIndex = 70;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 22);
            this.Delete.Text = "删除";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UserRechargeID
            // 
            this.UserRechargeID.DataPropertyName = "编号";
            this.UserRechargeID.Frozen = true;
            this.UserRechargeID.HeaderText = "编号";
            this.UserRechargeID.Name = "UserRechargeID";
            this.UserRechargeID.ReadOnly = true;
            this.UserRechargeID.Visible = false;
            // 
            // RechargeBalance
            // 
            this.RechargeBalance.DataPropertyName = "充值金额";
            this.RechargeBalance.HeaderText = "充值金额";
            this.RechargeBalance.Name = "RechargeBalance";
            this.RechargeBalance.ReadOnly = true;
            // 
            // identity
            // 
            this.identity.DataPropertyName = "身份证";
            this.identity.HeaderText = "身份证";
            this.identity.Name = "identity";
            this.identity.ReadOnly = true;
            // 
            // RechargeTime
            // 
            this.RechargeTime.DataPropertyName = "充值时间";
            this.RechargeTime.HeaderText = "充值时间";
            this.RechargeTime.Name = "RechargeTime";
            this.RechargeTime.ReadOnly = true;
            // 
            // CommodityName
            // 
            this.CommodityName.DataPropertyName = "赠送商品";
            this.CommodityName.HeaderText = "赠送商品";
            this.CommodityName.Name = "CommodityName";
            this.CommodityName.ReadOnly = true;
            // 
            // ClientTopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1134, 798);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientTopUp";
            this.Text = "顾客充值";
            this.Load += new System.EventHandler(this.ClientTopUp_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Commodity)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_topUpRecord)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Button inquire;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipLevel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker PhoneTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_topUpRecord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button recharge;
        private System.Windows.Forms.Label lab_gift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Balance;
        private System.Windows.Forms.ComboBox cbox_Member;
        private System.Windows.Forms.Label lab_balance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_Commodity;
        private System.Windows.Forms.Label lab_1;
        private System.Windows.Forms.Label lab_Recharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRechargeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RechargeBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RechargeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommodityName;
    }
}