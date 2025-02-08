using ProFormaLibraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFormaUI.Forms
{
    public partial class AddNewTrainee : Form
    {
        private List<string> SitesList = new List<string>();
        private List<string> ShiftList = new List<string>();
        public AddNewTrainee()
        {
            InitializeComponent();
            ClearStuff();
            LoadSites();
            LoadShifts();
        }

        private void ClearStuff()
        {
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
            errorLabel.Text = "";
        }
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || SurnameTextBox.Text == "" || SiteCombo.Text == "" || ShiftCombo.Text == "")
            {
                errorLabel.Text = "Please fill in all fields";
            }
            else
            {
                AssessmentModel model = new AssessmentModel();

                model.Name = NameTextBox.Text;
                model.Surname = SurnameTextBox.Text;
                model.Site = SiteCombo.Text;
                model.Shift = ShiftCombo.Text;
                model.CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                model.CreatedBy = Environment.UserName;
                model.Comments = CommentextBox.Text;

                try
                {
                    SqliteDataAccess.AddTrainee(model);
                    ClearStuff();

                    MessageBox.Show("New entry was added. Make sure to refresh the overvie to reload the grid.");
                    this.Close();
                }
                catch (Exception wtf) { errorLabel.Text = wtf.Message; }
            }
        }
    }
}
