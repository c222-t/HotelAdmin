
namespace HotelAdmin
{
    partial class CustomerAlter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_Discount = new System.Windows.Forms.Label();
            this.cbox_Member = new System.Windows.Forms.ComboBox();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.txt_IDCard = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Alter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lab_Discount);
            this.groupBox1.Controls.Add(this.cbox_Member);
            this.groupBox1.Controls.Add(this.txt_Balance);
            this.groupBox1.Controls.Add(this.txt_IDCard);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Alter);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 272);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改顾客信息";
            // 
            // lab_Discount
            // 
            this.lab_Discount.AutoSize = true;
            this.lab_Discount.Location = new System.Drawing.Point(104, 195);
            this.lab_Discount.Name = "lab_Discount";
            this.lab_Discount.Size = new System.Drawing.Size(96, 20);
            this.lab_Discount.TabIndex = 21;
            this.lab_Discount.Text = "lab_Discount";
            // 
            // cbox_Member
            // 
            this.cbox_Member.BackColor = System.Drawing.Color.White;
            this.cbox_Member.FormattingEnabled = true;
            this.cbox_Member.Location = new System.Drawing.Point(104, 156);
            this.cbox_Member.Name = "cbox_Member";
            this.cbox_Member.Size = new System.Drawing.Size(181, 28);
            this.cbox_Member.TabIndex = 20;
            this.cbox_Member.SelectedIndexChanged += new System.EventHandler(this.Cbox_Member_SelectedIndexChanged);
            // 
            // txt_Balance
            // 
            this.txt_Balance.BackColor = System.Drawing.Color.White;
            this.txt_Balance.Location = new System.Drawing.Point(104, 112);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.Size = new System.Drawing.Size(181, 26);
            this.txt_Balance.TabIndex = 19;
            // 
            // txt_IDCard
            // 
            this.txt_IDCard.BackColor = System.Drawing.Color.White;
            this.txt_IDCard.Enabled = false;
            this.txt_IDCard.Location = new System.Drawing.Point(104, 68);
            this.txt_IDCard.Name = "txt_IDCard";
            this.txt_IDCard.Size = new System.Drawing.Size(181, 26);
            this.txt_IDCard.TabIndex = 18;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.Location = new System.Drawing.Point(104, 24);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(181, 26);
            this.txt_Name.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "折扣：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "会员等级：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "用户余额：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "身份证：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "顾客姓名：";
            // 
            // Alter
            // 
            this.Alter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.Alter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.Alter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alter.ForeColor = System.Drawing.Color.White;
            this.Alter.Location = new System.Drawing.Point(210, 225);
            this.Alter.Name = "Alter";
            this.Alter.Size = new System.Drawing.Size(75, 30);
            this.Alter.TabIndex = 11;
            this.Alter.Text = "修 改";
            this.Alter.UseVisualStyleBackColor = false;
            this.Alter.Click += new System.EventHandler(this.Alter_Click);
            // 
            // CustomerAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 296);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerAlter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改顾客信息";
            this.Load += new System.EventHandler(this.CustomerAlter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Balance;
        private System.Windows.Forms.TextBox txt_IDCard;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Alter;
        private System.Windows.Forms.Label lab_Discount;
        private System.Windows.Forms.ComboBox cbox_Member;
    }
}