namespace ProFormaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            AvailableItemsComboBox = new ComboBox();
            SelectAvailableLAbel = new Label();
            ItemQtyTextBox = new TextBox();
            PAckagingQtyTextBox = new TextBox();
            label2 = new Label();
            selectedItemNameLabel = new Label();
            label1 = new Label();
            PackagingNameLabel = new Label();
            AddItemButton = new Button();
            Reset = new Button();
            CloseButton = new Button();
            PartsPerContainerLabel = new Label();
            ContainersPerHuLabel = new Label();
            PalletsLabel = new Label();
            PPCtextBox = new TextBox();
            CPPtextBox = new TextBox();
            PalletsTextBox = new TextBox();
            itemNotFondLabel = new Label();
            quantityErrorLabel = new Label();
            PackQtyErrorLabel = new Label();
            PPCerrorLAbel = new Label();
            CPHUerrorLAbel = new Label();
            PalletsErrorLAbel = new Label();
            ItemHScodeLabel = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            PackagingCOOlabel = new Label();
            PackagingHSlabel = new Label();
            PackagingCodeLabel = new Label();
            ItemCOOlabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // AvailableItemsComboBox
            // 
            AvailableItemsComboBox.FormattingEnabled = true;
            AvailableItemsComboBox.Location = new Point(308, 27);
            AvailableItemsComboBox.Name = "AvailableItemsComboBox";
            AvailableItemsComboBox.Size = new Size(477, 28);
            AvailableItemsComboBox.TabIndex = 0;
            AvailableItemsComboBox.SelectedIndexChanged += AvailableItemsComboBox_SelectedIndexChanged;
            // 
            // SelectAvailableLAbel
            // 
            SelectAvailableLAbel.AutoSize = true;
            SelectAvailableLAbel.Location = new Point(35, 30);
            SelectAvailableLAbel.Name = "SelectAvailableLAbel";
            SelectAvailableLAbel.Size = new Size(209, 20);
            SelectAvailableLAbel.TabIndex = 1;
            SelectAvailableLAbel.Text = "Select available item from list:";
            // 
            // ItemQtyTextBox
            // 
            ItemQtyTextBox.Location = new Point(179, 108);
            ItemQtyTextBox.Name = "ItemQtyTextBox";
            ItemQtyTextBox.Size = new Size(65, 27);
            ItemQtyTextBox.TabIndex = 2;
            ItemQtyTextBox.Text = "0";
            ItemQtyTextBox.TextChanged += ItemQtyTextBox_TextChanged;
            // 
            // PAckagingQtyTextBox
            // 
            PAckagingQtyTextBox.Location = new Point(179, 207);
            PAckagingQtyTextBox.Name = "PAckagingQtyTextBox";
            PAckagingQtyTextBox.Size = new Size(65, 27);
            PAckagingQtyTextBox.TabIndex = 37;
            PAckagingQtyTextBox.Text = "0";
            PAckagingQtyTextBox.TextChanged += Hauliertextbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 111);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 38;
            label2.Text = "Enter item quantity:";
            // 
            // selectedItemNameLabel
            // 
            selectedItemNameLabel.AutoSize = true;
            selectedItemNameLabel.Location = new Point(89, 30);
            selectedItemNameLabel.Name = "selectedItemNameLabel";
            selectedItemNameLabel.Size = new Size(100, 20);
            selectedItemNameLabel.TabIndex = 39;
            selectedItemNameLabel.Text = "Selected Item";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 210);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 40;
            label1.Text = "Packaging quantity:";
            // 
            // PackagingNameLabel
            // 
            PackagingNameLabel.AutoSize = true;
            PackagingNameLabel.Location = new Point(89, 90);
            PackagingNameLabel.Name = "PackagingNameLabel";
            PackagingNameLabel.Size = new Size(120, 20);
            PackagingNameLabel.TabIndex = 41;
            PackagingNameLabel.Text = "Packaging Name";
            // 
            // AddItemButton
            // 
            AddItemButton.FlatAppearance.MouseDownBackColor = Color.White;
            AddItemButton.FlatStyle = FlatStyle.Flat;
            AddItemButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddItemButton.ImeMode = ImeMode.NoControl;
            AddItemButton.Location = new Point(39, 297);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(171, 43);
            AddItemButton.TabIndex = 42;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // Reset
            // 
            Reset.FlatAppearance.MouseDownBackColor = Color.White;
            Reset.FlatStyle = FlatStyle.Flat;
            Reset.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Reset.ImeMode = ImeMode.NoControl;
            Reset.Location = new Point(228, 297);
            Reset.Name = "Reset";
            Reset.Size = new Size(171, 43);
            Reset.TabIndex = 43;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.MouseDownBackColor = Color.White;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ImeMode = ImeMode.NoControl;
            CloseButton.Location = new Point(615, 297);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(171, 43);
            CloseButton.TabIndex = 44;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // PartsPerContainerLabel
            // 
            PartsPerContainerLabel.AutoSize = true;
            PartsPerContainerLabel.Location = new Point(35, 144);
            PartsPerContainerLabel.Name = "PartsPerContainerLabel";
            PartsPerContainerLabel.Size = new Size(135, 20);
            PartsPerContainerLabel.TabIndex = 45;
            PartsPerContainerLabel.Text = "Parts Per Container:";
            // 
            // ContainersPerHuLabel
            // 
            ContainersPerHuLabel.AutoSize = true;
            ContainersPerHuLabel.Location = new Point(39, 177);
            ContainersPerHuLabel.Name = "ContainersPerHuLabel";
            ContainersPerHuLabel.Size = new Size(131, 20);
            ContainersPerHuLabel.TabIndex = 46;
            ContainersPerHuLabel.Text = "Containers Per HU:";
            // 
            // PalletsLabel
            // 
            PalletsLabel.AutoSize = true;
            PalletsLabel.Location = new Point(60, 243);
            PalletsLabel.Name = "PalletsLabel";
            PalletsLabel.Size = new Size(110, 20);
            PalletsLabel.TabIndex = 47;
            PalletsLabel.Text = "Handling Units:";
            // 
            // PPCtextBox
            // 
            PPCtextBox.Location = new Point(179, 141);
            PPCtextBox.Name = "PPCtextBox";
            PPCtextBox.Size = new Size(65, 27);
            PPCtextBox.TabIndex = 50;
            PPCtextBox.Text = "0";
            PPCtextBox.TextChanged += PPCtextBox_TextChanged;
            // 
            // CPPtextBox
            // 
            CPPtextBox.Location = new Point(179, 174);
            CPPtextBox.Name = "CPPtextBox";
            CPPtextBox.Size = new Size(65, 27);
            CPPtextBox.TabIndex = 51;
            CPPtextBox.Text = "0";
            CPPtextBox.TextChanged += CPPtextBox_TextChanged;
            // 
            // PalletsTextBox
            // 
            PalletsTextBox.Location = new Point(179, 240);
            PalletsTextBox.Name = "PalletsTextBox";
            PalletsTextBox.Size = new Size(65, 27);
            PalletsTextBox.TabIndex = 52;
            PalletsTextBox.Text = "0";
            PalletsTextBox.TextChanged += PalletsTextBox_TextChanged;
            // 
            // itemNotFondLabel
            // 
            itemNotFondLabel.AutoSize = true;
            itemNotFondLabel.ForeColor = Color.Red;
            itemNotFondLabel.Location = new Point(308, 58);
            itemNotFondLabel.Name = "itemNotFondLabel";
            itemNotFondLabel.Size = new Size(213, 20);
            itemNotFondLabel.TabIndex = 54;
            itemNotFondLabel.Text = "<Item not Found placeholder>";
            // 
            // quantityErrorLabel
            // 
            quantityErrorLabel.AutoSize = true;
            quantityErrorLabel.ForeColor = Color.Red;
            quantityErrorLabel.Location = new Point(250, 111);
            quantityErrorLabel.Name = "quantityErrorLabel";
            quantityErrorLabel.Size = new Size(280, 20);
            quantityErrorLabel.TabIndex = 55;
            quantityErrorLabel.Text = "<quantity must be numeric placeholder>";
            // 
            // PackQtyErrorLabel
            // 
            PackQtyErrorLabel.AutoSize = true;
            PackQtyErrorLabel.ForeColor = Color.Red;
            PackQtyErrorLabel.Location = new Point(250, 210);
            PackQtyErrorLabel.Name = "PackQtyErrorLabel";
            PackQtyErrorLabel.Size = new Size(280, 20);
            PackQtyErrorLabel.TabIndex = 56;
            PackQtyErrorLabel.Text = "<quantity must be numeric placeholder>";
            // 
            // PPCerrorLAbel
            // 
            PPCerrorLAbel.AutoSize = true;
            PPCerrorLAbel.ForeColor = Color.Red;
            PPCerrorLAbel.Location = new Point(250, 145);
            PPCerrorLAbel.Name = "PPCerrorLAbel";
            PPCerrorLAbel.Size = new Size(280, 20);
            PPCerrorLAbel.TabIndex = 57;
            PPCerrorLAbel.Text = "<quantity must be numeric placeholder>";
            // 
            // CPHUerrorLAbel
            // 
            CPHUerrorLAbel.AutoSize = true;
            CPHUerrorLAbel.ForeColor = Color.Red;
            CPHUerrorLAbel.Location = new Point(250, 177);
            CPHUerrorLAbel.Name = "CPHUerrorLAbel";
            CPHUerrorLAbel.Size = new Size(280, 20);
            CPHUerrorLAbel.TabIndex = 58;
            CPHUerrorLAbel.Text = "<quantity must be numeric placeholder>";
            // 
            // PalletsErrorLAbel
            // 
            PalletsErrorLAbel.AutoSize = true;
            PalletsErrorLAbel.ForeColor = Color.Red;
            PalletsErrorLAbel.Location = new Point(250, 243);
            PalletsErrorLAbel.Name = "PalletsErrorLAbel";
            PalletsErrorLAbel.Size = new Size(280, 20);
            PalletsErrorLAbel.TabIndex = 59;
            PalletsErrorLAbel.Text = "<quantity must be numeric placeholder>";
            // 
            // ItemHScodeLabel
            // 
            ItemHScodeLabel.AutoSize = true;
            ItemHScodeLabel.Location = new Point(89, 50);
            ItemHScodeLabel.Name = "ItemHScodeLabel";
            ItemHScodeLabel.Size = new Size(66, 20);
            ItemHScodeLabel.TabIndex = 60;
            ItemHScodeLabel.Text = "Item HS ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PackagingCOOlabel);
            groupBox1.Controls.Add(PackagingHSlabel);
            groupBox1.Controls.Add(PackagingCodeLabel);
            groupBox1.Controls.Add(ItemCOOlabel);
            groupBox1.Controls.Add(selectedItemNameLabel);
            groupBox1.Controls.Add(ItemHScodeLabel);
            groupBox1.Controls.Add(PackagingNameLabel);
            groupBox1.Location = new Point(536, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 183);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Data";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 110);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 71;
            label9.Text = "Code:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 90);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 70;
            label8.Text = "Packaging:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 70);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 69;
            label7.Text = "Origin:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 150);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 68;
            label6.Text = "Origin:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 130);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 67;
            label5.Text = "HS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 50);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 66;
            label4.Text = "HS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 30);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 65;
            label3.Text = "Item:";
            // 
            // PackagingCOOlabel
            // 
            PackagingCOOlabel.AutoSize = true;
            PackagingCOOlabel.Location = new Point(89, 150);
            PackagingCOOlabel.Name = "PackagingCOOlabel";
            PackagingCOOlabel.Size = new Size(111, 20);
            PackagingCOOlabel.TabIndex = 64;
            PackagingCOOlabel.Text = "Packaging COO";
            // 
            // PackagingHSlabel
            // 
            PackagingHSlabel.AutoSize = true;
            PackagingHSlabel.Location = new Point(89, 130);
            PackagingHSlabel.Name = "PackagingHSlabel";
            PackagingHSlabel.Size = new Size(99, 20);
            PackagingHSlabel.TabIndex = 63;
            PackagingHSlabel.Text = "Packaging HS";
            // 
            // PackagingCodeLabel
            // 
            PackagingCodeLabel.AutoSize = true;
            PackagingCodeLabel.Location = new Point(89, 110);
            PackagingCodeLabel.Name = "PackagingCodeLabel";
            PackagingCodeLabel.Size = new Size(115, 20);
            PackagingCodeLabel.TabIndex = 62;
            PackagingCodeLabel.Text = "Packaging Code";
            // 
            // ItemCOOlabel
            // 
            ItemCOOlabel.AutoSize = true;
            ItemCOOlabel.Location = new Point(89, 70);
            ItemCOOlabel.Name = "ItemCOOlabel";
            ItemCOOlabel.Size = new Size(74, 20);
            ItemCOOlabel.TabIndex = 61;
            ItemCOOlabel.Text = "Item COO";
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 378);
            Controls.Add(groupBox1);
            Controls.Add(PalletsErrorLAbel);
            Controls.Add(CPHUerrorLAbel);
            Controls.Add(PPCerrorLAbel);
            Controls.Add(PackQtyErrorLabel);
            Controls.Add(quantityErrorLabel);
            Controls.Add(itemNotFondLabel);
            Controls.Add(PalletsTextBox);
            Controls.Add(CPPtextBox);
            Controls.Add(PPCtextBox);
            Controls.Add(PalletsLabel);
            Controls.Add(ContainersPerHuLabel);
            Controls.Add(PartsPerContainerLabel);
            Controls.Add(CloseButton);
            Controls.Add(Reset);
            Controls.Add(AddItemButton);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(PAckagingQtyTextBox);
            Controls.Add(ItemQtyTextBox);
            Controls.Add(SelectAvailableLAbel);
            Controls.Add(AvailableItemsComboBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Item to Shipment";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox AvailableItemsComboBox;
        private Label SelectAvailableLAbel;
        private TextBox ItemQtyTextBox;
        private TextBox PAckagingQtyTextBox;
        private Label label2;
        private Label selectedItemNameLabel;
        private Label label1;
        private Label PackagingNameLabel;
        private Button AddItemButton;
        private Button Reset;
        private Button CloseButton;
        private Label PartsPerContainerLabel;
        private Label ContainersPerHuLabel;
        private Label PalletsLabel;
        private TextBox PPCtextBox;
        private TextBox CPPtextBox;
        private TextBox PalletsTextBox;
        private Label itemNotFondLabel;
        private Label quantityErrorLabel;
        private Label PackQtyErrorLabel;
        private Label PPCerrorLAbel;
        private Label CPHUerrorLAbel;
        private Label PalletsErrorLAbel;
        private Label ItemHScodeLabel;
        private GroupBox groupBox1;
        private Label PackagingCOOlabel;
        private Label PackagingHSlabel;
        private Label PackagingCodeLabel;
        private Label ItemCOOlabel;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}