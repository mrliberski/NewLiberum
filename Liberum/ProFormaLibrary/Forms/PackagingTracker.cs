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

        private void addButton_Click(object sender, EventArgs e)
        {
            //ADD entry to DB & RESET all
            AddEntrytoDB();
            ClearAllTextBoxes(this);
        }

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
            deliveryTimeTextBox.Focus();
        }

        private void NewDeliveryButton_Click(object sender, EventArgs e)
        {
            //CLEAR AND RETURN CARET
            packagingCodeTextBox.Text = string.Empty;
            advisedQtyTextBox.Text = string.Empty;
            receivedQtyTextBox.Text = string.Empty;
            commentTextBox.Text = string.Empty;
            deliveryNoTextBox.Text = string.Empty;
            deliveryTimeTextBox.Text = string.Empty;
            deliveryTimeTextBox.Focus();
        }


        //TODO - add record to DB
        private void AddEntrytoDB()
        {
            MessageBox.Show ("Pretending to add entry to db");
            SendDiscrepancyNotification();
            UpdateOverview();
        }

        //TODO - pulls date from db and feeds tableview
        private void UpdateOverview() { }

        //TODO - send email out when a discreapncy is entered
        private void SendDiscrepancyNotification() { }
    }
}
