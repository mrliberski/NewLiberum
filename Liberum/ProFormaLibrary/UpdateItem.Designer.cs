namespace ProFormaUI
{
    partial class UpdateItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItemForm));
            UpdateButton = new Button();
            BottomFormErrorLAbel = new Label();
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
            NewItemNameTextbox = new TextBox();
            itemNameLabel = new Label();
            CloseButton = new Button();
            ClearButton = new Button();
            ItemNameCombo = new ComboBox();
            newItemNameLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // UpdateButton
            // 
            UpdateButton.FlatAppearance.MouseDownBackColor = Color.White;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.ImeMode = ImeMode.NoControl;
            UpdateButton.Location = new Point(35, 553);
            UpdateButton.Margin = new Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(149, 25);
            UpdateButton.TabIndex = 185;
            UpdateButton.Text = "Update Existing Item";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // BottomFormErrorLAbel
            // 
            BottomFormErrorLAbel.AutoSize = true;
            BottomFormErrorLAbel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            BottomFormErrorLAbel.ForeColor = Color.Red;
            BottomFormErrorLAbel.ImageAlign = ContentAlignment.TopRight;
            BottomFormErrorLAbel.ImeMode = ImeMode.NoControl;
            BottomFormErrorLAbel.Location = new Point(35, 580);
            BottomFormErrorLAbel.Name = "BottomFormErrorLAbel";
            BottomFormErrorLAbel.Size = new Size(210, 15);
            BottomFormErrorLAbel.TabIndex = 184;
            BottomFormErrorLAbel.Text = "<-- error message placeholder label ->";
            BottomFormErrorLAbel.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(newItemNameLabel);
            groupBox1.Controls.Add(ItemNameCombo);
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
            groupBox1.Controls.Add(NewItemNameTextbox);
            groupBox1.Controls.Add(itemNameLabel);
            groupBox1.Location = new Point(35, 14);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(771, 535);
            groupBox1.TabIndex = 183;
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
            CustomerNumberErrorLabel.Location = new Point(476, 108);
            CustomerNumberErrorLabel.Name = "CustomerNumberErrorLabel";
            CustomerNumberErrorLabel.Size = new Size(210, 15);
            CustomerNumberErrorLabel.TabIndex = 183;
            CustomerNumberErrorLabel.Text = "<-- error message placeholder label ->";
            CustomerNumberErrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // CustomerNumberTextBox
            // 
            CustomerNumberTextBox.Location = new Point(188, 128);
            CustomerNumberTextBox.Margin = new Padding(3, 2, 3, 2);
            CustomerNumberTextBox.Name = "CustomerNumberTextBox";
            CustomerNumberTextBox.Size = new Size(282, 23);
            CustomerNumberTextBox.TabIndex = 181;
            CustomerNumberTextBox.Text = "Customer Number";
            // 
            // CustomerNumberLabel
            // 
            CustomerNumberLabel.AutoSize = true;
            CustomerNumberLabel.ImageAlign = ContentAlignment.TopRight;
            CustomerNumberLabel.ImeMode = ImeMode.NoControl;
            CustomerNumberLabel.Location = new Point(74, 131);
            CustomerNumberLabel.Name = "CustomerNumberLabel";
            CustomerNumberLabel.Size = new Size(103, 15);
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
            partNumberErrorLAbel.Location = new Point(476, 85);
            partNumberErrorLAbel.Name = "partNumberErrorLAbel";
            partNumberErrorLAbel.Size = new Size(210, 15);
            partNumberErrorLAbel.TabIndex = 180;
            partNumberErrorLAbel.Text = "<-- error message placeholder label ->";
            partNumberErrorLAbel.TextAlign = ContentAlignment.TopCenter;
            // 
            // PartNumberTextBox
            // 
            PartNumberTextBox.Location = new Point(188, 105);
            PartNumberTextBox.Margin = new Padding(3, 2, 3, 2);
            PartNumberTextBox.Name = "PartNumberTextBox";
            PartNumberTextBox.Size = new Size(282, 23);
            PartNumberTextBox.TabIndex = 178;
            PartNumberTextBox.Text = "Part Number";
            // 
            // PArtNumberLAbel
            // 
            PArtNumberLAbel.AutoSize = true;
            PArtNumberLAbel.ImageAlign = ContentAlignment.TopRight;
            PArtNumberLAbel.ImeMode = ImeMode.NoControl;
            PArtNumberLAbel.Location = new Point(102, 108);
            PArtNumberLAbel.Name = "PArtNumberLAbel";
            PArtNumberLAbel.Size = new Size(75, 15);
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
            LidErrorLAbel.Location = new Point(251, 502);
            LidErrorLAbel.Name = "LidErrorLAbel";
            LidErrorLAbel.Size = new Size(210, 15);
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
            ReqPalletErrorLabel.Location = new Point(251, 470);
            ReqPalletErrorLabel.Name = "ReqPalletErrorLabel";
            ReqPalletErrorLabel.Size = new Size(210, 15);
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
            ReqPackagingErrorLabel.Location = new Point(251, 439);
            ReqPackagingErrorLabel.Name = "ReqPackagingErrorLabel";
            ReqPackagingErrorLabel.Size = new Size(210, 15);
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
            ContainerPerPalletErrorLabel.Location = new Point(476, 384);
            ContainerPerPalletErrorLabel.Name = "ContainerPerPalletErrorLabel";
            ContainerPerPalletErrorLabel.Size = new Size(210, 15);
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
            ContainerPPUerrorLabel.Location = new Point(476, 361);
            ContainerPPUerrorLabel.Name = "ContainerPPUerrorLabel";
            ContainerPPUerrorLabel.Size = new Size(210, 15);
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
            ContainerCOOerrorLabel.Location = new Point(476, 338);
            ContainerCOOerrorLabel.Name = "ContainerCOOerrorLabel";
            ContainerCOOerrorLabel.Size = new Size(210, 15);
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
            ContainerHScodeErrorLabel.Location = new Point(476, 315);
            ContainerHScodeErrorLabel.Name = "ContainerHScodeErrorLabel";
            ContainerHScodeErrorLabel.Size = new Size(210, 15);
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
            ContainerPriceErrorLAbel.Location = new Point(476, 292);
            ContainerPriceErrorLAbel.Name = "ContainerPriceErrorLAbel";
            ContainerPriceErrorLAbel.Size = new Size(210, 15);
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
            ContainerWeightErrorLabel.Location = new Point(475, 269);
            ContainerWeightErrorLabel.Name = "ContainerWeightErrorLabel";
            ContainerWeightErrorLabel.Size = new Size(210, 15);
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
            ContainerCodeErrorLabel.Location = new Point(476, 246);
            ContainerCodeErrorLabel.Name = "ContainerCodeErrorLabel";
            ContainerCodeErrorLabel.Size = new Size(210, 15);
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
            ContainerNameErrolLabel.Location = new Point(476, 223);
            ContainerNameErrolLabel.Name = "ContainerNameErrolLabel";
            ContainerNameErrolLabel.Size = new Size(210, 15);
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
            ItemCOOerrorLAbel.Location = new Point(476, 200);
            ItemCOOerrorLAbel.Name = "ItemCOOerrorLAbel";
            ItemCOOerrorLAbel.Size = new Size(210, 15);
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
            itemHScodeErrorLabel.Location = new Point(476, 177);
            itemHScodeErrorLabel.Name = "itemHScodeErrorLabel";
            itemHScodeErrorLabel.Size = new Size(210, 15);
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
            ItemPPUerrorLabel.Location = new Point(475, 154);
            ItemPPUerrorLabel.Name = "ItemPPUerrorLabel";
            ItemPPUerrorLabel.Size = new Size(210, 15);
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
            ItemNetErrorLabel.Location = new Point(476, 131);
            ItemNetErrorLabel.Name = "ItemNetErrorLabel";
            ItemNetErrorLabel.Size = new Size(210, 15);
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
            ItemNameErrorLabel.Location = new Point(476, 28);
            ItemNameErrorLabel.Name = "ItemNameErrorLabel";
            ItemNameErrorLabel.Size = new Size(210, 15);
            ItemNameErrorLabel.TabIndex = 162;
            ItemNameErrorLabel.Text = "<-- error message placeholder label ->";
            ItemNameErrorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // requiresLidComboBox
            // 
            requiresLidComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            requiresLidComboBox.FormattingEnabled = true;
            requiresLidComboBox.Location = new Point(188, 499);
            requiresLidComboBox.Margin = new Padding(3, 2, 3, 2);
            requiresLidComboBox.Name = "requiresLidComboBox";
            requiresLidComboBox.Size = new Size(58, 23);
            requiresLidComboBox.TabIndex = 119;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.TopRight;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(106, 502);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 161;
            label2.Text = "Requires Lid";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // requiresPalletCombo
            // 
            requiresPalletCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            requiresPalletCombo.FormattingEnabled = true;
            requiresPalletCombo.Location = new Point(188, 467);
            requiresPalletCombo.Margin = new Padding(3, 2, 3, 2);
            requiresPalletCombo.Name = "requiresPalletCombo";
            requiresPalletCombo.Size = new Size(58, 23);
            requiresPalletCombo.TabIndex = 118;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(93, 470);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 159;
            label1.Text = "Requires Pallet";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // requiresPackComboBox
            // 
            requiresPackComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            requiresPackComboBox.FormattingEnabled = true;
            requiresPackComboBox.Location = new Point(188, 436);
            requiresPackComboBox.Margin = new Padding(3, 2, 3, 2);
            requiresPackComboBox.Name = "requiresPackComboBox";
            requiresPackComboBox.Size = new Size(58, 23);
            requiresPackComboBox.TabIndex = 109;
            // 
            // reqPackagingLabel
            // 
            reqPackagingLabel.AutoSize = true;
            reqPackagingLabel.ImageAlign = ContentAlignment.TopRight;
            reqPackagingLabel.ImeMode = ImeMode.NoControl;
            reqPackagingLabel.Location = new Point(67, 439);
            reqPackagingLabel.Name = "reqPackagingLabel";
            reqPackagingLabel.Size = new Size(110, 15);
            reqPackagingLabel.TabIndex = 157;
            reqPackagingLabel.Text = "Requires Packaging";
            reqPackagingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // boxesPerPalletTextBox
            // 
            boxesPerPalletTextBox.Location = new Point(188, 404);
            boxesPerPalletTextBox.Margin = new Padding(3, 2, 3, 2);
            boxesPerPalletTextBox.Name = "boxesPerPalletTextBox";
            boxesPerPalletTextBox.Size = new Size(282, 23);
            boxesPerPalletTextBox.TabIndex = 117;
            boxesPerPalletTextBox.Text = "Boxes Per Pallet";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ImageAlign = ContentAlignment.TopRight;
            label14.ImeMode = ImeMode.NoControl;
            label14.Location = new Point(61, 407);
            label14.Name = "label14";
            label14.Size = new Size(116, 15);
            label14.TabIndex = 151;
            label14.Text = "Containers Per Pallet";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // partsPerBoxTextBox
            // 
            partsPerBoxTextBox.Location = new Point(188, 381);
            partsPerBoxTextBox.Margin = new Padding(3, 2, 3, 2);
            partsPerBoxTextBox.Name = "partsPerBoxTextBox";
            partsPerBoxTextBox.Size = new Size(282, 23);
            partsPerBoxTextBox.TabIndex = 116;
            partsPerBoxTextBox.Text = "Perts per Box";
            // 
            // ppcLabel
            // 
            ppcLabel.AutoSize = true;
            ppcLabel.ImageAlign = ContentAlignment.TopRight;
            ppcLabel.ImeMode = ImeMode.NoControl;
            ppcLabel.Location = new Point(69, 384);
            ppcLabel.Name = "ppcLabel";
            ppcLabel.Size = new Size(108, 15);
            ppcLabel.TabIndex = 149;
            ppcLabel.Text = "Parts Per Container";
            ppcLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // containerCOOtextBox
            // 
            containerCOOtextBox.Location = new Point(188, 358);
            containerCOOtextBox.Margin = new Padding(3, 2, 3, 2);
            containerCOOtextBox.Name = "containerCOOtextBox";
            containerCOOtextBox.Size = new Size(282, 23);
            containerCOOtextBox.TabIndex = 115;
            containerCOOtextBox.Text = "Container COO";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ImageAlign = ContentAlignment.TopRight;
            label12.ImeMode = ImeMode.NoControl;
            label12.Location = new Point(89, 361);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 147;
            label12.Text = "Container COO";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // containerHStextBox
            // 
            containerHStextBox.Location = new Point(188, 335);
            containerHStextBox.Margin = new Padding(3, 2, 3, 2);
            containerHStextBox.Name = "containerHStextBox";
            containerHStextBox.Size = new Size(282, 23);
            containerHStextBox.TabIndex = 114;
            containerHStextBox.Text = "Container HS code";
            // 
            // containerHScodeLabel
            // 
            containerHScodeLabel.AutoSize = true;
            containerHScodeLabel.ImageAlign = ContentAlignment.TopRight;
            containerHScodeLabel.ImeMode = ImeMode.NoControl;
            containerHScodeLabel.Location = new Point(69, 338);
            containerHScodeLabel.Name = "containerHScodeLabel";
            containerHScodeLabel.Size = new Size(108, 15);
            containerHScodeLabel.TabIndex = 145;
            containerHScodeLabel.Text = "Container HS Code";
            containerHScodeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // containerPriceTextBox
            // 
            containerPriceTextBox.Location = new Point(188, 312);
            containerPriceTextBox.Margin = new Padding(3, 2, 3, 2);
            containerPriceTextBox.Name = "containerPriceTextBox";
            containerPriceTextBox.Size = new Size(282, 23);
            containerPriceTextBox.TabIndex = 113;
            containerPriceTextBox.Text = "Container Price";
            // 
            // containerPriceLAbel
            // 
            containerPriceLAbel.AutoSize = true;
            containerPriceLAbel.ImageAlign = ContentAlignment.TopRight;
            containerPriceLAbel.ImeMode = ImeMode.NoControl;
            containerPriceLAbel.Location = new Point(89, 315);
            containerPriceLAbel.Name = "containerPriceLAbel";
            containerPriceLAbel.Size = new Size(88, 15);
            containerPriceLAbel.TabIndex = 143;
            containerPriceLAbel.Text = "Container Price";
            containerPriceLAbel.TextAlign = ContentAlignment.TopCenter;
            // 
            // containerWeightTextBox
            // 
            containerWeightTextBox.Location = new Point(188, 289);
            containerWeightTextBox.Margin = new Padding(3, 2, 3, 2);
            containerWeightTextBox.Name = "containerWeightTextBox";
            containerWeightTextBox.Size = new Size(282, 23);
            containerWeightTextBox.TabIndex = 112;
            containerWeightTextBox.Text = "Container Weight (kg)";
            // 
            // containerWeightLabel
            // 
            containerWeightLabel.AutoSize = true;
            containerWeightLabel.ImageAlign = ContentAlignment.TopRight;
            containerWeightLabel.ImeMode = ImeMode.NoControl;
            containerWeightLabel.Location = new Point(53, 292);
            containerWeightLabel.Name = "containerWeightLabel";
            containerWeightLabel.Size = new Size(124, 15);
            containerWeightLabel.TabIndex = 141;
            containerWeightLabel.Text = "Container Weight (kg)";
            containerWeightLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ContainerCodeTextBox
            // 
            ContainerCodeTextBox.Location = new Point(188, 266);
            ContainerCodeTextBox.Margin = new Padding(3, 2, 3, 2);
            ContainerCodeTextBox.Name = "ContainerCodeTextBox";
            ContainerCodeTextBox.Size = new Size(282, 23);
            ContainerCodeTextBox.TabIndex = 111;
            ContainerCodeTextBox.Text = "Container Code";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ImageAlign = ContentAlignment.TopRight;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(90, 269);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 139;
            label8.Text = "ContainerCode";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // containerNameTextBox
            // 
            containerNameTextBox.Location = new Point(188, 243);
            containerNameTextBox.Margin = new Padding(3, 2, 3, 2);
            containerNameTextBox.Name = "containerNameTextBox";
            containerNameTextBox.Size = new Size(282, 23);
            containerNameTextBox.TabIndex = 110;
            containerNameTextBox.Text = "Container Name";
            // 
            // containerNameLabel
            // 
            containerNameLabel.AutoSize = true;
            containerNameLabel.ImageAlign = ContentAlignment.TopRight;
            containerNameLabel.ImeMode = ImeMode.NoControl;
            containerNameLabel.Location = new Point(83, 246);
            containerNameLabel.Name = "containerNameLabel";
            containerNameLabel.Size = new Size(94, 15);
            containerNameLabel.TabIndex = 137;
            containerNameLabel.Text = "Container Name";
            containerNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // itemCOOtextBox
            // 
            itemCOOtextBox.Location = new Point(188, 220);
            itemCOOtextBox.Margin = new Padding(3, 2, 3, 2);
            itemCOOtextBox.Name = "itemCOOtextBox";
            itemCOOtextBox.Size = new Size(282, 23);
            itemCOOtextBox.TabIndex = 108;
            itemCOOtextBox.Text = "Item COO";
            // 
            // itemCOOlabel
            // 
            itemCOOlabel.AutoSize = true;
            itemCOOlabel.ImageAlign = ContentAlignment.TopRight;
            itemCOOlabel.ImeMode = ImeMode.NoControl;
            itemCOOlabel.Location = new Point(117, 223);
            itemCOOlabel.Name = "itemCOOlabel";
            itemCOOlabel.Size = new Size(60, 15);
            itemCOOlabel.TabIndex = 135;
            itemCOOlabel.Text = "Item COO";
            itemCOOlabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // HScodeTextBox
            // 
            HScodeTextBox.Location = new Point(188, 197);
            HScodeTextBox.Margin = new Padding(3, 2, 3, 2);
            HScodeTextBox.Name = "HScodeTextBox";
            HScodeTextBox.Size = new Size(282, 23);
            HScodeTextBox.TabIndex = 107;
            HScodeTextBox.Text = "Commodity Code";
            // 
            // HScodeLabel
            // 
            HScodeLabel.AutoSize = true;
            HScodeLabel.ImageAlign = ContentAlignment.TopRight;
            HScodeLabel.ImeMode = ImeMode.NoControl;
            HScodeLabel.Location = new Point(124, 200);
            HScodeLabel.Name = "HScodeLabel";
            HScodeLabel.Size = new Size(53, 15);
            HScodeLabel.TabIndex = 133;
            HScodeLabel.Text = "HS Code";
            HScodeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // itemPriceTextBox
            // 
            itemPriceTextBox.Location = new Point(188, 174);
            itemPriceTextBox.Margin = new Padding(3, 2, 3, 2);
            itemPriceTextBox.Name = "itemPriceTextBox";
            itemPriceTextBox.Size = new Size(282, 23);
            itemPriceTextBox.TabIndex = 105;
            itemPriceTextBox.Text = "Item Price";
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.ImageAlign = ContentAlignment.TopRight;
            itemPriceLabel.ImeMode = ImeMode.NoControl;
            itemPriceLabel.Location = new Point(100, 177);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new Size(77, 15);
            itemPriceLabel.TabIndex = 129;
            itemPriceLabel.Text = "Price per unit";
            itemPriceLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // netWeightTextBox
            // 
            netWeightTextBox.Location = new Point(188, 151);
            netWeightTextBox.Margin = new Padding(3, 2, 3, 2);
            netWeightTextBox.Name = "netWeightTextBox";
            netWeightTextBox.Size = new Size(282, 23);
            netWeightTextBox.TabIndex = 103;
            netWeightTextBox.Text = "Net Weight";
            // 
            // netWeightLabel
            // 
            netWeightLabel.AutoSize = true;
            netWeightLabel.ImageAlign = ContentAlignment.TopRight;
            netWeightLabel.ImeMode = ImeMode.NoControl;
            netWeightLabel.Location = new Point(86, 154);
            netWeightLabel.Name = "netWeightLabel";
            netWeightLabel.Size = new Size(91, 15);
            netWeightLabel.TabIndex = 125;
            netWeightLabel.Text = "Net Weight (kg)";
            netWeightLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // selectCustomerComboBox
            // 
            selectCustomerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectCustomerComboBox.FormattingEnabled = true;
            selectCustomerComboBox.Location = new Point(189, 25);
            selectCustomerComboBox.Margin = new Padding(3, 2, 3, 2);
            selectCustomerComboBox.Name = "selectCustomerComboBox";
            selectCustomerComboBox.Size = new Size(281, 23);
            selectCustomerComboBox.TabIndex = 101;
            // 
            // selectCustomerLAbel
            // 
            selectCustomerLAbel.AutoSize = true;
            selectCustomerLAbel.ImeMode = ImeMode.NoControl;
            selectCustomerLAbel.Location = new Point(84, 28);
            selectCustomerLAbel.Name = "selectCustomerLAbel";
            selectCustomerLAbel.Size = new Size(93, 15);
            selectCustomerLAbel.TabIndex = 123;
            selectCustomerLAbel.Text = "Select Customer";
            // 
            // NewItemNameTextbox
            // 
            NewItemNameTextbox.Location = new Point(188, 82);
            NewItemNameTextbox.Margin = new Padding(3, 2, 3, 2);
            NewItemNameTextbox.Name = "NewItemNameTextbox";
            NewItemNameTextbox.Size = new Size(282, 23);
            NewItemNameTextbox.TabIndex = 102;
            NewItemNameTextbox.Text = "Item Name";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.ImageAlign = ContentAlignment.TopRight;
            itemNameLabel.ImeMode = ImeMode.NoControl;
            itemNameLabel.Location = new Point(112, 55);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(65, 15);
            itemNameLabel.TabIndex = 121;
            itemNameLabel.Text = "Select Item";
            itemNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.MouseDownBackColor = Color.White;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ImeMode = ImeMode.NoControl;
            CloseButton.Location = new Point(657, 553);
            CloseButton.Margin = new Padding(3, 2, 3, 2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(149, 25);
            CloseButton.TabIndex = 182;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.FlatAppearance.MouseDownBackColor = Color.White;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.ImeMode = ImeMode.NoControl;
            ClearButton.Location = new Point(189, 553);
            ClearButton.Margin = new Padding(3, 2, 3, 2);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(149, 25);
            ClearButton.TabIndex = 181;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ItemNameCombo
            // 
            ItemNameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemNameCombo.FormattingEnabled = true;
            ItemNameCombo.Location = new Point(189, 52);
            ItemNameCombo.Margin = new Padding(3, 2, 3, 2);
            ItemNameCombo.Name = "ItemNameCombo";
            ItemNameCombo.Size = new Size(281, 23);
            ItemNameCombo.TabIndex = 184;
            // 
            // newItemNameLabel
            // 
            newItemNameLabel.AutoSize = true;
            newItemNameLabel.ImageAlign = ContentAlignment.TopRight;
            newItemNameLabel.ImeMode = ImeMode.NoControl;
            newItemNameLabel.Location = new Point(84, 85);
            newItemNameLabel.Name = "newItemNameLabel";
            newItemNameLabel.Size = new Size(93, 15);
            newItemNameLabel.TabIndex = 185;
            newItemNameLabel.Text = "New Item Name";
            newItemNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.ImageAlign = ContentAlignment.TopRight;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(475, 55);
            label3.Name = "label3";
            label3.Size = new Size(210, 15);
            label3.TabIndex = 186;
            label3.Text = "<-- error message placeholder label ->";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.ImageAlign = ContentAlignment.TopRight;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(476, 407);
            label4.Name = "label4";
            label4.Size = new Size(210, 15);
            label4.TabIndex = 187;
            label4.Text = "<-- error message placeholder label ->";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // UpdateItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(838, 625);
            Controls.Add(UpdateButton);
            Controls.Add(BottomFormErrorLAbel);
            Controls.Add(groupBox1);
            Controls.Add(CloseButton);
            Controls.Add(ClearButton);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(854, 533);
            Name = "UpdateItemForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Item";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateButton;
        private Label BottomFormErrorLAbel;
        private GroupBox groupBox1;
        private Label CustomerNumberErrorLabel;
        private TextBox CustomerNumberTextBox;
        private Label CustomerNumberLabel;
        private Label partNumberErrorLAbel;
        private TextBox PartNumberTextBox;
        private Label PArtNumberLAbel;
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
        private ComboBox requiresLidComboBox;
        private Label label2;
        private ComboBox requiresPalletCombo;
        private Label label1;
        private ComboBox requiresPackComboBox;
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
        private ComboBox selectCustomerComboBox;
        private Label selectCustomerLAbel;
        private TextBox NewItemNameTextbox;
        private Label itemNameLabel;
        private Button CloseButton;
        private Button ClearButton;
        private Label newItemNameLabel;
        private ComboBox ItemNameCombo;
        private Label label4;
        private Label label3;
    }
}