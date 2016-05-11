namespace WindowsFormsApplication1
{
    partial class PurchaseForm
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.addItemLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.saleItemRadioButton = new System.Windows.Forms.RadioButton();
            this.notSellRadioButton = new System.Windows.Forms.RadioButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.purchaseLabel = new System.Windows.Forms.Label();
            this.saleLabel = new System.Windows.Forms.Label();
            this.pPriceTextBox = new System.Windows.Forms.TextBox();
            this.sPriceTextBox = new System.Windows.Forms.TextBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.purchaseDate = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.MinDatePiker = new System.Windows.Forms.DateTimePicker();
            this.MaxDatePiker = new System.Windows.Forms.DateTimePicker();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemViewButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dateGView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.productName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colorGview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.showAmountLabe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(674, 591);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.17804F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.82196F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.addItemLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(135, 144);
            this.splitContainer2.SplitterDistance = 35;
            this.splitContainer2.TabIndex = 0;
            // 
            // addItemLabel
            // 
            this.addItemLabel.AutoSize = true;
            this.addItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addItemLabel.Location = new System.Drawing.Point(0, 0);
            this.addItemLabel.Margin = new System.Windows.Forms.Padding(0);
            this.addItemLabel.Name = "addItemLabel";
            this.addItemLabel.Size = new System.Drawing.Size(90, 25);
            this.addItemLabel.TabIndex = 0;
            this.addItemLabel.Text = "Add Item";
            this.addItemLabel.Click += new System.EventHandler(this.addItemLabel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.saleItemRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.notSellRadioButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(135, 105);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // saleItemRadioButton
            // 
            this.saleItemRadioButton.AutoSize = true;
            this.saleItemRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.saleItemRadioButton.Location = new System.Drawing.Point(3, 3);
            this.saleItemRadioButton.Name = "saleItemRadioButton";
            this.saleItemRadioButton.Padding = new System.Windows.Forms.Padding(3);
            this.saleItemRadioButton.Size = new System.Drawing.Size(61, 28);
            this.saleItemRadioButton.TabIndex = 0;
            this.saleItemRadioButton.TabStop = true;
            this.saleItemRadioButton.Text = "Sale";
            this.saleItemRadioButton.UseVisualStyleBackColor = true;
            // 
            // notSellRadioButton
            // 
            this.notSellRadioButton.AutoSize = true;
            this.notSellRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.notSellRadioButton.Location = new System.Drawing.Point(3, 37);
            this.notSellRadioButton.Name = "notSellRadioButton";
            this.notSellRadioButton.Padding = new System.Windows.Forms.Padding(3);
            this.notSellRadioButton.Size = new System.Drawing.Size(116, 28);
            this.notSellRadioButton.TabIndex = 1;
            this.notSellRadioButton.TabStop = true;
            this.notSellRadioButton.Text = "Not For Sale";
            this.notSellRadioButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(135, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer3.Size = new System.Drawing.Size(539, 144);
            this.splitContainer3.SplitterDistance = 460;
            this.splitContainer3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.33766F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.64935F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.61472F));
            this.tableLayoutPanel2.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.colorLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.colorComboBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.quantityLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.quantityTextBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.purchaseLabel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.saleLabel, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.pPriceTextBox, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.sPriceTextBox, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.viewButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.purchaseDate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.addButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.69444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.30556F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(460, 144);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 36);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nameTextBox.Location = new System.Drawing.Point(59, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(227, 24);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.colorLabel.Location = new System.Drawing.Point(3, 36);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(50, 35);
            this.colorLabel.TabIndex = 2;
            this.colorLabel.Text = "Color";
            // 
            // colorComboBox
            // 
            this.colorComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(59, 39);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(227, 26);
            this.colorComboBox.TabIndex = 3;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.quantityLabel.Location = new System.Drawing.Point(292, 36);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(77, 35);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.quantityTextBox.Location = new System.Drawing.Point(375, 39);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(82, 24);
            this.quantityTextBox.TabIndex = 5;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // purchaseLabel
            // 
            this.purchaseLabel.AutoSize = true;
            this.purchaseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.purchaseLabel.Location = new System.Drawing.Point(292, 71);
            this.purchaseLabel.Name = "purchaseLabel";
            this.purchaseLabel.Size = new System.Drawing.Size(77, 36);
            this.purchaseLabel.TabIndex = 7;
            this.purchaseLabel.Text = "Purchase Price";
            // 
            // saleLabel
            // 
            this.saleLabel.AutoSize = true;
            this.saleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.saleLabel.Location = new System.Drawing.Point(292, 107);
            this.saleLabel.Name = "saleLabel";
            this.saleLabel.Size = new System.Drawing.Size(77, 37);
            this.saleLabel.TabIndex = 8;
            this.saleLabel.Text = "Selling Price";
            // 
            // pPriceTextBox
            // 
            this.pPriceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pPriceTextBox.Location = new System.Drawing.Point(375, 74);
            this.pPriceTextBox.Name = "pPriceTextBox";
            this.pPriceTextBox.Size = new System.Drawing.Size(82, 24);
            this.pPriceTextBox.TabIndex = 9;
            this.pPriceTextBox.TextChanged += new System.EventHandler(this.pPriceTextBox_TextChanged);
            this.pPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // sPriceTextBox
            // 
            this.sPriceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sPriceTextBox.Location = new System.Drawing.Point(375, 110);
            this.sPriceTextBox.Name = "sPriceTextBox";
            this.sPriceTextBox.Size = new System.Drawing.Size(82, 24);
            this.sPriceTextBox.TabIndex = 10;
            this.sPriceTextBox.TextChanged += new System.EventHandler(this.sPriceTextBox_TextChanged);
            this.sPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.viewButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewButton.Location = new System.Drawing.Point(292, 3);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 30);
            this.viewButton.TabIndex = 11;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateLabel.Location = new System.Drawing.Point(3, 71);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(50, 36);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Date";
            // 
            // purchaseDate
            // 
            this.purchaseDate.CustomFormat = "dd-MM-yyyy";
            this.purchaseDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.purchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseDate.Location = new System.Drawing.Point(59, 74);
            this.purchaseDate.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.Size = new System.Drawing.Size(227, 24);
            this.purchaseDate.TabIndex = 13;
            this.purchaseDate.Value = new System.DateTime(2015, 1, 6, 0, 0, 0, 0);
            this.purchaseDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(375, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 30);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.32506F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.67493F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(674, 443);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.MinDatePiker, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.MaxDatePiker, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.itemNameLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.itemNameTextBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.itemViewButton, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(668, 88);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // MinDatePiker
            // 
            this.MinDatePiker.CustomFormat = "dd-MM-yyyy";
            this.MinDatePiker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinDatePiker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MinDatePiker.Location = new System.Drawing.Point(403, 3);
            this.MinDatePiker.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.MinDatePiker.Name = "MinDatePiker";
            this.MinDatePiker.Size = new System.Drawing.Size(127, 24);
            this.MinDatePiker.TabIndex = 0;
            this.MinDatePiker.Value = new System.DateTime(2015, 1, 6, 0, 0, 0, 0);
            this.MinDatePiker.ValueChanged += new System.EventHandler(this.MinDatePiker_ValueChanged);
            // 
            // MaxDatePiker
            // 
            this.MaxDatePiker.CustomFormat = "dd-MM-yyyy";
            this.MaxDatePiker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxDatePiker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MaxDatePiker.Location = new System.Drawing.Point(536, 3);
            this.MaxDatePiker.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.MaxDatePiker.Name = "MaxDatePiker";
            this.MaxDatePiker.Size = new System.Drawing.Size(129, 24);
            this.MaxDatePiker.TabIndex = 1;
            this.MaxDatePiker.Value = new System.DateTime(2015, 1, 6, 0, 0, 0, 0);
            this.MaxDatePiker.ValueChanged += new System.EventHandler(this.MaxDatePiker_ValueChanged);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNameLabel.Location = new System.Drawing.Point(3, 0);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(127, 44);
            this.itemNameLabel.TabIndex = 2;
            this.itemNameLabel.Text = "Item Name";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(585, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.itemNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.itemNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNameTextBox.Location = new System.Drawing.Point(136, 3);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(261, 24);
            this.itemNameTextBox.TabIndex = 4;
            this.itemNameTextBox.TextChanged += new System.EventHandler(this.itemNameTextBox_TextChanged);
            // 
            // itemViewButton
            // 
            this.itemViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemViewButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.itemViewButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.itemViewButton.Location = new System.Drawing.Point(453, 47);
            this.itemViewButton.Name = "itemViewButton";
            this.itemViewButton.Size = new System.Drawing.Size(77, 29);
            this.itemViewButton.TabIndex = 5;
            this.itemViewButton.Text = "View";
            this.itemViewButton.UseVisualStyleBackColor = false;
            this.itemViewButton.Click += new System.EventHandler(this.itemViewButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateGView,
            this.productId,
            this.productName,
            this.colorGview,
            this.insertedBy,
            this.sellingPrice,
            this.purchasePrice,
            this.quantity,
            this.totalAmount});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 97);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(668, 306);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateGView
            // 
            this.dateGView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateGView.HeaderText = "Date";
            this.dateGView.Name = "dateGView";
            this.dateGView.ReadOnly = true;
            // 
            // productId
            // 
            this.productId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productId.FillWeight = 72.52539F;
            this.productId.HeaderText = "Product ID";
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.FillWeight = 220F;
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // colorGview
            // 
            this.colorGview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colorGview.HeaderText = "Color";
            this.colorGview.Name = "colorGview";
            // 
            // insertedBy
            // 
            this.insertedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.insertedBy.FillWeight = 72.52539F;
            this.insertedBy.HeaderText = "Inserted By";
            this.insertedBy.Name = "insertedBy";
            this.insertedBy.ReadOnly = true;
            // 
            // sellingPrice
            // 
            this.sellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellingPrice.FillWeight = 72.52539F;
            this.sellingPrice.HeaderText = "Selling Price";
            this.sellingPrice.Name = "sellingPrice";
            this.sellingPrice.ReadOnly = true;
            // 
            // purchasePrice
            // 
            this.purchasePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchasePrice.FillWeight = 72.52539F;
            this.purchasePrice.HeaderText = "Purchase Price";
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.FillWeight = 72.52539F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalAmount.FillWeight = 72.52539F;
            this.totalAmount.HeaderText = "Total Amount";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel5.Controls.Add(this.totalAmountLabel, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.showAmountLabe, 4, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 409);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(668, 31);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalAmountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.totalAmountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalAmountLabel.Location = new System.Drawing.Point(383, 0);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(129, 31);
            this.totalAmountLabel.TabIndex = 0;
            this.totalAmountLabel.Text = "Total Amount";
            // 
            // showAmountLabe
            // 
            this.showAmountLabe.AutoSize = true;
            this.showAmountLabe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.showAmountLabe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showAmountLabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.showAmountLabe.Location = new System.Drawing.Point(518, 0);
            this.showAmountLabe.Name = "showAmountLabe";
            this.showAmountLabe.Size = new System.Drawing.Size(147, 31);
            this.showAmountLabe.TabIndex = 1;
            this.showAmountLabe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 591);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PurchaseForm";
            this.Text = " ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label addItemLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton saleItemRadioButton;
        private System.Windows.Forms.RadioButton notSellRadioButton;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label purchaseLabel;
        private System.Windows.Forms.Label saleLabel;
        private System.Windows.Forms.TextBox pPriceTextBox;
        private System.Windows.Forms.TextBox sPriceTextBox;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker purchaseDate;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker MinDatePiker;
        private System.Windows.Forms.DateTimePicker MaxDatePiker;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label showAmountLabe;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button itemViewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGView;
        private System.Windows.Forms.DataGridViewLinkColumn productId;
        private System.Windows.Forms.DataGridViewLinkColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorGview;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
    }
}