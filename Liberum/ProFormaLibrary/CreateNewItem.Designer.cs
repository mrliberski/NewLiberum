namespace ProFormaUI
{
    partial class CreateNewItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewItemForm));
            CloseButton = new Button();
            ClearButton = new Button();
            CreateItemButton = new Button();
            itemNameTextbox = new TextBox();
            itemNameLabel = new Label();
            groupBox1 = new GroupBox();
            CustomerNumberErrorLabel = new Label();
            CustomerNumberTextBox = new TextBox();
            CustomerNumberLabel = new Label();
            partNumberErrorLAbel = new Label();
            PartNumberTextBox = new TextBox();
            PArtNumberLAbel = new Label();
            LidErrorLAbel = new Label();
            ReqPalletErrorLabel = new Label();
            ReqPackagingErrorLabel = new Label();
            ContainerPerPalletErrorLabel = new Label();
            ContainerPPUerrorLabel = new Label();
            ContainerCOOerrorLabel = new Label();
            ContainerHScodeErrorLabel = new Label();
            ContainerPriceErrorLAbel = new Label();
            ContainerWeightErrorLabel = new Label();
            ContainerCodeErrorLabel = new Label();
            ContainerNameErrolLabel = new Label();
            ItemCOOerrorLAbel = new Label();
            itemHScodeErrorLabel = new Label();
            ItemPPUerrorLabel = new Label();
            ItemNetErrorLabel = new Label();
            ItemNameErrorLabel = new Label();
            requiresLidComboBox = new ComboBox();
            label2 = new Label();
            requiresPalletCombo = new ComboBox();
            label1 = new Label();
            requiresPackComboBox = new ComboBox();
            reqPackagingLabel = new Label();
            boxesPerPalletTextBox = new TextBox();
            label14 = new Label();
            partsPerBoxTextBox = new TextBox();
            ppcLabel = new Label();
            containerCOOtextBox = new TextBox();
            label12 = new Label();
            containerHStextBox = new TextBox();
            containerHScodeLabel = new Label();
            containerPriceTextBox = new TextBox();
            containerPriceLAbel = new Label();
            containerWeightTextBox = new TextBox();
            containerWeightLabel = new Label();
            ContainerCodeTextBox = new TextBox();
            label8 = new Label();
            containerNameTextBox = new TextBox();
            containerNameLabel = new Label();
            itemCOOtextBox = new TextBox();
            itemCOOlabel = new Label();
            HScodeTextBox = new TextBox();
            HScodeLabel = new Label();
            itemPriceTextBox = new TextBox();
            itemPriceLabel = new Label();
            netWeightTextBox = new TextBox();
            netWeightLabel = new Label();
            selectCustomerComboBox = new ComboBox();
            selectCustomerLAbel = new Label();
            BottomFormErrorLAbel = new Label();
            UpdateButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.MouseDownBackColor = Color.White;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ImeMode = ImeMode.NoControl;
            CloseButton.Location = new Point(738, 664);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(170, 33);
            CloseButton.TabIndex = 122;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.FlatAppearance.MouseDownBackColor = Color.White;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.ImeMode = ImeMode.NoControl;
            ClearButton.Location = new Point(375, 664);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(170, 33);
            ClearButton.TabIndex = 121;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // CreateItemButton
            // 
            CreateItemButton.FlatAppearance.MouseDownBackColor = Color.White;
            CreateItemButton.FlatStyle = FlatStyle.Flat;
            CreateItemButton.ImeMode = ImeMode.NoControl;
            CreateItemButton.Location = new Point(23, 664);
            CreateItemButton.Name = "CreateItemButton";
            CreateItemButton.Size = new Size(170, 33);
            CreateItemButton.TabIndex = 120;
            CreateItemButton.Text = "Create New Item";
            CreateItemButton.UseVisualStyleBackColor = true;
            CreateItemButton.Click += CreateItemButton_Click;
            // 
            // itemNameTextbox
            // 
            itemNameTextbox.Location = new Point(216, 61);
            itemNameTextbox.Name = "itemNameTextbox";
            itemNameTextbox.Size = new Size(322, 27);
            itemNameTextbox.TabIndex = 102;
            itemNameTextbox.Text = "Item Name";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.ImageAlign = ContentAlignment.TopRight;
            itemNameLabel.ImeMode = ImeMode.NoControl;
            itemNameLabel.Location = new Point(102, 64);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(83, 20);
            itemNameLabel.TabIndex = 121;
            itemNameLabel.Text = "Item Name";
            itemNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CustomerNumberErrorLabel);
            groupBox1.Controls.Add(CustomerNumberTextBox);
            groupBox1.Controls.Add(CustomerNumberLabel);
            groupBox1.Controls.Add(partNumberErrorLAbel);
            groupBox1.Controls.Add(PartNumberTextBox);
            groupBox1.Controls.Add(PArtNumberLAbel);
            groupBox1.Controls.Add(LidErrorLAbel);
            groupBox1.Controls.Add(ReqPalletErrorLabel);
            groupBox1.Controls.Add(ReqPackagingErrorLabel);
            groupBox1.Controls.Add(ContainerPerPalletErrorLabel);
            groupBox1.Controls.Add(ContainerPPUerrorLabel);
            groupBox1.Controls.Add(ContainerCOOerrorLabel);
            groupBox1.Controls.Add(ContainerHScodeErrorLabel);
            groupBox1.Controls.Add(ContainerPriceErrorLAbel);
            groupBox1.Controls.Add(ContainerWeightErrorLabel);
            groupBox1.Controls.Add(ContainerCodeErrorLabel);
            groupBox1.Controls.Add(ContainerNameErrolLabel);
            groupBox1.Controls.Add(ItemCOOerrorLAbel);
            groupBox1.Controls.Add(itemHScodeErrorLabel);
            groupBox1.Controls.Add(ItemPPUerrorLabel);
            groupBox1.Controls.Add(ItemNetErrorLabel);
            groupBox1.Controls.Add(ItemNameErrorLabel);
            groupBox1.Controls.Add(requiresLidComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(requiresPalletCombo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(requiresPackComboBox);
            groupBox1.Controls.Add(reqPackagingLabel);
            groupBox1.Controls.Add(boxesPerPalletTextBox);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(partsPerBoxTextBox);
            groupBox1.Controls.Add(ppcLabel);
            groupBox1.Controls.Add(containerCOOtextBox);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(containerHStextBox);
            groupBox1.Controls.Add(containerHScodeLabel);
            groupBox1.Controls.Add(containerPriceTextBox);
            groupBox1.Controls.Add(containerPriceLAbel);
            groupBox1.Controls.Add(containerWeightTextBox);
            groupBox1.Controls.Add(containerWeightLabel);
            groupBox1.Controls.Add(ContainerCodeTextBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(containerNameTextBox);
            groupBox1.Controls.Add(containerNameLabel);
            groupBox1.Controls.Add(itemCOOtextBox);
            groupBox1.Controls.Add(itemCOOlabel);
            groupBox1.Controls.Add(HScodeTextBox);
            groupBox1.Controls.Add(HScodeLabel);
            groupBox1.Controls.Add(itemPriceTextBox);
            groupBox1.Controls.Add(itemPriceLabel);
            groupBox1.Controls.Add(netWeightTextBox);
            groupBox1.Controls.Add(netWeightLabel);
            groupBox1.Controls.Add(selectCustomerComboBox);
            groupBox1.Controls.Add(selectCustomerLAbel);
            groupBox1.Controls.Add(itemNameTextbox);
            groupBox1.Controls.Add(itemNameLabel);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(881, 634);
            groupBox1.TabIndex = 126;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Item Definitions";
            // 
            // CustomerNumberErrorLabel
            // 
            CustomerNumberErrorLabel.AutoSize = true;
            CustomerNumberErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            CustomerNumberErrorLabel.ForeColor = Color.Red;
            CustomerNumberErrorLabel.ImageAlign = ContentAlignment.TopRight;
            CustomerNumberErrorLabel.ImeMode = ImeMode.NoControl;
            CustomerNumberErrorLabel.Location = new Point(545, 118);
            CustomerNumberErrorLabel.Name = "CustomerNumberErrorLabel";
            CustomerNumberErrorLabel.Size = new Size(257, 20);
            CustomerNumberErrorLabel.TabIndex = 183;
            CustomerNumberErrorLabel.Text = "<-- error message placeholder label ->";
            CustomerNumberErrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // CustomerNumberTextBox
            // 
            CustomerNumberTextBox.Location = new Point(216, 115);
            CustomerNumberTextBox.Name = "CustomerNumberTextBox";
            CustomerNumberTextBox.Size = new Size(322, 27);
            CustomerNumberTextBox.TabIndex = 181;
            CustomerNumberTextBox.Text = "Customer Number";
            // 
            // CustomerNumberLabel
            // 
            CustomerNumberLabel.AutoSize = true;
            CustomerNumberLabel.ImageAlign = ContentAlignment.TopRight;
            CustomerNumberLabel.ImeMode = ImeMode.NoControl;
            CustomerNumberLabel.Location = new Point(59, 118);
            CustomerNumberLabel.Name = "CustomerNumberLabel";
            CustomerNumberLabel.Size = new Size(126, 20);
            CustomerNumberLabel.TabIndex = 182;
            CustomerNumberLabel.Text = "CustomerNumber";
            CustomerNumberLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // partNumberErrorLAbel
            // 
            partNumberErrorLAbel.AutoSize = true;
            partNumberErrorLAbel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            partNumberErrorLAbel.ForeColor = Color.Red;
            partNumberErrorLAbel.ImageAlign = ContentAlignment.TopRight;
            partNumberErrorLAbel.ImeMode = ImeMode.NoControl;
            partNumberErrorLAbel.Location = new Point(545, 91);
            partNumberErrorLAbel.Name = "partNumberErrorLAbel";
            partNumberErrorLAbel.Size = new Size(257, 20);
            partNumberErrorLAbel.TabIndex = 180;
            partNumberErrorLAbel.Text = "<-- error message placeholder label ->";
            partNumberErrorLAbel.TextAlign = ContentAlignment.TopCenter;
            // 
            // PartNumberTextBox
            // 
            PartNumberTextBox.Location = new Point(216, 88);
            PartNumberTextBox.Name = "PartNumberTextBox";
            PartNumberTextBox.Size = new Size(322, 27);
            PartNumberTextBox.TabIndex = 178;
            PartNumberTextBox.Text = "Part Number";
            // 
            // PArtNumberLAbel
            // 
            PArtNumberLAbel.AutoSize = true;
            PArtNumberLAbel.ImageAlign = ContentAlignment.TopRight;
            PArtNumberLAbel.ImeMode = ImeMode.NoControl;
            PArtNumberLAbel.Location = new Point(93, 91);
            PArtNumberLAbel.Name = "PArtNumberLAbel";
            PArtNumberLAbel.Size = new Size(92, 20);
            PArtNumberLAbel.TabIndex = 179;
            PArtNumberLAbel.Text = "Part Number";
            PArtNumberLAbel.TextAlign = ContentAlignment.TopCenter;
            // 
            // LidErrorLAbel
            // 
            LidErrorLAbel.AutoSize = true;
            LidErrorLAbel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            LidErrorLAbel.ForeColor = Color.Red;
            LidErrorLAbel.ImageAlign = ContentAlignment.TopRight;
            LidErrorLAbel.ImeMode = ImeMode.NoControl;
            LidErrorLAbel.Location = new Point(288, 549);
            LidErrorLAbel.Name = "LidErrorLAbel";
            LidErrorLAbel.Size = new Size(257, 20);
            LidErrorLAbel.TabIndex = 177;
            LidErrorLAbel.Text = "<-- error message placeholder label ->";
            LidErrorLAbel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ReqPalletErrorLabel
            // 
            ReqPalletErrorLabel.AutoSize = true;
            ReqPalletErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ReqPalletErrorLabel.ForeColor = Color.Red;
            ReqPalletErrorLabel.ImageAlign = ContentAlignment.TopRight;
            ReqPalletErrorLabel.ImeMode = ImeMode.NoControl;
            ReqPalletErrorLabel.Location = new Point(288, 515);
            ReqPalletErrorLabel.Name = "ReqPalletErrorLabel";
            ReqPalletErrorLabel.Size = new Size(257, 20);
            ReqPalletErrorLabel.TabIndex = 176;
            ReqPalletErrorLabel.Text = "<-- error message placeholder label ->";
            ReqPalletErrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ReqPackagingErrorLabel
            // 
            ReqPackagingErrorLabel.AutoSize = true;
            ReqPackagingErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ReqPackagingErrorLabel.ForeColor = Color.Red;
            ReqPackagingErrorLabel.ImageAlign = ContentAlignment.TopRight;
            ReqPackagingErrorLabel.ImeMode = ImeMode.NoControl;
            ReqPackagingErrorLabel.Location = new Point(288, 481);
            ReqPackagingErrorLabel.Name = "ReqPackagingErrorLabel";
            ReqPackagingErrorLabel.Size = new Size(257, 20);
            ReqPackagingErrorLabel.TabIndex = 175;
            ReqPackagingErrorLabel.Text = "<-- error message placeholder label ->";
            ReqPackagingErrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ContainerPerPalletErrorLabel
            // 
            ContainerPerPalletErrorLabel.AutoSize = true;
            ContainerPerPalletErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ContainerPerPalletErrorLabel.ForeColor = Color.Red;
            ContainerPerPalletErrorLabel.ImageAlign = ContentAlignment.TopRight;
            ContainerPerPalletErrorLabel.ImeMode = ImeMode.NoControl;
            ContainerPerPalletErrorLabel.Location = new Point(544, 442);
            ContainerPerPalletErrorLabel.Name = "ContainerPerPalletErrorLabel";
            ContainerPerPalletErrorLabel.Size = new Size(257, 20);
            ContainerPerPalletErrorLabel.TabIndex = 174;
            ContainerPerPalletErrorLabel.Text = "<-- error message placeholder label ->";
            ContainerPerPalletErrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ContainerPPUerrorLabel
            // 
            ContainerPPUerrorLabel.AutoSize = true;
            ContainerPPUerrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ContainerPPUerrorLabel.ForeColor = Color.Red;
            ContainerPPUerrorLabel.ImageAlign = ContentAlignment.TopRight;
            ContainerPPUerrorLabel.ImeMode = ImeMode.NoControl;
            ContainerPPUerrorLabel.Location = new Point(544, 415);
            ContainerPPUerrorLabel.Name = "ContainerPPUerrorLabel";
            ContainerPPUerrorLabel.Size = new Size(257, 20);
            ContainerPPUerrorLabel.TabIndex = 173;
            ContainerPPUerrorLabel.Text = "<-- error message placeholder label ->";
            ContainerPPUerrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ContainerCOOerrorLabel
            // 
            ContainerCOOerrorLabel.AutoSize = true;
            ContainerCOOerrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ContainerCOOerrorLabel.ForeColor = Color.Red;
            ContainerCOOerrorLabel.ImageAlign = ContentAlignment.TopRight;
            ContainerCOOerrorLabel.ImeMode = ImeMode.NoControl;
            ContainerCOOerrorLabel.Location = new Point(545, 388);
            ContainerCOOerrorLabel.Name = "ContainerCOOerrorLabel";
            ContainerCOOerrorLabel.Size = new Size(257, 20);
            ContainerCOOerrorLabel.TabIndex = 172;
            ContainerCOOerrorLabel.Text = "<-- error message placeholder label ->";
            ContainerCOOerrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ContainerHScodeErrorLabel
            // 
            ContainerHScodeErrorLabel.AutoSize = true;
            ContainerHScodeErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ContainerHScodeErrorLabel.ForeColor = Color.Red;
            ContainerHScodeErrorLabel.ImageAlign = ContentAlignment.TopRight;
            ContainerHScodeErrorLabel.ImeMode = ImeMode.NoControl;
            ContainerHScodeErrorLabel.Location = new Point(544, 361);
            ContainerHScodeErrorLabel.Name = "ContainerHScodeErrorLabel";
            ContainerHScodeErrorLabel.Size = new Size(257, 20);
            ContainerHScodeErrorLabel.TabIndex = 171;
            ContainerHScodeErrorLabel.Text = "<-- error message placeholder label ->";
            ContainerHScodeErrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ContainerPriceErrorLAbel
            // 
            ContainerPriceErrorLAbel.AutoSize = true;
            ContainerPriceErrorLAbel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ContainerPriceErrorLAbel.ForeColor = Color.Red;
            ContainerPriceErrorLAbel.ImageAlign = ContentAlignment.TopRight;
            ContainerPriceErrorLAbel.ImeMode = ImeMode.NoControl;
            ContainerPriceErrorLAbel.Location = new Point(544, 334);
            ContainerPriceErrorLAbel.Name = "ContainerPriceErrorLAbel";
            ContainerPriceErrorLAbel.Size = new Size(257, 20);
            ContainerPriceErrorLAbel.TabIndex = 170;
            ContainerPriceErrorLAbel.Text = "<-- error message placeholder label ->";
            ContainerPriceErrorLAbel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ContainerWeightErrorLabel
            // 
            ContainerWeightErrorLabel.AutoSize = true;
            ContainerWeightErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ContainerWeightErrorLabel.ForeColor = Color.Red;
            ContainerWeightErrorLabel.ImageAlign = ContentAlignment.TopRight;
            ContainerWeightErrorLabel.ImeMode = ImeMode.NoControl;
            ContainerWeightErrorLabel.Location = new Point(544, 307);
            ContainerWeightErrorLabel.Name = "ContainerWeightErrorLabel";
            ContainerWeightErrorLabel.Size = new Size(257, 20);
            ContainerWeightErrorLabel.TabIndex = 169;
            ContainerWeightErrorLabel.Text = "<-- error message placeholder label ->";
            ContainerWeightErrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ContainerCodeErrorLabel
            // 
            ContainerCodeErrorLabel.AutoSize = true;
            ContainerCodeErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ContainerCodeErrorLabel.ForeColor = Color.Red;
            ContainerCodeErrorLabel.ImageAlign = ContentAlignment.TopRight;
            ContainerCodeErrorLabel.ImeMode = ImeMode.NoControl;
            ContainerCodeErrorLabel.Location = new Point(544, 280);
            ContainerCodeErrorLabel.Name = "ContainerCodeErrorLabel";
            ContainerCodeErrorLabel.Size = new Size(257, 20);
            ContainerCodeErrorLabel.TabIndex = 168;
            ContainerCodeErrorLabel.Text = "<-- error message placeholder label ->";
            ContainerCodeErrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ContainerNameErrolLabel
            // 
            ContainerNameErrolLabel.AutoSize = true;
            ContainerNameErrolLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ContainerNameErrolLabel.ForeColor = Color.Red;
            ContainerNameErrolLabel.ImageAlign = ContentAlignment.TopRight;
            ContainerNameErrolLabel.ImeMode = ImeMode.NoControl;
            ContainerNameErrolLabel.Location = new Point(544, 253);
            ContainerNameErrolLabel.Name = "ContainerNameErrolLabel";
            ContainerNameErrolLabel.Size = new Size(257, 20);
            ContainerNameErrolLabel.TabIndex = 167;
            ContainerNameErrolLabel.Text = "<-- error message placeholder label ->";
            ContainerNameErrolLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ItemCOOerrorLAbel
            // 
            ItemCOOerrorLAbel.AutoSize = true;
            ItemCOOerrorLAbel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ItemCOOerrorLAbel.ForeColor = Color.Red;
            ItemCOOerrorLAbel.ImageAlign = ContentAlignment.TopRight;
            ItemCOOerrorLAbel.ImeMode = ImeMode.NoControl;
            ItemCOOerrorLAbel.Location = new Point(545, 226);
            ItemCOOerrorLAbel.Name = "ItemCOOerrorLAbel";
            ItemCOOerrorLAbel.Size = new Size(257, 20);
            ItemCOOerrorLAbel.TabIndex = 166;
            ItemCOOerrorLAbel.Text = "<-- error message placeholder label ->";
            ItemCOOerrorLAbel.TextAlign = ContentAlignment.TopCenter;
            // 
            // itemHScodeErrorLabel
            // 
            itemHScodeErrorLabel.AutoSize = true;
            itemHScodeErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            itemHScodeErrorLabel.ForeColor = Color.Red;
            itemHScodeErrorLabel.ImageAlign = ContentAlignment.TopRight;
            itemHScodeErrorLabel.ImeMode = ImeMode.NoControl;
            itemHScodeErrorLabel.Location = new Point(544, 199);
            itemHScodeErrorLabel.Name = "itemHScodeErrorLabel";
            itemHScodeErrorLabel.Size = new Size(257, 20);
            itemHScodeErrorLabel.TabIndex = 165;
            itemHScodeErrorLabel.Text = "<-- error message placeholder label ->";
            itemHScodeErrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ItemPPUerrorLabel
            // 
            ItemPPUerrorLabel.AutoSize = true;
            ItemPPUerrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ItemPPUerrorLabel.ForeColor = Color.Red;
            ItemPPUerrorLabel.ImageAlign = ContentAlignment.TopRight;
            ItemPPUerrorLabel.ImeMode = ImeMode.NoControl;
            ItemPPUerrorLabel.Location = new Point(545, 172);
            ItemPPUerrorLabel.Name = "ItemPPUerrorLabel";
            ItemPPUerrorLabel.Size = new Size(257, 20);
            ItemPPUerrorLabel.TabIndex = 164;
            ItemPPUerrorLabel.Text = "<-- error message placeholder label ->";
            ItemPPUerrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ItemNetErrorLabel
            // 
            ItemNetErrorLabel.AutoSize = true;
            ItemNetErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ItemNetErrorLabel.ForeColor = Color.Red;
            ItemNetErrorLabel.ImageAlign = ContentAlignment.TopRight;
            ItemNetErrorLabel.ImeMode = ImeMode.NoControl;
            ItemNetErrorLabel.Location = new Point(544, 145);
            ItemNetErrorLabel.Name = "ItemNetErrorLabel";
            ItemNetErrorLabel.Size = new Size(257, 20);
            ItemNetErrorLabel.TabIndex = 163;
            ItemNetErrorLabel.Text = "<-- error message placeholder label ->";
            ItemNetErrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ItemNameErrorLabel
            // 
            ItemNameErrorLabel.AutoSize = true;
            ItemNameErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ItemNameErrorLabel.ForeColor = Color.Red;
            ItemNameErrorLabel.ImageAlign = ContentAlignment.TopRight;
            ItemNameErrorLabel.ImeMode = ImeMode.NoControl;
            ItemNameErrorLabel.Location = new Point(544, 64);
            ItemNameErrorLabel.Name = "ItemNameErrorLabel";
            ItemNameErrorLabel.Size = new Size(257, 20);
            ItemNameErrorLabel.TabIndex = 162;
            ItemNameErrorLabel.Text = "<-- error message placeholder label ->";
            ItemNameErrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // requiresLidComboBox
            // 
            requiresLidComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            requiresLidComboBox.FormattingEnabled = true;
            requiresLidComboBox.Location = new Point(216, 546);
            requiresLidComboBox.Name = "requiresLidComboBox";
            requiresLidComboBox.Size = new Size(66, 28);
            requiresLidComboBox.TabIndex = 119;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.TopRight;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(95, 549);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 161;
            label2.Text = "Requires Lid";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // requiresPalletCombo
            // 
            requiresPalletCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            requiresPalletCombo.FormattingEnabled = true;
            requiresPalletCombo.Location = new Point(216, 512);
            requiresPalletCombo.Name = "requiresPalletCombo";
            requiresPalletCombo.Size = new Size(66, 28);
            requiresPalletCombo.TabIndex = 118;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(79, 515);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 159;
            label1.Text = "Requires Pallet";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // requiresPackComboBox
            // 
            requiresPackComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            requiresPackComboBox.FormattingEnabled = true;
            requiresPackComboBox.Location = new Point(216, 478);
            requiresPackComboBox.Name = "requiresPackComboBox";
            requiresPackComboBox.Size = new Size(66, 28);
            requiresPackComboBox.TabIndex = 109;
            // 
            // reqPackagingLabel
            // 
            reqPackagingLabel.AutoSize = true;
            reqPackagingLabel.ImageAlign = ContentAlignment.TopRight;
            reqPackagingLabel.ImeMode = ImeMode.NoControl;
            reqPackagingLabel.Location = new Point(48, 481);
            reqPackagingLabel.Name = "reqPackagingLabel";
            reqPackagingLabel.Size = new Size(137, 20);
            reqPackagingLabel.TabIndex = 157;
            reqPackagingLabel.Text = "Requires Packaging";
            reqPackagingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // boxesPerPalletTextBox
            // 
            boxesPerPalletTextBox.Location = new Point(216, 439);
            boxesPerPalletTextBox.Name = "boxesPerPalletTextBox";
            boxesPerPalletTextBox.Size = new Size(322, 27);
            boxesPerPalletTextBox.TabIndex = 117;
            boxesPerPalletTextBox.Text = "Boxes Per Pallet";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ImageAlign = ContentAlignment.TopRight;
            label14.ImeMode = ImeMode.NoControl;
            label14.Location = new Point(42, 442);
            label14.Name = "label14";
            label14.Size = new Size(143, 20);
            label14.TabIndex = 151;
            label14.Text = "Containers Per Pallet";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // partsPerBoxTextBox
            // 
            partsPerBoxTextBox.Location = new Point(216, 412);
            partsPerBoxTextBox.Name = "partsPerBoxTextBox";
            partsPerBoxTextBox.Size = new Size(322, 27);
            partsPerBoxTextBox.TabIndex = 116;
            partsPerBoxTextBox.Text = "Perts per Box";
            // 
            // ppcLabel
            // 
            ppcLabel.AutoSize = true;
            ppcLabel.ImageAlign = ContentAlignment.TopRight;
            ppcLabel.ImeMode = ImeMode.NoControl;
            ppcLabel.Location = new Point(53, 415);
            ppcLabel.Name = "ppcLabel";
            ppcLabel.Size = new Size(132, 20);
            ppcLabel.TabIndex = 149;
            ppcLabel.Text = "Parts Per Container";
            ppcLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // containerCOOtextBox
            // 
            containerCOOtextBox.Location = new Point(216, 385);
            containerCOOtextBox.Name = "containerCOOtextBox";
            containerCOOtextBox.Size = new Size(322, 27);
            containerCOOtextBox.TabIndex = 115;
            containerCOOtextBox.Text = "Container COO";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ImageAlign = ContentAlignment.TopRight;
            label12.ImeMode = ImeMode.NoControl;
            label12.Location = new Point(77, 388);
            label12.Name = "label12";
            label12.Size = new Size(108, 20);
            label12.TabIndex = 147;
            label12.Text = "Container COO";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // containerHStextBox
            // 
            containerHStextBox.Location = new Point(216, 358);
            containerHStextBox.Name = "containerHStextBox";
            containerHStextBox.Size = new Size(322, 27);
            containerHStextBox.TabIndex = 114;
            containerHStextBox.Text = "Container HS code";
            // 
            // containerHScodeLabel
            // 
            containerHScodeLabel.AutoSize = true;
            containerHScodeLabel.ImageAlign = ContentAlignment.TopRight;
            containerHScodeLabel.ImeMode = ImeMode.NoControl;
            containerHScodeLabel.Location = new Point(50, 361);
            containerHScodeLabel.Name = "containerHScodeLabel";
            containerHScodeLabel.Size = new Size(135, 20);
            containerHScodeLabel.TabIndex = 145;
            containerHScodeLabel.Text = "Container HS Code";
            containerHScodeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // containerPriceTextBox
            // 
            containerPriceTextBox.Location = new Point(216, 331);
            containerPriceTextBox.Name = "containerPriceTextBox";
            containerPriceTextBox.Size = new Size(322, 27);
            containerPriceTextBox.TabIndex = 113;
            containerPriceTextBox.Text = "Container Price";
            // 
            // containerPriceLAbel
            // 
            containerPriceLAbel.AutoSize = true;
            containerPriceLAbel.ImageAlign = ContentAlignment.TopRight;
            containerPriceLAbel.ImeMode = ImeMode.NoControl;
            containerPriceLAbel.Location = new Point(76, 334);
            containerPriceLAbel.Name = "containerPriceLAbel";
            containerPriceLAbel.Size = new Size(109, 20);
            containerPriceLAbel.TabIndex = 143;
            containerPriceLAbel.Text = "Container Price";
            containerPriceLAbel.TextAlign = ContentAlignment.TopCenter;
            // 
            // containerWeightTextBox
            // 
            containerWeightTextBox.Location = new Point(216, 304);
            containerWeightTextBox.Name = "containerWeightTextBox";
            containerWeightTextBox.Size = new Size(322, 27);
            containerWeightTextBox.TabIndex = 112;
            containerWeightTextBox.Text = "Container Weight (kg)";
            // 
            // containerWeightLabel
            // 
            containerWeightLabel.AutoSize = true;
            containerWeightLabel.ImageAlign = ContentAlignment.TopRight;
            containerWeightLabel.ImeMode = ImeMode.NoControl;
            containerWeightLabel.Location = new Point(31, 307);
            containerWeightLabel.Name = "containerWeightLabel";
            containerWeightLabel.Size = new Size(154, 20);
            containerWeightLabel.TabIndex = 141;
            containerWeightLabel.Text = "Container Weight (kg)";
            containerWeightLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ContainerCodeTextBox
            // 
            ContainerCodeTextBox.Location = new Point(216, 277);
            ContainerCodeTextBox.Name = "ContainerCodeTextBox";
            ContainerCodeTextBox.Size = new Size(322, 27);
            ContainerCodeTextBox.TabIndex = 111;
            ContainerCodeTextBox.Text = "Container Code";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ImageAlign = ContentAlignment.TopRight;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(77, 280);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 139;
            label8.Text = "ContainerCode";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // containerNameTextBox
            // 
            containerNameTextBox.Location = new Point(216, 250);
            containerNameTextBox.Name = "containerNameTextBox";
            containerNameTextBox.Size = new Size(322, 27);
            containerNameTextBox.TabIndex = 110;
            containerNameTextBox.Text = "Container Name";
            // 
            // containerNameLabel
            // 
            containerNameLabel.AutoSize = true;
            containerNameLabel.ImageAlign = ContentAlignment.TopRight;
            containerNameLabel.ImeMode = ImeMode.NoControl;
            containerNameLabel.Location = new Point(68, 253);
            containerNameLabel.Name = "containerNameLabel";
            containerNameLabel.Size = new Size(117, 20);
            containerNameLabel.TabIndex = 137;
            containerNameLabel.Text = "Container Name";
            containerNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // itemCOOtextBox
            // 
            itemCOOtextBox.Location = new Point(216, 223);
            itemCOOtextBox.Name = "itemCOOtextBox";
            itemCOOtextBox.Size = new Size(322, 27);
            itemCOOtextBox.TabIndex = 108;
            itemCOOtextBox.Text = "Item COO";
            // 
            // itemCOOlabel
            // 
            itemCOOlabel.AutoSize = true;
            itemCOOlabel.ImageAlign = ContentAlignment.TopRight;
            itemCOOlabel.ImeMode = ImeMode.NoControl;
            itemCOOlabel.Location = new Point(111, 226);
            itemCOOlabel.Name = "itemCOOlabel";
            itemCOOlabel.Size = new Size(74, 20);
            itemCOOlabel.TabIndex = 135;
            itemCOOlabel.Text = "Item COO";
            itemCOOlabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // HScodeTextBox
            // 
            HScodeTextBox.Location = new Point(216, 196);
            HScodeTextBox.Name = "HScodeTextBox";
            HScodeTextBox.Size = new Size(322, 27);
            HScodeTextBox.TabIndex = 107;
            HScodeTextBox.Text = "Commodity Code";
            // 
            // HScodeLabel
            // 
            HScodeLabel.AutoSize = true;
            HScodeLabel.ImageAlign = ContentAlignment.TopRight;
            HScodeLabel.ImeMode = ImeMode.NoControl;
            HScodeLabel.Location = new Point(118, 199);
            HScodeLabel.Name = "HScodeLabel";
            HScodeLabel.Size = new Size(67, 20);
            HScodeLabel.TabIndex = 133;
            HScodeLabel.Text = "HS Code";
            HScodeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // itemPriceTextBox
            // 
            itemPriceTextBox.Location = new Point(216, 169);
            itemPriceTextBox.Name = "itemPriceTextBox";
            itemPriceTextBox.Size = new Size(322, 27);
            itemPriceTextBox.TabIndex = 105;
            itemPriceTextBox.Text = "Item Price";
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.ImageAlign = ContentAlignment.TopRight;
            itemPriceLabel.ImeMode = ImeMode.NoControl;
            itemPriceLabel.Location = new Point(89, 172);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new Size(96, 20);
            itemPriceLabel.TabIndex = 129;
            itemPriceLabel.Text = "Price per unit";
            itemPriceLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // netWeightTextBox
            // 
            netWeightTextBox.Location = new Point(216, 142);
            netWeightTextBox.Name = "netWeightTextBox";
            netWeightTextBox.Size = new Size(322, 27);
            netWeightTextBox.TabIndex = 103;
            netWeightTextBox.Text = "Net Weight";
            // 
            // netWeightLabel
            // 
            netWeightLabel.AutoSize = true;
            netWeightLabel.ImageAlign = ContentAlignment.TopRight;
            netWeightLabel.ImeMode = ImeMode.NoControl;
            netWeightLabel.Location = new Point(71, 145);
            netWeightLabel.Name = "netWeightLabel";
            netWeightLabel.Size = new Size(114, 20);
            netWeightLabel.TabIndex = 125;
            netWeightLabel.Text = "Net Weight (kg)";
            netWeightLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // selectCustomerComboBox
            // 
            selectCustomerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectCustomerComboBox.FormattingEnabled = true;
            selectCustomerComboBox.Location = new Point(216, 33);
            selectCustomerComboBox.Name = "selectCustomerComboBox";
            selectCustomerComboBox.Size = new Size(321, 28);
            selectCustomerComboBox.TabIndex = 101;
            // 
            // selectCustomerLAbel
            // 
            selectCustomerLAbel.AutoSize = true;
            selectCustomerLAbel.ImeMode = ImeMode.NoControl;
            selectCustomerLAbel.Location = new Point(69, 36);
            selectCustomerLAbel.Name = "selectCustomerLAbel";
            selectCustomerLAbel.Size = new Size(116, 20);
            selectCustomerLAbel.TabIndex = 123;
            selectCustomerLAbel.Text = "Select Customer";
            // 
            // BottomFormErrorLAbel
            // 
            BottomFormErrorLAbel.AutoSize = true;
            BottomFormErrorLAbel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            BottomFormErrorLAbel.ForeColor = Color.Red;
            BottomFormErrorLAbel.ImageAlign = ContentAlignment.TopRight;
            BottomFormErrorLAbel.ImeMode = ImeMode.NoControl;
            BottomFormErrorLAbel.Location = new Point(23, 710);
            BottomFormErrorLAbel.Name = "BottomFormErrorLAbel";
            BottomFormErrorLAbel.Size = new Size(257, 20);
            BottomFormErrorLAbel.TabIndex = 178;
            BottomFormErrorLAbel.Text = "<-- error message placeholder label ->";
            BottomFormErrorLAbel.TextAlign = ContentAlignment.TopCenter;
            // 
            // UpdateButton
            // 
            UpdateButton.FlatAppearance.MouseDownBackColor = Color.White;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.ImeMode = ImeMode.NoControl;
            UpdateButton.Location = new Point(199, 664);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(170, 33);
            UpdateButton.TabIndex = 179;
            UpdateButton.Text = "Update Existing Item";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // CreateNewItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(958, 791);
            Controls.Add(UpdateButton);
            Controls.Add(BottomFormErrorLAbel);
            Controls.Add(groupBox1);
            Controls.Add(CloseButton);
            Controls.Add(ClearButton);
            Controls.Add(CreateItemButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(973, 695);
            Name = "CreateNewItemForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create New Item";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseButton;
        private Button ClearButton;
        private Button CreateItemButton;
        private TextBox itemNameTextbox;
        private Label itemNameLabel;
        private GroupBox groupBox1;
        private ComboBox selectCustomerComboBox;
        private Label selectCustomerLAbel;
        private Label reqPackagingLabel;
        private TextBox boxesPerPalletTextBox;
        private Label label14;
        private TextBox partsPerBoxTextBox;
        private Label ppcLabel;
        private TextBox containerCOOtextBox;
        private Label label12;
        private TextBox containerHStextBox;
        private Label containerHScodeLabel;
        private TextBox containerPriceTextBox;
        private Label containerPriceLAbel;
        private TextBox containerWeightTextBox;
        private Label containerWeightLabel;
        private TextBox ContainerCodeTextBox;
        private Label label8;
        private TextBox containerNameTextBox;
        private Label containerNameLabel;
        private TextBox itemCOOtextBox;
        private Label itemCOOlabel;
        private TextBox HScodeTextBox;
        private Label HScodeLabel;
        private TextBox itemPriceTextBox;
        private Label itemPriceLabel;
        private TextBox netWeightTextBox;
        private Label netWeightLabel;
        private ComboBox requiresPackComboBox;
        private ComboBox requiresLidComboBox;
        private Label label2;
        private ComboBox requiresPalletCombo;
        private Label label1;
        private Label LidErrorLAbel;
        private Label ReqPalletErrorLabel;
        private Label ReqPackagingErrorLabel;
        private Label ContainerPerPalletErrorLabel;
        private Label ContainerPPUerrorLabel;
        private Label ContainerCOOerrorLabel;
        private Label ContainerHScodeErrorLabel;
        private Label ContainerPriceErrorLAbel;
        private Label ContainerWeightErrorLabel;
        private Label ContainerCodeErrorLabel;
        private Label ContainerNameErrolLabel;
        private Label ItemCOOerrorLAbel;
        private Label itemHScodeErrorLabel;
        private Label ItemPPUerrorLabel;
        private Label ItemNetErrorLabel;
        private Label ItemNameErrorLabel;
        private Label BottomFormErrorLAbel;
        private Label CustomerNumberErrorLabel;
        private TextBox CustomerNumberTextBox;
        private Label CustomerNumberLabel;
        private Label partNumberErrorLAbel;
        private TextBox PartNumberTextBox;
        private Label PArtNumberLAbel;
        private Button UpdateButton;
    }
}