
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
            this.Btn_SelectionPath = new System.Windows.Forms.Button();
            this.Folder_ImgPath = new System.Windows.Forms.FolderBrowserDialog();
            this.fileName = new System.Windows.Forms.TextBox();
            this.txt_conut = new System.Windows.Forms.TextBox();
            this.unit = new System.Windows.Forms.DomainUpDown();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Retail = new System.Windows.Forms.TextBox();
            this.importPrice = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Goods)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Preserve
            // 
            this.Btn_Preserve.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Preserve.Location = new System.Drawing.Point(416, 266);
            this.Btn_Preserve.Name = "Btn_Preserve";
            this.Btn_Preserve.Size = new System.Drawing.Size(75, 33);
            this.Btn_Preserve.TabIndex = 6;
            this.Btn_Preserve.Text = "保 存";
            this.Btn_Preserve.UseVisualStyleBackColor = true;
            this.Btn_Preserve.Click += new System.EventHandler(this.Btn_Preserve_Click);
            // 
            // Pic_Goods
            // 
            this.Pic_Goods.Location = new System.Drawing.Point(309, 12);
            this.Pic_Goods.Name = "Pic_Goods";
            this.Pic_Goods.Size = new System.Drawing.Size(182, 230);
            this.Pic_Goods.TabIndex = 14;
            this.Pic_Goods.TabStop = false;
            // 
            // Btn_SelectionPath
            // 
            this.Btn_SelectionPath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_SelectionPath.Location = new System.Drawing.Point(214, 267);
            this.Btn_SelectionPath.Name = "Btn_SelectionPath";
            this.Btn_SelectionPath.Size = new System.Drawing.Size(75, 28);
            this.Btn_SelectionPath.TabIndex = 15;
            this.Btn_SelectionPath.Text = "图片路径";
            this.Btn_SelectionPath.UseVisualStyleBackColor = true;
            this.Btn_SelectionPath.Click += new System.EventHandler(this.Btn_SelectionPath_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(16, 271);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(182, 21);
            this.fileName.TabIndex = 16;
            // 
            // txt_conut
            // 
            this.txt_conut.Location = new System.Drawing.Point(69, 93);
            this.txt_conut.Name = "txt_conut";
            this.txt_conut.Size = new System.Drawing.Size(171, 21);
            this.txt_conut.TabIndex = 28;
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
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(69, 222);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(171, 20);
            this.Type.TabIndex = 26;
            // 
            // Retail
            // 
            this.Retail.Location = new System.Drawing.Point(69, 179);
            this.Retail.Name = "Retail";
            this.Retail.Size = new System.Drawing.Size(171, 21);
            this.Retail.TabIndex = 25;
            // 
            // importPrice
            // 
            this.importPrice.Location = new System.Drawing.Point(69, 137);
            this.importPrice.Name = "importPrice";
            this.importPrice.Size = new System.Drawing.Size(171, 21);
            this.importPrice.TabIndex = 24;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(69, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(171, 21);
            this.txt_name.TabIndex = 23;
            // 
            // label6
            // 
            this.importPrice.BackColor = System.Drawing.Color.Beige;
            this.importPrice.Location = new System.Drawing.Point(69, 150);
            this.importPrice.Name = "importPrice";
            this.importPrice.Size = new System.Drawing.Size(171, 21);
            this.importPrice.TabIndex = 8;
            this.importPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImportPrice_KeyPress);
            // 
            // label5
            // 
            this.Retail.BackColor = System.Drawing.Color.Beige;
            this.Retail.Location = new System.Drawing.Point(69, 192);
            this.Retail.Name = "Retail";
            this.Retail.Size = new System.Drawing.Size(171, 21);
            this.Retail.TabIndex = 9;
            this.Retail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Retail_KeyPress);
            // 
            // label4
            // 
            this.Type.BackColor = System.Drawing.Color.Beige;
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(69, 235);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(171, 20);
            this.Type.TabIndex = 10;
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
            this.txt_conut.BackColor = System.Drawing.Color.Beige;
            this.txt_conut.Location = new System.Drawing.Point(69, 106);
            this.txt_conut.Name = "txt_conut";
            this.txt_conut.Size = new System.Drawing.Size(171, 21);
            this.txt_conut.TabIndex = 13;
            this.txt_conut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_conut_KeyPress);
            // 
            // GoodsRedact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(282, 317);
            this.Controls.Add(this.txt_conut);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Retail);
            this.Controls.Add(this.importPrice);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.Btn_SelectionPath);
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
        private System.Windows.Forms.Button Btn_SelectionPath;
        private System.Windows.Forms.FolderBrowserDialog Folder_ImgPath;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.TextBox txt_conut;
        private System.Windows.Forms.DomainUpDown unit;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.TextBox Retail;
        private System.Windows.Forms.TextBox importPrice;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}