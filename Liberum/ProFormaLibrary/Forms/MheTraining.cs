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

        public string RefreshMessage = "Any changes will only be displayed when overview is reloaded";



        public MheTraining()
        {
            InitializeComponent();
            LoadTheme();
            ClearContent();
            LoadSites();
            LoadShifts();
            UpdateOverview();
            SetAdminView();

            // Add the event handler for the SelectionChanged event
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void SetAdminView()
        {
            if (Environment.UserName.ToUpper() == "PANLI" || Environment.UserName.ToUpper() == "PAWEL.LIBERSKI")
            {
                SaveStateLabel.Visible = true;
                IdLabel.Visible = true;
                IdLaberlheader.Visible = true;
                NameLabel.Visible = true;
                NameLabelHeader.Visible = true;
                SurnameLabel.Visible = true;
                SurnameLabelHeader.Visible = true;
                SiteTextBox.Visible = true;
                SiteCombo.Visible = true;
                DeptTextBox.Visible = true;
                ShiftCombo.Visible = true;
                CommentextBox.Visible = true;
                errorLabel.Visible = true;
                ArchiveButton.Visible = true;
            }

            // Show the admin view
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
            //dataGridView1.Columns["A1"].Visible = false;
            //dataGridView1.Columns["A2"].Visible = false;
            //dataGridView1.Columns["A3"].Visible = false;
            //dataGridView1.Columns["A4"].Visible = false;
            //dataGridView1.Columns["A5"].Visible = false;
            //dataGridView1.Columns["B1"].Visible = false;
            //dataGridView1.Columns["B2"].Visible = false;
            //dataGridView1.Columns["H1"].Visible = false;
            //dataGridView1.Columns["F1"].Visible = false;
            //dataGridView1.Columns["M3A"].Visible = false;
            //dataGridView1.Columns["M3B"].Visible = false;
            //dataGridView1.Columns["D1"].Visible = false;
            //dataGridView1.Columns["Remote"].Visible = false;
            //dataGridView1.Columns["Crane"].Visible = false;
            //dataGridView1.Columns["Assessment"].Visible = false;
            //dataGridView1.Columns["P1"].Visible = false;
            //dataGridView1.Columns["RackingInspection"].Visible = false;

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

        private void MoveSelection()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Assuming your DataGridView is bound to a DataTable or a collection of objects
                var selectedRow = dataGridView1.SelectedRows[0];
                NameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
                SurnameTextBox.Text = selectedRow.Cells["Surname"].Value.ToString();
                SiteTextBox.Text = selectedRow.Cells["Site"].Value.ToString();
                SiteCombo.Text = selectedRow.Cells["Site"].Value.ToString();
                DeptTextBox.Text = selectedRow.Cells["Shift"].Value.ToString();
                ShiftCombo.Text = selectedRow.Cells["Shift"].Value.ToString();

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
                catch (System.Exception wtf)
                {
                    P1picker.Format = DateTimePickerFormat.Custom;
                    P1picker.CustomFormat = " ";
                    //MessageBox.Show(wtf.Message);
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


                // Racking
                try
                {
                    DateTime P1Datevalue = DateTime.ParseExact(selectedRow.Cells["RackingInspection"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    RackingPicker.Format = DateTimePickerFormat.Long;
                    RackingPicker.Value = P1Datevalue;
                }
                catch (System.Exception wtf)
                {
                    RackingPicker.Format = DateTimePickerFormat.Custom;
                    RackingPicker.CustomFormat = " ";
                    //MessageBox.Show(wtf.Message);
                }

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            // if we use conditional if then we will gety prompted on form opening which is not desired
            //if (SaveStateLabel.Text != "Saved")
            //{
            //    DialogResult iExit;
            //    iExit = MessageBox.Show("You have some unsaved changes, do you want to navigate away? Changes will be lost", "Please confirm action...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (iExit == DialogResult.Yes)
            //    {
            //        MoveSelection();
            //        SaveStateLabel.Text = "Saved";
            //    }
            //}

            MoveSelection();
            SaveStateLabel.Text = "Saved";
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
            if (SaveStateLabel.Text != "Saved")
            {
                DialogResult iExit;
                iExit = MessageBox.Show("You have some unsaved changes, do you want to navigate away? Changes will be lost", "Please confirm action...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (iExit == DialogResult.Yes)
                {
                    MoveSelectionDown();
                    SaveStateLabel.Text = "Saved";
                }
            }
            else
            {
                MoveSelectionDown();
                SaveStateLabel.Text = "Saved";
            }
        }

        //private void RackingPicker_ValueChanged(object sender, EventArgs e)
        //{
        //    RackingPicker.Format = DateTimePickerFormat.Long;
        //    try
        //    {
        //        string NewValue = RackingPicker.Value.ToString("dd/MM/yyyy");
        //        //MessageBox.Show(NewValue);
        //        SqliteDataAccess.UpdateRacking(NewValue, int.Parse(IdLabel.Text));
        //        errorLabel.Text = RefreshMessage;
        //    }
        //    catch (System.Exception wtf)
        //    {
        //        errorLabel.Text = "Racking Inspection could not be updated;";
        //        System.Diagnostics.Debug.WriteLine(wtf.Message);
        //    }
        //}

        //private void SiteCombo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string NewValue = SiteCombo.Text;
        //        //MessageBox.Show(NewValue);
        //        SqliteDataAccess.UpdateSite(NewValue, int.Parse(IdLabel.Text));
        //        errorLabel.Text = RefreshMessage;
        //    }
        //    catch
        //    {
        //        errorLabel.Text = "Site could not be updated;";
        //    }
        //}

        //private void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string NewValue = ShiftCombo.Text;
        //        //MessageBox.Show(NewValue);
        //        SqliteDataAccess.UpdateShift(NewValue, int.Parse(IdLabel.Text));
        //        errorLabel.Text = RefreshMessage;
        //    }
        //    catch
        //    {
        //        errorLabel.Text = "Shift could not be updated;";
        //    }
        //}

        //private void CommentextBox_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string NewValue = CommentextBox.Text;
        //        //MessageBox.Show(NewValue);
        //        SqliteDataAccess.UpdateComment(NewValue, int.Parse(IdLabel.Text));
        //        errorLabel.Text = RefreshMessage;
        //    }
        //    catch
        //    {
        //        errorLabel.Text = "Comment could not be updated;";
        //    }
        //}

        private void MoveSelectionUp()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int currentIndex = dataGridView1.SelectedRows[0].Index;
                if (currentIndex > 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[currentIndex - 1].Selected = true;
                }
            }
        }

        private void MoveSelectionDown()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int currentIndex = dataGridView1.SelectedRows[0].Index;
                if (currentIndex < dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[currentIndex + 1].Selected = true;
                }
            }
        }

        //// Example button click event handlers
        //private void btnUp_Click(object sender, EventArgs e)
        //{
        //    MoveSelectionUp();
        //}

        //private void btnDown_Click(object sender, EventArgs e)
        //{
        //    MoveSelectionDown();
        //}



        //private void SiteTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    //not currently used
        //}

        //private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string NewValue = SurnameTextBox.Text;
        //        //MessageBox.Show(NewValue);
        //        SqliteDataAccess.UpdateSurname(NewValue, int.Parse(IdLabel.Text));
        //        errorLabel.Text = RefreshMessage;
        //    }
        //    catch (System.Exception wtf)
        //    {
        //        errorLabel.Text = "Comment could not be updated: " + wtf.Message;
        //    }
        //}

        //private void NameTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string NewValue = NameTextBox.Text;
        //        //MessageBox.Show(NewValue);
        //        SqliteDataAccess.UpdateName(NewValue, int.Parse(IdLabel.Text));
        //        errorLabel.Text = RefreshMessage;
        //    }
        //    catch (System.Exception wtf)
        //    {
        //        errorLabel.Text = "Comment could not be updated: " + wtf.Message;
        //    }
        //}

        //Reloads overview id data grid
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateOverview();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton radioButton = sender as RadioButton;
                if (radioButton != null && radioButton.Checked)
                {
                    AssessmentList.Clear();
                    dataGridView1.DataSource = null;
                    AssessmentList = SqliteDataAccess.LoadAssessmentItems(radioButton.Text);
                    dataGridView1.DataSource = AssessmentList;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //MessageBox.Show($"You selected: {radioButton.Text}");
                }
            }
            catch (System.Exception wtf)
            {
                errorLabel.Text = wtf.Message;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOverview();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (searchBox.Text != null)
                {
                    AssessmentList.Clear();
                    dataGridView1.DataSource = null;
                    AssessmentList = SqliteDataAccess.LoadAssessmentItemsSearch(searchBox.Text);
                    dataGridView1.DataSource = AssessmentList;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (System.Exception wtf)
            {
                errorLabel.Text = wtf.Message;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form open = new AddNewTrainee();
            open.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowMatrix();
        }

        private void ShowMatrix()
        {
            DialogResult iExit;
            iExit = MessageBox.Show("New matrix will be created, continue?", "Please confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                if (AssessmentList.Count > 0)
                {
                    try
                    {
                        MheMatrix.CreateHtmlMatrix(AssessmentList);
                        //DrawHtmlMatrix(AssessmentList);
                        //ConvertMatrixtToPdf();
                        //OpenFolder();
                        System.Diagnostics.Process.Start("explorer.exe", @".\Matrix");
                        System.Diagnostics.Debug.WriteLine("Possibly it went OK");
                    }
                    catch (System.Exception ex)
                    {
                        errorLabel.Text = string.Empty;
                        errorLabel.Text += ex.Message;
                        System.Diagnostics.Debug.WriteLine("MATRIX GENERATION FAILED BECAUSE OF " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("No items were found on the list.", "What are you doing stepbrother?", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
        }

        // Move to previous index and display warning if unsaved changes
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (SaveStateLabel.Text != "Saved")
            {
                DialogResult iExit;
                iExit = MessageBox.Show("You have some unsaved changes, do you want to navigate away? Changes will be lost", "Please confirm action...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (iExit == DialogResult.Yes)
                {
                    MoveSelectionUp();
                    SaveStateLabel.Text = "Saved";
                }
            }
            else
            {
                MoveSelectionUp();
                SaveStateLabel.Text = "Saved";
            }
        }

        //Change format of B1 date picker if a value is selected
        private void B1picker_ValueChanged_1(object sender, EventArgs e)
        {
            B1picker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void B2picker_ValueChanged(object sender, EventArgs e)
        {
            B2picker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void A1picker_ValueChanged(object sender, EventArgs e)
        {
            A1picker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void A2picker_ValueChanged(object sender, EventArgs e)
        {
            A2picker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void H1picker_ValueChanged(object sender, EventArgs e)
        {
            H1picker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void F1picker_ValueChanged(object sender, EventArgs e)
        {
            F1picker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void P1picker_ValueChanged(object sender, EventArgs e)
        {
            P1picker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void mewps3aPicker_ValueChanged(object sender, EventArgs e)
        {
            mewps3aPicker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void Mewps3Bpicker_ValueChanged(object sender, EventArgs e)
        {
            Mewps3Bpicker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void A4picker_ValueChanged(object sender, EventArgs e)
        {
            A4picker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void A5picker_ValueChanged(object sender, EventArgs e)
        {
            A5picker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void D1picker_ValueChanged(object sender, EventArgs e)
        {
            D1picker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void RemotePIcker_ValueChanged(object sender, EventArgs e)
        {
            RemotePIcker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void CranePicker_ValueChanged(object sender, EventArgs e)
        {
            CranePicker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void AssessmentPicker_ValueChanged(object sender, EventArgs e)
        {
            AssessmentPicker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void RackingPicker_ValueChanged(object sender, EventArgs e)
        {
            RackingPicker.Format = DateTimePickerFormat.Long;
            SaveStateLabel.Text = "Not Saved";
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveStateLabel.Text = "Not Saved";
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveStateLabel.Text = "Not Saved";
        }

        private void SiteCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveStateLabel.Text = "Not Saved";
        }

        private void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveStateLabel.Text = "Not Saved";
        }

        private void CommentextBox_TextChanged(object sender, EventArgs e)
        {
            SaveStateLabel.Text = "Not Saved";
        }

        // delete B1 date picker value
        private void button6_Click(object sender, EventArgs e)
        {
            ClearDatePicker(B1picker);
        }

        // b2 delete
        private void button1_Click(object sender, EventArgs e)
        {
            ClearDatePicker(B2picker);
        }

        //A1 delete
        private void button5_Click(object sender, EventArgs e)
        {
            ClearDatePicker(A1picker);
        }

        //A2 delete
        private void button7_Click(object sender, EventArgs e)
        {
            ClearDatePicker(A2picker);
        }

        //H1 delete
        private void button8_Click(object sender, EventArgs e)
        {
            ClearDatePicker(H1picker);
        }

        //F1 delete
        private void button9_Click(object sender, EventArgs e)
        {
            ClearDatePicker(F1picker);
        }

        //P1 Delete
        private void button10_Click(object sender, EventArgs e)
        {
            ClearDatePicker(P1picker);
        }

        //3A delete
        private void button11_Click(object sender, EventArgs e)
        {
            ClearDatePicker(mewps3aPicker);
        }

        //3B delete
        private void button12_Click(object sender, EventArgs e)
        {
            ClearDatePicker(Mewps3Bpicker);
        }

        //A4 delete
        private void button13_Click(object sender, EventArgs e)
        {
            ClearDatePicker(A4picker);
        }

        //A5 delete
        private void button14_Click(object sender, EventArgs e)
        {
            ClearDatePicker(A5picker);
        }

        //d1 delete
        private void button15_Click(object sender, EventArgs e)
        {
            ClearDatePicker(D1picker);
        }

        // remote delete
        private void button16_Click(object sender, EventArgs e)
        {
            ClearDatePicker(RemotePIcker);
        }

        //Assessment delete
        private void button18_Click(object sender, EventArgs e)
        {
            ClearDatePicker(AssessmentPicker);
        }

        //racking delete
        private void button19_Click(object sender, EventArgs e)
        {
            ClearDatePicker(RackingPicker);
        }

        //crane delete
        private void button17_Click(object sender, EventArgs e)
        {
            ClearDatePicker(CranePicker);
        }

        // Picker Clearing routine
        private void ClearDatePicker(DateTimePicker datePicker)
        {
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = " ";
            SaveStateLabel.Text = "Not Saved";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveStateLabel.Text == "Not Saved")
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Current record will be updated, do you wish to continue?", "Please confirm action...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (iExit == DialogResult.Yes)
                {
                    try
                    {
                        AssessmentModel assessment = new AssessmentModel();

                        assessment.Id = int.Parse(IdLabel.Text);
                        assessment.Name = NameTextBox.Text;
                        assessment.Surname = SurnameTextBox.Text;
                        assessment.Site = SiteCombo.Text;
                        assessment.Shift = ShiftCombo.Text;
                        assessment.Comments = CommentextBox.Text;

                        assessment.A1 = A1picker.Format != DateTimePickerFormat.Long ? "" : A1picker.Value.ToString("dd/MM/yyyy");
                        assessment.A2 = A2picker.Format != DateTimePickerFormat.Long ? "" : A2picker.Value.ToString("dd/MM/yyyy");
                        assessment.A4 = A4picker.Format != DateTimePickerFormat.Long ? "" : A4picker.Value.ToString("dd/MM/yyyy");
                        assessment.A5 = A5picker.Format != DateTimePickerFormat.Long ? "" : A5picker.Value.ToString("dd/MM/yyyy");
                        assessment.B1 = B1picker.Format != DateTimePickerFormat.Long ? "" : B1picker.Value.ToString("dd/MM/yyyy");
                        assessment.B2 = B2picker.Format != DateTimePickerFormat.Long ? "" : B2picker.Value.ToString("dd/MM/yyyy");
                        assessment.H1 = H1picker.Format != DateTimePickerFormat.Long ? "" : H1picker.Value.ToString("dd/MM/yyyy");
                        assessment.F1 = F1picker.Format != DateTimePickerFormat.Long ? "" : F1picker.Value.ToString("dd/MM/yyyy");
                        assessment.P1 = P1picker.Format != DateTimePickerFormat.Long ? "" : P1picker.Value.ToString("dd/MM/yyyy");
                        assessment.M3A = mewps3aPicker.Format != DateTimePickerFormat.Long ? "" : mewps3aPicker.Value.ToString("dd/MM/yyyy");
                        assessment.M3B = Mewps3Bpicker.Format != DateTimePickerFormat.Long ? "" : Mewps3Bpicker.Value.ToString("dd/MM/yyyy");
                        assessment.D1 = D1picker.Format != DateTimePickerFormat.Long ? "" : D1picker.Value.ToString("dd/MM/yyyy");
                        assessment.Remote = RemotePIcker.Format != DateTimePickerFormat.Long ? "" : RemotePIcker.Value.ToString("dd/MM/yyyy");
                        assessment.Crane = CranePicker.Format != DateTimePickerFormat.Long ? "" : CranePicker.Value.ToString("dd/MM/yyyy");
                        assessment.RackingInspection = RackingPicker.Format != DateTimePickerFormat.Long ? "" : RackingPicker.Value.ToString("dd/MM/yyyy");
                        assessment.Assessment = AssessmentPicker.Format != DateTimePickerFormat.Long ? "" : AssessmentPicker.Value.ToString("dd/MM/yyyy");
                        assessment.UpdatedBy = Environment.UserName;
                        assessment.UpdatedDate = DateTime.Now.ToString("dd/MM/yyyy");

                        SqliteDataAccess.UpdateAssessmentItem(assessment);
                        SaveStateLabel.Text = "Saved";
                        UpdateOverview();
                    }
                    catch (System.Exception wtf)
                    {
                        errorLabel.Text = wtf.Message;
                    }
                }
                else
                {
                    MessageBox.Show("Action cancelled by user.", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
