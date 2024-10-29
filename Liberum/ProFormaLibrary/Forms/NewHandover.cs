using ProFormaLibraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ProFormaUI.Forms
{
    public partial class NewHandover : Form
    {
        // Initialize common variables used to control the form 

        public CurrentHandoverModel _handover = new CurrentHandoverModel(); // To store information from db and updated to db
        public List<string> Shifts = new List<string>();                    // List of shifts from db
        private static System.Timers.Timer closeTimer;                      // Timer to close down the handover page after 5 mins of idle - to prevent write conflict
        public int HandoverVersion = 0;                                     // Handover index version - int in db - cannot overwrite handover stored in db with higher index

        public NewHandover()
        {
            InitializeComponent();
            LoadTheme();                        // Load colour theme
            LoadShiftsDropDown();               // Populate drop down
            ReloadForm();                       // Refresh data - fetch from DB
            StartCloseTimer();                  // start idle timer 
            Autosave();                         // turn autosave every 4 mins for selected people (team leaders)
        }

        // First of two functions controlling automatic close of the form after 5 mins of idle time - to prevent overwrite conflict between instances of software
        private void StartCloseTimer()
        {
            closeTimer = new System.Timers.Timer(300000); // 300000 ms = 5 minutes
            closeTimer.Elapsed += OnTimedEvent;
            closeTimer.AutoReset = false;
            closeTimer.Enabled = true;
        }

        //resets timer on textbox change
        private void ResetTimer()
        {
            if (closeTimer != null)
            {
                closeTimer.Stop();
                closeTimer.Start();
            }
        }

        // Second of two functions controlling automatic close of the form after 5 mins of idle time - to prevent overwrite conflict between instances of software
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                SaveState();
                this.Close();
            });
        }

        //Load drop down list of shifts # 1 of 2
        private void LoadShiftsDropDown()
        {
            Shifts.Clear();
            Shifts = SqliteDataAccess.GetShifts();
            WireUpShifts();
        }
        //Load drop down list of shifts # 2of 2
        private void WireUpShifts()
        {
            comboBox1.Items.Clear();
            comboBox1.DataSource = null;
            comboBox1.DataSource = Shifts;
        }

        // Apply button themes to current forms
        private void LoadTheme()
        {
            foreach (System.Windows.Forms.Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //label3.ForeColor = ThemeColor.PrimaryColor;
            //label4.ForeColor = ThemeColor.SecondaryColor;
        }

        // autosave for two main tem leaders
        //TODO - names should be stored in db for easy edit
        private void Autosave()
        {
            if (Environment.UserName.ToUpper() == "RICHARD.PUGH" || Environment.UserName.ToUpper() == "MARCIN.CHRZASZCZ" || Environment.UserName.ToUpper() == "PANLI")
            {
                timer1.Start();
                AutoSaveLabel.Text = "Conditional save activated...";
            }
        }

        //tick event
        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Tick");
            SaveState();
            AutoSaveLabel.Text = "Conditional save active - last changes saved at " + TimeOnly.FromDateTime(DateTime.Now);
            //AutoSaveLabel.Text = "Autosave was turned off for a few days.";
        }

        // Checks version index in the db
        private bool IsLatestVersion()
        {
            int currentVersion = HandoverVersion;
            int LatestVersion = SqliteDataAccess.CheckHandoverVersion();

            if (currentVersion < LatestVersion)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SaveState()
        {
            //MessageBox.Show("Saving state");
            // if this is not the latest version, then we cannot overwrite it
            if (!IsLatestVersion())
            {
                MessageBox.Show("Somebody else has already made change to handover. You cannot overwrite it. ", "Damn man");
                return;
            }

            _handover.HandoverDate = dateTimePicker1.Value;
            _handover.Shift = comboBox1.Text;

            _handover.HealthAndSafety = HSTextBox.Text;
            _handover.EquipmentIssues = textBox1.Text;
            _handover.AssemblyLines = textBox2.Text;
            _handover.MouldShop = textBox3.Text;
            _handover.Warehouse = textBox5.Text;
            _handover.AOB = textBox6.Text;

            // increment handover version
            HandoverVersion = HandoverVersion + 1;
            _handover.HandoverNumber = HandoverVersion;

            _handover.SubmittedDate = DateTime.Now;
            AutoSaveLabel.Text = "Data Saved.";

            try
            {
                SqliteDataAccess.InsertNewCurrentHandover(_handover);
            }
            catch (Exception ex) { AutoSaveLabel.Text = ex.Message; }
        }

        private void UpdateUnsavedLabel()
        {
            AutoSaveLabel.Text = "Make sure to save data.";
        }

        //fetches data from db to repopulat ethe form 
        private void ReloadForm()
        {
            //Fetch current state from database
            //Populate filelds
            try
            {
                _handover = SqliteDataAccess.FetchCurrentState();
            }
            catch (Exception ex) { AutoSaveLabel.Text = ex.Message; }

            HSTextBox.Text = _handover.HealthAndSafety;
            textBox1.Text = _handover.EquipmentIssues;
            textBox2.Text = _handover.AssemblyLines;
            textBox3.Text = _handover.MouldShop;
            textBox5.Text = _handover.Warehouse;
            textBox6.Text = _handover.AOB;

            HandoverVersion = _handover.HandoverNumber;

            try
            {
                label27.Text = SqliteDataAccess.GetLastSubmittedUserName();
                label28.Text = SqliteDataAccess.GetWhenLastHandoverWasSubmitted();
            }
            catch (Exception ex) { AutoSaveLabel.Text += ex.Message; }
        }

        private void HSTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        // Save button click 
        private void button2_Click(object sender, EventArgs e)
        {
            ResetTimer();
            SaveState();
        }

        // new handover click - clears textboxes and saves to db
        private void button5_Click(object sender, EventArgs e)
        {
            ResetTimer();

            DialogResult iExit;
            iExit = MessageBox.Show("All info will be cleared, continue?", "Please confirm..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (iExit == DialogResult.Yes)
            {
                HSTextBox.Text = string.Empty;
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;

                SaveState();
            }
        }

        //reload
        private void button3_Click(object sender, EventArgs e)
        {
            try { ReloadForm(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            ResetTimer();
        }


        //submit handover
        private void button1_Click(object sender, EventArgs e)
        {

            try 
            {
                SaveState();
                ReloadForm();
                SubmitHandover(_handover);
                ResetTimer();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            ResetTimer();
        }

        private void SubmitHandover (CurrentHandoverModel handover)
        {
            SqliteDataAccess.InsertCurrentHandover(handover);
            SqliteDataAccess.InsertHandoverArchive(handover);
            SqliteDataAccess.InsertHandoverSubmissionStamp();
            label27.Text = SqliteDataAccess.GetLastSubmittedUserName();
            label28.Text = SqliteDataAccess.GetWhenLastHandoverWasSubmitted();
            HandoverEmail.CreateHandoverEmail(handover);
        }
    }
}
