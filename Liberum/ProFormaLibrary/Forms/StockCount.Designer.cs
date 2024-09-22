namespace ProFormaUI.Forms
{
    partial class StockCount
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
            errorLabel = new Label();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Crimson;
            errorLabel.Location = new Point(-280, 166);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(226, 20);
            errorLabel.TabIndex = 58;
            errorLabel.Text = "Only numeric entries are allowed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 22);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 55;
            label3.Text = "Stock Count Panel ";
 //           label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(1230, 262);
            button3.Name = "button3";
            button3.Size = new Size(165, 48);
            button3.TabIndex = 57;
            button3.Text = "Submit";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(1230, 208);
            button2.Name = "button2";
            button2.Size = new Size(165, 48);
            button2.TabIndex = 56;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(15, 150);
            button1.Name = "button1";
            button1.Size = new Size(165, 48);
            button1.TabIndex = 60;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(15, 96);
            button4.Name = "button4";
            button4.Size = new Size(165, 48);
            button4.TabIndex = 59;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            // 
            // StockCount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 797);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(errorLabel);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "StockCount";
            Text = "StockCount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label errorLabel;
        private Label label3;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}