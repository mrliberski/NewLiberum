namespace ProFormaUI
{
    partial class UploadCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadCustomers));
            ErrorPlaceholderValueLabel = new Label();
            FileSelectButton = new Button();
            PathSelectionTextBox = new TextBox();
            InfoLabel = new Label();
            UploadFileButton = new Button();
            CloseButton = new Button();
            groupBox1 = new GroupBox();
            CustomerModelValue = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ErrorPlaceholderValueLabel
            // 
            ErrorPlaceholderValueLabel.AutoSize = true;
            ErrorPlaceholderValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorPlaceholderValueLabel.ForeColor = Color.Red;
            ErrorPlaceholderValueLabel.ImeMode = ImeMode.NoControl;
            ErrorPlaceholderValueLabel.Location = new Point(10, 50);
            ErrorPlaceholderValueLabel.Name = "ErrorPlaceholderValueLabel";
            ErrorPlaceholderValueLabel.Size = new Size(214, 15);
            ErrorPlaceholderValueLabel.TabIndex = 60;
            ErrorPlaceholderValueLabel.Text = "<-------- Error placeholder ----------->";
            // 
            // FileSelectButton
            // 
            FileSelectButton.FlatAppearance.MouseDownBackColor = Color.White;
            FileSelectButton.FlatStyle = FlatStyle.Flat;
            FileSelectButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FileSelectButton.ImeMode = ImeMode.NoControl;
            FileSelectButton.Location = new Point(10, 9);
            FileSelectButton.Margin = new Padding(3, 2, 3, 2);
            FileSelectButton.Name = "FileSelectButton";
            FileSelectButton.Size = new Size(150, 24);
            FileSelectButton.TabIndex = 59;
            FileSelectButton.Text = "Select File";
            FileSelectButton.UseVisualStyleBackColor = true;
            FileSelectButton.Click += FileSelectButton_Click;
            // 
            // PathSelectionTextBox
            // 
            PathSelectionTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PathSelectionTextBox.Location = new Point(165, 11);
            PathSelectionTextBox.Margin = new Padding(3, 2, 3, 2);
            PathSelectionTextBox.Name = "PathSelectionTextBox";
            PathSelectionTextBox.Size = new Size(675, 23);
            PathSelectionTextBox.TabIndex = 58;
            PathSelectionTextBox.Text = "Select Valid Excel File";
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InfoLabel.ImeMode = ImeMode.NoControl;
            InfoLabel.Location = new Point(10, 35);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(109, 15);
            InfoLabel.TabIndex = 57;
            InfoLabel.Text = "<Info Placeholder>";
            // 
            // UploadFileButton
            // 
            UploadFileButton.FlatAppearance.MouseDownBackColor = Color.White;
            UploadFileButton.FlatStyle = FlatStyle.Flat;
            UploadFileButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UploadFileButton.ImeMode = ImeMode.NoControl;
            UploadFileButton.Location = new Point(10, 221);
            UploadFileButton.Margin = new Padding(3, 2, 3, 2);
            UploadFileButton.Name = "UploadFileButton";
            UploadFileButton.Size = new Size(150, 24);
            UploadFileButton.TabIndex = 61;
            UploadFileButton.Text = "Upload File";
            UploadFileButton.UseVisualStyleBackColor = true;
            UploadFileButton.Click += UploadFileButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.MouseDownBackColor = Color.White;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ImeMode = ImeMode.NoControl;
            CloseButton.Location = new Point(690, 221);
            CloseButton.Margin = new Padding(3, 2, 3, 2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(150, 24);
            CloseButton.TabIndex = 62;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CustomerModelValue);
            groupBox1.Location = new Point(10, 94);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(830, 123);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Model";
            // 
            // CustomerModelValue
            // 
            CustomerModelValue.AutoSize = true;
            CustomerModelValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerModelValue.ImeMode = ImeMode.NoControl;
            CustomerModelValue.Location = new Point(5, 24);
            CustomerModelValue.Name = "CustomerModelValue";
            CustomerModelValue.Size = new Size(93, 15);
            CustomerModelValue.TabIndex = 64;
            CustomerModelValue.Text = "CustomerModel";
            // 
            // UploadCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(852, 272);
            Controls.Add(groupBox1);
            Controls.Add(CloseButton);
            Controls.Add(UploadFileButton);
            Controls.Add(ErrorPlaceholderValueLabel);
            Controls.Add(FileSelectButton);
            Controls.Add(PathSelectionTextBox);
            Controls.Add(InfoLabel);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(868, 311);
            Name = "UploadCustomers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Upload Customers";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button UploadFileButton;
        private Label ErrorPlaceholderValueLabel;
        private Button FileSelectButton;
        private TextBox PathSelectionTextBox;
        private Label InfoLabel;
        private Button CloseButton;
        private GroupBox groupBox1;
        private Label CustomerModelValue;
    }
}