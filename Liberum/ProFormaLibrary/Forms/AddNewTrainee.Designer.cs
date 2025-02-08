namespace ProFormaUI.Forms
{
    partial class AddNewTrainee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTrainee));
            label5 = new Label();
            label4 = new Label();
            CommentextBox = new TextBox();
            label35 = new Label();
            SiteCombo = new ComboBox();
            ShiftCombo = new ComboBox();
            SurnameTextBox = new TextBox();
            label1 = new Label();
            NameTextBox = new TextBox();
            label14 = new Label();
            addButton = new Button();
            SaveStateLabel = new Label();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 139);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 326;
            label5.Text = "Department";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 105);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 325;
            label4.Text = "Site";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CommentextBox
            // 
            CommentextBox.Location = new Point(317, 35);
            CommentextBox.Multiline = true;
            CommentextBox.Name = "CommentextBox";
            CommentextBox.ScrollBars = ScrollBars.Vertical;
            CommentextBox.Size = new Size(455, 128);
            CommentextBox.TabIndex = 323;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(317, 13);
            label35.Name = "label35";
            label35.Size = new Size(74, 20);
            label35.TabIndex = 324;
            label35.Text = "Comment";
            // 
            // SiteCombo
            // 
            SiteCombo.FormattingEnabled = true;
            SiteCombo.Location = new Point(117, 102);
            SiteCombo.Name = "SiteCombo";
            SiteCombo.Size = new Size(183, 28);
            SiteCombo.TabIndex = 322;
            SiteCombo.Text = "Redditch 2";
            // 
            // ShiftCombo
            // 
            ShiftCombo.FormattingEnabled = true;
            ShiftCombo.Location = new Point(117, 136);
            ShiftCombo.Name = "ShiftCombo";
            ShiftCombo.Size = new Size(183, 28);
            ShiftCombo.TabIndex = 321;
            ShiftCombo.Text = "Whatever";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(117, 69);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(183, 27);
            SurnameTextBox.TabIndex = 319;
            SurnameTextBox.Text = "Wood";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 73);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 320;
            label1.Text = "Surname";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(117, 35);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(183, 27);
            NameTextBox.TabIndex = 317;
            NameTextBox.Text = "Craig ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(62, 39);
            label14.Name = "label14";
            label14.Size = new Size(49, 20);
            label14.TabIndex = 318;
            label14.Text = "Name";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addButton
            // 
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Location = new Point(384, 178);
            addButton.Name = "addButton";
            addButton.Size = new Size(388, 36);
            addButton.TabIndex = 327;
            addButton.Text = "Create New Record";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // SaveStateLabel
            // 
            SaveStateLabel.AutoSize = true;
            SaveStateLabel.Location = new Point(8, 249);
            SaveStateLabel.Name = "SaveStateLabel";
            SaveStateLabel.Size = new Size(49, 20);
            SaveStateLabel.TabIndex = 329;
            SaveStateLabel.Text = "Saved";
            SaveStateLabel.TextAlign = ContentAlignment.MiddleRight;
            SaveStateLabel.Visible = false;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Crimson;
            errorLabel.Location = new Point(7, 226);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(163, 20);
            errorLabel.TabIndex = 328;
            errorLabel.Text = "Error Label Placeholder";
            // 
            // AddNewTrainee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(820, 289);
            Controls.Add(SaveStateLabel);
            Controls.Add(errorLabel);
            Controls.Add(addButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CommentextBox);
            Controls.Add(label35);
            Controls.Add(SiteCombo);
            Controls.Add(ShiftCombo);
            Controls.Add(SurnameTextBox);
            Controls.Add(label1);
            Controls.Add(NameTextBox);
            Controls.Add(label14);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddNewTrainee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Record";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox CommentextBox;
        private Label label35;
        private ComboBox SiteCombo;
        private ComboBox ShiftCombo;
        private TextBox SurnameTextBox;
        private Label label1;
        private TextBox NameTextBox;
        private Label label14;
        private Button addButton;
        private Label SaveStateLabel;
        private Label errorLabel;
    }
}