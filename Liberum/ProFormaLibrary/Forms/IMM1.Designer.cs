namespace ProFormaUI.Forms
{
    partial class IMM1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMM1));
            label1 = new Label();
            ProjQtyLabel = new Label();
            button1 = new Button();
            errorLabel = new Label();
            ProjectNameCombo = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            ProductNameCombo = new ComboBox();
            CycleTimeTextBox = new TextBox();
            label6 = new Label();
            LabourtextBox = new TextBox();
            label7 = new Label();
            ProductionTimeTextBox = new TextBox();
            label8 = new Label();
            ProductionQtyTextBox = new TextBox();
            label9 = new Label();
            ToolNumberLabel = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 129);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 275;
            label1.Text = "Cycle time (s)";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.UseMnemonic = false;
            // 
            // ProjQtyLabel
            // 
            ProjQtyLabel.AutoSize = true;
            ProjQtyLabel.Location = new Point(667, 129);
            ProjQtyLabel.Name = "ProjQtyLabel";
            ProjQtyLabel.Size = new Size(17, 20);
            ProjQtyLabel.TabIndex = 274;
            ProjQtyLabel.Text = "0";
            ProjQtyLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.Location = new Point(26, 283);
            button1.Name = "button1";
            button1.Size = new Size(229, 48);
            button1.TabIndex = 273;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Crimson;
            errorLabel.Location = new Point(26, 9);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(163, 20);
            errorLabel.TabIndex = 346;
            errorLabel.Text = "Error Label Placeholder";
            // 
            // ProjectNameCombo
            // 
            ProjectNameCombo.FormattingEnabled = true;
            ProjectNameCombo.Location = new Point(223, 48);
            ProjectNameCombo.Name = "ProjectNameCombo";
            ProjectNameCombo.Size = new Size(660, 28);
            ProjectNameCombo.TabIndex = 347;
            ProjectNameCombo.Text = "Project";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 129);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 348;
            label2.Text = "Projected quantity per hour";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 85);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 349;
            label4.Text = "Product Name";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 51);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 350;
            label5.Text = "Project Name";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProductNameCombo
            // 
            ProductNameCombo.FormattingEnabled = true;
            ProductNameCombo.Location = new Point(223, 82);
            ProductNameCombo.Name = "ProductNameCombo";
            ProductNameCombo.Size = new Size(660, 28);
            ProductNameCombo.TabIndex = 351;
            ProductNameCombo.Text = "Product Name";
            // 
            // CycleTimeTextBox
            // 
            CycleTimeTextBox.Location = new Point(223, 126);
            CycleTimeTextBox.Name = "CycleTimeTextBox";
            CycleTimeTextBox.Size = new Size(115, 27);
            CycleTimeTextBox.TabIndex = 352;
            CycleTimeTextBox.Text = "CycleTime";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(565, 162);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 353;
            label6.Text = "Tool Number";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabourtextBox
            // 
            LabourtextBox.Location = new Point(223, 159);
            LabourtextBox.Name = "LabourtextBox";
            LabourtextBox.Size = new Size(115, 27);
            LabourtextBox.TabIndex = 355;
            LabourtextBox.Text = "Labour";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 162);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 354;
            label7.Text = "Labour Required";
            label7.TextAlign = ContentAlignment.MiddleRight;
            label7.UseMnemonic = false;
            // 
            // ProductionTimeTextBox
            // 
            ProductionTimeTextBox.Location = new Point(223, 192);
            ProductionTimeTextBox.Name = "ProductionTimeTextBox";
            ProductionTimeTextBox.Size = new Size(115, 27);
            ProductionTimeTextBox.TabIndex = 357;
            ProductionTimeTextBox.Text = "Production Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 195);
            label8.Name = "label8";
            label8.Size = new Size(140, 20);
            label8.TabIndex = 356;
            label8.Text = "Production Time (h)";
            label8.TextAlign = ContentAlignment.MiddleRight;
            label8.UseMnemonic = false;
            // 
            // ProductionQtyTextBox
            // 
            ProductionQtyTextBox.Location = new Point(223, 225);
            ProductionQtyTextBox.Name = "ProductionQtyTextBox";
            ProductionQtyTextBox.Size = new Size(115, 27);
            ProductionQtyTextBox.TabIndex = 359;
            ProductionQtyTextBox.Text = "Production Qty";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 228);
            label9.Name = "label9";
            label9.Size = new Size(132, 20);
            label9.TabIndex = 358;
            label9.Text = "Projected Quantity";
            label9.TextAlign = ContentAlignment.MiddleRight;
            label9.UseMnemonic = false;
            // 
            // ToolNumberLabel
            // 
            ToolNumberLabel.AutoSize = true;
            ToolNumberLabel.Location = new Point(667, 162);
            ToolNumberLabel.Name = "ToolNumberLabel";
            ToolNumberLabel.Size = new Size(41, 20);
            ToolNumberLabel.TabIndex = 360;
            ToolNumberLabel.Text = "T123";
            ToolNumberLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.Location = new Point(933, 48);
            button2.Name = "button2";
            button2.Size = new Size(229, 48);
            button2.TabIndex = 361;
            button2.Text = "Tool Change";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(933, 102);
            button3.Name = "button3";
            button3.Size = new Size(229, 48);
            button3.TabIndex = 362;
            button3.Text = "Planned Down";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(933, 156);
            button4.Name = "button4";
            button4.Size = new Size(229, 48);
            button4.TabIndex = 363;
            button4.Text = "Planned Down";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(933, 210);
            button5.Name = "button5";
            button5.Size = new Size(229, 48);
            button5.TabIndex = 364;
            button5.Text = "Tool Out";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(933, 264);
            button6.Name = "button6";
            button6.Size = new Size(229, 48);
            button6.TabIndex = 365;
            button6.Text = "Maintenance";
            button6.UseVisualStyleBackColor = true;
            // 
            // IMM1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1211, 351);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(ToolNumberLabel);
            Controls.Add(ProductionQtyTextBox);
            Controls.Add(ProductionTimeTextBox);
            Controls.Add(LabourtextBox);
            Controls.Add(CycleTimeTextBox);
            Controls.Add(ProductNameCombo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ProjectNameCombo);
            Controls.Add(errorLabel);
            Controls.Add(label1);
            Controls.Add(ProjQtyLabel);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IMM1";
            Text = "IMM1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ProjQtyLabel;
        private Button button1;
        private Label errorLabel;
        private ComboBox ProjectNameCombo;
        private Label label2;
        private Label label4;
        private Label label5;
        private ComboBox ProductNameCombo;
        private TextBox CycleTimeTextBox;
        private Label label6;
        private TextBox LabourtextBox;
        private Label label7;
        private TextBox ProductionTimeTextBox;
        private Label label8;
        private TextBox ProductionQtyTextBox;
        private Label label9;
        private Label ToolNumberLabel;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}