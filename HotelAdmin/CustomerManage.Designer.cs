
namespace HotelAdmin
{
    partial class CustomerManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pl_User = new System.Windows.Forms.Panel();
            this.Dgv_UserShow = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelephoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Option_Alter = new System.Windows.Forms.ToolStripMenuItem();
            this.Option_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_InquireBox = new System.Windows.Forms.TextBox();
            this.Btn_Inquire = new System.Windows.Forms.Button();
            this.Lab_Remind = new System.Windows.Forms.Label();
            this.Pl_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_UserShow)).BeginInit();
            this.UserMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pl_User
            // 
            this.Pl_User.BackColor = System.Drawing.Color.White;
            this.Pl_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pl_User.Controls.Add(this.Dgv_UserShow);
            this.Pl_User.Location = new System.Drawing.Point(12, 46);
            this.Pl_User.Name = "Pl_User";
            this.Pl_User.Size = new System.Drawing.Size(950, 366);
            this.Pl_User.TabIndex = 2;
            // 
            // Dgv_UserShow
            // 
            this.Dgv_UserShow.AllowUserToAddRows = false;
            this.Dgv_UserShow.AllowUserToDeleteRows = false;
            this.Dgv_UserShow.AllowUserToResizeColumns = false;
            this.Dgv_UserShow.AllowUserToResizeRows = false;
            this.Dgv_UserShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_UserShow.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_UserShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_UserShow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgv_UserShow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_UserShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_UserShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_UserShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.IDCard,
            this.TelephoneNumber,
            this.Gender,
            this.Age,
            this.Balance,
            this.Discount,
            this.MembershipLevel});
            this.Dgv_UserShow.ContextMenuStrip = this.UserMenu;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_UserShow.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_UserShow.GridColor = System.Drawing.Color.White;
            this.Dgv_UserShow.Location = new System.Drawing.Point(-1, -1);
            this.Dgv_UserShow.Name = "Dgv_UserShow";
            this.Dgv_UserShow.ReadOnly = true;
            this.Dgv_UserShow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_UserShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv_UserShow.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_UserShow.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Dgv_UserShow.RowTemplate.Height = 23;
            this.Dgv_UserShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_UserShow.Size = new System.Drawing.Size(950, 342);
            this.Dgv_UserShow.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户姓名";
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
            // TelephoneNumber
            // 
            this.TelephoneNumber.DataPropertyName = "TelephoneNumber";
            this.TelephoneNumber.HeaderText = "联系电话";
            this.TelephoneNumber.Name = "TelephoneNumber";
            this.TelephoneNumber.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "年龄";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "用户余额";
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
            // UserMenu
            // 
            this.UserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Option_Alter,
            this.Option_Delete});
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.Size = new System.Drawing.Size(101, 48);
            // 
            // Option_Alter
            // 
            this.Option_Alter.Name = "Option_Alter";
            this.Option_Alter.Size = new System.Drawing.Size(180, 22);
            this.Option_Alter.Text = "修改";
            this.Option_Alter.Click += new System.EventHandler(this.Option_Alter_Click);
            // 
            // Option_Delete
            // 
            this.Option_Delete.Name = "Option_Delete";
            this.Option_Delete.Size = new System.Drawing.Size(180, 22);
            this.Option_Delete.Text = "删除";
            this.Option_Delete.Click += new System.EventHandler(this.Option_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "客户查询：";
            // 
            // Txt_InquireBox
            // 
            this.Txt_InquireBox.Location = new System.Drawing.Point(97, 11);
            this.Txt_InquireBox.Name = "Txt_InquireBox";
            this.Txt_InquireBox.Size = new System.Drawing.Size(233, 21);
            this.Txt_InquireBox.TabIndex = 4;
            this.Txt_InquireBox.TextChanged += new System.EventHandler(this.Txt_InquireBox_TextChanged);
            // 
            // Btn_Inquire
            // 
            this.Btn_Inquire.Location = new System.Drawing.Point(887, 11);
            this.Btn_Inquire.Name = "Btn_Inquire";
            this.Btn_Inquire.Size = new System.Drawing.Size(75, 23);
            this.Btn_Inquire.TabIndex = 5;
            this.Btn_Inquire.Text = "查 询";
            this.Btn_Inquire.UseVisualStyleBackColor = true;
            this.Btn_Inquire.Click += new System.EventHandler(this.Btn_Inquire_Click);
            // 
            // Lab_Remind
            // 
            this.Lab_Remind.AutoSize = true;
            this.Lab_Remind.BackColor = System.Drawing.Color.White;
            this.Lab_Remind.Enabled = false;
            this.Lab_Remind.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Remind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Lab_Remind.Location = new System.Drawing.Point(106, 13);
            this.Lab_Remind.Name = "Lab_Remind";
            this.Lab_Remind.Size = new System.Drawing.Size(188, 17);
            this.Lab_Remind.TabIndex = 6;
            this.Lab_Remind.Text = "请输入顾客姓名（支持模糊查询）";
            // 
            // CustomerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 424);
            this.Controls.Add(this.Lab_Remind);
            this.Controls.Add(this.Btn_Inquire);
            this.Controls.Add(this.Txt_InquireBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pl_User);
            this.Name = "CustomerManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顾客管理";
            this.Load += new System.EventHandler(this.CustomerManage_Load);
            this.Pl_User.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_UserShow)).EndInit();
            this.UserMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Pl_User;
        private System.Windows.Forms.DataGridView Dgv_UserShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_InquireBox;
        private System.Windows.Forms.Button Btn_Inquire;
        private System.Windows.Forms.Label Lab_Remind;
        private System.Windows.Forms.ContextMenuStrip UserMenu;
        private System.Windows.Forms.ToolStripMenuItem Option_Alter;
        private System.Windows.Forms.ToolStripMenuItem Option_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelephoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipLevel;
    }
}