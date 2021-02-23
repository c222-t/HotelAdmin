
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
            this.Billing = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.Book = new System.Windows.Forms.ToolStripMenuItem();
            this.TopUp = new System.Windows.Forms.ToolStripMenuItem();
            this.InquiringThe = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomKeeper = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerCRM = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonnelManage = new System.Windows.Forms.ToolStripMenuItem();
            this.CommodityManager = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.Suspend = new System.Windows.Forms.ToolStripMenuItem();
            this.AsFor = new System.Windows.Forms.ToolStripMenuItem();
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
            this.CustomerCRM,
            this.PersonnelManage,
            this.CommodityManager,
            this.SystemSetup,
            this.Suspend,
            this.AsFor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Billing
            // 
            this.Billing.Name = "Billing";
            this.Billing.Size = new System.Drawing.Size(44, 21);
            this.Billing.Text = "开单";
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
            // TopUp
            // 
            this.TopUp.Name = "TopUp";
            this.TopUp.Size = new System.Drawing.Size(44, 21);
            this.TopUp.Text = "充值";
            // 
            // InquiringThe
            // 
            this.InquiringThe.Name = "InquiringThe";
            this.InquiringThe.Size = new System.Drawing.Size(68, 21);
            this.InquiringThe.Text = "营业查询";
            // 
            // RoomKeeper
            // 
            this.RoomKeeper.Name = "RoomKeeper";
            this.RoomKeeper.Size = new System.Drawing.Size(68, 21);
            this.RoomKeeper.Text = "房间管理";
            // 
            // CustomerCRM
            // 
            this.CustomerCRM.Name = "CustomerCRM";
            this.CustomerCRM.Size = new System.Drawing.Size(68, 21);
            this.CustomerCRM.Text = "客户管理";
            this.CustomerCRM.Click += new System.EventHandler(this.CustomerCRM_Click);
            // 
            // PersonnelManage
            // 
            this.PersonnelManage.Name = "PersonnelManage";
            this.PersonnelManage.Size = new System.Drawing.Size(68, 21);
            this.PersonnelManage.Text = "员工管理";
            this.PersonnelManage.Click += new System.EventHandler(this.PersonnelManage_Click);
            // 
            // CommodityManager
            // 
            this.CommodityManager.Name = "CommodityManager";
            this.CommodityManager.Size = new System.Drawing.Size(68, 21);
            this.CommodityManager.Text = "商品管理";
            this.CommodityManager.Click += new System.EventHandler(this.CommodityManager_Click);
            // 
            // SystemSetup
            // 
            this.SystemSetup.Name = "SystemSetup";
            this.SystemSetup.Size = new System.Drawing.Size(68, 21);
            this.SystemSetup.Text = "系统设置";
            this.SystemSetup.Click += new System.EventHandler(this.SystemSetup_Click);
            // 
            // Suspend
            // 
            this.Suspend.Name = "Suspend";
            this.Suspend.Size = new System.Drawing.Size(44, 21);
            this.Suspend.Text = "挂起";
            this.Suspend.Click += new System.EventHandler(this.Suspend_Click);
            // 
            // AsFor
            // 
            this.AsFor.Name = "AsFor";
            this.AsFor.Size = new System.Drawing.Size(44, 21);
            this.AsFor.Text = "关于";
            this.AsFor.Click += new System.EventHandler(this.AsFor_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
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
        private System.Windows.Forms.ToolStripMenuItem CustomerCRM;
        private System.Windows.Forms.ToolStripMenuItem RoomKeeper;
        private System.Windows.Forms.ToolStripMenuItem PersonnelManage;
        private System.Windows.Forms.ToolStripMenuItem SystemSetup;
        private System.Windows.Forms.ToolStripMenuItem AsFor;
        private System.Windows.Forms.ToolStripMenuItem Billing;
        private System.Windows.Forms.ToolStripMenuItem CheckOut;
        private System.Windows.Forms.ToolStripMenuItem Book;
        private System.Windows.Forms.ToolStripMenuItem TopUp;
        private System.Windows.Forms.ToolStripMenuItem CommodityManager;
        private System.Windows.Forms.ToolStripMenuItem Suspend;
    }
}