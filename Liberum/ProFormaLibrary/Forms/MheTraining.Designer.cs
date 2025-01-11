namespace ProFormaUI.Forms
{
    partial class MheTraining
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
            addButton = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            IdLaberlheader = new Label();
            IdLabel = new Label();
            SurnameLabelHeader = new Label();
            NameLabelHeader = new Label();
            SurnameLabel = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            label14 = new Label();
            SurnameTextBox = new TextBox();
            label1 = new Label();
            ShiftCombo = new ComboBox();
            B1picker = new DateTimePicker();
            mewps3aPicker = new DateTimePicker();
            P1picker = new DateTimePicker();
            F1picker = new DateTimePicker();
            H1picker = new DateTimePicker();
            A2picker = new DateTimePicker();
            A1picker = new DateTimePicker();
            B2picker = new DateTimePicker();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            A5picker = new DateTimePicker();
            A4picker = new DateTimePicker();
            Mewps3Bpicker = new DateTimePicker();
            D1picker = new DateTimePicker();
            RemotePIcker = new DateTimePicker();
            CranePicker = new DateTimePicker();
            AssessmentPicker = new DateTimePicker();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            RackingPicker = new DateTimePicker();
            SiteCombo = new ComboBox();
            label33 = new Label();
            label34 = new Label();
            CommentextBox = new TextBox();
            label35 = new Label();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            searchBox = new TextBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button4 = new Button();
            SiteTextBox = new TextBox();
            label4 = new Label();
            DeptTextBox = new TextBox();
            label5 = new Label();
            ArchiveButton = new Button();
            UpdateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // errorLabel
            // 
            errorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Crimson;
            errorLabel.Location = new Point(31, 754);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(163, 20);
            errorLabel.TabIndex = 72;
            errorLabel.Text = "Error Label Placeholder";
            errorLabel.Click += errorLabel_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Location = new Point(817, 590);
            addButton.Name = "addButton";
            addButton.Size = new Size(455, 36);
            addButton.TabIndex = 70;
            addButton.Text = "Add New Record";
            addButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(11, 9);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 73;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(411, 670);
            dataGridView1.TabIndex = 83;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 13);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 84;
            label2.Text = "Assessment Records:";
            // 
            // IdLaberlheader
            // 
            IdLaberlheader.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            IdLaberlheader.AutoSize = true;
            IdLaberlheader.Location = new Point(856, 754);
            IdLaberlheader.Name = "IdLaberlheader";
            IdLaberlheader.Size = new Size(22, 20);
            IdLaberlheader.TabIndex = 96;
            IdLaberlheader.Text = "Id";
            IdLaberlheader.TextAlign = ContentAlignment.MiddleRight;
            IdLaberlheader.Visible = false;
            // 
            // IdLabel
            // 
            IdLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(884, 754);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(84, 20);
            IdLabel.TabIndex = 102;
            IdLabel.Text = "<ID Label>";
            IdLabel.TextAlign = ContentAlignment.MiddleLeft;
            IdLabel.Visible = false;
            // 
            // SurnameLabelHeader
            // 
            SurnameLabelHeader.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SurnameLabelHeader.AutoSize = true;
            SurnameLabelHeader.Location = new Point(811, 794);
            SurnameLabelHeader.Name = "SurnameLabelHeader";
            SurnameLabelHeader.Size = new Size(67, 20);
            SurnameLabelHeader.TabIndex = 103;
            SurnameLabelHeader.Text = "Surname";
            SurnameLabelHeader.TextAlign = ContentAlignment.MiddleRight;
            SurnameLabelHeader.Visible = false;
            // 
            // NameLabelHeader
            // 
            NameLabelHeader.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NameLabelHeader.AutoSize = true;
            NameLabelHeader.Location = new Point(830, 774);
            NameLabelHeader.Name = "NameLabelHeader";
            NameLabelHeader.Size = new Size(49, 20);
            NameLabelHeader.TabIndex = 104;
            NameLabelHeader.Text = "Name";
            NameLabelHeader.TextAlign = ContentAlignment.MiddleRight;
            NameLabelHeader.Visible = false;
            // 
            // SurnameLabel
            // 
            SurnameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(884, 794);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(87, 20);
            SurnameLabel.TabIndex = 105;
            SurnameLabel.Text = "<Surname>";
            SurnameLabel.TextAlign = ContentAlignment.MiddleLeft;
            SurnameLabel.Visible = false;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(884, 774);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(69, 20);
            NameLabel.TabIndex = 106;
            NameLabel.Text = "<Name>";
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
            NameLabel.Visible = false;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NameTextBox.Location = new Point(617, 61);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(183, 27);
            NameTextBox.TabIndex = 107;
            NameTextBox.Text = "Craig ";
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(562, 65);
            label14.Name = "label14";
            label14.Size = new Size(49, 20);
            label14.TabIndex = 108;
            label14.Text = "Name";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SurnameTextBox.Location = new Point(617, 95);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(183, 27);
            SurnameTextBox.TabIndex = 109;
            SurnameTextBox.Text = "Wood";
            SurnameTextBox.TextChanged += SurnameTextBox_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(544, 99);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 110;
            label1.Text = "Surname";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ShiftCombo
            // 
            ShiftCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShiftCombo.FormattingEnabled = true;
            ShiftCombo.Location = new Point(617, 162);
            ShiftCombo.Name = "ShiftCombo";
            ShiftCombo.Size = new Size(183, 28);
            ShiftCombo.TabIndex = 269;
            ShiftCombo.Text = "Whatever";
            ShiftCombo.SelectedIndexChanged += ShiftCombo_SelectedIndexChanged;
            // 
            // B1picker
            // 
            B1picker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            B1picker.Font = new Font("Segoe UI", 9F);
            B1picker.Location = new Point(617, 229);
            B1picker.Name = "B1picker";
            B1picker.RightToLeft = RightToLeft.No;
            B1picker.Size = new Size(183, 27);
            B1picker.TabIndex = 268;
            B1picker.ValueChanged += B1picker_ValueChanged;
            // 
            // mewps3aPicker
            // 
            mewps3aPicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mewps3aPicker.Font = new Font("Segoe UI", 9F);
            mewps3aPicker.Location = new Point(617, 461);
            mewps3aPicker.Name = "mewps3aPicker";
            mewps3aPicker.RightToLeft = RightToLeft.No;
            mewps3aPicker.Size = new Size(183, 27);
            mewps3aPicker.TabIndex = 272;
            mewps3aPicker.ValueChanged += mewps3aPicker_ValueChanged;
            // 
            // P1picker
            // 
            P1picker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            P1picker.Font = new Font("Segoe UI", 9F);
            P1picker.Location = new Point(617, 428);
            P1picker.Name = "P1picker";
            P1picker.RightToLeft = RightToLeft.No;
            P1picker.Size = new Size(183, 27);
            P1picker.TabIndex = 273;
            P1picker.ValueChanged += P1picker_ValueChanged;
            // 
            // F1picker
            // 
            F1picker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            F1picker.Font = new Font("Segoe UI", 9F);
            F1picker.Location = new Point(617, 395);
            F1picker.Name = "F1picker";
            F1picker.RightToLeft = RightToLeft.No;
            F1picker.Size = new Size(183, 27);
            F1picker.TabIndex = 274;
            F1picker.ValueChanged += F1picker_ValueChanged;
            // 
            // H1picker
            // 
            H1picker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            H1picker.Font = new Font("Segoe UI", 9F);
            H1picker.Location = new Point(617, 363);
            H1picker.Name = "H1picker";
            H1picker.RightToLeft = RightToLeft.No;
            H1picker.Size = new Size(183, 27);
            H1picker.TabIndex = 275;
            H1picker.ValueChanged += H1picker_ValueChanged;
            // 
            // A2picker
            // 
            A2picker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            A2picker.Font = new Font("Segoe UI", 9F);
            A2picker.Location = new Point(617, 329);
            A2picker.Name = "A2picker";
            A2picker.RightToLeft = RightToLeft.No;
            A2picker.Size = new Size(183, 27);
            A2picker.TabIndex = 276;
            A2picker.ValueChanged += A2picker_ValueChanged;
            // 
            // A1picker
            // 
            A1picker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            A1picker.Font = new Font("Segoe UI", 9F);
            A1picker.Location = new Point(617, 296);
            A1picker.Name = "A1picker";
            A1picker.RightToLeft = RightToLeft.No;
            A1picker.Size = new Size(183, 27);
            A1picker.TabIndex = 277;
            A1picker.ValueChanged += A1picker_ValueChanged;
            // 
            // B2picker
            // 
            B2picker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            B2picker.Font = new Font("Segoe UI", 9F);
            B2picker.Location = new Point(617, 263);
            B2picker.Name = "B2picker";
            B2picker.RightToLeft = RightToLeft.No;
            B2picker.Size = new Size(183, 27);
            B2picker.TabIndex = 278;
            B2picker.ValueChanged += B2picker_ValueChanged;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Location = new Point(467, 235);
            label17.Name = "label17";
            label17.Size = new Size(144, 20);
            label17.TabIndex = 279;
            label17.Text = "Counterbalance - B1";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Location = new Point(467, 268);
            label18.Name = "label18";
            label18.Size = new Size(144, 20);
            label18.TabIndex = 280;
            label18.Text = "Counterbalance - B2";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Location = new Point(474, 301);
            label19.Name = "label19";
            label19.Size = new Size(137, 20);
            label19.TabIndex = 281;
            label19.Text = "PPT Pedestrian - A1";
            label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Location = new Point(507, 333);
            label20.Name = "label20";
            label20.Size = new Size(104, 20);
            label20.TabIndex = 282;
            label20.Text = "PPT Rider - A2";
            label20.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.Location = new Point(506, 367);
            label21.Name = "label21";
            label21.Size = new Size(105, 20);
            label21.TabIndex = 283;
            label21.Text = "Tow Train - H1";
            label21.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Location = new Point(543, 400);
            label22.Name = "label22";
            label22.Size = new Size(68, 20);
            label22.TabIndex = 284;
            label22.Text = "VNA - F1";
            label22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.Location = new Point(496, 433);
            label23.Name = "label23";
            label23.Size = new Size(115, 20);
            label23.TabIndex = 285;
            label23.Text = "Bendi Truck - P1";
            label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label24.AutoSize = true;
            label24.Location = new Point(519, 467);
            label24.Name = "label24";
            label24.Size = new Size(92, 20);
            label24.TabIndex = 286;
            label24.Text = "MEWPS - 3A";
            label24.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label25.AutoSize = true;
            label25.Location = new Point(519, 499);
            label25.Name = "label25";
            label25.Size = new Size(91, 20);
            label25.TabIndex = 287;
            label25.Text = "MEWPS - 3B";
            label25.TextAlign = ContentAlignment.MiddleRight;
            // 
            // A5picker
            // 
            A5picker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            A5picker.Font = new Font("Segoe UI", 9F);
            A5picker.Location = new Point(617, 560);
            A5picker.Name = "A5picker";
            A5picker.RightToLeft = RightToLeft.No;
            A5picker.Size = new Size(183, 27);
            A5picker.TabIndex = 288;
            A5picker.ValueChanged += A5picker_ValueChanged;
            // 
            // A4picker
            // 
            A4picker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            A4picker.Font = new Font("Segoe UI", 9F);
            A4picker.Location = new Point(617, 527);
            A4picker.Name = "A4picker";
            A4picker.RightToLeft = RightToLeft.No;
            A4picker.Size = new Size(183, 27);
            A4picker.TabIndex = 289;
            A4picker.ValueChanged += A4picker_ValueChanged;
            // 
            // Mewps3Bpicker
            // 
            Mewps3Bpicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Mewps3Bpicker.Font = new Font("Segoe UI", 9F);
            Mewps3Bpicker.Location = new Point(617, 493);
            Mewps3Bpicker.Name = "Mewps3Bpicker";
            Mewps3Bpicker.RightToLeft = RightToLeft.No;
            Mewps3Bpicker.Size = new Size(183, 27);
            Mewps3Bpicker.TabIndex = 290;
            Mewps3Bpicker.ValueChanged += Mewps3Bpicker_ValueChanged;
            // 
            // D1picker
            // 
            D1picker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            D1picker.Font = new Font("Segoe UI", 9F);
            D1picker.Location = new Point(617, 593);
            D1picker.Name = "D1picker";
            D1picker.RightToLeft = RightToLeft.No;
            D1picker.Size = new Size(183, 27);
            D1picker.TabIndex = 291;
            D1picker.ValueChanged += D1picker_ValueChanged;
            // 
            // RemotePIcker
            // 
            RemotePIcker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemotePIcker.Font = new Font("Segoe UI", 9F);
            RemotePIcker.Location = new Point(617, 627);
            RemotePIcker.Name = "RemotePIcker";
            RemotePIcker.RightToLeft = RightToLeft.No;
            RemotePIcker.Size = new Size(183, 27);
            RemotePIcker.TabIndex = 292;
            RemotePIcker.ValueChanged += RemotePIcker_ValueChanged;
            // 
            // CranePicker
            // 
            CranePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CranePicker.Font = new Font("Segoe UI", 9F);
            CranePicker.Location = new Point(617, 659);
            CranePicker.Name = "CranePicker";
            CranePicker.RightToLeft = RightToLeft.No;
            CranePicker.Size = new Size(183, 27);
            CranePicker.TabIndex = 293;
            CranePicker.ValueChanged += CranePicker_ValueChanged;
            // 
            // AssessmentPicker
            // 
            AssessmentPicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AssessmentPicker.Font = new Font("Segoe UI", 9F);
            AssessmentPicker.Location = new Point(617, 692);
            AssessmentPicker.Name = "AssessmentPicker";
            AssessmentPicker.RightToLeft = RightToLeft.No;
            AssessmentPicker.Size = new Size(183, 27);
            AssessmentPicker.TabIndex = 294;
            AssessmentPicker.ValueChanged += AssessmentPicker_ValueChanged;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label26.AutoSize = true;
            label26.Location = new Point(482, 532);
            label26.Name = "label26";
            label26.Size = new Size(129, 20);
            label26.TabIndex = 295;
            label26.Text = "Pallet Stacker - A4";
            label26.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label27.AutoSize = true;
            label27.Location = new Point(491, 565);
            label27.Name = "label27";
            label27.Size = new Size(119, 20);
            label27.TabIndex = 296;
            label27.Text = "Pallet Stacker A5";
            label27.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label28.AutoSize = true;
            label28.Location = new Point(486, 597);
            label28.Name = "label28";
            label28.Size = new Size(124, 20);
            label28.TabIndex = 297;
            label28.Text = "Reach Truck  - D1";
            label28.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label29.AutoSize = true;
            label29.Location = new Point(550, 631);
            label29.Name = "label29";
            label29.Size = new Size(61, 20);
            label29.TabIndex = 298;
            label29.Text = "Remote";
            label29.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.Location = new Point(491, 664);
            label30.Name = "label30";
            label30.Size = new Size(119, 20);
            label30.TabIndex = 299;
            label30.Text = "Crane Inspection";
            label30.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label31.AutoSize = true;
            label31.Location = new Point(525, 697);
            label31.Name = "label31";
            label31.Size = new Size(85, 20);
            label31.TabIndex = 300;
            label31.Text = "Assesments";
            label31.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label32
            // 
            label32.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label32.AutoSize = true;
            label32.Location = new Point(478, 731);
            label32.Name = "label32";
            label32.Size = new Size(133, 20);
            label32.TabIndex = 301;
            label32.Text = "Racking Inspection";
            label32.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RackingPicker
            // 
            RackingPicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RackingPicker.Font = new Font("Segoe UI", 9F);
            RackingPicker.Location = new Point(617, 725);
            RackingPicker.Name = "RackingPicker";
            RackingPicker.RightToLeft = RightToLeft.No;
            RackingPicker.Size = new Size(183, 27);
            RackingPicker.TabIndex = 302;
            RackingPicker.ValueChanged += RackingPicker_ValueChanged;
            // 
            // SiteCombo
            // 
            SiteCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SiteCombo.FormattingEnabled = true;
            SiteCombo.Location = new Point(617, 128);
            SiteCombo.Name = "SiteCombo";
            SiteCombo.Size = new Size(183, 28);
            SiteCombo.TabIndex = 303;
            SiteCombo.Text = "Redditch 2";
            SiteCombo.SelectedIndexChanged += SiteCombo_SelectedIndexChanged;
            // 
            // label33
            // 
            label33.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label33.AutoSize = true;
            label33.Location = new Point(1233, 754);
            label33.Name = "label33";
            label33.Size = new Size(39, 20);
            label33.TabIndex = 304;
            label33.Text = "Shift";
            label33.TextAlign = ContentAlignment.MiddleRight;
            label33.Visible = false;
            // 
            // label34
            // 
            label34.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label34.AutoSize = true;
            label34.Location = new Point(1193, 757);
            label34.Name = "label34";
            label34.Size = new Size(34, 20);
            label34.TabIndex = 305;
            label34.Text = "Site";
            label34.TextAlign = ContentAlignment.MiddleRight;
            label34.Visible = false;
            // 
            // CommentextBox
            // 
            CommentextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CommentextBox.Location = new Point(817, 61);
            CommentextBox.Multiline = true;
            CommentextBox.Name = "CommentextBox";
            CommentextBox.ScrollBars = ScrollBars.Vertical;
            CommentextBox.Size = new Size(455, 128);
            CommentextBox.TabIndex = 306;
            CommentextBox.TextChanged += CommentextBox_TextChanged;
            // 
            // label35
            // 
            label35.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label35.AutoSize = true;
            label35.Location = new Point(817, 39);
            label35.Name = "label35";
            label35.Size = new Size(74, 20);
            label35.TabIndex = 307;
            label35.Text = "Comment";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(817, 674);
            button2.Name = "button2";
            button2.Size = new Size(455, 36);
            button2.TabIndex = 309;
            button2.Text = "Show Matrix";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1051, 715);
            button3.Name = "button3";
            button3.Size = new Size(221, 36);
            button3.TabIndex = 310;
            button3.Text = ">>";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(searchBox);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(817, 229);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 224);
            groupBox1.TabIndex = 311;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(21, 39);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(411, 27);
            searchBox.TabIndex = 109;
            searchBox.Text = "Search Here";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(21, 159);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(79, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Leavers";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(21, 131);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Droitwich";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(21, 103);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(89, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Redditch";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 75);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "All Sites";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(817, 715);
            button4.Name = "button4";
            button4.Size = new Size(221, 36);
            button4.TabIndex = 312;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // SiteTextBox
            // 
            SiteTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SiteTextBox.Location = new Point(817, 516);
            SiteTextBox.Name = "SiteTextBox";
            SiteTextBox.Size = new Size(183, 27);
            SiteTextBox.TabIndex = 313;
            SiteTextBox.Text = "Redditch";
            SiteTextBox.Visible = false;
            SiteTextBox.TextChanged += SiteTextBox_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(577, 131);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 314;
            label4.Text = "Site";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DeptTextBox
            // 
            DeptTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeptTextBox.Location = new Point(1006, 516);
            DeptTextBox.Name = "DeptTextBox";
            DeptTextBox.Size = new Size(183, 27);
            DeptTextBox.TabIndex = 315;
            DeptTextBox.Text = "Logistic";
            DeptTextBox.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(522, 165);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 316;
            label5.Text = "Department";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ArchiveButton
            // 
            ArchiveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ArchiveButton.FlatStyle = FlatStyle.Flat;
            ArchiveButton.Location = new Point(817, 632);
            ArchiveButton.Name = "ArchiveButton";
            ArchiveButton.Size = new Size(455, 36);
            ArchiveButton.TabIndex = 317;
            ArchiveButton.Text = "Archive Current Record";
            ArchiveButton.UseVisualStyleBackColor = true;
            ArchiveButton.Click += ArchiveButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Location = new Point(31, 715);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(411, 36);
            UpdateButton.TabIndex = 318;
            UpdateButton.Text = "Reload Overview";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // MheTraining
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1299, 860);
            Controls.Add(UpdateButton);
            Controls.Add(ArchiveButton);
            Controls.Add(DeptTextBox);
            Controls.Add(label5);
            Controls.Add(SiteTextBox);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(CommentextBox);
            Controls.Add(label35);
            Controls.Add(label34);
            Controls.Add(label33);
            Controls.Add(SiteCombo);
            Controls.Add(RackingPicker);
            Controls.Add(label32);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(AssessmentPicker);
            Controls.Add(CranePicker);
            Controls.Add(RemotePIcker);
            Controls.Add(D1picker);
            Controls.Add(Mewps3Bpicker);
            Controls.Add(A4picker);
            Controls.Add(A5picker);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(B2picker);
            Controls.Add(A1picker);
            Controls.Add(A2picker);
            Controls.Add(H1picker);
            Controls.Add(F1picker);
            Controls.Add(P1picker);
            Controls.Add(mewps3aPicker);
            Controls.Add(ShiftCombo);
            Controls.Add(B1picker);
            Controls.Add(SurnameTextBox);
            Controls.Add(label1);
            Controls.Add(NameTextBox);
            Controls.Add(label14);
            Controls.Add(NameLabel);
            Controls.Add(SurnameLabel);
            Controls.Add(NameLabelHeader);
            Controls.Add(SurnameLabelHeader);
            Controls.Add(IdLabel);
            Controls.Add(IdLaberlheader);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(errorLabel);
            Controls.Add(addButton);
            Name = "MheTraining";
            Text = "Manual Handling Equipment Training ";
            Load += MheTraining_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label errorLabel;
        private Button addButton;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label IdLaberlheader;
        private Label IdLabel;
        private Label SurnameLabelHeader;
        private Label NameLabelHeader;
        private Label SurnameLabel;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label label14;
        private TextBox SurnameTextBox;
        private Label label1;
        private ComboBox ShiftCombo;
        private DateTimePicker B1picker;
        private DateTimePicker mewps3aPicker;
        private DateTimePicker P1picker;
        private DateTimePicker F1picker;
        private DateTimePicker H1picker;
        private DateTimePicker A2picker;
        private DateTimePicker A1picker;
        private DateTimePicker B2picker;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private DateTimePicker A5picker;
        private DateTimePicker A4picker;
        private DateTimePicker Mewps3Bpicker;
        private DateTimePicker D1picker;
        private DateTimePicker RemotePIcker;
        private DateTimePicker CranePicker;
        private DateTimePicker AssessmentPicker;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private DateTimePicker RackingPicker;
        private ComboBox SiteCombo;
        private Label label33;
        private Label label34;
        private TextBox CommentextBox;
        private Label label35;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button4;
        private TextBox searchBox;
        private TextBox SiteTextBox;
        private Label label4;
        private TextBox DeptTextBox;
        private Label label5;
        private Button ArchiveButton;
        private Button UpdateButton;
    }
}