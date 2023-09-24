namespace ProFormaUI
{
    partial class UploadItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadItems));
            selectCustomerComboBox = new ComboBox();
            selectCustomerLAbel = new Label();
            FileSelectButton = new Button();
            PathSelectionTextBox = new TextBox();
            CloseButton = new Button();
            UploadFileButton = new Button();
            groupBox1 = new GroupBox();
            ItemModelValue = new Label();
            ErrorPlaceholderValueLabel = new Label();
            InfoLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // selectCustomerComboBox
            // 
            selectCustomerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectCustomerComboBox.FormattingEnabled = true;
            selectCustomerComboBox.Location = new Point(205, 26);
            selectCustomerComboBox.Name = "selectCustomerComboBox";
            selectCustomerComboBox.Size = new Size(321, 28);
            selectCustomerComboBox.TabIndex = 124;
            // 
            // selectCustomerLAbel
            // 
            selectCustomerLAbel.AutoSize = true;
            selectCustomerLAbel.ImeMode = ImeMode.NoControl;
            selectCustomerLAbel.Location = new Point(82, 29);
            selectCustomerLAbel.Name = "selectCustomerLAbel";
            selectCustomerLAbel.Size = new Size(116, 20);
            selectCustomerLAbel.TabIndex = 125;
            selectCustomerLAbel.Text = "Select Customer";
            // 
            // FileSelectButton
            // 
            FileSelectButton.FlatAppearance.MouseDownBackColor = Color.White;
            FileSelectButton.FlatStyle = FlatStyle.Flat;
            FileSelectButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FileSelectButton.ImeMode = ImeMode.NoControl;
            FileSelectButton.Location = new Point(27, 72);
            FileSelectButton.Name = "FileSelectButton";
            FileSelectButton.Size = new Size(171, 32);
            FileSelectButton.TabIndex = 127;
            FileSelectButton.Text = "Select File";
            FileSelectButton.UseVisualStyleBackColor = true;
            FileSelectButton.Click += FileSelectButton_Click;
            // 
            // PathSelectionTextBox
            // 
            PathSelectionTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PathSelectionTextBox.Location = new Point(205, 75);
            PathSelectionTextBox.Name = "PathSelectionTextBox";
            PathSelectionTextBox.Size = new Size(771, 27);
            PathSelectionTextBox.TabIndex = 126;
            PathSelectionTextBox.Text = "Select Valid Excel File";
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.MouseDownBackColor = Color.White;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ImeMode = ImeMode.NoControl;
            CloseButton.Location = new Point(805, 110);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(171, 32);
            CloseButton.TabIndex = 129;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // UploadFileButton
            // 
            UploadFileButton.FlatAppearance.MouseDownBackColor = Color.White;
            UploadFileButton.FlatStyle = FlatStyle.Flat;
            UploadFileButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UploadFileButton.ImeMode = ImeMode.NoControl;
            UploadFileButton.Location = new Point(27, 110);
            UploadFileButton.Name = "UploadFileButton";
            UploadFileButton.Size = new Size(171, 32);
            UploadFileButton.TabIndex = 128;
            UploadFileButton.Text = "Upload File";
            UploadFileButton.UseVisualStyleBackColor = true;
            UploadFileButton.Click += UploadFileButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ItemModelValue);
            groupBox1.Location = new Point(27, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(949, 206);
            groupBox1.TabIndex = 130;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Model";
            // 
            // ItemModelValue
            // 
            ItemModelValue.AutoSize = true;
            ItemModelValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemModelValue.ImeMode = ImeMode.NoControl;
            ItemModelValue.Location = new Point(6, 32);
            ItemModelValue.Name = "ItemModelValue";
            ItemModelValue.Size = new Size(86, 20);
            ItemModelValue.TabIndex = 64;
            ItemModelValue.Text = "Item Model";
            // 
            // ErrorPlaceholderValueLabel
            // 
            ErrorPlaceholderValueLabel.AutoSize = true;
            ErrorPlaceholderValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorPlaceholderValueLabel.ForeColor = Color.Red;
            ErrorPlaceholderValueLabel.ImeMode = ImeMode.NoControl;
            ErrorPlaceholderValueLabel.Location = new Point(27, 408);
            ErrorPlaceholderValueLabel.Name = "ErrorPlaceholderValueLabel";
            ErrorPlaceholderValueLabel.Size = new Size(266, 20);
            ErrorPlaceholderValueLabel.TabIndex = 132;
            ErrorPlaceholderValueLabel.Text = "<-------- Error placeholder ----------->";
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InfoLabel.ImeMode = ImeMode.NoControl;
            InfoLabel.Location = new Point(27, 388);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(137, 20);
            InfoLabel.TabIndex = 131;
            InfoLabel.Text = "<Info Placeholder>";
            // 
            // UploadItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 460);
            Controls.Add(ErrorPlaceholderValueLabel);
            Controls.Add(InfoLabel);
            Controls.Add(groupBox1);
            Controls.Add(CloseButton);
            Controls.Add(UploadFileButton);
            Controls.Add(FileSelectButton);
            Controls.Add(PathSelectionTextBox);
            Controls.Add(selectCustomerComboBox);
            Controls.Add(selectCustomerLAbel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UploadItems";
            Text = "Upload Items";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selectCustomerComboBox;
        private Label selectCustomerLAbel;
        private Button FileSelectButton;
        private TextBox PathSelectionTextBox;
        private Button CloseButton;
        private Button UploadFileButton;
        private GroupBox groupBox1;
        private Label ItemModelValue;
        private Label ErrorPlaceholderValueLabel;
        private Label InfoLabel;
    }
}