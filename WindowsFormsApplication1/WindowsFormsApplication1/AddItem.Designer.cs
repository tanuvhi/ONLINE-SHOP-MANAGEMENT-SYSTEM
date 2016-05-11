namespace WindowsFormsApplication1
{
    partial class AddItem
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
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.colorLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.avaliableQuantity = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CausesValidation = false;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.46626F));
            this.tableLayoutPanel1.Controls.Add(this.itemNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.04728F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 444);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.itemNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.itemNameLabel.Location = new System.Drawing.Point(3, 0);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(481, 50);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "uuu";
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.itemNameLabel.Click += new System.EventHandler(this.itemNameLabel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(481, 351);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.9149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.40426F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.68085F));
            this.tableLayoutPanel3.Controls.Add(this.colorLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.quantityLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.colorComboBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.quantityTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.avaliableQuantity, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.priceLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.priceTextBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.orderByLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.orderComboBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.orderIdLabel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.orderIdTextBox, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(234, 345);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.colorLabel.Location = new System.Drawing.Point(3, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(68, 51);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "Color";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.quantityLabel.Location = new System.Drawing.Point(3, 51);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(68, 51);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colorComboBox
            // 
            this.colorComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(77, 3);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(95, 26);
            this.colorComboBox.TabIndex = 1;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            this.colorComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.colorComboBox_KeyDown);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.quantityTextBox.Location = new System.Drawing.Point(77, 54);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(95, 24);
            this.quantityTextBox.TabIndex = 3;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // avaliableQuantity
            // 
            this.avaliableQuantity.AutoSize = true;
            this.avaliableQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avaliableQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.avaliableQuantity.ForeColor = System.Drawing.Color.Red;
            this.avaliableQuantity.Location = new System.Drawing.Point(178, 51);
            this.avaliableQuantity.Name = "avaliableQuantity";
            this.avaliableQuantity.Size = new System.Drawing.Size(53, 51);
            this.avaliableQuantity.TabIndex = 4;
            this.avaliableQuantity.Text = "label1";
            this.avaliableQuantity.Click += new System.EventHandler(this.avaliableQuantity_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.priceLabel.Location = new System.Drawing.Point(3, 102);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(68, 51);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.priceTextBox.Location = new System.Drawing.Point(77, 105);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(95, 24);
            this.priceTextBox.TabIndex = 6;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // orderByLabel
            // 
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.orderByLabel.Location = new System.Drawing.Point(3, 153);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(68, 51);
            this.orderByLabel.TabIndex = 7;
            this.orderByLabel.Text = "Order By";
            this.orderByLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // orderComboBox
            // 
            this.orderComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Location = new System.Drawing.Point(77, 156);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(95, 26);
            this.orderComboBox.TabIndex = 8;
            this.orderComboBox.SelectedIndexChanged += new System.EventHandler(this.orderComboBox_SelectedIndexChanged);
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.orderIdLabel.Location = new System.Drawing.Point(3, 204);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(68, 51);
            this.orderIdLabel.TabIndex = 9;
            this.orderIdLabel.Text = "Order ID";
            this.orderIdLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.orderIdTextBox.Location = new System.Drawing.Point(77, 207);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(95, 24);
            this.orderIdTextBox.TabIndex = 10;
            this.orderIdTextBox.TextChanged += new System.EventHandler(this.orderIdTextBox_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.cancelButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.addButton, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 407);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(487, 37);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cancelButton.Location = new System.Drawing.Point(3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 31);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.Location = new System.Drawing.Point(404, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 31);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label avaliableQuantity;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label orderByLabel;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.TextBox orderIdTextBox;
    }
}