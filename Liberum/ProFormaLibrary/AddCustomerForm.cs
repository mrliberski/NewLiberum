using ProFormaLibraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFormaUI
{
    public partial class AddCustomerForm : Form
    {
        bool FormValid;

        public AddCustomerForm()
        {
            InitializeComponent();
            ClearForm();
        }

        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {

        }

        private void AddEntryToDatabase(CustomerModel model)
        {
            model.CustomerName = customerNameTextBox.Text;
            model.CustomerAddressLine1 = addressLine1TextBox.Text;
            model.CustomerAddressLine2 = addressLine2TextBox.Text;
            model.CustomerAddressLine3 = Address3TextBox.Text;
            model.CustomerPhone = telephoneTextbox.Text;
            model.CustomerCity = cityTextBox.Text;
            model.CustomerCountry = countryTextBox.Text;
            model.SAPnumber = sapNumberTextBox.Text;
            model.CustomerZipCode = postCodeTextBox.Text;
            model.CustomerVAT = vatNumberTextBox.Text;
            model.CustomerEORI = eoriNumberTextBox.Text;
            model.CustomerUKExitCode = exitPointTextbox.Text;
            model.CustomerFinalCustomsCode = destinationOfficeTextbox.Text;
            model.CustomerFootNote = "";
            model.CustomerContactPerson = contactNameTextbox.Text;
            model.Haulier = haulierNameTextbox.Text;
            model.Incoterms = IncotermsTextBox.Text;
            model.Currency = CurrencyTextBox.Text;

            //CustomerRegion,
            SqliteDataAccess.SaveNewCustomer(model);
        }

        // TODO - make validation more gracious
        private void ValidateForm()
        {
            if (customerNameTextBox.Text.Length < 3)
            {
                MessageBox.Show("Customer Name must have at least 3 characters", "Customer Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormValid = false;
            }

            if (addressLine1TextBox.Text.Length < 1)
            {
                MessageBox.Show("First line of address must not be empty", "Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormValid = false;
            }

            if (countryTextBox.Text.Length < 1)
            {
                MessageBox.Show("You must define a country", "Country", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormValid = false;
            }

            if (cityTextBox.Text.Length < 1)
            {
                MessageBox.Show("City not specified", "City", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormValid = false;
            }

            if (postCodeTextBox.Text.Length < 1)
            {
                MessageBox.Show("Post Code must not be empty.", "Post code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormValid = false;
            }

        }

        private void ClearForm()
        {
            customerNameTextBox.Text = string.Empty;
            addressLine1TextBox.Text = string.Empty;
            addressLine2TextBox.Text = string.Empty;
            Address3TextBox.Text = string.Empty;
            cityTextBox.Text = string.Empty;
            postCodeTextBox.Text = string.Empty;
            countryTextBox.Text = string.Empty;
            vatNumberTextBox.Text = string.Empty;
            eoriNumberTextBox.Text = string.Empty;
            sapNumberTextBox.Text = string.Empty;
            customerNameTextBox.Text = string.Empty;
            telephoneTextbox.Text = string.Empty;
            exitPointTextbox.Text = string.Empty;
            destinationOfficeTextbox.Text = string.Empty;
            haulierNameTextbox.Text = string.Empty;
            contactNameTextbox.Text = string.Empty;
            IncotermsTextBox.Text = string.Empty;
            CurrencyTextBox.Text = string.Empty;

            customerNameTextBox.Focus();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerDetailsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateCustomerNewButton_Click(object sender, EventArgs e)
        {
            FormValid = true;
            ValidateForm();

            if (!FormValid)
            {
                MessageBox.Show("Please check your entries.", "Validation failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //MessageBox.Show("valid");

            CustomerModel model = new CustomerModel();

            AddEntryToDatabase(model);

            ClearForm();
        }
    }
}
