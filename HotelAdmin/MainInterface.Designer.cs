
namespace HotelAdmin
{
    partial class MainInterface
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InquiringThe = new System.Windows.Forms.ToolStripMenuItem();
            this.客户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomKeeper = new System.Windows.Forms.ToolStripMenuItem();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Billing = new System.Windows.Forms.ToolStripMenuItem();
            this.TopUp = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.Book = new System.Windows.Forms.ToolStripMenuItem();
            this.挂起ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Billing,
            this.CheckOut,
            this.Book,
            this.TopUp,
            this.InquiringThe,
            this.RoomKeeper,
            this.客户管理ToolStripMenuItem,
            this.员工管理ToolStripMenuItem,
            this.商品管理ToolStripMenuItem,
            this.系统设置ToolStripMenuItem,
            this.挂起ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InquiringThe
            // 
            this.InquiringThe.Name = "InquiringThe";
            this.InquiringThe.Size = new System.Drawing.Size(68, 21);
            this.InquiringThe.Text = "营业查询";
            // 
            // 客户管理ToolStripMenuItem
            // 
            this.客户管理ToolStripMenuItem.Name = "客户管理ToolStripMenuItem";
            this.客户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.客户管理ToolStripMenuItem.Text = "客户管理";
            // 
            // RoomKeeper
            // 
            this.RoomKeeper.Name = "RoomKeeper";
            this.RoomKeeper.Size = new System.Drawing.Size(68, 21);
            this.RoomKeeper.Text = "房间管理";
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(32, 21);
            this.关于ToolStripMenuItem.Text = "关";
            // 
            // 商品管理ToolStripMenuItem
            // 
            this.商品管理ToolStripMenuItem.Name = "商品管理ToolStripMenuItem";
            this.商品管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.商品管理ToolStripMenuItem.Text = "商品管理";
            // 
            // Billing
            // 
            this.Billing.Name = "Billing";
            this.Billing.Size = new System.Drawing.Size(44, 21);
            this.Billing.Text = "开单";
            // 
            // TopUp
            // 
            this.TopUp.Name = "TopUp";
            this.TopUp.Size = new System.Drawing.Size(44, 21);
            this.TopUp.Text = "充值";
            // 
            // CheckOut
            // 
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(44, 21);
            this.CheckOut.Text = "结账";
            // 
            // Book
            // 
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(44, 21);
            this.Book.Text = "预定";
            // 
            // 挂起ToolStripMenuItem
            // 
            this.挂起ToolStripMenuItem.Name = "挂起ToolStripMenuItem";
            this.挂起ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.挂起ToolStripMenuItem.Text = "挂起";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 881);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainInterface";
            this.Text = "酒店管理系统";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InquiringThe;
        private System.Windows.Forms.ToolStripMenuItem 客户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoomKeeper;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Billing;
        private System.Windows.Forms.ToolStripMenuItem CheckOut;
        private System.Windows.Forms.ToolStripMenuItem Book;
        private System.Windows.Forms.ToolStripMenuItem TopUp;
        private System.Windows.Forms.ToolStripMenuItem 商品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 挂起ToolStripMenuItem;
    }
}