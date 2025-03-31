namespace ProFormaUI
{
    partial class MainPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            panelMenu = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            ExitButton = new FontAwesome.Sharp.IconButton();
            ReportBugButton = new FontAwesome.Sharp.IconButton();
            HandoverButton4 = new FontAwesome.Sharp.IconButton();
            HandoverButton3 = new FontAwesome.Sharp.IconButton();
            HandoverButton2 = new FontAwesome.Sharp.IconButton();
            TrackerButton = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            InternalPackagingButton = new FontAwesome.Sharp.IconButton();
            PackagingCountButton = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            exportButton1 = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            btnCloseChildform = new Button();
            lblTitle = new Label();
            panelDesktopPanel = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(iconButton4);
            panelMenu.Controls.Add(iconButton3);
            panelMenu.Controls.Add(ExitButton);
            panelMenu.Controls.Add(ReportBugButton);
            panelMenu.Controls.Add(HandoverButton4);
            panelMenu.Controls.Add(HandoverButton3);
            panelMenu.Controls.Add(HandoverButton2);
            panelMenu.Controls.Add(TrackerButton);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(InternalPackagingButton);
            panelMenu.Controls.Add(PackagingCountButton);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(exportButton1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(219, 808);
            panelMenu.TabIndex = 35;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.Gainsboro;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            iconButton4.IconColor = Color.Gainsboro;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 24;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.ImeMode = ImeMode.NoControl;
            iconButton4.Location = new Point(0, 575);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(219, 45);
            iconButton4.TabIndex = 24;
            iconButton4.Text = "  Stock Lanes";
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.Gainsboro;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            iconButton3.IconColor = Color.Gainsboro;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 24;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.ImeMode = ImeMode.NoControl;
            iconButton3.Location = new Point(0, 530);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(219, 45);
            iconButton3.TabIndex = 23;
            iconButton3.Text = "  Production Plan";
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // ExitButton
            // 
            ExitButton.Dock = DockStyle.Bottom;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.ForeColor = Color.Gainsboro;
            ExitButton.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            ExitButton.IconColor = Color.Gainsboro;
            ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ExitButton.IconSize = 24;
            ExitButton.ImageAlign = ContentAlignment.MiddleLeft;
            ExitButton.ImeMode = ImeMode.NoControl;
            ExitButton.Location = new Point(0, 757);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(219, 51);
            ExitButton.TabIndex = 21;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ReportBugButton
            // 
            ReportBugButton.Dock = DockStyle.Top;
            ReportBugButton.FlatAppearance.BorderSize = 0;
            ReportBugButton.FlatStyle = FlatStyle.Flat;
            ReportBugButton.ForeColor = Color.Gainsboro;
            ReportBugButton.IconChar = FontAwesome.Sharp.IconChar.HeadSideCough;
            ReportBugButton.IconColor = Color.Gainsboro;
            ReportBugButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ReportBugButton.IconSize = 24;
            ReportBugButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReportBugButton.ImeMode = ImeMode.NoControl;
            ReportBugButton.Location = new Point(0, 485);
            ReportBugButton.Name = "ReportBugButton";
            ReportBugButton.Size = new Size(219, 45);
            ReportBugButton.TabIndex = 20;
            ReportBugButton.Text = "  Report Bug";
            ReportBugButton.UseVisualStyleBackColor = true;
            ReportBugButton.Click += ReportBugButton_Click;
            // 
            // HandoverButton4
            // 
            HandoverButton4.Dock = DockStyle.Top;
            HandoverButton4.FlatAppearance.BorderSize = 0;
            HandoverButton4.FlatStyle = FlatStyle.Flat;
            HandoverButton4.ForeColor = Color.Gainsboro;
            HandoverButton4.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            HandoverButton4.IconColor = Color.Gainsboro;
            HandoverButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HandoverButton4.IconSize = 24;
            HandoverButton4.ImageAlign = ContentAlignment.MiddleLeft;
            HandoverButton4.ImeMode = ImeMode.NoControl;
            HandoverButton4.Location = new Point(0, 440);
            HandoverButton4.Name = "HandoverButton4";
            HandoverButton4.Size = new Size(219, 45);
            HandoverButton4.TabIndex = 19;
            HandoverButton4.Text = "  Hang On ";
            HandoverButton4.UseVisualStyleBackColor = true;
            HandoverButton4.Click += HandoverButton4_Click;
            // 
            // HandoverButton3
            // 
            HandoverButton3.Dock = DockStyle.Top;
            HandoverButton3.FlatAppearance.BorderSize = 0;
            HandoverButton3.FlatStyle = FlatStyle.Flat;
            HandoverButton3.ForeColor = Color.Gainsboro;
            HandoverButton3.IconChar = FontAwesome.Sharp.IconChar.Truck;
            HandoverButton3.IconColor = Color.Gainsboro;
            HandoverButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HandoverButton3.IconSize = 24;
            HandoverButton3.ImageAlign = ContentAlignment.MiddleLeft;
            HandoverButton3.ImeMode = ImeMode.NoControl;
            HandoverButton3.Location = new Point(0, 395);
            HandoverButton3.Name = "HandoverButton3";
            HandoverButton3.Size = new Size(219, 45);
            HandoverButton3.TabIndex = 18;
            HandoverButton3.Text = "  Shipments";
            HandoverButton3.UseVisualStyleBackColor = true;
            HandoverButton3.Click += HandoverButton3_Click;
            // 
            // HandoverButton2
            // 
            HandoverButton2.Dock = DockStyle.Top;
            HandoverButton2.FlatAppearance.BorderSize = 0;
            HandoverButton2.FlatStyle = FlatStyle.Flat;
            HandoverButton2.ForeColor = Color.Gainsboro;
            HandoverButton2.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            HandoverButton2.IconColor = Color.Gainsboro;
            HandoverButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HandoverButton2.IconSize = 24;
            HandoverButton2.ImageAlign = ContentAlignment.MiddleLeft;
            HandoverButton2.ImeMode = ImeMode.NoControl;
            HandoverButton2.Location = new Point(0, 350);
            HandoverButton2.Name = "HandoverButton2";
            HandoverButton2.Size = new Size(219, 45);
            HandoverButton2.TabIndex = 17;
            HandoverButton2.Text = "  Handover";
            HandoverButton2.UseVisualStyleBackColor = true;
            HandoverButton2.Click += HandoverButton2_Click;
            // 
            // TrackerButton
            // 
            TrackerButton.Dock = DockStyle.Top;
            TrackerButton.FlatAppearance.BorderSize = 0;
            TrackerButton.FlatStyle = FlatStyle.Flat;
            TrackerButton.ForeColor = Color.Gainsboro;
            TrackerButton.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            TrackerButton.IconColor = Color.Gainsboro;
            TrackerButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TrackerButton.IconSize = 24;
            TrackerButton.ImageAlign = ContentAlignment.MiddleLeft;
            TrackerButton.ImeMode = ImeMode.NoControl;
            TrackerButton.Location = new Point(0, 305);
            TrackerButton.Name = "TrackerButton";
            TrackerButton.Size = new Size(219, 45);
            TrackerButton.TabIndex = 15;
            TrackerButton.Text = "  Packaging Tracker";
            TrackerButton.UseVisualStyleBackColor = true;
            TrackerButton.Click += TrackerButton_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.Gainsboro;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Car;
            iconButton2.IconColor = Color.Gainsboro;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 24;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.ImeMode = ImeMode.NoControl;
            iconButton2.Location = new Point(0, 260);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(219, 45);
            iconButton2.TabIndex = 22;
            iconButton2.Text = "  Bentley Count";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // InternalPackagingButton
            // 
            InternalPackagingButton.Dock = DockStyle.Top;
            InternalPackagingButton.FlatAppearance.BorderSize = 0;
            InternalPackagingButton.FlatStyle = FlatStyle.Flat;
            InternalPackagingButton.ForeColor = Color.Gainsboro;
            InternalPackagingButton.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            InternalPackagingButton.IconColor = Color.Gainsboro;
            InternalPackagingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            InternalPackagingButton.IconSize = 24;
            InternalPackagingButton.ImageAlign = ContentAlignment.MiddleLeft;
            InternalPackagingButton.ImeMode = ImeMode.NoControl;
            InternalPackagingButton.Location = new Point(0, 215);
            InternalPackagingButton.Name = "InternalPackagingButton";
            InternalPackagingButton.Size = new Size(219, 45);
            InternalPackagingButton.TabIndex = 14;
            InternalPackagingButton.Text = "  Internal";
            InternalPackagingButton.UseVisualStyleBackColor = true;
            InternalPackagingButton.Click += InternalPackagingButton_Click;
            // 
            // PackagingCountButton
            // 
            PackagingCountButton.Dock = DockStyle.Top;
            PackagingCountButton.FlatAppearance.BorderSize = 0;
            PackagingCountButton.FlatStyle = FlatStyle.Flat;
            PackagingCountButton.ForeColor = Color.Gainsboro;
            PackagingCountButton.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            PackagingCountButton.IconColor = Color.Gainsboro;
            PackagingCountButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PackagingCountButton.IconSize = 24;
            PackagingCountButton.ImageAlign = ContentAlignment.MiddleLeft;
            PackagingCountButton.ImeMode = ImeMode.NoControl;
            PackagingCountButton.Location = new Point(0, 170);
            PackagingCountButton.Name = "PackagingCountButton";
            PackagingCountButton.Size = new Size(219, 45);
            PackagingCountButton.TabIndex = 13;
            PackagingCountButton.Text = "  BMW Count";
            PackagingCountButton.UseVisualStyleBackColor = true;
            PackagingCountButton.Click += PackagingCountButton_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 24;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.ImeMode = ImeMode.NoControl;
            iconButton1.Location = new Point(0, 125);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(219, 45);
            iconButton1.TabIndex = 12;
            iconButton1.Text = "  MHE Training";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // exportButton1
            // 
            exportButton1.Dock = DockStyle.Top;
            exportButton1.FlatAppearance.BorderSize = 0;
            exportButton1.FlatStyle = FlatStyle.Flat;
            exportButton1.ForeColor = Color.Gainsboro;
            exportButton1.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            exportButton1.IconColor = Color.Gainsboro;
            exportButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exportButton1.IconSize = 24;
            exportButton1.ImageAlign = ContentAlignment.MiddleLeft;
            exportButton1.ImeMode = ImeMode.NoControl;
            exportButton1.Location = new Point(0, 80);
            exportButton1.Name = "exportButton1";
            exportButton1.Size = new Size(219, 45);
            exportButton1.TabIndex = 11;
            exportButton1.Text = "  Exports";
            exportButton1.UseVisualStyleBackColor = true;
            exportButton1.Click += exportButton1_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(219, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.LightGray;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(58, 21);
            label1.Name = "label1";
            label1.Size = new Size(106, 35);
            label1.TabIndex = 0;
            label1.Text = "Liberum";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildform);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(219, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(902, 80);
            panelTitleBar.TabIndex = 36;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Broadway", 19.8000011F);
            btnMinimize.ForeColor = Color.Gainsboro;
            btnMinimize.ImageAlign = ContentAlignment.TopCenter;
            btnMinimize.ImeMode = ImeMode.NoControl;
            btnMinimize.Location = new Point(789, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Padding = new Padding(1, 0, 0, 0);
            btnMinimize.Size = new Size(34, 75);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "O";
            btnMinimize.UseMnemonic = false;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Broadway", 19.8000011F);
            btnMaximize.ForeColor = Color.Gainsboro;
            btnMaximize.ImageAlign = ContentAlignment.TopCenter;
            btnMaximize.ImeMode = ImeMode.NoControl;
            btnMaximize.Location = new Point(829, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Padding = new Padding(1, 0, 0, 0);
            btnMaximize.Size = new Size(34, 75);
            btnMaximize.TabIndex = 3;
            btnMaximize.Text = "O";
            btnMaximize.UseMnemonic = false;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += button11_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Broadway", 19.8000011F);
            btnClose.ForeColor = Color.Gainsboro;
            btnClose.ImageAlign = ContentAlignment.TopCenter;
            btnClose.Location = new Point(865, 0);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(1, 0, 0, 0);
            btnClose.Size = new Size(34, 75);
            btnClose.TabIndex = 2;
            btnClose.Text = "O";
            btnClose.UseMnemonic = false;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCloseChildform
            // 
            btnCloseChildform.Dock = DockStyle.Left;
            btnCloseChildform.FlatAppearance.BorderSize = 0;
            btnCloseChildform.FlatStyle = FlatStyle.Flat;
            btnCloseChildform.Image = Properties.Resources.cross_out__2_;
            btnCloseChildform.Location = new Point(0, 0);
            btnCloseChildform.Name = "btnCloseChildform";
            btnCloseChildform.Size = new Size(82, 80);
            btnCloseChildform.TabIndex = 1;
            btnCloseChildform.UseVisualStyleBackColor = true;
            btnCloseChildform.Click += btnCloseChildform_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F);
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Location = new Point(293, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(87, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.AutoScroll = true;
            panelDesktopPanel.AutoSize = true;
            panelDesktopPanel.Controls.Add(label2);
            panelDesktopPanel.Controls.Add(pictureBox1);
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(219, 80);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(902, 728);
            panelDesktopPanel.TabIndex = 37;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(247, 276);
            label2.Name = "label2";
            label2.Size = new Size(321, 35);
            label2.TabIndex = 1;
            label2.Text = "Sunday, 29 September 2029";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(293, 211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 85);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1121, 808);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(749, 498);
            Name = "MainPanel";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Panel ";
            WindowState = FormWindowState.Maximized;
            Load += MainPanel_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPanel.ResumeLayout(false);
            panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelMenu;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private Button button7;
        private Button button4;
        private Button button3;
        private Label lblTitle;
        private Panel panelDesktopPanel;
        private Button btnCloseChildform;
        private PictureBox pictureBox1;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnMaximize;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton exportButton1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton PackagingCountButton;
        private FontAwesome.Sharp.IconButton InternalPackagingButton;
        private FontAwesome.Sharp.IconButton TrackerButton;
        private FontAwesome.Sharp.IconButton HandoverButton4;
        private FontAwesome.Sharp.IconButton HandoverButton3;
        private FontAwesome.Sharp.IconButton HandoverButton2;
        private FontAwesome.Sharp.IconButton ReportBugButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}