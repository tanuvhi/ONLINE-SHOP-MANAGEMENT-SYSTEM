namespace WindowsFormsApplication1
{
    partial class Main
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
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wAITINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTOCKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTOCKToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pURCHASEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHIPPERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showUserConPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellToolStripMenuItem,
            this.sTOCKToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.sHIPPERSToolStripMenuItem,
            this.sELLERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 10, 2, 10);
            this.menuStrip1.Size = new System.Drawing.Size(674, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.sToolStripMenuItem,
            this.seeToolStripMenuItem,
            this.salesHistoryToolStripMenuItem});
            this.sellToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.sellToolStripMenuItem.Text = "SALES";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.sellToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.aToolStripMenuItem.Text = "Add Order";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shToolStripMenuItem,
            this.wAITINGToolStripMenuItem});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.sToolStripMenuItem.Text = "Shipping";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // shToolStripMenuItem
            // 
            this.shToolStripMenuItem.Name = "shToolStripMenuItem";
            this.shToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.shToolStripMenuItem.Text = "Tomorrow";
            this.shToolStripMenuItem.Click += new System.EventHandler(this.shToolStripMenuItem_Click);
            // 
            // wAITINGToolStripMenuItem
            // 
            this.wAITINGToolStripMenuItem.Name = "wAITINGToolStripMenuItem";
            this.wAITINGToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.wAITINGToolStripMenuItem.Text = "Waiting";
            this.wAITINGToolStripMenuItem.Click += new System.EventHandler(this.wAITINGToolStripMenuItem_Click);
            // 
            // seeToolStripMenuItem
            // 
            this.seeToolStripMenuItem.Name = "seeToolStripMenuItem";
            this.seeToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.seeToolStripMenuItem.Text = "Transection";
            this.seeToolStripMenuItem.Click += new System.EventHandler(this.seeToolStripMenuItem_Click);
            // 
            // salesHistoryToolStripMenuItem
            // 
            this.salesHistoryToolStripMenuItem.Name = "salesHistoryToolStripMenuItem";
            this.salesHistoryToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.salesHistoryToolStripMenuItem.Text = "Sales History";
            this.salesHistoryToolStripMenuItem.Click += new System.EventHandler(this.salesHistoryToolStripMenuItem_Click);
            // 
            // sTOCKToolStripMenuItem
            // 
            this.sTOCKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTOCKToolStripMenuItem1,
            this.pURCHASEToolStripMenuItem1,
            this.addToolStripMenuItem});
            this.sTOCKToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.sTOCKToolStripMenuItem.Name = "sTOCKToolStripMenuItem";
            this.sTOCKToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.sTOCKToolStripMenuItem.Text = "STOCK";
            this.sTOCKToolStripMenuItem.Click += new System.EventHandler(this.sTOCKToolStripMenuItem_Click);
            // 
            // sTOCKToolStripMenuItem1
            // 
            this.sTOCKToolStripMenuItem1.Name = "sTOCKToolStripMenuItem1";
            this.sTOCKToolStripMenuItem1.Size = new System.Drawing.Size(195, 24);
            this.sTOCKToolStripMenuItem1.Text = "Stock";
            this.sTOCKToolStripMenuItem1.Click += new System.EventHandler(this.sTOCKToolStripMenuItem1_Click);
            // 
            // pURCHASEToolStripMenuItem1
            // 
            this.pURCHASEToolStripMenuItem1.Name = "pURCHASEToolStripMenuItem1";
            this.pURCHASEToolStripMenuItem1.Size = new System.Drawing.Size(195, 24);
            this.pURCHASEToolStripMenuItem1.Text = "Purchase History";
            this.pURCHASEToolStripMenuItem1.Click += new System.EventHandler(this.pURCHASEToolStripMenuItem1_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.addToolStripMenuItem.Text = "Add New Product";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.employeeToolStripMenuItem.Text = "EMPLOYEES";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.addEmployeeToolStripMenuItem.Text = "Employees";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // sHIPPERSToolStripMenuItem
            // 
            this.sHIPPERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCompanyToolStripMenuItem,
            this.viewAllCompanyToolStripMenuItem});
            this.sHIPPERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.sHIPPERSToolStripMenuItem.Name = "sHIPPERSToolStripMenuItem";
            this.sHIPPERSToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.sHIPPERSToolStripMenuItem.Text = "SHIPPERS";
            // 
            // addCompanyToolStripMenuItem
            // 
            this.addCompanyToolStripMenuItem.Name = "addCompanyToolStripMenuItem";
            this.addCompanyToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.addCompanyToolStripMenuItem.Text = "Add Company";
            // 
            // viewAllCompanyToolStripMenuItem
            // 
            this.viewAllCompanyToolStripMenuItem.Name = "viewAllCompanyToolStripMenuItem";
            this.viewAllCompanyToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.viewAllCompanyToolStripMenuItem.Text = "View All Company";
            // 
            // sELLERToolStripMenuItem
            // 
            this.sELLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iToolStripMenuItem,
            this.commissionToolStripMenuItem});
            this.sELLERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.sELLERToolStripMenuItem.Name = "sELLERToolStripMenuItem";
            this.sELLERToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.sELLERToolStripMenuItem.Text = "SELLERS";
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.iToolStripMenuItem.Text = "Information";
            // 
            // commissionToolStripMenuItem
            // 
            this.commissionToolStripMenuItem.Name = "commissionToolStripMenuItem";
            this.commissionToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.commissionToolStripMenuItem.Text = "Commission";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.showUserConPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.635009F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.36499F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 537);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.Controls.Add(this.logoutLabel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.userNameLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(668, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.logoutLabel.Location = new System.Drawing.Point(589, 0);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(61, 18);
            this.logoutLabel.TabIndex = 0;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Log Out";
            this.logoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.userNameLabel.Location = new System.Drawing.Point(583, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 34);
            this.userNameLabel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "All Transection";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(134, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME TO ULTRA SHOP BD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showUserConPanel
            // 
            this.showUserConPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showUserConPanel.Location = new System.Drawing.Point(3, 43);
            this.showUserConPanel.Name = "showUserConPanel";
            this.showUserConPanel.Size = new System.Drawing.Size(668, 491);
            this.showUserConPanel.TabIndex = 1;
            this.showUserConPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.showUserConPanel_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(674, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTOCKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pURCHASEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sTOCKToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wAITINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHIPPERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllCompanyToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Panel showUserConPanel;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sELLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commissionToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;

    }
}