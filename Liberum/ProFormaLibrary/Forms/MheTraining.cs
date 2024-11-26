using Microsoft.Windows.Themes;
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
using System;
using System.Collections.Generic;

using System.Drawing;
using System.Linq;

using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.Office.Interop.Outlook;
using System.Xml;
using System.Globalization;

namespace ProFormaUI.Forms
{
    public partial class MheTraining : Form
    {
        private List<string> SitesList = new List<string>();
        private List<string> ShiftList = new List<string>();
        private List<AssessmentModel> AssessmentList = new List<AssessmentModel>();



        public MheTraining()
        {
            InitializeComponent();
            LoadTheme();
            ClearContent();
            LoadSites();
            LoadShifts();
            UpdateOverview();

            // Add the event handler for the SelectionChanged event
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

        }

        //This routine updates the overview of item list by fetching all items from Assessments table
        private void UpdateOverview()
        {
            AssessmentList.Clear();
            dataGridView1.DataSource = null;
            AssessmentList = SqliteDataAccess.LoadAssessmentItems();
            dataGridView1.DataSource = AssessmentList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.Columns["Id"].Visible = false;
            //dataGridView1.Columns["Shift"].Visible = false;
            dataGridView1.Columns["CreatedDate"].Visible = false;
            dataGridView1.Columns["UpdatedDate"].Visible = false;
            dataGridView1.Columns["CreatedBy"].Visible = false;
            dataGridView1.Columns["UpdatedBy"].Visible = false;
            dataGridView1.Columns["Comments"].Visible = false;
            //dataGridView1.Columns["LiveRecord"].Visible = false;
            dataGridView1.Columns["A1"].Visible = false;
            dataGridView1.Columns["A2"].Visible = false;
            dataGridView1.Columns["A3"].Visible = false;
            dataGridView1.Columns["A4"].Visible = false;
            dataGridView1.Columns["A5"].Visible = false;
            dataGridView1.Columns["B1"].Visible = false;
            dataGridView1.Columns["B2"].Visible = false;
            dataGridView1.Columns["H1"].Visible = false;
            dataGridView1.Columns["F1"].Visible = false;
            dataGridView1.Columns["M3A"].Visible = false;
            dataGridView1.Columns["M3B"].Visible = false;
            dataGridView1.Columns["D1"].Visible = false;
            dataGridView1.Columns["Remote"].Visible = false;
            dataGridView1.Columns["Crane"].Visible = false;
            dataGridView1.Columns["Assessment"].Visible = false;

            //dataGridView1.Columns[9].HeaderText = "Registration";
            //dataGridView1.Columns[1].HeaderText = "Delivery Date";
            //dataGridView1.Columns[3].HeaderText = "Delivery Number";
            //dataGridView1.Columns[4].HeaderText = "Packaging Code";
            //dataGridView1.Columns[5].HeaderText = "Qty Advised";
            //dataGridView1.Columns[6].HeaderText = "Qty Received";

            // dataGridView1.Columns["DeliveryDate"].AutoSizeMode; 
            //dataGridView1.Columns[1].Name = "Column2";
            //dataGridView1.Columns[2].Name = "Column3";
            //dataGridView1.Columns[3].Name = "Column4";
            //dataGridView1.Columns[4].Name = "Column5";
            //dataGridView1.Columns[5].Name = "Column6";
            //dataGridView1.Columns[6].Name = "Column7";
            //dataGridView1.Columns[7].Name = "Column8";
            //dataGridView1.Columns[8].Name = "Column9";

            //dataGridView1.Columns["RegNumber"].DisplayIndex = 2;

            //NOTE: Selected index will be one and basing on this will be populating overview

            errorLabel.Text = string.Empty;
        }

