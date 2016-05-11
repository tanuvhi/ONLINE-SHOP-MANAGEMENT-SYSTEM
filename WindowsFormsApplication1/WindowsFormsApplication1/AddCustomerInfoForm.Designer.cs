namespace WindowsFormsApplication1
{
    partial class AddCustomerInfoForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.phoneLabel2 = new System.Windows.Forms.Label();
            this.phoneTextBox2 = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.shipLabel = new System.Windows.Forms.Label();
            this.shipComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pasteTextBox = new System.Windows.Forms.TextBox();
            this.pasteLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addcusInfoLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.allBoxClearButton = new System.Windows.Forms.Button();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.67278F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addcusInfoLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.412826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.58717F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 581);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer1.Size = new System.Drawing.Size(668, 466);
            this.splitContainer1.SplitterDistance = 417;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.3789F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.6211F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.phoneLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.regionLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.nameLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.regionComboBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cityLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cityComboBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.phoneLabel2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.phoneTextBox2, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.addressLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.addressTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.shipLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.shipComboBox, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(417, 466);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.27746F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.72254F));
            this.tableLayoutPanel3.Controls.Add(this.searchButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.PhoneTextBox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(113, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(301, 40);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.searchButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.searchButton.Location = new System.Drawing.Point(226, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(72, 28);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PhoneTextBox.Location = new System.Drawing.Point(3, 3);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(217, 24);
            this.PhoneTextBox.TabIndex = 5;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            this.PhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTextBox_KeyPress);
            // 
            // phoneLabel1
            // 
            this.phoneLabel1.AutoSize = true;
            this.phoneLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.phoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.phoneLabel1.Location = new System.Drawing.Point(3, 0);
            this.phoneLabel1.Name = "phoneLabel1";
            this.phoneLabel1.Size = new System.Drawing.Size(104, 18);
            this.phoneLabel1.TabIndex = 16;
            this.phoneLabel1.Text = "Phone ";
            this.phoneLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nameTextBox.Location = new System.Drawing.Point(113, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(301, 24);
            this.nameTextBox.TabIndex = 19;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.regionLabel.Location = new System.Drawing.Point(3, 92);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(104, 46);
            this.regionLabel.TabIndex = 20;
            this.regionLabel.Text = "Region";
            this.regionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nameLabel.Location = new System.Drawing.Point(3, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 46);
            this.nameLabel.TabIndex = 18;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // regionComboBox
            // 
            this.regionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Location = new System.Drawing.Point(113, 95);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(301, 26);
            this.regionComboBox.TabIndex = 21;
            this.regionComboBox.SelectedIndexChanged += new System.EventHandler(this.regionComboBox_SelectedIndexChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cityLabel.Location = new System.Drawing.Point(3, 138);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(104, 46);
            this.cityLabel.TabIndex = 22;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cityComboBox
            // 
            this.cityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(113, 141);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(301, 26);
            this.cityComboBox.TabIndex = 23;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // phoneLabel2
            // 
            this.phoneLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel2.AutoSize = true;
            this.phoneLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.phoneLabel2.Location = new System.Drawing.Point(3, 184);
            this.phoneLabel2.Name = "phoneLabel2";
            this.phoneLabel2.Size = new System.Drawing.Size(104, 46);
            this.phoneLabel2.TabIndex = 24;
            this.phoneLabel2.Text = "Phone";
            this.phoneLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // phoneTextBox2
            // 
            this.phoneTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.phoneTextBox2.Location = new System.Drawing.Point(113, 187);
            this.phoneTextBox2.Name = "phoneTextBox2";
            this.phoneTextBox2.Size = new System.Drawing.Size(301, 24);
            this.phoneTextBox2.TabIndex = 25;
            this.phoneTextBox2.TextChanged += new System.EventHandler(this.phoneTextBox2_TextChanged);
            this.phoneTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox2_KeyPress);
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addressLabel.Location = new System.Drawing.Point(3, 230);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(104, 93);
            this.addressLabel.TabIndex = 26;
            this.addressLabel.Text = "Address";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addressTextBox.Location = new System.Drawing.Point(113, 233);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(301, 87);
            this.addressTextBox.TabIndex = 27;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // shipLabel
            // 
            this.shipLabel.AutoSize = true;
            this.shipLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.shipLabel.Location = new System.Drawing.Point(3, 333);
            this.shipLabel.Name = "shipLabel";
            this.shipLabel.Size = new System.Drawing.Size(104, 36);
            this.shipLabel.TabIndex = 28;
            this.shipLabel.Text = "Shipping Company";
            this.shipLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // shipComboBox
            // 
            this.shipComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shipComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.shipComboBox.FormattingEnabled = true;
            this.shipComboBox.Location = new System.Drawing.Point(113, 340);
            this.shipComboBox.Name = "shipComboBox";
            this.shipComboBox.Size = new System.Drawing.Size(301, 26);
            this.shipComboBox.TabIndex = 29;
            this.shipComboBox.SelectedIndexChanged += new System.EventHandler(this.shipComboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.993006F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.91608F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.Controls.Add(this.pasteTextBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.pasteLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.49367F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.50633F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(247, 466);
            this.tableLayoutPanel4.TabIndex = 25;
            // 
            // pasteTextBox
            // 
            this.pasteTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pasteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pasteTextBox.Location = new System.Drawing.Point(20, 36);
            this.pasteTextBox.Multiline = true;
            this.pasteTextBox.Name = "pasteTextBox";
            this.pasteTextBox.Size = new System.Drawing.Size(201, 311);
            this.pasteTextBox.TabIndex = 21;
            this.pasteTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pasteLabel
            // 
            this.pasteLabel.AutoSize = true;
            this.pasteLabel.BackColor = System.Drawing.Color.Aqua;
            this.pasteLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pasteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pasteLabel.Location = new System.Drawing.Point(20, 15);
            this.pasteLabel.Name = "pasteLabel";
            this.pasteLabel.Size = new System.Drawing.Size(201, 18);
            this.pasteLabel.TabIndex = 22;
            this.pasteLabel.Text = "Paste Customer Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 31);
            this.panel1.TabIndex = 23;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.Location = new System.Drawing.Point(0, 0);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 31);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(126, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addcusInfoLabel
            // 
            this.addcusInfoLabel.AutoSize = true;
            this.addcusInfoLabel.BackColor = System.Drawing.Color.Aqua;
            this.addcusInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addcusInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addcusInfoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addcusInfoLabel.Location = new System.Drawing.Point(3, 0);
            this.addcusInfoLabel.Name = "addcusInfoLabel";
            this.addcusInfoLabel.Size = new System.Drawing.Size(668, 32);
            this.addcusInfoLabel.TabIndex = 1;
            this.addcusInfoLabel.Text = "Add Customer Information";
            this.addcusInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Controls.Add(this.allBoxClearButton);
            this.panel2.Controls.Add(this.addOrderButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 545);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 33);
            this.panel2.TabIndex = 2;
            // 
            // allBoxClearButton
            // 
            this.allBoxClearButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.allBoxClearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.allBoxClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.allBoxClearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.allBoxClearButton.Location = new System.Drawing.Point(0, 0);
            this.allBoxClearButton.Name = "allBoxClearButton";
            this.allBoxClearButton.Size = new System.Drawing.Size(75, 33);
            this.allBoxClearButton.TabIndex = 21;
            this.allBoxClearButton.Text = "Clear All";
            this.allBoxClearButton.UseVisualStyleBackColor = false;
            this.allBoxClearButton.Click += new System.EventHandler(this.allBoxClearButton_Click);
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addOrderButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addOrderButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addOrderButton.Location = new System.Drawing.Point(556, 0);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(112, 33);
            this.addOrderButton.TabIndex = 1;
            this.addOrderButton.Text = "Add Order";
            this.addOrderButton.UseVisualStyleBackColor = false;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // AddCustomerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddCustomerInfoForm";
            this.Text = " ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label addcusInfoLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label phoneLabel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label phoneLabel2;
        private System.Windows.Forms.TextBox phoneTextBox2;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label shipLabel;
        private System.Windows.Forms.ComboBox shipComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox pasteTextBox;
        private System.Windows.Forms.Label pasteLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button allBoxClearButton;
    }
}