namespace WindowsFormsApplication1
{
    partial class AddNewProductForm
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
            System.Windows.Forms.Button removeButton;
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.submitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.subCategoryLabel2 = new System.Windows.Forms.Label();
            this.subCategoryLabel1 = new System.Windows.Forms.Label();
            this.subCategoryComboBox2 = new System.Windows.Forms.ComboBox();
            this.caltegoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.conditionComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.subCategoryComboBox1 = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.colorListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            removeButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            removeButton.BackColor = System.Drawing.SystemColors.HotTrack;
            removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            removeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            removeButton.Location = new System.Drawing.Point(3, 3);
            removeButton.Name = "removeButton";
            removeButton.Size = new System.Drawing.Size(75, 29);
            removeButton.TabIndex = 27;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += new System.EventHandler(this.delectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel2.Controls.Add(this.submitButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 551);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(674, 30);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.submitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitButton.Location = new System.Drawing.Point(573, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(98, 30);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.79641F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57485F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.14371F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.233533F));
            this.tableLayoutPanel2.Controls.Add(this.nameTextBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.subCategoryLabel2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.subCategoryLabel1, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.subCategoryComboBox2, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.caltegoryLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.categoryComboBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.conditionLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.conditionComboBox, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.descriptionTextBox, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.descriptionLabel, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.subCategoryComboBox1, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.colorComboBox, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.colorLabel, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.961316F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.961316F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.961316F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.961316F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.55706F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.59768F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(668, 515);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nameTextBox.Location = new System.Drawing.Point(168, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 24);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nameLabel.Location = new System.Drawing.Point(69, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 18);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // subCategoryLabel2
            // 
            this.subCategoryLabel2.AutoSize = true;
            this.subCategoryLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.subCategoryLabel2.Location = new System.Drawing.Point(69, 102);
            this.subCategoryLabel2.Name = "subCategoryLabel2";
            this.subCategoryLabel2.Size = new System.Drawing.Size(68, 36);
            this.subCategoryLabel2.TabIndex = 25;
            this.subCategoryLabel2.Text = "Sub Sub Category";
            // 
            // subCategoryLabel1
            // 
            this.subCategoryLabel1.AutoSize = true;
            this.subCategoryLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.subCategoryLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.subCategoryLabel1.Location = new System.Drawing.Point(345, 51);
            this.subCategoryLabel1.Name = "subCategoryLabel1";
            this.subCategoryLabel1.Size = new System.Drawing.Size(77, 36);
            this.subCategoryLabel1.TabIndex = 23;
            this.subCategoryLabel1.Text = "Sub Category";
            // 
            // subCategoryComboBox2
            // 
            this.subCategoryComboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subCategoryComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.subCategoryComboBox2.FormattingEnabled = true;
            this.subCategoryComboBox2.Location = new System.Drawing.Point(168, 105);
            this.subCategoryComboBox2.Name = "subCategoryComboBox2";
            this.subCategoryComboBox2.Size = new System.Drawing.Size(171, 26);
            this.subCategoryComboBox2.TabIndex = 3;
            this.subCategoryComboBox2.SelectedIndexChanged += new System.EventHandler(this.subCategoryComboBox2_SelectedIndexChanged);
            // 
            // caltegoryLabel
            // 
            this.caltegoryLabel.AutoSize = true;
            this.caltegoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.caltegoryLabel.Location = new System.Drawing.Point(69, 51);
            this.caltegoryLabel.Name = "caltegoryLabel";
            this.caltegoryLabel.Size = new System.Drawing.Size(68, 18);
            this.caltegoryLabel.TabIndex = 21;
            this.caltegoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(168, 54);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(171, 26);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.conditionLabel.Location = new System.Drawing.Point(69, 153);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(71, 18);
            this.conditionLabel.TabIndex = 19;
            this.conditionLabel.Text = "Condition";
            // 
            // conditionComboBox
            // 
            this.conditionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conditionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.conditionComboBox.FormattingEnabled = true;
            this.conditionComboBox.Location = new System.Drawing.Point(168, 156);
            this.conditionComboBox.Name = "conditionComboBox";
            this.conditionComboBox.Size = new System.Drawing.Size(171, 26);
            this.conditionComboBox.TabIndex = 5;
            this.conditionComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionTextBox.Location = new System.Drawing.Point(168, 207);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(171, 131);
            this.descriptionTextBox.TabIndex = 6;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.discriptionTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.descriptionLabel.Location = new System.Drawing.Point(69, 204);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 18);
            this.descriptionLabel.TabIndex = 16;
            this.descriptionLabel.Text = "Description";
            // 
            // subCategoryComboBox1
            // 
            this.subCategoryComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subCategoryComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.subCategoryComboBox1.FormattingEnabled = true;
            this.subCategoryComboBox1.Location = new System.Drawing.Point(428, 54);
            this.subCategoryComboBox1.Name = "subCategoryComboBox1";
            this.subCategoryComboBox1.Size = new System.Drawing.Size(180, 26);
            this.subCategoryComboBox1.TabIndex = 2;
            this.subCategoryComboBox1.SelectedIndexChanged += new System.EventHandler(this.subCategoryComboBox1_SelectedIndexChanged);
            // 
            // colorComboBox
            // 
            this.colorComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(428, 156);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(180, 26);
            this.colorComboBox.TabIndex = 4;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.colorListBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(428, 207);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.73737F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.26263F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(180, 182);
            this.tableLayoutPanel3.TabIndex = 26;
            // 
            // colorListBox
            // 
            this.colorListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.colorListBox.FormattingEnabled = true;
            this.colorListBox.ItemHeight = 18;
            this.colorListBox.Location = new System.Drawing.Point(3, 3);
            this.colorListBox.Name = "colorListBox";
            this.colorListBox.Size = new System.Drawing.Size(174, 128);
            this.colorListBox.TabIndex = 9;
            this.colorListBox.SelectedIndexChanged += new System.EventHandler(this.colorListBox_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(removeButton);
            this.flowLayoutPanel1.Controls.Add(this.addButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 137);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(174, 42);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(84, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 29);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.colorLabel.Location = new System.Drawing.Point(345, 153);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(77, 18);
            this.colorLabel.TabIndex = 6;
            this.colorLabel.Text = "Color";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 581);
            this.tableLayoutPanel1.TabIndex = 28;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // AddNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(674, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "AddNewProductForm";
            this.Text = "AddNewProduct";
            this.Load += new System.EventHandler(this.AddNewProduct_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label subCategoryLabel2;
        private System.Windows.Forms.Label subCategoryLabel1;
        private System.Windows.Forms.ComboBox subCategoryComboBox2;
        private System.Windows.Forms.Label caltegoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.ComboBox conditionComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ComboBox subCategoryComboBox1;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox colorListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;



    }
}