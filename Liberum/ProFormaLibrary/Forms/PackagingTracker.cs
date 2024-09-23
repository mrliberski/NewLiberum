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
    public partial class PackagingTracker : Form
    {
        private List<PackagingTrackerItem> _items = new List<PackagingTrackerItem>();
        private string _deliveryQuery = string.Empty;


        //MAIN FUNCTION
        public PackagingTracker()
        {
            InitializeComponent();
            LoadTheme();
            ClearAllTextBoxes(this);
            UpdateOverview();
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

            // POSSIBLE MORE APPLICATIONS
            //label3.ForeColor = ThemeColor.PrimaryColor;
            //label4.ForeColor = ThemeColor.SecondaryColor;
        }

        // Clear button
        private void button5_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
        }

        private void ClearAllTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    ((TextBox)c).ForeColor = Color.Black;
                }
                else
                {
                    ClearAllTextBoxes(c);
                }
            }

            errorLabel.Visible = false;
        }

        // ADD SINGLE RECORD
        private void addButton_Click(object sender, EventArgs e)
        {
            //ADD entry to DB & RESET all
            AddEntrytoDB();
            ClearAllTextBoxes(this);
        }

        // ADD RECORD FOR MULTIITEM DELIVERY
        private void addPlusNewEntryButton_Click(object sender, EventArgs e)
        {
            //ADD ENTRY AND KEEP DATE, DELIVERY TIME AND DELIVERY NUMBER
            // CHANGE FONT COLOR TO GRAYISH
            AddEntrytoDB();
            packagingCodeTextBox.Text = string.Empty;
            advisedQtyTextBox.Text = string.Empty;
            receivedQtyTextBox.Text = string.Empty;
            commentTextBox.Text = string.Empty;
            packagingCodeTextBox.Focus();
        }


        // ADD ITEM & START NEW DELIVERY
        private void AddPlusNewDeliveryButton_Click(object sender, EventArgs e)
        {
            //ADD ENTRY, KEEP DATE 
            AddEntrytoDB();
            packagingCodeTextBox.Text = string.Empty;
            advisedQtyTextBox.Text = string.Empty;
            receivedQtyTextBox.Text = string.Empty;
            commentTextBox.Text = string.Empty;
            deliveryNoTextBox.Text = string.Empty;
            deliveryTimeTextBox.Text = string.Empty;
            RegTextBox.Text = string.Empty;
            deliveryTimeTextBox.Focus();
        }

        //START OVER
        private void NewDeliveryButton_Click(object sender, EventArgs e)
        {
            //CLEAR AND RETURN CARET
            packagingCodeTextBox.Text = string.Empty;
            advisedQtyTextBox.Text = string.Empty;
            receivedQtyTextBox.Text = string.Empty;
            commentTextBox.Text = string.Empty;
            deliveryNoTextBox.Text = string.Empty;
            deliveryTimeTextBox.Text = string.Empty;
            RegTextBox.Text = string.Empty;
            deliveryTimeTextBox.Focus();
            errorLabel.Text = string.Empty;
        }


        //TODO - add record to DB
        private void AddEntrytoDB()
        {
            //MessageBox.Show ("Pretending to add entry to db");
            PackagingTrackerItem item = new PackagingTrackerItem();
            item.DeliveryDate = dateTimePicker1.Value.ToString();
            item.DeliveryTime = deliveryTimeTextBox.Text;
            item.DeliveryNumber = deliveryNoTextBox.Text;
            item.PackagingCode = packagingCodeTextBox.Text;

            int advised;
            if (int.TryParse(advisedQtyTextBox.Text, out advised))
            {
                advised = int.Parse(advisedQtyTextBox.Text);
            }
            else
            {
                advised = 0;
            }

            int received;
            if (int.TryParse(receivedQtyTextBox.Text, out received))
            {
                received = int.Parse(receivedQtyTextBox.Text);
            }
            else
            {
                received = 0;
            }

            item.AdvisedQty = advised;
            item.ReceivedQty = received;

            item.Comment = commentTextBox.Text;
            item.RegNumber = RegTextBox.Text;

            // If advised is not equal to received, we need to report it
            if (advised != received) { SendDiscrepancyNotification(item); }

            // Add entry to DB
            SqliteDataAccess.InsertPackTrackerItem(item);
            //MessageBox.Show("Record Added");

            // Refresh grid
            UpdateOverview();
        }

        //TODO - pulls date from db and feeds tableview
        private void UpdateOverview()
        {
            _items.Clear();
            dataGridView1.DataSource = null;
            _items = SqliteDataAccess.PullPackagingTracker();
            dataGridView1.DataSource = _items;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["DeliveryTime"].Visible = false;

            //dataGridView1.Columns["DeliveryDate"].Name = "Delivery Date";
            //dataGridView1.Columns[1].Name = "Column2";
            //dataGridView1.Columns[2].Name = "Column3";
            //dataGridView1.Columns[3].Name = "Column4";
            //dataGridView1.Columns[4].Name = "Column5";
            //dataGridView1.Columns[5].Name = "Column6";
            //dataGridView1.Columns[6].Name = "Column7";
            //dataGridView1.Columns[7].Name = "Column8";
            //dataGridView1.Columns[8].Name = "Column9";

            dataGridView1.Columns["RegNumber"].DisplayIndex = 2;

            SearchErrorLabel.Text = string.Empty;
        }


        // IF discrepancy is detected this block is triggered - we send notification
        private void SendDiscrepancyNotification(PackagingTrackerItem item)
        {
            PackagingCountTemplate.SendPackagingAlert(item);
            // TODO - once validated, message box can be switched off
            // MessageBox.Show("Discrepancy detected - notification was sent.");
        }

        private void receivedQtyTextBox_TextChanged(object sender, EventArgs e)
        {
            //int quantityOfItems;
            if (int.TryParse(receivedQtyTextBox.Text, out int quantityOfItems))
            {
                errorLabel.Visible = false;
            }
            else
            {
                receivedQtyTextBox.Text = string.Empty;
                errorLabel.Visible = true;
            }
        }

        private void advisedQtyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(advisedQtyTextBox.Text, out int quantityOfItems))
            {
                errorLabel.Visible = false;
            }
            else
            {
                advisedQtyTextBox.Text = string.Empty;
                errorLabel.Visible = true;
            }
        }

        private void searchDeliveryTextBox_TextChanged(object sender, EventArgs e)
        {

            SearchDelivery();

            //_items = SqliteDataAccess.SearchDeliveries();

        }

        private void SearchDelivery()
        {
            try
            {
                //clear error label and grab delivery number to search
                SearchErrorLabel.Text = string.Empty;
                _deliveryQuery = searchDeliveryTextBox.Text;
                try
                {
                    _items.Clear();
                    dataGridView1.DataSource = null;
                    _items = SqliteDataAccess.SearchByDelivery(_deliveryQuery);
                    dataGridView1.DataSource = _items;
                    dataGridView1.Columns["Id"].Visible = false;
                }
                catch (System.Exception ex)
                {
                    SearchErrorLabel.Text = ex.Message;
                }
            }
            catch (System.Exception ex)
            {
                SearchErrorLabel.Text = string.Empty;
                SearchErrorLabel.Visible = true;
                SearchErrorLabel.Text = ex.Message;
            }
        }

        private void searchPackagingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //clear error label and grab delivery number to search
                SearchErrorLabel.Text = string.Empty;
                _deliveryQuery = searchPackagingTextBox.Text;
                try
                {
                    _items.Clear();
                    dataGridView1.DataSource = null;
                    _items = SqliteDataAccess.SearchByPackaging(_deliveryQuery);
                    dataGridView1.DataSource = _items;
                    dataGridView1.Columns["Id"].Visible = false;
                }
                catch (System.Exception ex)
                {
                    SearchErrorLabel.Text = ex.Message;
                }
            }
            catch (System.Exception ex)
            {
                SearchErrorLabel.Text = string.Empty;
                SearchErrorLabel.Visible = true;
                SearchErrorLabel.Text = ex.Message;
            }
        }
    }
}
