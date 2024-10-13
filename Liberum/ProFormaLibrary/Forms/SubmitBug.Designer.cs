namespace ProFormaUI.Forms
{
    partial class SubmitBug
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
            MessageTextBox = new TextBox();
            label1 = new Label();
            errorLabel = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // MessageTextBox
            // 
            MessageTextBox.Location = new Point(23, 131);
            MessageTextBox.Multiline = true;
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.ScrollBars = ScrollBars.Vertical;
            MessageTextBox.Size = new Size(944, 187);
            MessageTextBox.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 108);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 71;
            label1.Text = "Message:";
            label1.Click += label1_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Crimson;
            errorLabel.Location = new Point(23, 34);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(364, 20);
            errorLabel.TabIndex = 73;
            errorLabel.Text = "No personal information is being collected or stored. ";
            errorLabel.Click += errorLabel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 9);
            label3.Name = "label3";
            label3.Size = new Size(402, 25);
            label3.TabIndex = 72;
            label3.Text = "You can use this form to report errors or ideas.";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(23, 324);
            button1.Name = "button1";
            button1.Size = new Size(165, 48);
            button1.TabIndex = 75;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SubmitBug
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 463);
            Controls.Add(button1);
            Controls.Add(errorLabel);
            Controls.Add(label3);
            Controls.Add(MessageTextBox);
            Controls.Add(label1);
            Name = "SubmitBug";
            Text = "Submit Idea or Report Bug";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MessageTextBox;
        private Label label1;
        private Label errorLabel;
        private Label label3;
        private Button button1;
    }
}