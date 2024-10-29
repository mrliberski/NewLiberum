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
    public partial class Shipments : Form
    {

        public CurrentHandoverModel _handover = new CurrentHandoverModel(); // To store information from db and updated to db
        public List<string> Shifts = new List<string>();                    // List of shifts from db
        private static System.Timers.Timer closeTimer;                      // Timer to close down the handover page after 5 mins of idle - to prevent write conflict
        public int HandoverVersion = 0;                                     // Handover index version - int in db - cannot overwrite handover stored in db with higher index

        public Shipments()
        {
            InitializeComponent();
            LoadTheme();                        // Load colour theme
            ReloadForm();                       // Refresh data - fetch from DB
            StartCloseTimer();                  // start idle timer 
            Autosave();                         // turn autosave every 4 mins for selected people (team leaders)
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

            _handover.DespatchPlan1 = textBox7.Text;
            _handover.Arrival1 = textBox8.Text;
            _handover.Departure1 = textBox9.Text;
            _handover.FirstSeq1 = textBox10.Text;
            _handover.LastSeq1 = textBox11.Text;
            _handover.RegNumber1 = textBox12.Text;
            _handover.ToPlan1 = textBox13.Text;
            _handover.Comment1 = textBox14.Text;

            _handover.DespatchPlan2 = textBox22.Text;
            _handover.Arrival2 = textBox21.Text;
            _handover.Departure2 = textBox20.Text;
            _handover.FirstSeq2 = textBox19.Text;
            _handover.LastSeq2 = textBox18.Text;
            _handover.RegNumber2 = textBox17.Text;
            _handover.ToPlan2 = textBox16.Text;
            _handover.Comment2 = textBox15.Text;

            _handover.DespatchPlan3 = textBox30.Text;
            _handover.Arrival3 = textBox29.Text;
            _handover.Departure3 = textBox28.Text;
            _handover.FirstSeq3 = textBox27.Text;
            _handover.LastSeq3 = textBox26.Text;
            _handover.RegNumber3 = textBox25.Text;
            _handover.ToPlan3 = textBox24.Text;
            _handover.Comment3 = textBox23.Text;

            _handover.DespatchPlan4 = textBox38.Text;
            _handover.Arrival4 = textBox37.Text;
            _handover.Departure4 = textBox36.Text;
            _handover.FirstSeq4 = textBox35.Text;
            _handover.LastSeq4 = textBox34.Text;
            _handover.RegNumber4 = textBox33.Text;
            _handover.ToPlan4 = textBox32.Text;
            _handover.Comment4 = textBox31.Text;

            _handover.DespatchPlan5 = textBox46.Text;
            _handover.Arrival5 = textBox45.Text;
            _handover.Departure5 = textBox44.Text;
            _handover.FirstSeq5 = textBox43.Text;
            _handover.LastSeq5 = textBox42.Text;
            _handover.RegNumber5 = textBox41.Text;
            _handover.ToPlan5 = textBox40.Text;
            _handover.Comment5 = textBox39.Text;

            _handover.DespatchPlan6 = textBox54.Text;
            _handover.Arrival6 = textBox53.Text;
            _handover.Departure6 = textBox52.Text;
            _handover.FirstSeq6 = textBox51.Text;
            _handover.LastSeq6 = textBox50.Text;
            _handover.RegNumber6 = textBox49.Text;
            _handover.ToPlan6 = textBox48.Text;
            _handover.Comment6 = textBox47.Text;

            _handover.DespatchPlan7 = textBox62.Text;
            _handover.Arrival7 = textBox61.Text;
            _handover.Departure7 = textBox60.Text;
            _handover.FirstSeq7 = textBox59.Text;
            _handover.LastSeq7 = textBox58.Text;
            _handover.RegNumber7 = textBox57.Text;
            _handover.ToPlan7 = textBox56.Text;
            _handover.Comment7 = textBox55.Text;

            _handover.DespatchPlan8 = textBox70.Text;
            _handover.Arrival8 = textBox69.Text;
            _handover.Departure8 = textBox68.Text;
            _handover.FirstSeq8 = textBox67.Text;
            _handover.LastSeq8 = textBox66.Text;
            _handover.RegNumber8 = textBox65.Text;
            _handover.ToPlan8 = textBox64.Text;
            _handover.Comment8 = textBox63.Text;

            _handover.DespatchPlan9 = textBox72.Text;
            _handover.Arrival9 = textBox71.Text;
            _handover.Departure9 = textBox6.Text;
            _handover.FirstSeq9 = textBox5.Text;
            _handover.LastSeq9 = textBox4.Text;
            _handover.RegNumber9 = textBox3.Text;
            _handover.ToPlan9 = textBox2.Text;
            _handover.Comment9 = textBox1.Text;

            _handover.DespatchPlan10 = textBox80.Text;
            _handover.Arrival10 = textBox79.Text;
            _handover.Departure10 = textBox78.Text;
            _handover.FirstSeq10 = textBox77.Text;
            _handover.LastSeq10 = textBox76.Text;
            _handover.RegNumber10 = textBox75.Text;
            _handover.ToPlan10 = textBox74.Text;
            _handover.Comment10 = textBox73.Text;

            // increment handover version
            HandoverVersion = HandoverVersion + 1;
            _handover.HandoverNumber = HandoverVersion;

            _handover.SubmittedDate = DateTime.Now;
            AutoSaveLabel.Text = "Data Saved.";

            SqliteDataAccess.InsertShipmentsOnly(_handover);

            //try
            //{
            //    MessageBox.Show("inserting");
            //    SqliteDataAccess.InsertShipmentsOnly(_handover);
            //}
            //catch (Exception ex) { AutoSaveLabel.Text = ex.Message; }
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

        // Second of two functions controlling automatic close of the form after 5 mins of idle time - to prevent overwrite conflict between instances of software
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                SaveState();
                this.Close();
            });
        }

        private void ReloadForm()
        {
            //Fetch current state from database
            //Populate filelds
            _handover = SqliteDataAccess.FetchCurrentState();

            textBox7.Text = _handover.DespatchPlan1;
            textBox8.Text = _handover.Arrival1;
            textBox9.Text = _handover.Departure1;
            textBox10.Text = _handover.FirstSeq1;
            textBox11.Text = _handover.LastSeq1;
            textBox12.Text = _handover.RegNumber1;
            textBox13.Text = _handover.ToPlan1;
            textBox14.Text = _handover.Comment1;

            textBox22.Text = _handover.DespatchPlan2;
            textBox21.Text = _handover.Arrival2;
            textBox20.Text = _handover.Departure2;
            textBox19.Text = _handover.FirstSeq2;
            textBox18.Text = _handover.LastSeq2;
            textBox17.Text = _handover.RegNumber2;
            textBox16.Text = _handover.ToPlan2;
            textBox15.Text = _handover.Comment2;

            textBox30.Text = _handover.DespatchPlan3;
            textBox29.Text = _handover.Arrival3;
            textBox28.Text = _handover.Departure3;
            textBox27.Text = _handover.FirstSeq3;
            textBox26.Text = _handover.LastSeq3;
            textBox25.Text = _handover.RegNumber3;
            textBox24.Text = _handover.ToPlan3;
            textBox23.Text = _handover.Comment3;

            textBox38.Text = _handover.DespatchPlan4;
            textBox37.Text = _handover.Arrival4;
            textBox36.Text = _handover.Departure4;
            textBox35.Text = _handover.FirstSeq4;
            textBox34.Text = _handover.LastSeq4;
            textBox33.Text = _handover.RegNumber4;
            textBox32.Text = _handover.ToPlan4;
            textBox31.Text = _handover.Comment4;

            textBox46.Text = _handover.DespatchPlan5;
            textBox45.Text = _handover.Arrival5;
            textBox44.Text = _handover.Departure5;
            textBox43.Text = _handover.FirstSeq5;
            textBox42.Text = _handover.LastSeq5;
            textBox41.Text = _handover.RegNumber5;
            textBox40.Text = _handover.ToPlan5;
            textBox39.Text = _handover.Comment5;

            textBox54.Text = _handover.DespatchPlan6;
            textBox53.Text = _handover.Arrival6;
            textBox52.Text = _handover.Departure6;
            textBox51.Text = _handover.FirstSeq6;
            textBox50.Text = _handover.LastSeq6;
            textBox49.Text = _handover.RegNumber6;
            textBox48.Text = _handover.ToPlan6;
            textBox47.Text = _handover.Comment6;

            textBox62.Text = _handover.DespatchPlan7;
            textBox61.Text = _handover.Arrival7;
            textBox60.Text = _handover.Departure7;
            textBox59.Text = _handover.FirstSeq7;
            textBox58.Text = _handover.LastSeq7;
            textBox57.Text = _handover.RegNumber7;
            textBox56.Text = _handover.ToPlan7;
            textBox55.Text = _handover.Comment7;

            textBox70.Text = _handover.DespatchPlan8;
            textBox69.Text = _handover.Arrival8;
            textBox68.Text = _handover.Departure8;
            textBox67.Text = _handover.FirstSeq8;
            textBox66.Text = _handover.LastSeq8;
            textBox65.Text = _handover.RegNumber8;
            textBox64.Text = _handover.ToPlan8;
            textBox63.Text = _handover.Comment8;

            textBox72.Text = _handover.DespatchPlan9;
            textBox71.Text = _handover.Arrival9;
            textBox6.Text = _handover.Departure9;
            textBox5.Text = _handover.FirstSeq9;
            textBox4.Text = _handover.LastSeq9;
            textBox3.Text = _handover.RegNumber9;
            textBox2.Text = _handover.ToPlan9;
            textBox1.Text = _handover.Comment9;

            textBox80.Text = _handover.DespatchPlan10;
            textBox79.Text = _handover.Arrival10;
            textBox78.Text = _handover.Departure10;
            textBox77.Text = _handover.FirstSeq10;
            textBox76.Text = _handover.LastSeq10;
            textBox75.Text = _handover.RegNumber10;
            textBox74.Text = _handover.ToPlan10;
            textBox73.Text = _handover.Comment10;

            HandoverVersion = _handover.HandoverNumber;

            label5.Text = SqliteDataAccess.GetLastSubmittedUserName();
            label3.Text = SqliteDataAccess.GetWhenLastHandoverWasSubmitted();
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

        private void UpdateUnsavedLabel()
        {
            AutoSaveLabel.Text = "Make sure to save data.";
        }

        // CLEAR
        private void ClearShipmentsButton_Click(object sender, EventArgs e)
        {
            ResetTimer();

            DialogResult iExit;
            iExit = MessageBox.Show("All info will be cleared, continue?", "Please confirm..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (iExit == DialogResult.Yes)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                }

                SaveState();
            }
        }

        //SAVE
        private void button2_Click(object sender, EventArgs e)
        {
            ResetTimer();
            SaveState();
        }

        // RELOAD
        private void button3_Click(object sender, EventArgs e)
        {
            try { ReloadForm(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            ResetTimer();
        }


        // PLAN 1
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        // PLAN 2

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        // PLAN 3
        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox29_TextChanged_1(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        // PLAN 4
        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        // PLAN 5
        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        // PLAN 6
        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        // PLAN 7
        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        // PLAN 8
        private void textBox70_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        // PLAN 9
        private void textBox72_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox71_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        // PLAN 10
        private void textBox80_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox79_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox78_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
            UpdateUnsavedLabel();
        }
    }
}
