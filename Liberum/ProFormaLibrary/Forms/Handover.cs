using ProFormaLibraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFormaUI.Forms
{
    public partial class Handover : Form
    {
        public CurrentHandoverModel _handover = new CurrentHandoverModel();
        public List<string> Shifts = new List<string>();


        public Handover()
        {
            InitializeComponent();
            LoadTheme();
            LoadShiftsDropDown();
            ReloadForm();
            Autosave();
            
        }

        //Load drop down list of shifts
        private void LoadShiftsDropDown()
        {
            Shifts.Clear();
            Shifts = SqliteDataAccess.GetShifts();
            WireUpShifts();
        }

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
        //IGNORE
        private void DateLabel_Click(object sender, EventArgs e)
        {

        }
        //IGNORE
        private void button4_Click(object sender, EventArgs e)
        {

        }

        //Reload BUTTON CLICK
        private void button3_Click(object sender, EventArgs e)
        {
            try { ReloadForm(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ReloadForm()
        {
            //Fetch current state from database
            //Populate filelds
            _handover = SqliteDataAccess.FetchCurrentState();

            HSTextBox.Text = _handover.HealthAndSafety;
            textBox1.Text = _handover.EquipmentIssues;
            textBox2.Text = _handover.AssemblyLines;
            textBox3.Text = _handover.MouldShop;
            textBox4.Text = _handover.HangOnParts;
            textBox5.Text = _handover.Warehouse;
            textBox6.Text = _handover.AOB;

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

            label27.Text = SqliteDataAccess.GetLastSubmittedUserName();
            label28.Text = SqliteDataAccess.GetWhenLastHandoverWasSubmitted();
        }

        //Submit button click
        private void button1_Click(object sender, EventArgs e)
        {
            SaveState();
            SubmitHandover();
        }

        private void SubmitHandover()
        {
            SqliteDataAccess.InsertCurrentHandover(_handover);
            SqliteDataAccess.InsertHandoverArchive(_handover);
            SqliteDataAccess.InsertHandoverSubmissionStamp();
            label27.Text = SqliteDataAccess.GetLastSubmittedUserName();
            label28.Text = SqliteDataAccess.GetWhenLastHandoverWasSubmitted();
            HandoverEmail.CreateHandoverEmail(_handover);
        }


        //SAVE BUTTON CLICK
        private void button2_Click(object sender, EventArgs e)
        {
            SaveState();
        }

        private void SaveState()
        {
            _handover.HandoverDate = dateTimePicker1.Value;
            _handover.Shift = comboBox1.Text;

            _handover.HealthAndSafety = HSTextBox.Text;
            _handover.EquipmentIssues = textBox1.Text;
            _handover.AssemblyLines = textBox2.Text;
            _handover.MouldShop = textBox3.Text;
            _handover.HangOnParts = textBox4.Text;
            _handover.Warehouse = textBox5.Text;
            _handover.AOB = textBox6.Text;

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

            _handover.SubmittedDate = DateTime.Now;

            SqliteDataAccess.InsertCurrentHandover(_handover);
        }

        //New handover
        private void button5_Click(object sender, EventArgs e)
        {
            HSTextBox.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;

            ClearShipments();
        }

        private void ClearShipmentsButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("All shipment info will be cleared, continue?", "Please confirm..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (iExit == DialogResult.Yes)
            {
                ClearShipments();
            }
        }

        private void ClearShipments()
        {
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;
            textBox14.Text = string.Empty;

            textBox22.Text = string.Empty;
            textBox21.Text = string.Empty;
            textBox20.Text = string.Empty;
            textBox19.Text = string.Empty;
            textBox18.Text = string.Empty;
            textBox17.Text = string.Empty;
            textBox16.Text = string.Empty;
            textBox15.Text = string.Empty;

            textBox30.Text = string.Empty;
            textBox29.Text = string.Empty;
            textBox28.Text = string.Empty;
            textBox27.Text = string.Empty;
            textBox26.Text = string.Empty;
            textBox25.Text = string.Empty;
            textBox24.Text = string.Empty;
            textBox23.Text = string.Empty;

            textBox38.Text = string.Empty;
            textBox37.Text = string.Empty;
            textBox36.Text = string.Empty;
            textBox35.Text = string.Empty;
            textBox34.Text = string.Empty;
            textBox33.Text = string.Empty;
            textBox32.Text = string.Empty;
            textBox31.Text = string.Empty;

            textBox46.Text = string.Empty;
            textBox45.Text = string.Empty;
            textBox44.Text = string.Empty;
            textBox43.Text = string.Empty;
            textBox42.Text = string.Empty;
            textBox41.Text = string.Empty;
            textBox40.Text = string.Empty;
            textBox39.Text = string.Empty;

            textBox54.Text = string.Empty;
            textBox53.Text = string.Empty;
            textBox52.Text = string.Empty;
            textBox51.Text = string.Empty;
            textBox50.Text = string.Empty;
            textBox49.Text = string.Empty;
            textBox48.Text = string.Empty;
            textBox47.Text = string.Empty;

            textBox62.Text = string.Empty;
            textBox61.Text = string.Empty;
            textBox60.Text = string.Empty;
            textBox59.Text = string.Empty;
            textBox58.Text = string.Empty;
            textBox57.Text = string.Empty;
            textBox56.Text = string.Empty;
            textBox55.Text = string.Empty;

            textBox70.Text = string.Empty;
            textBox69.Text = string.Empty;
            textBox68.Text = string.Empty;
            textBox67.Text = string.Empty;
            textBox66.Text = string.Empty;
            textBox65.Text = string.Empty;
            textBox64.Text = string.Empty;
            textBox63.Text = string.Empty;

            SaveState();
        }

        // Only enable autosave for these two
        //TODO - move it to sql
        private void Autosave()
        {
            if (Environment.UserName.ToUpper() == "RICHARD.PUGH" || Environment.UserName.ToUpper() == "MARCIN.CHRZASZCZ")
            {
                timer1.Start();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            SaveState();
            AutoSaveLabel.Text = "Autosave active - last changes saved at " + TimeOnly.FromDateTime(DateTime.Now);
        }
    }
}