        private void ClearContent()
        {
            NameTextBox.Text = string.Empty;
            SurnameTextBox.Text = string.Empty;
            CommentextBox.Text = string.Empty;
            searchBox.Text = string.Empty;
            ShiftCombo.Text = string.Empty;
            SiteCombo.Text = string.Empty;

            IdLaberlheader.Text = string.Empty;
            NameLabelHeader.Text = string.Empty;
            SurnameLabelHeader.Text = string.Empty;

            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            B1picker.Format = DateTimePickerFormat.Custom;
            B1picker.CustomFormat = " ";

            B2picker.Format = DateTimePickerFormat.Custom;
            B2picker.CustomFormat = " ";

            A1picker.Format = DateTimePickerFormat.Custom;
            A1picker.CustomFormat = " ";

            A2picker.Format = DateTimePickerFormat.Custom;
            A2picker.CustomFormat = " ";

            H1picker.Format = DateTimePickerFormat.Custom;
            H1picker.CustomFormat = " ";

            F1picker.Format = DateTimePickerFormat.Custom;
            F1picker.CustomFormat = " ";

            P1picker.Format = DateTimePickerFormat.Custom;
            P1picker.CustomFormat = " ";

            mewps3aPicker.Format = DateTimePickerFormat.Custom;
            mewps3aPicker.CustomFormat = " ";

            Mewps3Bpicker.Format = DateTimePickerFormat.Custom;
            Mewps3Bpicker.CustomFormat = " ";

            A4picker.Format = DateTimePickerFormat.Custom;
            A4picker.CustomFormat = " ";

            A5picker.Format = DateTimePickerFormat.Custom;
            A5picker.CustomFormat = " ";

            D1picker.Format = DateTimePickerFormat.Custom;
            D1picker.CustomFormat = " ";

            RemotePIcker.Format = DateTimePickerFormat.Custom;
            RemotePIcker.CustomFormat = " ";

            CranePicker.Format = DateTimePickerFormat.Custom;
            CranePicker.CustomFormat = " ";

            AssessmentPicker.Format = DateTimePickerFormat.Custom;
            AssessmentPicker.CustomFormat = " ";

            RackingPicker.Format = DateTimePickerFormat.Custom;
            RackingPicker.CustomFormat = " ";

            IdLabel.Text = string.Empty;
            NameLabel.Text = string.Empty;
            SurnameLabel.Text = string.Empty;
            errorLabel.Text = string.Empty;
        }


        // Populates combobox selections
        private void LoadSites()
        {
            SitesList.Clear();
            SitesList = SqliteDataAccess.LoadSites();
            WireUpSites();
        }

        private void WireUpSites()
        {
            SiteCombo.Items.Clear();
            SiteCombo.DataSource = null;
            SiteCombo.DataSource = SitesList;
            //MessageBox.Show("ping1");
        }

        private void LoadShifts()
        {
            ShiftList.Clear();
            ShiftList = SqliteDataAccess.LoadShifts();
            WireUpShifts();
        }

        private void WireUpShifts()
        {
            ShiftCombo.Items.Clear();
            ShiftCombo.DataSource = null;
            ShiftCombo.DataSource = ShiftList;
            //MessageBox.Show("ping2");
        }

        private void LoadTheme()
        {
            foreach (System.Windows.Forms.Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ProFormaLibraries.ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.FlatAppearance.BorderColor = ProFormaLibraries.ThemeColor.SecondaryColor;
                }
            }

            //label3.ForeColor = ThemeColor.PrimaryColor;
            //label4.ForeColor = ThemeColor.SecondaryColor;
        }

        private void MheTraining_Load(object sender, EventArgs e)
        {

        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }

