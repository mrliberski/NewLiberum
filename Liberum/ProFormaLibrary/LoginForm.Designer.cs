namespace ProFormaUI
{
    partial class LogonScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogonScreenForm));
            groupBox1 = new GroupBox();
            passwordSupportInfoLabel = new Label();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            supportInformationLabel1 = new Label();
            userNameLabel = new Label();
            userNameTextbox = new TextBox();
            logOnButton = new Button();
            capsLockInfoLabel = new Label();
            copyrightLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(capsLockInfoLabel);
            groupBox1.Controls.Add(passwordSupportInfoLabel);
            groupBox1.Controls.Add(passwordLabel);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(supportInformationLabel1);
            groupBox1.Controls.Add(userNameLabel);
            groupBox1.Controls.Add(userNameTextbox);
            groupBox1.Controls.Add(logOnButton);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // passwordSupportInfoLabel
            // 
            resources.ApplyResources(passwordSupportInfoLabel, "passwordSupportInfoLabel");
            passwordSupportInfoLabel.Name = "passwordSupportInfoLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(passwordLabel, "passwordLabel");
            passwordLabel.Name = "passwordLabel";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(passwordTextBox, "passwordTextBox");
            passwordTextBox.Name = "passwordTextBox";
            // 
            // supportInformationLabel1
            // 
            resources.ApplyResources(supportInformationLabel1, "supportInformationLabel1");
            supportInformationLabel1.Name = "supportInformationLabel1";
            // 
            // userNameLabel
            // 
            resources.ApplyResources(userNameLabel, "userNameLabel");
            userNameLabel.Name = "userNameLabel";
            // 
            // userNameTextbox
            // 
            resources.ApplyResources(userNameTextbox, "userNameTextbox");
            userNameTextbox.Name = "userNameTextbox";
            // 
            // logOnButton
            // 
            resources.ApplyResources(logOnButton, "logOnButton");
            logOnButton.Name = "logOnButton";
            logOnButton.UseVisualStyleBackColor = true;
            logOnButton.Click += logOnButton_Click;
            // 
            // capsLockInfoLabel
            // 
            resources.ApplyResources(capsLockInfoLabel, "capsLockInfoLabel");
            capsLockInfoLabel.Name = "capsLockInfoLabel";
            // 
            // copyrightLabel
            // 
            resources.ApplyResources(copyrightLabel, "copyrightLabel");
            copyrightLabel.Name = "copyrightLabel";
            // 
            // LogonScreenForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(copyrightLabel);
            Controls.Add(groupBox1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LogonScreenForm";
            Load += LoginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label passwordSupportInfoLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label supportInformationLabel1;
        private Label userNameLabel;
        private TextBox userNameTextbox;
        private Button logOnButton;
        private Label capsLockInfoLabel;
        private Label copyrightLabel;
    }
}