
namespace HotelAdmin
{
    partial class CustomerOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbox_payWay = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbox_roomClass = new System.Windows.Forms.ComboBox();
            this.dtpicker_leave = new System.Windows.Forms.DateTimePicker();
            this.dtpicker_begin = new System.Windows.Forms.DateTimePicker();
            this.Discount = new System.Windows.Forms.Label();
            this.cbox_members = new System.Windows.Forms.ComboBox();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.txt_bmikece = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_IDcard = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.Btn_Billing = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dgv_RoomList = new System.Windows.Forms.DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_age);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cbox_payWay);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbox_roomClass);
            this.panel1.Controls.Add(this.dtpicker_leave);
            this.panel1.Controls.Add(this.dtpicker_begin);
            this.panel1.Controls.Add(this.Discount);
            this.panel1.Controls.Add(this.cbox_members);
            this.panel1.Controls.Add(this.rbtn_female);
            this.panel1.Controls.Add(this.rbtn_male);
            this.panel1.Controls.Add(this.txt_bmikece);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.txt_IDcard);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.Btn_Billing);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(667, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 583);
            this.panel1.TabIndex = 2;
            // 
            // txt_age
            // 
            this.txt_age.BackColor = System.Drawing.Color.Beige;
            this.txt_age.Location = new System.Drawing.Point(197, 333);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(55, 21);
            this.txt_age.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(140, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "年龄：";
            // 
            // cbox_payWay
            // 
            this.cbox_payWay.AutoCompleteCustomSource.AddRange(new string[] {
            "现金支付",
            "余额支付"});
            this.cbox_payWay.BackColor = System.Drawing.Color.Beige;
            this.cbox_payWay.FormattingEnabled = true;
            this.cbox_payWay.Items.AddRange(new object[] {
            "现金支付",
            "余额支付"});
            this.cbox_payWay.Location = new System.Drawing.Point(92, 457);
            this.cbox_payWay.Name = "cbox_payWay";
            this.cbox_payWay.Size = new System.Drawing.Size(160, 20);
            this.cbox_payWay.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(7, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "客房类型：";
            // 
            // cbox_roomClass
            // 
            this.cbox_roomClass.BackColor = System.Drawing.Color.Beige;
            this.cbox_roomClass.FormattingEnabled = true;
            this.cbox_roomClass.Items.AddRange(new object[] {
            "全部"});
            this.cbox_roomClass.Location = new System.Drawing.Point(92, 210);
            this.cbox_roomClass.Name = "cbox_roomClass";
            this.cbox_roomClass.Size = new System.Drawing.Size(160, 20);
            this.cbox_roomClass.TabIndex = 21;
            this.cbox_roomClass.SelectedIndexChanged += new System.EventHandler(this.Cbox_roomClass_SelectedIndexChanged);
            // 
            // dtpicker_leave
            // 
            this.dtpicker_leave.Location = new System.Drawing.Point(92, 416);
            this.dtpicker_leave.Name = "dtpicker_leave";
            this.dtpicker_leave.Size = new System.Drawing.Size(160, 21);
            this.dtpicker_leave.TabIndex = 25;
            // 
            // dtpicker_begin
            // 
            this.dtpicker_begin.Enabled = false;
            this.dtpicker_begin.Location = new System.Drawing.Point(92, 375);
            this.dtpicker_begin.Name = "dtpicker_begin";
            this.dtpicker_begin.Size = new System.Drawing.Size(160, 21);
            this.dtpicker_begin.TabIndex = 24;
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Discount.Location = new System.Drawing.Point(88, 334);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(17, 20);
            this.Discount.TabIndex = 23;
            this.Discount.Text = "0";
            // 
            // cbox_members
            // 
            this.cbox_members.BackColor = System.Drawing.Color.Beige;
            this.cbox_members.FormattingEnabled = true;
            this.cbox_members.Location = new System.Drawing.Point(92, 293);
            this.cbox_members.Name = "cbox_members";
            this.cbox_members.Size = new System.Drawing.Size(160, 20);
            this.cbox_members.TabIndex = 22;
            this.cbox_members.SelectedIndexChanged += new System.EventHandler(this.Cbox_members_SelectedIndexChanged);
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(142, 92);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(35, 16);
            this.rbtn_female.TabIndex = 18;
            this.rbtn_female.Text = "女";
            this.rbtn_female.UseVisualStyleBackColor = true;
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Checked = true;
            this.rbtn_male.Location = new System.Drawing.Point(92, 92);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(35, 16);
            this.rbtn_male.TabIndex = 17;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "男";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // txt_bmikece
            // 
            this.txt_bmikece.BackColor = System.Drawing.Color.Beige;
            this.txt_bmikece.Location = new System.Drawing.Point(92, 251);
            this.txt_bmikece.Name = "txt_bmikece";
            this.txt_bmikece.Size = new System.Drawing.Size(160, 21);
            this.txt_bmikece.TabIndex = 16;
            this.txt_bmikece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_bmikece_KeyPress);
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.Beige;
            this.txt_phone.Location = new System.Drawing.Point(92, 169);
            this.txt_phone.MaxLength = 11;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(160, 21);
            this.txt_phone.TabIndex = 15;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_phone_KeyPress);
            // 
            // txt_IDcard
            // 
            this.txt_IDcard.BackColor = System.Drawing.Color.Beige;
            this.txt_IDcard.Location = new System.Drawing.Point(92, 129);
            this.txt_IDcard.MaxLength = 18;
            this.txt_IDcard.Name = "txt_IDcard";
            this.txt_IDcard.Size = new System.Drawing.Size(160, 21);
            this.txt_IDcard.TabIndex = 14;
            this.txt_IDcard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_IDcard_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Beige;
            this.txt_name.Location = new System.Drawing.Point(92, 46);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(160, 21);
            this.txt_name.TabIndex = 13;
            // 
            // Btn_Billing
            // 
            this.Btn_Billing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.Btn_Billing.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.Btn_Billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Billing.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Billing.Location = new System.Drawing.Point(92, 506);
            this.Btn_Billing.Name = "Btn_Billing";
            this.Btn_Billing.Size = new System.Drawing.Size(99, 32);
            this.Btn_Billing.TabIndex = 12;
            this.Btn_Billing.Text = "开 单";
            this.Btn_Billing.UseVisualStyleBackColor = false;
            this.Btn_Billing.Click += new System.EventHandler(this.Btn_Billing_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(7, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "支付方式：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(7, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "预离时间：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(7, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "开单时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(35, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "折扣：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(7, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "会员等级：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(35, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "余额：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(7, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "联系电话：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(21, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "身份证：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "顾客性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "顾客名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(109, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单选项";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Dgv_RoomList);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 583);
            this.panel2.TabIndex = 3;
            // 
            // Dgv_RoomList
            // 
            this.Dgv_RoomList.AllowUserToAddRows = false;
            this.Dgv_RoomList.AllowUserToDeleteRows = false;
            this.Dgv_RoomList.AllowUserToResizeColumns = false;
            this.Dgv_RoomList.AllowUserToResizeRows = false;
            this.Dgv_RoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_RoomList.BackgroundColor = System.Drawing.Color.Beige;
            this.Dgv_RoomList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_RoomList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_RoomList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_RoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.Price,
            this.typeName,
            this.Floor});
            this.Dgv_RoomList.GridColor = System.Drawing.Color.White;
            this.Dgv_RoomList.Location = new System.Drawing.Point(16, 40);
            this.Dgv_RoomList.MultiSelect = false;
            this.Dgv_RoomList.Name = "Dgv_RoomList";
            this.Dgv_RoomList.ReadOnly = true;
            this.Dgv_RoomList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_RoomList.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_RoomList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_RoomList.RowTemplate.Height = 23;
            this.Dgv_RoomList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_RoomList.Size = new System.Drawing.Size(602, 498);
            this.Dgv_RoomList.TabIndex = 2;
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomNumber";
            this.RoomNumber.HeaderText = "房间编号";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "价格";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // typeName
            // 
            this.typeName.DataPropertyName = "Name";
            this.typeName.HeaderText = "房间类型";
            this.typeName.Name = "typeName";
            this.typeName.ReadOnly = true;
            // 
            // Floor
            // 
            this.Floor.DataPropertyName = "Floor";
            this.Floor.HeaderText = "所属楼层";
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(12, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "房间列表";
            // 
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(964, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerOrder";
            this.Text = "顾客开单";
            this.Load += new System.EventHandler(this.CustomerOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RoomList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_Billing;
        private System.Windows.Forms.DateTimePicker dtpicker_leave;
        private System.Windows.Forms.DateTimePicker dtpicker_begin;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.ComboBox cbox_members;
        private System.Windows.Forms.ComboBox cbox_roomClass;
        private System.Windows.Forms.RadioButton rbtn_female;
        private System.Windows.Forms.RadioButton rbtn_male;
        private System.Windows.Forms.TextBox txt_bmikece;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_IDcard;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cbox_payWay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView Dgv_RoomList;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label13;
    }
}