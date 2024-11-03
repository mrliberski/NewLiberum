using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProFormaLibraries;
using ProFormaLibrary;
using ProFormaUI;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Runtime.InteropServices;
using System.Media;
using System.Globalization;



namespace ProFormaUI
{
    public partial class MainPanel : Form
    {
        // Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public DateTime deadLine = new DateTime(2025, 01, 07);


        //Constructor
        public MainPanel()
        {
            InitializeComponent();

            //Log visitor
            SqliteDataAccess.InsertVisit();

            // style formatting 
            random = new Random();
            btnCloseChildform.Visible = false;

            //remove frame
            this.Text = string.Empty;
            this.ControlBox = false;

            //This bit will restrict the size of window to cover the taskbar
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            AmendDeadLine();
            CheckLicence();
            CheckAppAccess();
            CheckMHEaccess();
            NotificationsLogic.DisplayNotificationsAsRequired();
            timer1.Start();
            SetDateLabel();
        }

        //


        private void ShowButtons()
        {
            exportButton1.Visible = true;
            iconButton1.Visible = true; iconButton1.Enabled = false;
            PackagingCountButton.Visible = true;
            InternalPackagingButton.Visible = true;
            TrackerButton.Visible = true;
            HandoverButton1.Visible = true;
            HandoverButton2.Visible = true;
            HandoverButton3.Visible = true;
            HandoverButton4.Visible = true;
            ReportBugButton.Visible = true;
        }

        private void HideButtons()
        {
            exportButton1.Visible = false;
            iconButton1.Visible = false;
            PackagingCountButton.Visible = false;
            InternalPackagingButton.Visible = false;
            TrackerButton.Visible = false;
            HandoverButton1.Visible = false;
            HandoverButton2.Visible = false;
            HandoverButton3.Visible = false;
            HandoverButton4.Visible = false;
            ReportBugButton.Visible = false;
        }

        private void ShowMHE() { iconButton1.Visible = true; iconButton1.Enabled = true; }

        private void HideMHE() { iconButton1.Visible = false; iconButton1.Enabled = false; }

        private void CheckAppAccess()
        {
            try 
            {
                string currentUser = Environment.UserName;
                List<UserModel> users = SqliteDataAccess.PermittedUsers();

                foreach (var user in users)
                {
                    DateTime ExpiryDate = DateTime.ParseExact(user.Expiry, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    if (user.User.ToUpper() == currentUser.ToUpper() && ExpiryDate > DateTime.Now)
                    {
                        ShowButtons();
                        return;
                    }
                    else 
                    {
                        HideButtons();
                        MessageBox.Show("Hello World.");
                    }
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Exception");
            }
        }

        private void CheckMHEaccess()
        {
            try
            {
                string currentUser = Environment.UserName;
                List<UserModel> users = SqliteDataAccess.PermittedUsersMHE();

                foreach (var user in users)
                {
                    DateTime ExpiryDate = DateTime.ParseExact(user.Expiry, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    if (user.User.ToUpper() == currentUser.ToUpper() && ExpiryDate > DateTime.Now)
                    {
                        ShowMHE();
                        return;
                    }
                    else
                    {
                        HideMHE();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception");
            }
        }


        /// <summary>
        /// /dragging window
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// <summary>
        /// end of dragging window
        /// </summary>
        /// <returns></returns>


        //methods

        private void AmendDeadLine()
        {
            if (Environment.UserName.ToUpper() == "PAWEL.LIBERSKI" || Environment.UserName.ToUpper() == "PANLI" || Environment.UserName.ToUpper() == "ALINA.SIM")
            {
                deadLine = new DateTime(2099, 08, 01);
            }
        }

        private void CheckLicence()
        {
            if (ValidateExpiryDate())
            {
                MessageBox.Show("Licence Expired. Please obtaina a licenced version of a software.", "Expired Licence", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //System.Windows.Forms.Application.Exit();

                string directoryPath = @".\Sounds";
                string filePath = Path.Combine(directoryPath, "p-hub-bro.wav");

                // Create a SoundPlayer object with the desired sound file
                SoundPlayer customSound = new SoundPlayer(filePath);
                customSound.Play();

                // MessageBox.Show("This module is not yet available.", "Disappointment.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // MessageBox.Show("Licence Expired. Please obtaina a licenced version of a software.", "Expired Licence", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Show a message box and set the sound for that message box
                // MessageBox.Show("Custom sound message box", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, true, "customSound");

                // Play the custom sound
                System.Reflection.Assembly.GetExecutingAssembly().PlaySound("customSound", customSound);






            }
        }

        private bool ValidateExpiryDate()
        {
            DateTime Expiration = deadLine;

            if (Expiration < DateTime.Today)
            {
                return true;
            }
            else if (Expiration == DateTime.Today)
            {
                MessageBox.Show("The licence will expire today", "Suspense", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Expiration > DateTime.Today)
            {
                //MessageBox.Show(@"Welcome, This is a demo software and is provided with on as-is basis. It comes with no warranties whatsoever. ", "Licence Expiry date: " + Expiration.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                MessageBox.Show("No idea man", "WTF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private System.Drawing.Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }

        // Highlight the buitton that has been clicked
        // select random color from theme
        // change bckgrnd of buttom
        // Selected font color of button
        //  change font size of button
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    System.Drawing.Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = System.Drawing.Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    // Apply theme colour to child form buttons
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    btnCloseChildform.Visible = true;
                }
            }

        }

        private void DisableButton()
        {
            foreach (System.Windows.Forms.Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button) || previousBtn.GetType() == typeof(FontAwesome.Sharp.IconButton))
                {
                    previousBtn.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = System.Drawing.Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnCounts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //highlight active button
            ActivateButton(btnSender);


            //format child form and open within a panel
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = childForm.Text;

        }





        private void MainPanel_Load(object sender, EventArgs e)
        {

        }

        //export
        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new ProFormaGenerator(), sender);
        }

        //Packaging count
        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.formCounts(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.StockCount(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.ControlPage(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.PackagingTracker(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Handover(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.InternalPackaging(), sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(new Forms.formCounts(), sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.SubmitBug(), sender);
        }

        // exit button
        private void button10_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Close();
        }

        private void btnCloseChildform_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
                //ActivateButton(sender);
            }
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = System.Drawing.Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildform.Visible = false;
            panelMenu.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //exit button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //maximize button
        private void button11_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void SetDateLabel()
        {
            label2.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void exportButton1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new ProFormaGenerator(), sender);
        }

        private void PackagingCountButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.formCounts(), sender);
        }

        private void InternalPackagingButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.InternalPackaging(), sender);
        }

        private void TrackerButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.PackagingTracker(), sender);
        }

        private void HandoverButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Handover(), sender);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Close();
        }

        private void ReportBugButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.SubmitBug(), sender);
        }

        private void HandoverButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Shipments(), sender);
        }

        private void HandoverButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.HangOn(), sender);
        }

        private void HandoverButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.NewHandover(), sender);
        }

        //MHE TRAINING BUTTON
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.MheTraining(), sender);
        }
    }
}
