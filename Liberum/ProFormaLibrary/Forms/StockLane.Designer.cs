namespace ProFormaUI.Forms
{
    partial class StockLane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockLane));
            label5 = new Label();
            label4 = new Label();
            ItemsCombo = new ComboBox();
            CheckCombo = new ComboBox();
            TimeTextBox = new TextBox();
            label1 = new Label();
            QtyTextBox = new TextBox();
            PartNumberLabel = new Label();
            errorLabel = new Label();
            addButton = new Button();
            dataGrid = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            MixCombo = new ComboBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            ActionsTextBox = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 126);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 324;
            label5.Text = "100% Check";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 262);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 323;
            label4.Text = "Date Counted";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ItemsCombo
            // 
            ItemsCombo.FormattingEnabled = true;
            ItemsCombo.Location = new Point(30, 48);
            ItemsCombo.Name = "ItemsCombo";
            ItemsCombo.Size = new Size(393, 28);
            ItemsCombo.TabIndex = 1;
            ItemsCombo.Text = "F6X Warm Air Duct LHD";
            ItemsCombo.SelectedIndexChanged += ItemsCombo_SelectedIndexChanged;
            // 
            // CheckCombo
            // 
            CheckCombo.FormattingEnabled = true;
            CheckCombo.Location = new Point(179, 123);
            CheckCombo.Name = "CheckCombo";
            CheckCombo.Size = new Size(108, 28);
            CheckCombo.TabIndex = 2;
            CheckCombo.Text = "Yes";
            // 
            // TimeTextBox
            // 
            TimeTextBox.Location = new Point(179, 224);
            TimeTextBox.Name = "TimeTextBox";
            TimeTextBox.Size = new Size(108, 27);
            TimeTextBox.TabIndex = 5;
            TimeTextBox.Text = "12:85";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 227);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 320;
            label1.Text = "Time Counted";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // QtyTextBox
            // 
            QtyTextBox.Location = new Point(179, 191);
            QtyTextBox.Name = "QtyTextBox";
            QtyTextBox.Size = new Size(108, 27);
            QtyTextBox.TabIndex = 4;
            QtyTextBox.Text = "9000";
            // 
            // PartNumberLabel
            // 
            PartNumberLabel.AutoSize = true;
            PartNumberLabel.Location = new Point(30, 79);
            PartNumberLabel.Name = "PartNumberLabel";
            PartNumberLabel.Size = new Size(111, 20);
            PartNumberLabel.TabIndex = 318;
            PartNumberLabel.Text = "123456789-000";
            PartNumberLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // errorLabel
            // 
            errorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Crimson;
            errorLabel.Location = new Point(30, 696);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(163, 20);
            errorLabel.TabIndex = 325;
            errorLabel.Text = "Error Label Placeholder";
            errorLabel.Click += errorLabel_Click;
            // 
            // addButton
            // 
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Location = new Point(30, 530);
            addButton.Name = "addButton";
            addButton.Size = new Size(393, 36);
            addButton.TabIndex = 9;
            addButton.Text = "Add New Record";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(445, 48);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 29;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(932, 668);
            dataGrid.TabIndex = 327;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 25);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 328;
            label2.Text = "Select Material";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 160);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 330;
            label3.Text = "Lane Mixed";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MixCombo
            // 
            MixCombo.FormattingEnabled = true;
            MixCombo.Location = new Point(179, 157);
            MixCombo.Name = "MixCombo";
            MixCombo.Size = new Size(108, 28);
            MixCombo.TabIndex = 3;
            MixCombo.Text = "Yes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 194);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 332;
            label6.Text = "Quantity Counted";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F);
            dateTimePicker1.Location = new Point(179, 257);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.No;
            dateTimePicker1.Size = new Size(177, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(30, 572);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(136, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Also send email";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ActionsTextBox
            // 
            ActionsTextBox.Location = new Point(30, 324);
            ActionsTextBox.Multiline = true;
            ActionsTextBox.Name = "ActionsTextBox";
            ActionsTextBox.Size = new Size(393, 200);
            ActionsTextBox.TabIndex = 7;
            ActionsTextBox.Text = resources.GetString("ActionsTextBox.Text");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 301);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 336;
            label7.Text = "Actions or comments";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // StockLane
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1456, 760);
            Controls.Add(label7);
            Controls.Add(ActionsTextBox);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(MixCombo);
            Controls.Add(label2);
            Controls.Add(dataGrid);
            Controls.Add(addButton);
            Controls.Add(errorLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ItemsCombo);
            Controls.Add(CheckCombo);
            Controls.Add(TimeTextBox);
            Controls.Add(label1);
            Controls.Add(QtyTextBox);
            Controls.Add(PartNumberLabel);
            Name = "StockLane";
            Text = "Stock Lane Check";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private ComboBox ItemsCombo;
        private ComboBox CheckCombo;
        private TextBox TimeTextBox;
        private Label label1;
        private TextBox QtyTextBox;
        private Label PartNumberLabel;
        private Label errorLabel;
        private Button addButton;
        private DataGridView dataGrid;
        private Label label2;
        private Label label3;
        private ComboBox MixCombo;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private TextBox ActionsTextBox;
        private Label label7;
    }
}