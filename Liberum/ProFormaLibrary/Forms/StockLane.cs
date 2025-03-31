using ProFormaLibraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFormaUI.Forms
{
    public partial class StockLane : Form
    {
        List<StockLaneItems> stockLaneList = new List<StockLaneItems>();
        List<StockLaneCheckModel> stockLaneCheckList = new List<StockLaneCheckModel>();

        public StockLane()
        {
            InitializeComponent();
            LoadTheme();
            ResetForm();
            LoadCombos();
            LoadStockLaneList();
            LoadTextGrid();
        }

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

            // POSSIBLE MORE APPLICATIONS
            //label3.ForeColor = ThemeColor.PrimaryColor;
            //label4.ForeColor = ThemeColor.SecondaryColor;
        }

        private void LoadCombos()
        {
            CheckCombo.Items.Add("Yes");
            CheckCombo.Items.Add("No");

            MixCombo.Items.Add("Yes");
            MixCombo.Items.Add("No");
        }

        private void LoadStockLaneList()
        {
            try
            {
                // Reinitialize the stockLaneList to avoid residual data
                stockLaneList = SqliteDataAccess.LoadStockLanes();
                WireUpStockLanes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock lanes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WireUpStockLanes()
        {
            try
            {
                // Ensure stockLaneList is not null or empty
                if (stockLaneList == null || stockLaneList.Count == 0)
                {
                    MessageBox.Show("No stock lane items to display.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ItemsCombo.DataSource = null;
                    return;
                }

                // Safely clear and reset the combo box
                ItemsCombo.DataSource = null;
                ItemsCombo.DataSource = stockLaneList;
                ItemsCombo.DisplayMember = "Name";
                ItemsCombo.SelectedIndex = -1; // Ensures no item is preselected
                ItemsCombo.ResetText();

                // Clear associated labels or dependent controls
                PartNumberLabel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error wiring up combo box: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateNumber()
        {
            object selectedItem = ItemsCombo.SelectedItem;

            if (selectedItem != null && selectedItem is StockLaneItems)
            {
                PartNumberLabel.Text = ((StockLaneItems)selectedItem).PartNumber;
            }
        }


        private void LoadTextGrid()
        {
            stockLaneCheckList.Clear();
            dataGrid.DataSource = null;
            stockLaneCheckList = SqliteDataAccess.LoadStockLaneChecks();
            dataGrid.DataSource = stockLaneCheckList;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGrid.Columns["Id"].Visible = false;
            dataGrid.Columns["TimeAdded"].Visible = false;
            dataGrid.Columns["DateAdded"].Visible = false;
            dataGrid.Columns["AddedBy"].Visible = false;

            //dataGridView1.Columns["Id"].Visible = false;
            //dataGridView1.Columns["DeliveryTime"].Visible = false;
            //dataGridView1.Columns["EntryDate"].Visible = false;

            //dataGridView1.Columns[9].HeaderText = "Registration";
            //dataGridView1.Columns[1].HeaderText = "Delivery Date";
            //dataGridView1.Columns[3].HeaderText = "Delivery Number";
            //dataGridView1.Columns[4].HeaderText = "Packaging Code";
            //dataGridView1.Columns[5].HeaderText = "Qty Advised";
            //dataGridView1.Columns[6].HeaderText = "Qty Received";
        }


        private void ResetForm()
        {
            // Clear all textboxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                errorLabel.Text = "";
            }
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {
            // do nothing
        }

        private void ItemsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateNumber();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ItemsCombo.SelectedIndex == -1)
            {
                errorLabel.Text = "Please select an item";
                return;
            }

            StockLaneCheckModel model = new StockLaneCheckModel();

            model.ItemDescription = ItemsCombo.Text;
            model.PartNumber = PartNumberLabel.Text;
            model.Checked = CheckCombo.Text;
            model.Mixed = MixCombo.Text;
            model.Quantity = string.IsNullOrWhiteSpace(QtyTextBox.Text) ? 0 : Convert.ToInt32(QtyTextBox.Text);
            model.Time = string.IsNullOrWhiteSpace(TimeTextBox.Text) ? DateTime.Now.ToString("hh:mm") : TimeTextBox.Text;
            model.Date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            model.Actions = string.IsNullOrWhiteSpace(ActionsTextBox.Text) ? "No actions reported. " : ActionsTextBox.Text;
            model.AddedBy = Environment.UserName;
            model.Email = checkBox1.Checked ? "Yes" : "No";

            SqliteDataAccess.InsertStockLaneCheck(model);
            
            ResetForm();
            LoadTextGrid();

            if (checkBox1.Checked)
            {
                StockLaneEmail.SendEmail(model);
                //MessageBox.Show("Email sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorLabel.Text = "Stock lane check added successfully and email sent.";
            }
            else
            {
                //MessageBox.Show("Stock lane check added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorLabel.Text = "Stock lane check added successfully";
            }
        }



    }
}
