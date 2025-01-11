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
            ExitButton = new FontAwesome.Sharp.IconButton();
            ReportBugButton = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            HandoverButton4 = new FontAwesome.Sharp.IconButton();
            HandoverButton3 = new FontAwesome.Sharp.IconButton();
            HandoverButton2 = new FontAwesome.Sharp.IconButton();
            TrackerButton = new FontAwesome.Sharp.IconButton();
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
            resources.ApplyResources(panelMenu, "panelMenu");
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
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
            panelMenu.Name = "panelMenu";
            // 
            // ExitButton
            // 
            resources.ApplyResources(ExitButton, "ExitButton");
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.ForeColor = Color.Gainsboro;
            ExitButton.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            ExitButton.IconColor = Color.Gainsboro;
            ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ExitButton.Name = "ExitButton";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ReportBugButton
            // 
            resources.ApplyResources(ReportBugButton, "ReportBugButton");
            ReportBugButton.FlatAppearance.BorderSize = 0;
            ReportBugButton.ForeColor = Color.Gainsboro;
            ReportBugButton.IconChar = FontAwesome.Sharp.IconChar.HeadSideCough;
            ReportBugButton.IconColor = Color.Gainsboro;
            ReportBugButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ReportBugButton.Name = "ReportBugButton";
            ReportBugButton.UseVisualStyleBackColor = true;
            ReportBugButton.Click += ReportBugButton_Click;
            // 
            // iconButton2
            // 
            resources.ApplyResources(iconButton2, "iconButton2");
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.ForeColor = Color.Gainsboro;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Car;
            iconButton2.IconColor = Color.Gainsboro;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Name = "iconButton2";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // HandoverButton4
            // 
            resources.ApplyResources(HandoverButton4, "HandoverButton4");
            HandoverButton4.FlatAppearance.BorderSize = 0;
            HandoverButton4.ForeColor = Color.Gainsboro;
            HandoverButton4.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            HandoverButton4.IconColor = Color.Gainsboro;
            HandoverButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HandoverButton4.Name = "HandoverButton4";
            HandoverButton4.UseVisualStyleBackColor = true;
            HandoverButton4.Click += HandoverButton4_Click;
            // 
            // HandoverButton3
            // 
            resources.ApplyResources(HandoverButton3, "HandoverButton3");
            HandoverButton3.FlatAppearance.BorderSize = 0;
            HandoverButton3.ForeColor = Color.Gainsboro;
            HandoverButton3.IconChar = FontAwesome.Sharp.IconChar.Truck;
            HandoverButton3.IconColor = Color.Gainsboro;
            HandoverButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HandoverButton3.Name = "HandoverButton3";
            HandoverButton3.UseVisualStyleBackColor = true;
            HandoverButton3.Click += HandoverButton3_Click;
            // 
            // HandoverButton2
            // 
            resources.ApplyResources(HandoverButton2, "HandoverButton2");
            HandoverButton2.FlatAppearance.BorderSize = 0;
            HandoverButton2.ForeColor = Color.Gainsboro;
            HandoverButton2.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            HandoverButton2.IconColor = Color.Gainsboro;
            HandoverButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HandoverButton2.Name = "HandoverButton2";
            HandoverButton2.UseVisualStyleBackColor = true;
            HandoverButton2.Click += HandoverButton2_Click;
            // 
            // TrackerButton
            // 
            resources.ApplyResources(TrackerButton, "TrackerButton");
            TrackerButton.FlatAppearance.BorderSize = 0;
            TrackerButton.ForeColor = Color.Gainsboro;
            TrackerButton.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            TrackerButton.IconColor = Color.Gainsboro;
            TrackerButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TrackerButton.Name = "TrackerButton";
            TrackerButton.UseVisualStyleBackColor = true;
            TrackerButton.Click += TrackerButton_Click;
            // 
            // InternalPackagingButton
            // 
            resources.ApplyResources(InternalPackagingButton, "InternalPackagingButton");
            InternalPackagingButton.FlatAppearance.BorderSize = 0;
            InternalPackagingButton.ForeColor = Color.Gainsboro;
            InternalPackagingButton.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            InternalPackagingButton.IconColor = Color.Gainsboro;
            InternalPackagingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            InternalPackagingButton.Name = "InternalPackagingButton";
            InternalPackagingButton.UseVisualStyleBackColor = true;
            InternalPackagingButton.Click += InternalPackagingButton_Click;
            // 
            // PackagingCountButton
            // 
            resources.ApplyResources(PackagingCountButton, "PackagingCountButton");
            PackagingCountButton.FlatAppearance.BorderSize = 0;
            PackagingCountButton.ForeColor = Color.Gainsboro;
            PackagingCountButton.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            PackagingCountButton.IconColor = Color.Gainsboro;
            PackagingCountButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PackagingCountButton.Name = "PackagingCountButton";
            PackagingCountButton.UseVisualStyleBackColor = true;
            PackagingCountButton.Click += PackagingCountButton_Click;
            // 
            // iconButton1
            // 
            resources.ApplyResources(iconButton1, "iconButton1");
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Name = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // exportButton1
            // 
            resources.ApplyResources(exportButton1, "exportButton1");
            exportButton1.FlatAppearance.BorderSize = 0;
            exportButton1.ForeColor = Color.Gainsboro;
            exportButton1.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            exportButton1.IconColor = Color.Gainsboro;
            exportButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exportButton1.Name = "exportButton1";
            exportButton1.UseVisualStyleBackColor = true;
            exportButton1.Click += exportButton1_Click_1;
            // 
            // panelLogo
            // 
            resources.ApplyResources(panelLogo, "panelLogo");
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Name = "panelLogo";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.LightGray;
            label1.Name = "label1";
            // 
            // panelTitleBar
            // 
            resources.ApplyResources(panelTitleBar, "panelTitleBar");
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildform);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            resources.ApplyResources(btnMinimize, "btnMinimize");
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.ForeColor = Color.Gainsboro;
            btnMinimize.Name = "btnMinimize";
            btnMinimize.UseMnemonic = false;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            resources.ApplyResources(btnMaximize, "btnMaximize");
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.ForeColor = Color.Gainsboro;
            btnMaximize.Name = "btnMaximize";
            btnMaximize.UseMnemonic = false;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += button11_Click;
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.ForeColor = Color.Gainsboro;
            btnClose.Name = "btnClose";
            btnClose.UseMnemonic = false;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCloseChildform
            // 
            resources.ApplyResources(btnCloseChildform, "btnCloseChildform");
            btnCloseChildform.FlatAppearance.BorderSize = 0;
            btnCloseChildform.Image = Properties.Resources.cross_out__2_;
            btnCloseChildform.Name = "btnCloseChildform";
            btnCloseChildform.UseVisualStyleBackColor = true;
            btnCloseChildform.Click += btnCloseChildform_Click;
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Name = "lblTitle";
            // 
            // panelDesktopPanel
            // 
            resources.ApplyResources(panelDesktopPanel, "panelDesktopPanel");
            panelDesktopPanel.Controls.Add(label2);
            panelDesktopPanel.Controls.Add(pictureBox1);
            panelDesktopPanel.Name = "panelDesktopPanel";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainPanel
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MainPanel";
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
    }
}