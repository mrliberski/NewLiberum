namespace ProFormaUI.Forms
{
    partial class NewHandover
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
            components = new System.ComponentModel.Container();
            AutoSaveLabel = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox6 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            HSTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            DateLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // AutoSaveLabel
            // 
            AutoSaveLabel.AutoSize = true;
            AutoSaveLabel.Location = new Point(149, 838);
            AutoSaveLabel.Name = "AutoSaveLabel";
            AutoSaveLabel.Size = new Size(128, 20);
            AutoSaveLabel.TabIndex = 300;
            AutoSaveLabel.Text = "Autosave inactive.";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(490, 818);
            label28.Name = "label28";
            label28.Size = new Size(94, 20);
            label28.TabIndex = 299;
            label28.Text = "<DateTime>";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(374, 818);
            label27.Name = "label27";
            label27.Size = new Size(98, 20);
            label27.TabIndex = 298;
            label27.Text = "<UserName>";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(149, 818);
            label26.Name = "label26";
            label26.Size = new Size(224, 20);
            label26.TabIndex = 297;
            label26.Text = "Handover was last submitted by:";
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(936, 7);
            button5.Name = "button5";
            button5.Size = new Size(88, 36);
            button5.TabIndex = 195;
            button5.Text = "New";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1124, 7);
            button3.Name = "button3";
            button3.Size = new Size(88, 36);
            button3.TabIndex = 197;
            button3.Text = "Reload";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1030, 7);
            button2.Name = "button2";
            button2.Size = new Size(88, 36);
            button2.TabIndex = 196;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Interval = 30000;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(149, 682);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ScrollBars = ScrollBars.Vertical;
            textBox6.Size = new Size(1157, 120);
            textBox6.TabIndex = 205;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 689);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 279;
            label8.Text = "Dock / AOB";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(149, 556);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ScrollBars = ScrollBars.Vertical;
            textBox5.Size = new Size(1157, 120);
            textBox5.TabIndex = 204;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 563);
            label7.Name = "label7";
            label7.Size = new Size(134, 40);
            label7.TabIndex = 278;
            label7.Text = "Material Shortages\r\nWarehouse Checks\r\n";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(149, 430);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(1157, 120);
            textBox3.TabIndex = 202;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 433);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 275;
            label5.Text = "Mould Shop";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 304);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(1157, 120);
            textBox2.TabIndex = 201;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 307);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 272;
            label4.Text = "Assembly Lines";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 178);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(1157, 120);
            textBox1.TabIndex = 200;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 181);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 270;
            label3.Text = "Equipment Issues";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(448, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 28);
            comboBox1.TabIndex = 194;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(394, 10);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 267;
            label2.Text = "Shift:";
            // 
            // HSTextBox
            // 
            HSTextBox.Location = new Point(149, 52);
            HSTextBox.Multiline = true;
            HSTextBox.Name = "HSTextBox";
            HSTextBox.ScrollBars = ScrollBars.Vertical;
            HSTextBox.Size = new Size(1157, 120);
            HSTextBox.TabIndex = 199;
            HSTextBox.TextChanged += HSTextBox_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(205, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.No;
            dateTimePicker1.Size = new Size(183, 27);
            dateTimePicker1.TabIndex = 193;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 55);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 263;
            label1.Text = "Health And Safety";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.Location = new Point(149, 13);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(50, 23);
            DateLabel.TabIndex = 260;
            DateLabel.Text = "Date:";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1218, 7);
            button1.Name = "button1";
            button1.Size = new Size(88, 36);
            button1.TabIndex = 198;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NewHandover
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1382, 969);
            Controls.Add(AutoSaveLabel);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(HSTextBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(DateLabel);
            Controls.Add(button1);
            Name = "NewHandover";
            Text = "NewHandover";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AutoSaveLabel;
        private Label label28;
        private Label label27;
        private Label label26;
        private Button button5;
        private Button button3;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox HSTextBox;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label DateLabel;
        private Button button1;
    }
}