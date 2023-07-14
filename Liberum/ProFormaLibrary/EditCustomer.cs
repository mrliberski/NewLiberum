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

namespace ProFormaUI
{
    public partial class EditCustomer : Form
    {
        List<CustomerModel> customers = new List<CustomerModel>();

        public EditCustomer()
        {
            InitializeComponent();
            ClearForm();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            customers = SqliteDataAccess.LoadCustomers();
            WireUpCustomers();
        }

        private void WireUpCustomers()
        {
            selectCustomerComboBox.DataSource = null;
            selectCustomerComboBox.DataSource = customers;
            selectCustomerComboBox.DisplayMember = "CustomerName";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            addressLine1TextBox.Text = string.Empty;
            addressLine2TextBox.Text = string.Empty;
            addressLine3TextBox.Text = string.Empty;
            cityTextBox.Text = string.Empty;
            countryTextBox.Text = string.Empty;
            vatNumberTextBox.Text = string.Empty;
            eoriNumberTextBox.Text = string.Empty;
            sapNumberTextBox.Text = string.Empty;
            postCodeTextBox.Text = string.Empty;
            contactNameTextbox.Text = string.Empty;
            telephoneTextbox.Text = string.Empty;
            exitPointTextbox.Text = string.Empty;
            destinationOfficeTextbox.Text = string.Empty;
            haulierNameTextbox.Text = string.Empty;
            footerTextBox.Text = string.Empty;
            IncotermsTextBox.Text = string.Empty;
            CurrencyTextBox.Text = string.Empty;

            //TODO - foreach loops somehow are failing here

            //foreach (Control control in this.Controls)
            //{
            //    TextBox textBox = control as TextBox;
            //    if (textBox != null)
            //    {
            //        textBox.Text = string.Empty;
            //    }
            //}

            //foreach (Control control in e.Controls)
            //{
            //    if(control is TextBox)
            //    {
            //        ((TextBox)control).Text = string.Empty;
            //    }

            //    addressLine1TextBox.Text = string.Empty;
            //}
        }

        private void SelectCustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = selectCustomerComboBox.SelectedItem;

            if (selectedItem != null && selectedItem is CustomerModel)
            {
                addressLine1TextBox.Text = ((CustomerModel)selectedItem).CustomerAddressLine1;
                addressLine2TextBox.Text = ((CustomerModel)selectedItem).CustomerAddressLine2;
                addressLine3TextBox.Text = ((CustomerModel)selectedItem).CustomerAddressLine3;
                postCodeTextBox.Text = ((CustomerModel)selectedItem).CustomerZipCode;
                countryTextBox.Text = ((CustomerModel)selectedItem).CustomerCountry;
                vatNumberTextBox.Text = ((CustomerModel)selectedItem).CustomerVAT;
                eoriNumberTextBox.Text = ((CustomerModel)selectedItem).CustomerEORI;
                sapNumberTextBox.Text = ((CustomerModel)selectedItem).SAPnumber;
                contactNameTextbox.Text = ((CustomerModel)selectedItem).CustomerContactPerson;
                telephoneTextbox.Text = ((CustomerModel)selectedItem).CustomerPhone;
                haulierNameTextbox.Text = ((CustomerModel)selectedItem).Haulier;
                exitPointTextbox.Text = ((CustomerModel)selectedItem).CustomerUKExitCode;
                destinationOfficeTextbox.Text = ((CustomerModel)selectedItem).CustomerFinalCustomsCode;
                cityTextBox.Text = ((CustomerModel)selectedItem).CustomerCity;
                footerTextBox.Text = ((CustomerModel)selectedItem).CustomerFootNote;
                IncotermsTextBox.Text = ((CustomerModel)selectedItem).Incoterms;
                CurrencyTextBox.Text = ((CustomerModel)selectedItem).Currency;

                //MessageBox.Show(this.selectCustomerComboBox.Text as string, "meh", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //AddressLine1Label.Text = ((System.Data.DataRowView)selectedItem)["CustomerAddressLine1"].ToString();

            }
        }

        private void createCustomerButton_Click(object sender, EventArgs e)
        {
            object selectedItem = selectCustomerComboBox.SelectedItem;

            if (selectedItem != null && selectedItem is CustomerModel)
            {
                CustomerModel model = new CustomerModel();

                model.CustomerName = ((CustomerModel)selectedItem).CustomerName;

                model.CustomerAddressLine1 = addressLine1TextBox.Text;
                model.CustomerAddressLine2 = addressLine2TextBox.Text;
                model.CustomerAddressLine3 = addressLine3TextBox.Text;
                model.CustomerZipCode = postCodeTextBox.Text;
                model.CustomerCity = cityTextBox.Text;
                model.CustomerFootNote = footerTextBox.Text;
                model.SAPnumber = sapNumberTextBox.Text;
                model.CustomerCountry = countryTextBox.Text;
                model.Haulier = haulierNameTextbox.Text;
                model.CustomerVAT = vatNumberTextBox.Text;
                model.CustomerEORI = eoriNumberTextBox.Text;
                model.CustomerContactPerson = contactNameTextbox.Text;
                model.CustomerPhone = telephoneTextbox.Text;
                model.CustomerUKExitCode = exitPointTextbox.Text;
                model.CustomerFinalCustomsCode = destinationOfficeTextbox.Text;
                model.Incoterms = IncotermsTextBox.Text;
                model.Currency = CurrencyTextBox.Text;

                //MessageBox.Show(model.CustomerId);

                SqliteDataAccess.UpdateCustomer(model);
                ClearForm();
                this.Close();
            }
        }

        private void CustomerDetailsGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
