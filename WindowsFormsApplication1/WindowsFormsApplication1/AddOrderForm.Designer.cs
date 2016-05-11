namespace WindowsFormsApplication1
{
    partial class AddOrderForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerInfoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phone1label = new System.Windows.Forms.Label();
            this.phone1TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone2TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.shipperLabel = new System.Windows.Forms.Label();
            this.shipperTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.PreOrderListView = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fdfdggggf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.viewItembutton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.shippingCostLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.shipCostTextBox = new System.Windows.Forms.TextBox();
            this.shipDateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.discountLabel = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.orderlistView = new System.Windows.Forms.ListView();
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.showTotalLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(674, 591);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.customerInfoLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PreOrderListView, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.47053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.52947F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(204, 591);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // customerInfoLabel
            // 
            this.customerInfoLabel.AutoSize = true;
            this.customerInfoLabel.BackColor = System.Drawing.Color.Cyan;
            this.customerInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.customerInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.customerInfoLabel.Location = new System.Drawing.Point(3, 0);
            this.customerInfoLabel.Name = "customerInfoLabel";
            this.customerInfoLabel.Size = new System.Drawing.Size(198, 30);
            this.customerInfoLabel.TabIndex = 16;
            this.customerInfoLabel.Text = "Customer Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 294);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 37);
            this.panel1.TabIndex = 17;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(0, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 31);
            this.editButton.TabIndex = 15;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel2.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.phone1label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.phone1TextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.phone2TextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cityTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.shipperLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.shipperTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.addressTextBox, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.68224F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.68224F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.68224F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.68224F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.68224F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.36449F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.93925F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.285047F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(198, 258);
            this.tableLayoutPanel2.TabIndex = 18;
            this.tableLayoutPanel2.TabStop = true;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nameTextBox.Location = new System.Drawing.Point(58, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(137, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // phone1label
            // 
            this.phone1label.AutoSize = true;
            this.phone1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.phone1label.Location = new System.Drawing.Point(3, 30);
            this.phone1label.Name = "phone1label";
            this.phone1label.Size = new System.Drawing.Size(47, 26);
            this.phone1label.TabIndex = 17;
            this.phone1label.Text = "Phone 1 : ";
            // 
            // phone1TextBox
            // 
            this.phone1TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phone1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.phone1TextBox.Location = new System.Drawing.Point(58, 33);
            this.phone1TextBox.Name = "phone1TextBox";
            this.phone1TextBox.Size = new System.Drawing.Size(137, 20);
            this.phone1TextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phone 2";
            // 
            // phone2TextBox
            // 
            this.phone2TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phone2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.phone2TextBox.Location = new System.Drawing.Point(58, 63);
            this.phone2TextBox.Name = "phone2TextBox";
            this.phone2TextBox.Size = new System.Drawing.Size(137, 20);
            this.phone2TextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(3, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 30);
            this.label5.TabIndex = 21;
            this.label5.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cityTextBox.Location = new System.Drawing.Point(58, 93);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(137, 20);
            this.cityTextBox.TabIndex = 22;
            // 
            // shipperLabel
            // 
            this.shipperLabel.AutoSize = true;
            this.shipperLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.shipperLabel.Location = new System.Drawing.Point(3, 120);
            this.shipperLabel.Name = "shipperLabel";
            this.shipperLabel.Size = new System.Drawing.Size(49, 30);
            this.shipperLabel.TabIndex = 23;
            this.shipperLabel.Text = "shipper:";
            // 
            // shipperTextBox
            // 
            this.shipperTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipperTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.shipperTextBox.Location = new System.Drawing.Point(58, 123);
            this.shipperTextBox.Name = "shipperTextBox";
            this.shipperTextBox.Size = new System.Drawing.Size(137, 20);
            this.shipperTextBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(3, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 60);
            this.label6.TabIndex = 25;
            this.label6.Text = "Address :";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.addressTextBox.Location = new System.Drawing.Point(58, 153);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(137, 54);
            this.addressTextBox.TabIndex = 26;
            // 
            // PreOrderListView
            // 
            this.PreOrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.fdfdggggf,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.PreOrderListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreOrderListView.Location = new System.Drawing.Point(3, 334);
            this.PreOrderListView.Name = "PreOrderListView";
            this.PreOrderListView.Size = new System.Drawing.Size(198, 254);
            this.PreOrderListView.TabIndex = 19;
            this.PreOrderListView.UseCompatibleStateImageBehavior = false;
            this.PreOrderListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            this.columnHeader10.Width = 27;
            // 
            // fdfdggggf
            // 
            this.fdfdggggf.Text = "Order Date";
            this.fdfdggggf.Width = 64;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ship Date";
            this.columnHeader7.Width = 53;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Bill";
            this.columnHeader8.Width = 33;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Order status";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 466F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.orderlistView, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(466, 591);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.splitContainer2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(460, 194);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.05556F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.94444F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel5.Controls.Add(this.itemNameLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.idLabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.itemNameTextBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.viewItembutton, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(454, 80);
            this.tableLayoutPanel5.TabIndex = 0;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.itemNameLabel.Location = new System.Drawing.Point(3, 0);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(49, 40);
            this.itemNameLabel.TabIndex = 20;
            this.itemNameLabel.Text = "Item Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.idLabel.Location = new System.Drawing.Point(3, 40);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(49, 40);
            this.idLabel.TabIndex = 21;
            this.idLabel.Text = "Item ID";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.itemNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.itemNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.itemNameTextBox.Location = new System.Drawing.Point(58, 3);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(243, 24);
            this.itemNameTextBox.TabIndex = 22;
            this.itemNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(58, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 24);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // viewItembutton
            // 
            this.viewItembutton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.viewItembutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.viewItembutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewItembutton.Location = new System.Drawing.Point(307, 3);
            this.viewItembutton.Name = "viewItembutton";
            this.viewItembutton.Size = new System.Drawing.Size(91, 30);
            this.viewItembutton.TabIndex = 24;
            this.viewItembutton.Text = "View Item";
            this.viewItembutton.UseVisualStyleBackColor = false;
            this.viewItembutton.Click += new System.EventHandler(this.showItembutton_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 89);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel7);
            this.splitContainer2.Size = new System.Drawing.Size(454, 102);
            this.splitContainer2.SplitterDistance = 220;
            this.splitContainer2.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.18182F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.81818F));
            this.tableLayoutPanel6.Controls.Add(this.shippingCostLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.dateTimePicker1, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.shipCostTextBox, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.shipDateLabel, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(220, 102);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // shippingCostLabel
            // 
            this.shippingCostLabel.AutoSize = true;
            this.shippingCostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shippingCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.shippingCostLabel.Location = new System.Drawing.Point(3, 0);
            this.shippingCostLabel.Name = "shippingCostLabel";
            this.shippingCostLabel.Size = new System.Drawing.Size(78, 51);
            this.shippingCostLabel.TabIndex = 0;
            this.shippingCostLabel.Text = "Shipping Cost";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 54);
            this.dateTimePicker1.MaxDate = new System.DateTime(2090, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 24);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2015, 1, 4, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // shipCostTextBox
            // 
            this.shipCostTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.shipCostTextBox.Location = new System.Drawing.Point(87, 3);
            this.shipCostTextBox.Name = "shipCostTextBox";
            this.shipCostTextBox.Size = new System.Drawing.Size(130, 24);
            this.shipCostTextBox.TabIndex = 2;
            this.shipCostTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            this.shipCostTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shipCostTextBox_KeyDown);
            this.shipCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shipCostTextBox_KeyPress);
            this.shipCostTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.shipCostTextBox_KeyUp);
            this.shipCostTextBox.MouseLeave += new System.EventHandler(this.shipCostTextBox_MouseLeave);
            this.shipCostTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shipCostTextBox_MouseMove);
            // 
            // shipDateLabel
            // 
            this.shipDateLabel.AutoSize = true;
            this.shipDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.shipDateLabel.Location = new System.Drawing.Point(3, 51);
            this.shipDateLabel.Name = "shipDateLabel";
            this.shipDateLabel.Size = new System.Drawing.Size(78, 51);
            this.shipDateLabel.TabIndex = 3;
            this.shipDateLabel.Text = "Shipping Date";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.43478F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.56522F));
            this.tableLayoutPanel7.Controls.Add(this.discountLabel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.discountTextBox, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(230, 102);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.discountLabel.Location = new System.Drawing.Point(3, 0);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(86, 51);
            this.discountLabel.TabIndex = 0;
            this.discountLabel.Text = "Discount";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.discountTextBox.Location = new System.Drawing.Point(95, 3);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(132, 24);
            this.discountTextBox.TabIndex = 1;
            this.discountTextBox.Text = "0";
            this.discountTextBox.TextChanged += new System.EventHandler(this.discountTextBox_TextChanged);
            this.discountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountTextBox_KeyPress);
            this.discountTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.discountTextBox_KeyUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(95, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Controls.Add(this.confirmButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 554);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(460, 34);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmButton.Location = new System.Drawing.Point(357, 3);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 32);
            this.confirmButton.TabIndex = 26;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // orderlistView
            // 
            this.orderlistView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.orderlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productName,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.orderlistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderlistView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.orderlistView.FullRowSelect = true;
            this.orderlistView.GridLines = true;
            this.orderlistView.Location = new System.Drawing.Point(0, 200);
            this.orderlistView.Margin = new System.Windows.Forms.Padding(0);
            this.orderlistView.Name = "orderlistView";
            this.orderlistView.Size = new System.Drawing.Size(466, 316);
            this.orderlistView.TabIndex = 28;
            this.orderlistView.UseCompatibleStateImageBehavior = false;
            this.orderlistView.View = System.Windows.Forms.View.Details;
            this.orderlistView.SelectedIndexChanged += new System.EventHandler(this.ProductlistView_SelectedIndexChanged);
            // 
            // productName
            // 
            this.productName.Text = "Product Name";
            this.productName.Width = 216;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Color";
            this.columnHeader1.Width = 54;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Price";
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 49;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Order By";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Order By [Id]";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel8.Controls.Add(this.showTotalLabel, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.RemoveButton, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 516);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(466, 35);
            this.tableLayoutPanel8.TabIndex = 29;
            // 
            // showTotalLabel
            // 
            this.showTotalLabel.AutoSize = true;
            this.showTotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.showTotalLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.showTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.showTotalLabel.Location = new System.Drawing.Point(298, 6);
            this.showTotalLabel.Name = "showTotalLabel";
            this.showTotalLabel.Size = new System.Drawing.Size(165, 29);
            this.showTotalLabel.TabIndex = 0;
            this.showTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveButton.Location = new System.Drawing.Point(3, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(84, 29);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(163, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Amount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 591);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AddOrderForm";
            this.Text = "AddOrderForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label customerInfoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label phone1label;
        private System.Windows.Forms.TextBox phone1TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone2TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label shipperLabel;
        private System.Windows.Forms.TextBox shipperTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button viewItembutton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label shippingCostLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox shipCostTextBox;
        private System.Windows.Forms.Label shipDateLabel;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label showTotalLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView orderlistView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView PreOrderListView;
        private System.Windows.Forms.ColumnHeader fdfdggggf;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}