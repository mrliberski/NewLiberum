namespace ProFormaUI
{
    partial class LicenceInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenceInfo));
            CloseButton = new Button();
            CustomerModelValue = new Label();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.MouseDownBackColor = Color.White;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ImeMode = ImeMode.NoControl;
            CloseButton.Location = new Point(324, 362);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(171, 32);
            CloseButton.TabIndex = 63;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // CustomerModelValue
            // 
            CustomerModelValue.AutoSize = true;
            CustomerModelValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerModelValue.ImeMode = ImeMode.NoControl;
            CustomerModelValue.Location = new Point(22, 24);
            CustomerModelValue.Name = "CustomerModelValue";
            CustomerModelValue.Size = new Size(115, 20);
            CustomerModelValue.TabIndex = 65;
            CustomerModelValue.Text = "CustomerModel";
            CustomerModelValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LicenceInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CustomerModelValue);
            Controls.Add(CloseButton);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(818, 497);
            Name = "LicenceInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LicenceInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseButton;
        private Label CustomerModelValue;
    }
}