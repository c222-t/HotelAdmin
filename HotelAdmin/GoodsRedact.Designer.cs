
namespace HotelAdmin
{
    partial class GoodsRedact
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
            this.Btn_Preserve = new System.Windows.Forms.Button();
            this.Pic_Goods = new System.Windows.Forms.PictureBox();
            this.Folder_ImgPath = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_conut = new System.Windows.Forms.TextBox();
            this.unit = new System.Windows.Forms.DomainUpDown();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Retail = new System.Windows.Forms.TextBox();
            this.importPrice = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ofdPath = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Goods)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Preserve
            // 
            this.Btn_Preserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.Btn_Preserve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.Btn_Preserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Preserve.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Preserve.ForeColor = System.Drawing.Color.White;
            this.Btn_Preserve.Location = new System.Drawing.Point(416, 266);
            this.Btn_Preserve.Name = "Btn_Preserve";
            this.Btn_Preserve.Size = new System.Drawing.Size(75, 33);
            this.Btn_Preserve.TabIndex = 6;
            this.Btn_Preserve.Text = "保 存";
            this.Btn_Preserve.UseVisualStyleBackColor = false;
            this.Btn_Preserve.Click += new System.EventHandler(this.Btn_Preserve_Click);
            // 
            // Pic_Goods
            // 
            this.Pic_Goods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Goods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_Goods.Location = new System.Drawing.Point(309, 12);
            this.Pic_Goods.Name = "Pic_Goods";
            this.Pic_Goods.Size = new System.Drawing.Size(182, 243);
            this.Pic_Goods.TabIndex = 14;
            this.Pic_Goods.TabStop = false;
            // 
            // txt_conut
            // 
            this.txt_conut.BackColor = System.Drawing.Color.White;
            this.txt_conut.Location = new System.Drawing.Point(69, 106);
            this.txt_conut.Name = "txt_conut";
            this.txt_conut.Size = new System.Drawing.Size(171, 21);
            this.txt_conut.TabIndex = 13;
            this.txt_conut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_conut_KeyPress);
            // 
            // unit
            // 
            this.unit.Location = new System.Drawing.Point(69, 54);
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Size = new System.Drawing.Size(171, 21);
            this.unit.TabIndex = 27;
            // 
            // Type
            // 
            this.Type.BackColor = System.Drawing.Color.Beige;
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(69, 235);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(171, 20);
            this.Type.TabIndex = 10;
            // 
            // Retail
            // 
            this.Retail.BackColor = System.Drawing.Color.White;
            this.Retail.Location = new System.Drawing.Point(69, 192);
            this.Retail.Name = "Retail";
            this.Retail.Size = new System.Drawing.Size(171, 21);
            this.Retail.TabIndex = 9;
            this.Retail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Retail_KeyPress);
            // 
            // importPrice
            // 
            this.importPrice.BackColor = System.Drawing.Color.White;
            this.importPrice.Location = new System.Drawing.Point(69, 150);
            this.importPrice.Name = "importPrice";
            this.importPrice.Size = new System.Drawing.Size(171, 21);
            this.importPrice.TabIndex = 8;
            this.importPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImportPrice_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(69, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(171, 21);
            this.txt_name.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "单位：";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "名称：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(12, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "数量：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(12, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "进价：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(12, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "零售：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(12, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "类型：";
            // 
            // ofdPath
            // 
            this.ofdPath.FileName = "openFileDialog1";
            // 
            // GoodsRedact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 317);
            this.Controls.Add(this.txt_conut);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Retail);
            this.Controls.Add(this.importPrice);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pic_Goods);
            this.Controls.Add(this.Btn_Preserve);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoodsRedact";
            this.Text = "商品编辑";
            this.Load += new System.EventHandler(this.GoodsRedact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Goods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Preserve;
        private System.Windows.Forms.PictureBox Pic_Goods;
        private System.Windows.Forms.FolderBrowserDialog Folder_ImgPath;
        private System.Windows.Forms.TextBox txt_conut;
        private System.Windows.Forms.DomainUpDown unit;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.TextBox Retail;
        private System.Windows.Forms.TextBox importPrice;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog ofdPath;
    }
}