        private void B1picker_ValueChanged(object sender, EventArgs e)
        {
            B1picker.Format = DateTimePickerFormat.Long;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Assuming your DataGridView is bound to a DataTable or a collection of objects
                var selectedRow = dataGridView1.SelectedRows[0];
                NameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
                SurnameTextBox.Text = selectedRow.Cells["Surname"].Value.ToString();
                SiteTextBox.Text = selectedRow.Cells["Site"].Value.ToString();
                DeptTextBox.Text = selectedRow.Cells["Shift"].Value.ToString();

                IdLaberlheader.Text = "Id";
                NameLabelHeader.Text = "Name";
                SurnameLabelHeader.Text = "Surname";
                IdLabel.Text = selectedRow.Cells["Id"].Value.ToString();
                NameLabel.Text = selectedRow.Cells["Name"].Value.ToString();
                SurnameLabel.Text = selectedRow.Cells["Surname"].Value.ToString();
                CommentextBox.Text = selectedRow.Cells["Comments"].Value.ToString();

                //A1
                try
                {
                    DateTime A1Datevalue = DateTime.ParseExact(selectedRow.Cells["A1"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    A1picker.Format = DateTimePickerFormat.Long;
                    A1picker.Value = A1Datevalue;
                }
                catch
                {
                    A1picker.Format = DateTimePickerFormat.Custom;
                    A1picker.CustomFormat = " ";
                }
                //A2
                try
                {
                    DateTime A2Datevalue = DateTime.ParseExact(selectedRow.Cells["A2"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    A2picker.Format = DateTimePickerFormat.Long;
                    A2picker.Value = A2Datevalue;
                }
                catch
                {
                    A2picker.Format = DateTimePickerFormat.Custom;
                    A2picker.CustomFormat = " ";
                }
                //A3 picker was not created yet
                //try
                //{
                //    DateTime A3Datevalue = DateTime.ParseExact(selectedRow.Cells["A3"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                //    A3picker.Format = DateTimePickerFormat.Long;= "dd/MM/yyyy";
                //    A3picker.Value = A3Datevalue;
                //}
                //catch
                //{
                //    A3picker.Format = DateTimePickerFormat.Custom;
                //    A3picker.CustomFormat = " ";
                //}

                //A4 
                try
                {
                    DateTime A4Datevalue = DateTime.ParseExact(selectedRow.Cells["A4"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    A4picker.Format = DateTimePickerFormat.Long;
                    A4picker.Value = A4Datevalue;
                }
                catch
                {
                    A4picker.Format = DateTimePickerFormat.Custom;
                    A4picker.CustomFormat = " ";
                }

                //A5
                try
                {
                    DateTime A5Datevalue = DateTime.ParseExact(selectedRow.Cells["A5"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    A5picker.Format = DateTimePickerFormat.Long;
                    A5picker.Value = A5Datevalue;
                }
                catch
                {
                    A5picker.Format = DateTimePickerFormat.Custom;
                    A5picker.CustomFormat = " ";
                }

                //B1
                try
                {
                    DateTime B1Datevalue = DateTime.ParseExact(selectedRow.Cells["B1"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    B1picker.Format = DateTimePickerFormat.Long;
                    B1picker.Value = B1Datevalue;
                }
                catch
                {
                    B1picker.Format = DateTimePickerFormat.Custom;
                    B1picker.CustomFormat = " ";
                }

                // B2
                try
                {
                    DateTime B2Datevalue = DateTime.ParseExact(selectedRow.Cells["B2"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    B2picker.Format = DateTimePickerFormat.Long;
                    //B2picker.CustomFormat = "dd/MM/yyyy";
                    B2picker.Value = B2Datevalue;
                }
                catch
                {
                    B2picker.Format = DateTimePickerFormat.Custom;
                    B2picker.CustomFormat = " ";
                }

                //H1 - tow train
                try
                {
                    DateTime H1Datevalue = DateTime.ParseExact(selectedRow.Cells["H1"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    H1picker.Format = DateTimePickerFormat.Long;
                    H1picker.Value = H1Datevalue;
                }
                catch
                {
                    H1picker.Format = DateTimePickerFormat.Custom;
                    H1picker.CustomFormat = " ";
                }

                //F1 - VNA
                try
                {
                    DateTime F1Datevalue = DateTime.ParseExact(selectedRow.Cells["F1"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    F1picker.Format = DateTimePickerFormat.Long;
                    F1picker.Value = F1Datevalue;
                }
                catch
                {
                    F1picker.Format = DateTimePickerFormat.Custom;
                    F1picker.CustomFormat = " ";
                }

                // P1 - bendi
                try
                {
                    DateTime P1Datevalue = DateTime.ParseExact(selectedRow.Cells["P1"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    P1picker.Format = DateTimePickerFormat.Long;
                    P1picker.Value = P1Datevalue;
                }
                catch
                {
                    P1picker.Format = DateTimePickerFormat.Custom;
                    P1picker.CustomFormat = " ";
                }

                // 3A
                try
                {
                    DateTime M3ADatevalue = DateTime.ParseExact(selectedRow.Cells["M3A"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    mewps3aPicker.Format = DateTimePickerFormat.Long;
                    mewps3aPicker.Value = M3ADatevalue;
                }
                catch
                {
                    mewps3aPicker.Format = DateTimePickerFormat.Custom;
                    mewps3aPicker.CustomFormat = " ";
                }

                // 3B
                try
                {
                    DateTime M3BDatevalue = DateTime.ParseExact(selectedRow.Cells["M3B"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Mewps3Bpicker.Format = DateTimePickerFormat.Long;
                    Mewps3Bpicker.Value = M3BDatevalue;
                }
                catch
                {
                    Mewps3Bpicker.Format = DateTimePickerFormat.Custom;
                    Mewps3Bpicker.CustomFormat = " ";
                }


                // D1 - reach truck
                try
                {
                    DateTime D1Datevalue = DateTime.ParseExact(selectedRow.Cells["D1"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    D1picker.Format = DateTimePickerFormat.Long;
                    D1picker.Value = D1Datevalue;
                }
                catch
                {
                    D1picker.Format = DateTimePickerFormat.Custom;
                    D1picker.CustomFormat = " ";
                }

                // remote
                try
                {
                    DateTime RemoteDatevalue = DateTime.ParseExact(selectedRow.Cells["Remote"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    RemotePIcker.Format = DateTimePickerFormat.Long;
                    RemotePIcker.Value = RemoteDatevalue;
                }
                catch
                {
                    RemotePIcker.Format = DateTimePickerFormat.Custom;
                    RemotePIcker.CustomFormat = " ";
                }

                // Crane
                try
                {
                    DateTime CraneDatevalue = DateTime.ParseExact(selectedRow.Cells["Crane"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    CranePicker.Format = DateTimePickerFormat.Long;
                    CranePicker.Value = CraneDatevalue;
                }
                catch
                {
                    CranePicker.Format = DateTimePickerFormat.Custom;
                    CranePicker.CustomFormat = " ";
                }

                //Assessments
                try
                {
                    DateTime AssessmentDatevalue = DateTime.ParseExact(selectedRow.Cells["Assessment"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    AssessmentPicker.Format = DateTimePickerFormat.Long;
                    AssessmentPicker.Value = AssessmentDatevalue;
                }
                catch
                {
                    AssessmentPicker.Format = DateTimePickerFormat.Custom;
                    AssessmentPicker.CustomFormat = " ";
                }

                // TODO: Racking Inspection
                //try
                //{
                //    DateTime RackingDatevalue = DateTime.ParseExact(selectedRow.Cells["Racking"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                //    RackingPicker.Format = DateTimePickerFormat.Long;
                //    RackingPicker.Value = RackingDatevalue;
                //}
                //catch
                //{
                //    RackingPicker.Format = DateTimePickerFormat.Custom;
                //    RackingPicker.CustomFormat = " ";
                //}




            }

        }

        private void ArchiveButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Current record will be archived and will no longer be accessible, do you wish to continue?", "Please confirm action...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (iExit == DialogResult.Yes)
            {
                int RecordId;
                if (int.TryParse(IdLabel.Text, out RecordId))
                {
                    try
                    {
                        SqliteDataAccess.UpdateLiveRecord(RecordId);
                        ClearContent();
                        UpdateOverview();
                    }
                    catch (System.Exception SomeError)
                    {
                        errorLabel.Text = SomeError.Message;
                    }
                }
                else
                {
                    errorLabel.Text = "";
                }
            }
        }

        // move to next index
        private void button3_Click(object sender, EventArgs e)
        {
            //// Ensure there is a currently selected cell
            //if (dataGridView1.CurrentCell == null)
            //{
            //    MessageBox.Show("No cell is currently selected.");
            //    return;
            //}

            //int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            //int nextRowIndex = currentRowIndex + 1;

            //// Ensure the next row is within bounds and not the new row
            //if (nextRowIndex < dataGridView1.Rows.Count - (dataGridView1.AllowUserToAddRows ? 1 : 0))
            //{
            //    // Try to set the next cell as current, defaulting to the first column
            //    try
            //    {
            //        dataGridView1.CurrentCell = dataGridView1.Rows[nextRowIndex].Cells[0];
            //    }
            //    catch (System.Exception ex)
            //    {
            //        MessageBox.Show($"Cannot move to the next row: {ex.Message}");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Already at the last row.");
            //}
        }


        // move to previous index
        private void button4_Click(object sender, EventArgs e)
        {
            //int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            //int previousRowIndex = currentRowIndex - 1;

            //if (previousRowIndex >= 0)
            //{
            //    dataGridView1.CurrentCell = dataGridView1.Rows[previousRowIndex].Cells[0];
            //}
        }
    }
}
