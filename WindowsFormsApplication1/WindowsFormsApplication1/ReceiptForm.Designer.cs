namespace WindowsFormsApplication1
{
    partial class ReceiptForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toatalAmount = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.receiptPrintButton = new System.Windows.Forms.Button();
            this.envelopePrintButton = new System.Windows.Forms.Button();
            this.confirmationComboBox = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.shipCostTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shipDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dicountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.ll = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shipLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.shippingCostLabel = new System.Windows.Forms.Label();
            this.OrderListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OrderListView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.85746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.14254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Aqua;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 449);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 38);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toatalAmount);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 35);
            this.panel1.TabIndex = 0;
            // 
            // toatalAmount
            // 
            this.toatalAmount.AutoSize = true;
            this.toatalAmount.BackColor = System.Drawing.Color.Lime;
            this.toatalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.toatalAmount.Location = new System.Drawing.Point(493, 0);
            this.toatalAmount.Name = "toatalAmount";
            this.toatalAmount.Size = new System.Drawing.Size(64, 25);
            this.toatalAmount.TabIndex = 0;
            this.toatalAmount.Text = "label8";
            this.toatalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toatalAmount.Click += new System.EventHandler(this.toatalAmount_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Aquamarine;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.64544F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.2685F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.receiptPrintButton, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.envelopePrintButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.confirmationComboBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.confirmButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.DiscountTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.shipCostTextBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 487);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.40541F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.59459F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(584, 74);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // receiptPrintButton
            // 
            this.receiptPrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptPrintButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.receiptPrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.receiptPrintButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.receiptPrintButton.Location = new System.Drawing.Point(487, 41);
            this.receiptPrintButton.Margin = new System.Windows.Forms.Padding(0);
            this.receiptPrintButton.Name = "receiptPrintButton";
            this.receiptPrintButton.Size = new System.Drawing.Size(97, 33);
            this.receiptPrintButton.TabIndex = 0;
            this.receiptPrintButton.Text = "Recipt Print";
            this.receiptPrintButton.UseVisualStyleBackColor = false;
            this.receiptPrintButton.Click += new System.EventHandler(this.receiptPrintButton_Click);
            // 
            // envelopePrintButton
            // 
            this.envelopePrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.envelopePrintButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.envelopePrintButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.envelopePrintButton.Location = new System.Drawing.Point(0, 41);
            this.envelopePrintButton.Margin = new System.Windows.Forms.Padding(0);
            this.envelopePrintButton.Name = "envelopePrintButton";
            this.envelopePrintButton.Size = new System.Drawing.Size(113, 33);
            this.envelopePrintButton.TabIndex = 1;
            this.envelopePrintButton.Text = "Envelope Print";
            this.envelopePrintButton.UseVisualStyleBackColor = false;
            this.envelopePrintButton.Click += new System.EventHandler(this.envelopePrintButton_Click);
            // 
            // confirmationComboBox
            // 
            this.confirmationComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmationComboBox.FormattingEnabled = true;
            this.confirmationComboBox.Location = new System.Drawing.Point(149, 44);
            this.confirmationComboBox.Name = "confirmationComboBox";
            this.confirmationComboBox.Size = new System.Drawing.Size(143, 26);
            this.confirmationComboBox.TabIndex = 3;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.confirmButton.ForeColor = System.Drawing.Color.Transparent;
            this.confirmButton.Location = new System.Drawing.Point(298, 44);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(96, 27);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(149, 3);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(87, 24);
            this.DiscountTextBox.TabIndex = 4;
            this.DiscountTextBox.TextChanged += new System.EventHandler(this.DiscountTextBox_TextChanged);
            this.DiscountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiscountTextBox_KeyPress);
            // 
            // shipCostTextBox
            // 
            this.shipCostTextBox.Location = new System.Drawing.Point(439, 3);
            this.shipCostTextBox.Name = "shipCostTextBox";
            this.shipCostTextBox.Size = new System.Drawing.Size(83, 24);
            this.shipCostTextBox.TabIndex = 5;
            this.shipCostTextBox.TextChanged += new System.EventHandler(this.shipCostTextBox_TextChanged);
            this.shipCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shipCostTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 41);
            this.label8.TabIndex = 6;
            this.label8.Text = "Discount";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(298, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 41);
            this.label9.TabIndex = 7;
            this.label9.Text = "Shipping Cost";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Aqua;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46448F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.44887F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.73137F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.66378F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.69151F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.customerNameLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.shipDateTimePicker, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.button1, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.dicountTextBox, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.addressLabel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.ll, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cityLabel, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.phoneLabel, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.shipLabel, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.shippingCostLabel, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.04871F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.48265F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.23432F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.23432F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(578, 155);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customerNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.customerNameLabel.Location = new System.Drawing.Point(98, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(187, 18);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shipping Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // shipDateTimePicker
            // 
            this.shipDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shipDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.shipDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.shipDateTimePicker.Location = new System.Drawing.Point(98, 111);
            this.shipDateTimePicker.Name = "shipDateTimePicker";
            this.shipDateTimePicker.Size = new System.Drawing.Size(187, 24);
            this.shipDateTimePicker.TabIndex = 3;
            this.shipDateTimePicker.Value = new System.DateTime(2015, 1, 15, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(291, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(498, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dicountTextBox
            // 
            this.dicountTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dicountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dicountTextBox.Location = new System.Drawing.Point(376, 111);
            this.dicountTextBox.Name = "dicountTextBox";
            this.dicountTextBox.Size = new System.Drawing.Size(119, 24);
            this.dicountTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addressLabel.Location = new System.Drawing.Point(98, 32);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(187, 31);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "label5";
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ll.Location = new System.Drawing.Point(291, 0);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(79, 32);
            this.ll.TabIndex = 9;
            this.ll.Text = "City";
            this.ll.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cityLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cityLabel.Location = new System.Drawing.Point(376, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(119, 18);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(291, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.phoneLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.phoneLabel.Location = new System.Drawing.Point(376, 32);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(119, 18);
            this.phoneLabel.TabIndex = 12;
            this.phoneLabel.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(291, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Shipping Company";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // shipLabel
            // 
            this.shipLabel.AutoSize = true;
            this.shipLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shipLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.shipLabel.Location = new System.Drawing.Point(376, 63);
            this.shipLabel.Name = "shipLabel";
            this.shipLabel.Size = new System.Drawing.Size(119, 18);
            this.shipLabel.TabIndex = 14;
            this.shipLabel.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(3, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 45);
            this.label7.TabIndex = 15;
            this.label7.Text = "Shipping Cost";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // shippingCostLabel
            // 
            this.shippingCostLabel.AutoSize = true;
            this.shippingCostLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shippingCostLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shippingCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.shippingCostLabel.Location = new System.Drawing.Point(98, 63);
            this.shippingCostLabel.Name = "shippingCostLabel";
            this.shippingCostLabel.Size = new System.Drawing.Size(187, 18);
            this.shippingCostLabel.TabIndex = 16;
            this.shippingCostLabel.Text = "label8";
            // 
            // OrderListView
            // 
            this.OrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.OrderListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.OrderListView.GridLines = true;
            this.OrderListView.Location = new System.Drawing.Point(3, 164);
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.Size = new System.Drawing.Size(578, 282);
            this.OrderListView.TabIndex = 3;
            this.OrderListView.TileSize = new System.Drawing.Size(2, 2);
            this.OrderListView.UseCompatibleStateImageBehavior = false;
            this.OrderListView.View = System.Windows.Forms.View.Details;
            this.OrderListView.SelectedIndexChanged += new System.EventHandler(this.OrderListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Color";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit Price";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            this.columnHeader5.Width = 72;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total";
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker shipDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dicountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label shipLabel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ListView OrderListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button receiptPrintButton;
        private System.Windows.Forms.Button envelopePrintButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ComboBox confirmationComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label shippingCostLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label toatalAmount;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.TextBox shipCostTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}