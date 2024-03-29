﻿namespace ProFormaUI
{
    partial class InvoiceEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceEdit));
            InvoiceNumberTextBox = new TextBox();
            InvoiceNumberLabel = new Label();
            SearchButton = new Button();
            ErrorPlaceholderValueLabel = new Label();
            telephoneValue = new Label();
            contactNameVAlue = new Label();
            telephoneNumberLAbel = new Label();
            contactNameLabel = new Label();
            sapNumberValue = new Label();
            customerSapNumberLabel = new Label();
            eoriNumberValue = new Label();
            EoriNumberLabel = new Label();
            VatNumberValue = new Label();
            VATNumberLabel = new Label();
            CountryValue = new Label();
            CountryLabel = new Label();
            PostCodeValue = new Label();
            PostCodeLabel = new Label();
            CityValue = new Label();
            Address2Value = new Label();
            Address1Value = new Label();
            AddressLine1Label = new Label();
            CustomerNameValueLabel = new Label();
            CustomerNameLabel = new Label();
            dataGridView1 = new DataGridView();
            CloseButton = new Button();
            button1 = new Button();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            printInvoiceToolStripMenuItem = new ToolStripMenuItem();
            updateInvoiceToolStripMenuItem = new ToolStripMenuItem();
            printInvoiceToolStripMenuItem1 = new ToolStripMenuItem();
            deleteInvoiceToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem2 = new ToolStripMenuItem();
            exitToolStripMenuItem3 = new ToolStripMenuItem();
            button3 = new Button();
            button4 = new Button();
            currentHunumberLabel = new Label();
            CurrentHuNumberValue = new Label();
            InvoiceTypeLabel = new Label();
            InvoiceTypeComboBox = new ComboBox();
            KanbanTextBox = new TextBox();
            POtextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // InvoiceNumberTextBox
            // 
            InvoiceNumberTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InvoiceNumberTextBox.Location = new Point(561, 53);
            InvoiceNumberTextBox.Name = "InvoiceNumberTextBox";
            InvoiceNumberTextBox.Size = new Size(229, 27);
            InvoiceNumberTextBox.TabIndex = 54;
            InvoiceNumberTextBox.Text = "Invoice Number";
            InvoiceNumberTextBox.TextChanged += InvoiceNumberTextBox_TextChanged;
            // 
            // InvoiceNumberLabel
            // 
            InvoiceNumberLabel.AutoSize = true;
            InvoiceNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InvoiceNumberLabel.ImeMode = ImeMode.NoControl;
            InvoiceNumberLabel.Location = new Point(389, 57);
            InvoiceNumberLabel.Name = "InvoiceNumberLabel";
            InvoiceNumberLabel.Size = new Size(152, 20);
            InvoiceNumberLabel.TabIndex = 53;
            InvoiceNumberLabel.Text = "Enter Invoice Number";
            // 
            // SearchButton
            // 
            SearchButton.FlatAppearance.MouseDownBackColor = Color.White;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchButton.ImeMode = ImeMode.NoControl;
            SearchButton.Location = new Point(818, 51);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(171, 32);
            SearchButton.TabIndex = 55;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // ErrorPlaceholderValueLabel
            // 
            ErrorPlaceholderValueLabel.AutoSize = true;
            ErrorPlaceholderValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorPlaceholderValueLabel.ForeColor = Color.Red;
            ErrorPlaceholderValueLabel.ImeMode = ImeMode.NoControl;
            ErrorPlaceholderValueLabel.Location = new Point(387, 99);
            ErrorPlaceholderValueLabel.Name = "ErrorPlaceholderValueLabel";
            ErrorPlaceholderValueLabel.Size = new Size(266, 20);
            ErrorPlaceholderValueLabel.TabIndex = 56;
            ErrorPlaceholderValueLabel.Text = "<-------- Error placeholder ----------->";
            // 
            // telephoneValue
            // 
            telephoneValue.AutoSize = true;
            telephoneValue.ImeMode = ImeMode.NoControl;
            telephoneValue.Location = new Point(138, 437);
            telephoneValue.Name = "telephoneValue";
            telephoneValue.Size = new Size(62, 20);
            telephoneValue.TabIndex = 74;
            telephoneValue.Text = "<none>";
            // 
            // contactNameVAlue
            // 
            contactNameVAlue.AutoSize = true;
            contactNameVAlue.ImeMode = ImeMode.NoControl;
            contactNameVAlue.Location = new Point(138, 417);
            contactNameVAlue.Name = "contactNameVAlue";
            contactNameVAlue.Size = new Size(62, 20);
            contactNameVAlue.TabIndex = 73;
            contactNameVAlue.Text = "<none>";
            // 
            // telephoneNumberLAbel
            // 
            telephoneNumberLAbel.AutoSize = true;
            telephoneNumberLAbel.ImeMode = ImeMode.NoControl;
            telephoneNumberLAbel.Location = new Point(54, 437);
            telephoneNumberLAbel.Name = "telephoneNumberLAbel";
            telephoneNumberLAbel.Size = new Size(78, 20);
            telephoneNumberLAbel.TabIndex = 72;
            telephoneNumberLAbel.Text = "Telephone";
            // 
            // contactNameLabel
            // 
            contactNameLabel.AutoSize = true;
            contactNameLabel.ImeMode = ImeMode.NoControl;
            contactNameLabel.Location = new Point(28, 417);
            contactNameLabel.Name = "contactNameLabel";
            contactNameLabel.Size = new Size(104, 20);
            contactNameLabel.TabIndex = 71;
            contactNameLabel.Text = "Contact Name";
            // 
            // sapNumberValue
            // 
            sapNumberValue.AutoSize = true;
            sapNumberValue.ImeMode = ImeMode.NoControl;
            sapNumberValue.Location = new Point(138, 397);
            sapNumberValue.Name = "sapNumberValue";
            sapNumberValue.Size = new Size(62, 20);
            sapNumberValue.TabIndex = 70;
            sapNumberValue.Text = "<none>";
            // 
            // customerSapNumberLabel
            // 
            customerSapNumberLabel.AutoSize = true;
            customerSapNumberLabel.ImeMode = ImeMode.NoControl;
            customerSapNumberLabel.Location = new Point(39, 397);
            customerSapNumberLabel.Name = "customerSapNumberLabel";
            customerSapNumberLabel.Size = new Size(93, 20);
            customerSapNumberLabel.TabIndex = 69;
            customerSapNumberLabel.Text = "SAP Number";
            // 
            // eoriNumberValue
            // 
            eoriNumberValue.AutoSize = true;
            eoriNumberValue.ImeMode = ImeMode.NoControl;
            eoriNumberValue.Location = new Point(138, 377);
            eoriNumberValue.Name = "eoriNumberValue";
            eoriNumberValue.Size = new Size(62, 20);
            eoriNumberValue.TabIndex = 68;
            eoriNumberValue.Text = "<none>";
            // 
            // EoriNumberLabel
            // 
            EoriNumberLabel.AutoSize = true;
            EoriNumberLabel.ImeMode = ImeMode.NoControl;
            EoriNumberLabel.Location = new Point(33, 377);
            EoriNumberLabel.Name = "EoriNumberLabel";
            EoriNumberLabel.Size = new Size(99, 20);
            EoriNumberLabel.TabIndex = 67;
            EoriNumberLabel.Text = "EORI Number";
            // 
            // VatNumberValue
            // 
            VatNumberValue.AutoSize = true;
            VatNumberValue.ImeMode = ImeMode.NoControl;
            VatNumberValue.Location = new Point(138, 357);
            VatNumberValue.Name = "VatNumberValue";
            VatNumberValue.Size = new Size(62, 20);
            VatNumberValue.TabIndex = 66;
            VatNumberValue.Text = "<none>";
            // 
            // VATNumberLabel
            // 
            VATNumberLabel.AutoSize = true;
            VATNumberLabel.ImeMode = ImeMode.NoControl;
            VATNumberLabel.Location = new Point(40, 357);
            VATNumberLabel.Name = "VATNumberLabel";
            VATNumberLabel.Size = new Size(92, 20);
            VATNumberLabel.TabIndex = 65;
            VATNumberLabel.Text = "VAT Number";
            // 
            // CountryValue
            // 
            CountryValue.AutoSize = true;
            CountryValue.ImeMode = ImeMode.NoControl;
            CountryValue.Location = new Point(138, 337);
            CountryValue.Name = "CountryValue";
            CountryValue.Size = new Size(62, 20);
            CountryValue.TabIndex = 64;
            CountryValue.Text = "<none>";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.ImeMode = ImeMode.NoControl;
            CountryLabel.Location = new Point(72, 337);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(60, 20);
            CountryLabel.TabIndex = 63;
            CountryLabel.Text = "Country";
            // 
            // PostCodeValue
            // 
            PostCodeValue.AutoSize = true;
            PostCodeValue.ImeMode = ImeMode.NoControl;
            PostCodeValue.Location = new Point(138, 317);
            PostCodeValue.Name = "PostCodeValue";
            PostCodeValue.Size = new Size(62, 20);
            PostCodeValue.TabIndex = 62;
            PostCodeValue.Text = "<none>";
            // 
            // PostCodeLabel
            // 
            PostCodeLabel.AutoSize = true;
            PostCodeLabel.ImeMode = ImeMode.NoControl;
            PostCodeLabel.Location = new Point(57, 317);
            PostCodeLabel.Name = "PostCodeLabel";
            PostCodeLabel.Size = new Size(75, 20);
            PostCodeLabel.TabIndex = 61;
            PostCodeLabel.Text = "Post Code";
            // 
            // CityValue
            // 
            CityValue.AutoSize = true;
            CityValue.ImeMode = ImeMode.NoControl;
            CityValue.Location = new Point(138, 297);
            CityValue.Name = "CityValue";
            CityValue.Size = new Size(62, 20);
            CityValue.TabIndex = 60;
            CityValue.Text = "<none>";
            // 
            // Address2Value
            // 
            Address2Value.AutoSize = true;
            Address2Value.ImeMode = ImeMode.NoControl;
            Address2Value.Location = new Point(138, 277);
            Address2Value.Name = "Address2Value";
            Address2Value.Size = new Size(62, 20);
            Address2Value.TabIndex = 59;
            Address2Value.Text = "<none>";
            // 
            // Address1Value
            // 
            Address1Value.AutoSize = true;
            Address1Value.ImeMode = ImeMode.NoControl;
            Address1Value.Location = new Point(138, 257);
            Address1Value.Name = "Address1Value";
            Address1Value.Size = new Size(62, 20);
            Address1Value.TabIndex = 58;
            Address1Value.Text = "<none>";
            // 
            // AddressLine1Label
            // 
            AddressLine1Label.AutoSize = true;
            AddressLine1Label.ImeMode = ImeMode.NoControl;
            AddressLine1Label.Location = new Point(70, 257);
            AddressLine1Label.Name = "AddressLine1Label";
            AddressLine1Label.Size = new Size(62, 20);
            AddressLine1Label.TabIndex = 57;
            AddressLine1Label.Text = "Address";
            // 
            // CustomerNameValueLabel
            // 
            CustomerNameValueLabel.AutoSize = true;
            CustomerNameValueLabel.ImeMode = ImeMode.NoControl;
            CustomerNameValueLabel.Location = new Point(138, 237);
            CustomerNameValueLabel.Name = "CustomerNameValueLabel";
            CustomerNameValueLabel.Size = new Size(62, 20);
            CustomerNameValueLabel.TabIndex = 76;
            CustomerNameValueLabel.Text = "<none>";
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.ImeMode = ImeMode.NoControl;
            CustomerNameLabel.Location = new Point(16, 237);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(116, 20);
            CustomerNameLabel.TabIndex = 75;
            CustomerNameLabel.Text = "Customer Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(389, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1109, 611);
            dataGridView1.TabIndex = 77;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.White;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ImeMode = ImeMode.NoControl;
            CloseButton.Location = new Point(1325, 759);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(171, 32);
            CloseButton.TabIndex = 78;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(1147, 759);
            button1.Name = "button1";
            button1.Size = new Size(171, 32);
            button1.TabIndex = 79;
            button1.Text = "Update Invoice";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(565, 759);
            button2.Name = "button2";
            button2.Size = new Size(171, 32);
            button2.TabIndex = 80;
            button2.Text = "Remove Selected";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { printInvoiceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1560, 30);
            menuStrip1.TabIndex = 81;
            menuStrip1.Text = "menuStrip1";
            // 
            // printInvoiceToolStripMenuItem
            // 
            printInvoiceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateInvoiceToolStripMenuItem, printInvoiceToolStripMenuItem1, deleteInvoiceToolStripMenuItem, exitToolStripMenuItem, exitToolStripMenuItem1, exitToolStripMenuItem2, exitToolStripMenuItem3 });
            printInvoiceToolStripMenuItem.Name = "printInvoiceToolStripMenuItem";
            printInvoiceToolStripMenuItem.Size = new Size(60, 24);
            printInvoiceToolStripMenuItem.Text = "Menu";
            // 
            // updateInvoiceToolStripMenuItem
            // 
            updateInvoiceToolStripMenuItem.Name = "updateInvoiceToolStripMenuItem";
            updateInvoiceToolStripMenuItem.Size = new Size(192, 26);
            updateInvoiceToolStripMenuItem.Text = "Update Invoice";
            // 
            // printInvoiceToolStripMenuItem1
            // 
            printInvoiceToolStripMenuItem1.Name = "printInvoiceToolStripMenuItem1";
            printInvoiceToolStripMenuItem1.Size = new Size(192, 26);
            printInvoiceToolStripMenuItem1.Text = "Print Invoice";
            // 
            // deleteInvoiceToolStripMenuItem
            // 
            deleteInvoiceToolStripMenuItem.Name = "deleteInvoiceToolStripMenuItem";
            deleteInvoiceToolStripMenuItem.Size = new Size(192, 26);
            deleteInvoiceToolStripMenuItem.Text = "Delete Invoice";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(192, 26);
            exitToolStripMenuItem.Text = "Remove Item";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(192, 26);
            exitToolStripMenuItem1.Text = "Add Item";
            // 
            // exitToolStripMenuItem2
            // 
            exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            exitToolStripMenuItem2.Size = new Size(192, 26);
            exitToolStripMenuItem2.Text = "Open Folder";
            // 
            // exitToolStripMenuItem3
            // 
            exitToolStripMenuItem3.Name = "exitToolStripMenuItem3";
            exitToolStripMenuItem3.Size = new Size(192, 26);
            exitToolStripMenuItem3.Text = "Exit";
            exitToolStripMenuItem3.Click += exitToolStripMenuItem3_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(389, 759);
            button3.Name = "button3";
            button3.Size = new Size(171, 32);
            button3.TabIndex = 82;
            button3.Text = "Add Item";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.FlatAppearance.MouseDownBackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(971, 759);
            button4.Name = "button4";
            button4.Size = new Size(171, 32);
            button4.TabIndex = 83;
            button4.Text = "Print";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // currentHunumberLabel
            // 
            currentHunumberLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            currentHunumberLabel.AutoSize = true;
            currentHunumberLabel.ImeMode = ImeMode.NoControl;
            currentHunumberLabel.Location = new Point(19, 781);
            currentHunumberLabel.Name = "currentHunumberLabel";
            currentHunumberLabel.Size = new Size(239, 20);
            currentHunumberLabel.TabIndex = 84;
            currentHunumberLabel.Text = "Current number of HU in shipment:";
            // 
            // CurrentHuNumberValue
            // 
            CurrentHuNumberValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CurrentHuNumberValue.AutoSize = true;
            CurrentHuNumberValue.ImeMode = ImeMode.NoControl;
            CurrentHuNumberValue.Location = new Point(264, 781);
            CurrentHuNumberValue.Name = "CurrentHuNumberValue";
            CurrentHuNumberValue.Size = new Size(62, 20);
            CurrentHuNumberValue.TabIndex = 85;
            CurrentHuNumberValue.Text = "<none>";
            // 
            // InvoiceTypeLabel
            // 
            InvoiceTypeLabel.AutoSize = true;
            InvoiceTypeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InvoiceTypeLabel.ImeMode = ImeMode.NoControl;
            InvoiceTypeLabel.Location = new Point(19, 52);
            InvoiceTypeLabel.Name = "InvoiceTypeLabel";
            InvoiceTypeLabel.Size = new Size(94, 20);
            InvoiceTypeLabel.TabIndex = 87;
            InvoiceTypeLabel.Text = "Invoice Type:";
            InvoiceTypeLabel.Click += InvoiceTypeLabel_Click;
            // 
            // InvoiceTypeComboBox
            // 
            InvoiceTypeComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InvoiceTypeComboBox.FormattingEnabled = true;
            InvoiceTypeComboBox.Location = new Point(19, 75);
            InvoiceTypeComboBox.Name = "InvoiceTypeComboBox";
            InvoiceTypeComboBox.Size = new Size(311, 28);
            InvoiceTypeComboBox.TabIndex = 86;
            InvoiceTypeComboBox.SelectedIndexChanged += InvoiceTypeComboBox_SelectedIndexChanged;
            // 
            // KanbanTextBox
            // 
            KanbanTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            KanbanTextBox.Location = new Point(19, 182);
            KanbanTextBox.Name = "KanbanTextBox";
            KanbanTextBox.Size = new Size(311, 27);
            KanbanTextBox.TabIndex = 91;
            KanbanTextBox.Text = "Kanban";
            KanbanTextBox.TextChanged += KanbanTextBox_TextChanged;
            // 
            // POtextBox
            // 
            POtextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            POtextBox.Location = new Point(19, 129);
            POtextBox.Name = "POtextBox";
            POtextBox.Size = new Size(311, 27);
            POtextBox.TabIndex = 90;
            POtextBox.Text = "PO / Ref";
            POtextBox.TextChanged += POtextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(19, 159);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 89;
            label2.Text = "Kanban No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(19, 106);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 88;
            label1.Text = "PO / Ref Number";
            // 
            // InvoiceEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1560, 827);
            Controls.Add(KanbanTextBox);
            Controls.Add(POtextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InvoiceTypeLabel);
            Controls.Add(InvoiceTypeComboBox);
            Controls.Add(CurrentHuNumberValue);
            Controls.Add(currentHunumberLabel);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CloseButton);
            Controls.Add(dataGridView1);
            Controls.Add(CustomerNameValueLabel);
            Controls.Add(CustomerNameLabel);
            Controls.Add(telephoneValue);
            Controls.Add(contactNameVAlue);
            Controls.Add(telephoneNumberLAbel);
            Controls.Add(contactNameLabel);
            Controls.Add(sapNumberValue);
            Controls.Add(customerSapNumberLabel);
            Controls.Add(eoriNumberValue);
            Controls.Add(EoriNumberLabel);
            Controls.Add(VatNumberValue);
            Controls.Add(VATNumberLabel);
            Controls.Add(CountryValue);
            Controls.Add(CountryLabel);
            Controls.Add(PostCodeValue);
            Controls.Add(PostCodeLabel);
            Controls.Add(CityValue);
            Controls.Add(Address2Value);
            Controls.Add(Address1Value);
            Controls.Add(AddressLine1Label);
            Controls.Add(ErrorPlaceholderValueLabel);
            Controls.Add(SearchButton);
            Controls.Add(InvoiceNumberTextBox);
            Controls.Add(InvoiceNumberLabel);
            Controls.Add(menuStrip1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(100, 98);
            Name = "InvoiceEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Invoice";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InvoiceNumberTextBox;
        private Label InvoiceNumberLabel;
        private Button SearchButton;
        private Label ErrorPlaceholderValueLabel;
        private Label telephoneValue;
        private Label contactNameVAlue;
        private Label telephoneNumberLAbel;
        private Label contactNameLabel;
        private Label sapNumberValue;
        private Label customerSapNumberLabel;
        private Label eoriNumberValue;
        private Label EoriNumberLabel;
        private Label VatNumberValue;
        private Label VATNumberLabel;
        private Label CountryValue;
        private Label CountryLabel;
        private Label PostCodeValue;
        private Label PostCodeLabel;
        private Label CityValue;
        private Label Address2Value;
        private Label Address1Value;
        private Label AddressLine1Label;
        private Label CustomerNameValueLabel;
        private Label CustomerNameLabel;
        private DataGridView dataGridView1;
        private Button CloseButton;
        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem printInvoiceToolStripMenuItem;
        private ToolStripMenuItem updateInvoiceToolStripMenuItem;
        private ToolStripMenuItem printInvoiceToolStripMenuItem1;
        private ToolStripMenuItem deleteInvoiceToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem2;
        private ToolStripMenuItem exitToolStripMenuItem3;
        private Button button3;
        private Button button4;
        private Label currentHunumberLabel;
        private Label CurrentHuNumberValue;
        private Label InvoiceTypeLabel;
        private ComboBox InvoiceTypeComboBox;
        private TextBox KanbanTextBox;
        private TextBox POtextBox;
        private Label label2;
        private Label label1;
    }
}