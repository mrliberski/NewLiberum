using Microsoft.Office.Interop.Outlook;
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
    public partial class InvoiceEdit : Form, ICustomerItemSelection
    {
        public int _invoiceId;
        private InvoiceItem _invoiceCustomerName = new InvoiceItem();
        private List<InvoiceItem> _invoiceItems = new List<InvoiceItem>();
        private CustomerModel _customerModel = new CustomerModel();
        //private List<InvoiceItem> _currentItems = new List<InvoiceItem>();

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
            SearchMe();
        }

        private void SearchMe()
        {
            // ClearForm(); - to nie moze tu byc :)
            // validate if entry is a valid int
            _invoiceItems.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _invoiceItems;

            try
            {
                ErrorPlaceholderValueLabel.Text = string.Empty;
                _invoiceId = int.Parse(InvoiceNumberTextBox.Text);
                // MessageBox.Show("OK");
                try
                {
                    // MessageBox.Show("Trying");
                    _invoiceCustomerName = SqliteDataAccess.SelectInvoiceCustomer(_invoiceId);
                    if (_invoiceCustomerName != null)
                    {
                        // MessageBox.Show("1");
                        CustomerNameValueLabel.Text = _invoiceCustomerName.CustomerName;
                        PopulateCustomerInfo(_invoiceCustomerName.CustomerName);
                        PopulateItems(_invoiceId);
                    }
                    else
                    {
                        // MessageBox.Show("2");
                        CustomerNameValueLabel.Text = string.Empty;
                        ErrorPlaceholderValueLabel.Text = string.Empty;
                        ErrorPlaceholderValueLabel.Text = "No hits...";
                    }

                }
                catch (System.Exception ex)
                {
                    // MessageBox.Show("3");
                    ErrorPlaceholderValueLabel.Text = string.Empty;
                    CustomerNameValueLabel.Text = string.Empty;
                    ErrorPlaceholderValueLabel.Text = ex.Message;
                }
            }
            catch (System.Exception ex)
            {
                // MessageBox.Show("NOK");
                ErrorPlaceholderValueLabel.Text = string.Empty;
                ErrorPlaceholderValueLabel.Text = ex.Message;

            }
        }

        private void PopulateCustomerInfo(string Customer)
        {
            _customerModel = SqliteDataAccess.FetchCustomerInfo(Customer);
            Address1Value.Text = _customerModel.CustomerAddressLine1;
            Address2Value.Text = _customerModel.CustomerAddressLine2;
            PostCodeValue.Text = _customerModel.CustomerZipCode;
            CountryValue.Text = _customerModel.CustomerCountry;
            VatNumberValue.Text = _customerModel.CustomerVAT;
            eoriNumberValue.Text = _customerModel.CustomerEORI;
            sapNumberValue.Text = _customerModel.SAPnumber;
            contactNameVAlue.Text = _customerModel.CustomerContactPerson;
            telephoneValue.Text = _customerModel.CustomerPhone;
        }

        private void PopulateItems(int InvoiceNumber)
        {
            _invoiceItems = SqliteDataAccess.PopulateItems(InvoiceNumber);
            WireUpItems();
        }

        private void WireUpItems()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _invoiceItems;

            dataGridView1.Columns["Id"].Visible = false;
        }

        private void InvoiceNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchMe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(string.Format("Are you sure you want to remove selected item from invoice?{0}This acion is non-reversible.", Environment.NewLine));
                DialogResult iExit;
                iExit = MessageBox.Show(
                    "Are you sure you want to remove selected item from invoice?" + Environment.NewLine + " This action is non-reversible.",
                    "Please confirm selection.",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (iExit == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    if (rowIndex >= 0)
                    {
                        InvoiceItem it = _invoiceItems[rowIndex];
                        _invoiceItems.Remove(it);
                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = _invoiceItems;
                    WireUpItems();

                    MessageBox.Show(string.Format("I should be romoving item from DB here{0}But I am not...{0}I will get to it.", Environment.NewLine));
                }
            }
            catch (System.Exception ex)
            {
                ErrorPlaceholderValueLabel.Text = string.Empty;
                ErrorPlaceholderValueLabel.Text = ex.Message + " - " + ex.Source;
                //MessageBox.Show("An error occured: " + ex.Message + " - " + ex.Source);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void AddItem()
        {
            //if (((CustomerModel)selectCustomerComboBox.SelectedItem).CustomerName != null)
            if (CustomerNameValueLabel.Text != string.Empty)
            {
                 string SelectedCustomer = CustomerNameValueLabel.Text;

                Form open = new AddItem(this, SelectedCustomer);
                open.ShowDialog();
            }
            else
            {
                MessageBox.Show("No valid Invoice was selected...", "Selection error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void ItemSelection(ItemModel SelectedItem)
        {
            // Here we need to map ItemModel to InvoiceItemModel
            InvoiceItem _newInvoiceItem = NewItem(SelectedItem);

            // Add to Db and grid view
            AddNewItemToDatabase(_newInvoiceItem);
            _invoiceItems.Add(_newInvoiceItem);
            WireUpItems();
        }

        private InvoiceItem NewItem(ItemModel item)
        {
            InvoiceItem Output = new InvoiceItem();
            Output.InvoiceNumber = InvoiceNumberTextBox.Text;
            Output.CustomerName = CustomerNameValueLabel.Text;

            Output.ItemQuantity = item.ItemQuantity;
            Output.ItemName = item.ItemName;
            Output.PartNumber = item.PartNumber;
            Output.CustomerNumber = item.CustomerNumber;
            Output.ItemNetWeight = item.ItemNetWeight;
            Output.ItemGrossWeight =item.ItemGrossWeight;
            Output.ItemPrice = item.ItemPrice;
            Output.ItemHScode = item.ItemHScode; 
            Output.ItemCOO = item.ItemCOO;
            Output.ContainerName = item.ContainerName;
            Output.ContainersQuantity = item.ContainersQuantity;
            Output.ContainerCode = item.ContainerCode;
            Output.ContainerNetWeight = item.ContainerNetWeight;
            Output.ContainerGrossWeight = item.ContainerGrossWeight;
            Output.ContainerPrice= item.ContainerPrice;
            Output.ContainerHSCode= item.ContainerHSCode;
            Output.ContainerCOO = item.ContainerCOO;
            Output.PartsPerContainer = item.PartsPerContainer;
            Output.ContainersPerPallet = item.Cpp;
            Output.PalletsQuantity = item.PalletsQuantity;
            Output.RequiresPackaging = item.RequiresPackaging;
            Output.RequiresLid = item.RequiresLid;
            Output.RequiresPallet = item.RequiresPallet;
            Output.CreatedDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            return Output;
        }

        private void AddNewItemToDatabase(InvoiceItem _newInvoiceItem)
        {
            MessageBox.Show("Here I need to add item to db", "I will do it", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public void SelectedCustomer(CustomerModel customer)
        {
            throw new NotImplementedException();
        }
    }
}
