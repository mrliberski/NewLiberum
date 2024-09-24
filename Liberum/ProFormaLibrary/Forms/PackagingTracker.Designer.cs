namespace ProFormaUI.Forms
{
    partial class PackagingTracker
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
            AddPlusNewDeliveryButton = new Button();
            addButton = new Button();
            label1 = new Label();
            label2 = new Label();
            errorLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            deliveryTimeTextBox = new TextBox();
            label5 = new Label();
            deliveryNoTextBox = new TextBox();
            label6 = new Label();
            packagingCodeTextBox = new TextBox();
            label7 = new Label();
            advisedQtyTextBox = new TextBox();
            label8 = new Label();
            receivedQtyTextBox = new TextBox();
            label9 = new Label();
            commentTextBox = new TextBox();
            addPlusNewEntryButton = new Button();
            NewDeliveryButton = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            label3 = new Label();
            searchDeliveryTextBox = new TextBox();
            label4 = new Label();
            searchPackagingTextBox = new TextBox();
            SearchErrorLabel = new Label();
            RegTextBox = new TextBox();
            label10 = new Label();
            ExportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AddPlusNewDeliveryButton
            // 
            AddPlusNewDeliveryButton.FlatStyle = FlatStyle.Flat;
            AddPlusNewDeliveryButton.Location = new Point(38, 516);
            AddPlusNewDeliveryButton.Name = "AddPlusNewDeliveryButton";
            AddPlusNewDeliveryButton.Size = new Size(354, 36);
            AddPlusNewDeliveryButton.TabIndex = 11;
            AddPlusNewDeliveryButton.Text = "Add + New Delivery";
            AddPlusNewDeliveryButton.UseVisualStyleBackColor = true;
            AddPlusNewDeliveryButton.Click += AddPlusNewDeliveryButton_Click;
            // 
            // addButton
            // 
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Location = new Point(38, 432);
            addButton.Name = "addButton";
            addButton.Size = new Size(354, 36);
            addButton.TabIndex = 9;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 99);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 65;
            label1.Text = "Delivery Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 67);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 66;
            label2.Text = "Delivery Date";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Crimson;
            errorLabel.Location = new Point(39, 22);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(169, 20);
            errorLabel.TabIndex = 68;
            errorLabel.Text = "Numeric Value Required";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(163, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.No;
            dateTimePicker1.Size = new Size(229, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // deliveryTimeTextBox
            // 
            deliveryTimeTextBox.Location = new Point(163, 96);
            deliveryTimeTextBox.Name = "deliveryTimeTextBox";
            deliveryTimeTextBox.Size = new Size(229, 27);
            deliveryTimeTextBox.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 165);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 73;
            label5.Text = "Delivery No";
            // 
            // deliveryNoTextBox
            // 
            deliveryNoTextBox.Location = new Point(163, 162);
            deliveryNoTextBox.Name = "deliveryNoTextBox";
            deliveryNoTextBox.Size = new Size(229, 27);
            deliveryNoTextBox.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 198);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 75;
            label6.Text = "Packaging Code";
            // 
            // packagingCodeTextBox
            // 
            packagingCodeTextBox.Location = new Point(163, 195);
            packagingCodeTextBox.Name = "packagingCodeTextBox";
            packagingCodeTextBox.Size = new Size(229, 27);
            packagingCodeTextBox.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 231);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 77;
            label7.Text = "Advised Qty";
            // 
            // advisedQtyTextBox
            // 
            advisedQtyTextBox.Location = new Point(163, 228);
            advisedQtyTextBox.Name = "advisedQtyTextBox";
            advisedQtyTextBox.Size = new Size(229, 27);
            advisedQtyTextBox.TabIndex = 6;
            advisedQtyTextBox.TextChanged += advisedQtyTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 265);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 79;
            label8.Text = "Received Qty";
            // 
            // receivedQtyTextBox
            // 
            receivedQtyTextBox.Location = new Point(163, 261);
            receivedQtyTextBox.Name = "receivedQtyTextBox";
            receivedQtyTextBox.Size = new Size(229, 27);
            receivedQtyTextBox.TabIndex = 7;
            receivedQtyTextBox.TextChanged += receivedQtyTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 301);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 81;
            label9.Text = "Comment";
            // 
            // commentTextBox
            // 
            commentTextBox.Location = new Point(163, 294);
            commentTextBox.Multiline = true;
            commentTextBox.Name = "commentTextBox";
            commentTextBox.ScrollBars = ScrollBars.Horizontal;
            commentTextBox.Size = new Size(229, 96);
            commentTextBox.TabIndex = 8;
            // 
            // addPlusNewEntryButton
            // 
            addPlusNewEntryButton.FlatStyle = FlatStyle.Flat;
            addPlusNewEntryButton.Location = new Point(38, 474);
            addPlusNewEntryButton.Name = "addPlusNewEntryButton";
            addPlusNewEntryButton.Size = new Size(354, 36);
            addPlusNewEntryButton.TabIndex = 10;
            addPlusNewEntryButton.Text = "Add + New Entry";
            addPlusNewEntryButton.UseVisualStyleBackColor = true;
            addPlusNewEntryButton.Click += addPlusNewEntryButton_Click;
            // 
            // NewDeliveryButton
            // 
            NewDeliveryButton.FlatStyle = FlatStyle.Flat;
            NewDeliveryButton.Location = new Point(38, 558);
            NewDeliveryButton.Name = "NewDeliveryButton";
            NewDeliveryButton.Size = new Size(354, 36);
            NewDeliveryButton.TabIndex = 12;
            NewDeliveryButton.Text = "Clear + New Delivery";
            NewDeliveryButton.UseVisualStyleBackColor = true;
            NewDeliveryButton.Click += NewDeliveryButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(435, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1048, 667);
            dataGridView1.TabIndex = 82;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(38, 600);
            button5.Name = "button5";
            button5.Size = new Size(354, 36);
            button5.TabIndex = 13;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 677);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 84;
            label3.Text = "Search Delivery";
            // 
            // searchDeliveryTextBox
            // 
            searchDeliveryTextBox.Location = new Point(163, 674);
            searchDeliveryTextBox.Name = "searchDeliveryTextBox";
            searchDeliveryTextBox.Size = new Size(229, 27);
            searchDeliveryTextBox.TabIndex = 14;
            searchDeliveryTextBox.TextChanged += searchDeliveryTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 710);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 86;
            label4.Text = "Packaging";
            // 
            // searchPackagingTextBox
            // 
            searchPackagingTextBox.Location = new Point(163, 707);
            searchPackagingTextBox.Name = "searchPackagingTextBox";
            searchPackagingTextBox.Size = new Size(229, 27);
            searchPackagingTextBox.TabIndex = 15;
            searchPackagingTextBox.TextChanged += searchPackagingTextBox_TextChanged;
            // 
            // SearchErrorLabel
            // 
            SearchErrorLabel.AutoSize = true;
            SearchErrorLabel.ForeColor = Color.Crimson;
            SearchErrorLabel.Location = new Point(39, 753);
            SearchErrorLabel.Name = "SearchErrorLabel";
            SearchErrorLabel.Size = new Size(56, 20);
            SearchErrorLabel.TabIndex = 87;
            SearchErrorLabel.Text = "No hits";
            // 
            // RegTextBox
            // 
            RegTextBox.Location = new Point(163, 129);
            RegTextBox.Name = "RegTextBox";
            RegTextBox.Size = new Size(229, 27);
            RegTextBox.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 132);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 89;
            label10.Text = "Registration";
            // 
            // ExportButton
            // 
            ExportButton.FlatStyle = FlatStyle.Flat;
            ExportButton.Location = new Point(1129, 753);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(354, 36);
            ExportButton.TabIndex = 90;
            ExportButton.Text = "Export Results";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // PackagingTracker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 878);
            Controls.Add(ExportButton);
            Controls.Add(RegTextBox);
            Controls.Add(label10);
            Controls.Add(SearchErrorLabel);
            Controls.Add(label4);
            Controls.Add(searchPackagingTextBox);
            Controls.Add(label3);
            Controls.Add(searchDeliveryTextBox);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(NewDeliveryButton);
            Controls.Add(addPlusNewEntryButton);
            Controls.Add(label9);
            Controls.Add(commentTextBox);
            Controls.Add(label8);
            Controls.Add(receivedQtyTextBox);
            Controls.Add(label7);
            Controls.Add(advisedQtyTextBox);
            Controls.Add(label6);
            Controls.Add(packagingCodeTextBox);
            Controls.Add(label5);
            Controls.Add(deliveryNoTextBox);
            Controls.Add(deliveryTimeTextBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(errorLabel);
            Controls.Add(AddPlusNewDeliveryButton);
            Controls.Add(addButton);
            Name = "PackagingTracker";
            Text = "PackagingTracker";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddPlusNewDeliveryButton;
        private Button addButton;
        private Label label1;
        private Label label2;
        private Label errorLabel;
        private DateTimePicker dateTimePicker1;
        private TextBox deliveryTimeTextBox;
        private Label label5;
        private TextBox deliveryNoTextBox;
        private Label label6;
        private TextBox packagingCodeTextBox;
        private Label label7;
        private TextBox advisedQtyTextBox;
        private Label label8;
        private TextBox receivedQtyTextBox;
        private Label label9;
        private TextBox commentTextBox;
        private Button addPlusNewEntryButton;
        private Button NewDeliveryButton;
        private DataGridView dataGridView1;
        private Button button5;
        private Label label3;
        private TextBox searchDeliveryTextBox;
        private Label label4;
        private TextBox searchPackagingTextBox;
        private Label SearchErrorLabel;
        private TextBox RegTextBox;
        private Label label10;
        private Button ExportButton;
    }
}