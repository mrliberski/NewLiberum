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
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ProFormaUI
{
    public partial class InvoiceEdit : Form
    {
        private int _invoiceId;
        private InvoiceItem _invoiceCustomerName;
        private List<InvoiceItem> _invoiceItems;

        public InvoiceEdit()
        {
            InitializeComponent();
            ClearForm();
        }

        private void ClearForm()
        {
            CustomerNameValueLabel.Text = string.Empty;
            Address1Value.Text = string.Empty;
            Address2Value.Text = string.Empty;
            CityValue.Text = string.Empty;
            PostCodeValue.Text = string.Empty;
            CountryValue.Text = string.Empty;
            VatNumberValue.Text = string.Empty;
            eoriNumberValue.Text = string.Empty;
            sapNumberValue.Text = string.Empty;
            contactNameVAlue.Text = string.Empty;
            telephoneValue.Text = string.Empty;

            ErrorPlaceholderValueLabel.Text = string.Empty;

            InvoiceNumberTextBox.Text = string.Empty;
        }

        private void printInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // validate if entry is a valid int
            try
            {
                _invoiceId = int.Parse(InvoiceNumberTextBox.Text);
                ErrorPlaceholderValueLabel.Text= string.Empty;
                //MessageBox.Show("OK");
                try
                {
                    _invoiceCustomerName = SqliteDataAccess.SelectInvoiceCustomer(_invoiceId);
                    if ( _invoiceCustomerName != null )
                    {
                        CustomerNameValueLabel.Text = _invoiceCustomerName.CustomerName;
                        PopulateCustomerInfo(_invoiceCustomerName.CustomerName);
                        PopulateItems(_invoiceId);
                    }
                    else
                    {
                        CustomerNameValueLabel.Text = string.Empty;
                        ErrorPlaceholderValueLabel.Text = string.Empty;
                        ErrorPlaceholderValueLabel.Text = "No hits...";
                    }
                   
                }
                catch (Exception ex)
                {
                    ErrorPlaceholderValueLabel.Text = string.Empty;
                    CustomerNameValueLabel.Text = string.Empty;
                    ErrorPlaceholderValueLabel.Text += ex.Message;
                }
            } 
            catch (Exception ex)
            {
                ErrorPlaceholderValueLabel.Text = string.Empty;
                ErrorPlaceholderValueLabel.Text += ex.Message;
            }
            

            //if (int.TryParse(PalletsTextBox.Text, out int Pallet))
            //{
            //    //RecalculateBoxes ();
            //    ((ItemModel)AvailableItemsComboBox.SelectedItem).PalletsQuantity = Pallet;
            //}
            //else
            //{
            //    PalletsTextBox.Text = ((ItemModel)AvailableItemsComboBox.SelectedItem).PalletsQuantity.ToString();
            //    PalletsErrorLAbel.Text = "Value was reset due to incorrect format...";
            //}
        }

        private void PopulateCustomerInfo(string Customer)
        {

        }

        private List<InvoiceItem> PopulateItems(int InvoiceNumber)
        {
            return _invoiceItems;
        }
    }
}
