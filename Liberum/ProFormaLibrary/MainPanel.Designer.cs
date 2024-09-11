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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            panelMenu = new Panel();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            button1 = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            resources.ApplyResources(panelMenu, "panelMenu");
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Name = "panelMenu";
            // 
            // panelLogo
            // 
            resources.ApplyResources(panelLogo, "panelLogo");
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Name = "panelLogo";
            // 
            // panelTitleBar
            // 
            resources.ApplyResources(panelTitleBar, "panelTitleBar");
            panelTitleBar.BackColor = SystemColors.ActiveCaption;
            panelTitleBar.Name = "panelTitleBar";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.Gainsboro;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MainPanel";
            WindowState = FormWindowState.Maximized;
            Load += MainPanel_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private Button button1;
    }
}