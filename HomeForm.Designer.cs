
namespace POSAccount
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnSalePay = new System.Windows.Forms.Button();
            this.btnPurchasePay = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnBalaance = new System.Windows.Forms.Button();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.btnIncomeStatement = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPOS = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnIncomeStatement);
            this.panel1.Controls.Add(this.panelLogout);
            this.panel1.Controls.Add(this.btnBalaance);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.btnPurchasePay);
            this.panel1.Controls.Add(this.btnSalePay);
            this.panel1.Controls.Add(this.btnPurchase);
            this.panel1.Controls.Add(this.btnSale);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 450);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssDate});
            this.statusStrip1.Location = new System.Drawing.Point(251, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(549, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(479, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Ready";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssDate
            // 
            this.tssDate.Name = "tssDate";
            this.tssDate.Size = new System.Drawing.Size(55, 17);
            this.tssDate.Text = "Datetime";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.lbPOS);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnMaximize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(251, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 68);
            this.panel2.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Location = new System.Drawing.Point(352, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 44);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.Location = new System.Drawing.Point(412, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(36, 44);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(473, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 53);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Location = new System.Drawing.Point(36, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(202, 44);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.Location = new System.Drawing.Point(36, 53);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(202, 44);
            this.BtnHome.TabIndex = 4;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSale.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.Location = new System.Drawing.Point(36, 103);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(202, 44);
            this.btnSale.TabIndex = 5;
            this.btnSale.Text = "New Sale";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPurchase.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.Location = new System.Drawing.Point(36, 153);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(202, 44);
            this.btnPurchase.TabIndex = 6;
            this.btnPurchase.Text = "New Purchase";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnSalePay
            // 
            this.btnSalePay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSalePay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalePay.FlatAppearance.BorderSize = 0;
            this.btnSalePay.Location = new System.Drawing.Point(36, 203);
            this.btnSalePay.Name = "btnSalePay";
            this.btnSalePay.Size = new System.Drawing.Size(202, 44);
            this.btnSalePay.TabIndex = 7;
            this.btnSalePay.Text = "Sale Payment";
            this.btnSalePay.UseVisualStyleBackColor = false;
            this.btnSalePay.Click += new System.EventHandler(this.btnSalePay_Click);
            // 
            // btnPurchasePay
            // 
            this.btnPurchasePay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPurchasePay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPurchasePay.FlatAppearance.BorderSize = 0;
            this.btnPurchasePay.Location = new System.Drawing.Point(36, 253);
            this.btnPurchasePay.Name = "btnPurchasePay";
            this.btnPurchasePay.Size = new System.Drawing.Size(202, 44);
            this.btnPurchasePay.TabIndex = 8;
            this.btnPurchasePay.Text = "Purchase Payment";
            this.btnPurchasePay.UseVisualStyleBackColor = false;
            this.btnPurchasePay.Click += new System.EventHandler(this.btnPurchasePay_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.Location = new System.Drawing.Point(36, 303);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(202, 44);
            this.btnTransaction.TabIndex = 9;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = false;
            // 
            // btnBalaance
            // 
            this.btnBalaance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBalaance.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBalaance.FlatAppearance.BorderSize = 0;
            this.btnBalaance.Location = new System.Drawing.Point(36, 353);
            this.btnBalaance.Name = "btnBalaance";
            this.btnBalaance.Size = new System.Drawing.Size(202, 44);
            this.btnBalaance.TabIndex = 10;
            this.btnBalaance.Text = "Balance Sheet";
            this.btnBalaance.UseVisualStyleBackColor = false;
            // 
            // panelLogout
            // 
            this.panelLogout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLogout.Location = new System.Drawing.Point(3, 3);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(30, 44);
            this.panelLogout.TabIndex = 11;
            // 
            // btnIncomeStatement
            // 
            this.btnIncomeStatement.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIncomeStatement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncomeStatement.FlatAppearance.BorderSize = 0;
            this.btnIncomeStatement.Location = new System.Drawing.Point(36, 403);
            this.btnIncomeStatement.Name = "btnIncomeStatement";
            this.btnIncomeStatement.Size = new System.Drawing.Size(202, 44);
            this.btnIncomeStatement.TabIndex = 12;
            this.btnIncomeStatement.Text = "Income Statment";
            this.btnIncomeStatement.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(251, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 360);
            this.panel3.TabIndex = 13;
            // 
            // lbPOS
            // 
            this.lbPOS.AutoSize = true;
            this.lbPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbPOS.Location = new System.Drawing.Point(78, 21);
            this.lbPOS.Name = "lbPOS";
            this.lbPOS.Size = new System.Drawing.Size(256, 26);
            this.lbPOS.TabIndex = 3;
            this.lbPOS.Text = "Point of Sale & Accounting";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.Location = new System.Drawing.Point(6, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(33, 30);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(6, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 30);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPurchasePay;
        private System.Windows.Forms.Button btnSalePay;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBalaance;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Button btnIncomeStatement;
        private System.Windows.Forms.Label lbPOS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSetting;
    }
}