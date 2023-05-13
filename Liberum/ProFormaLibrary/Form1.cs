using Microsoft.VisualBasic;
using ProFormaLibraries;
using ProFormaUI;
using System.Diagnostics.CodeAnalysis;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Text;

namespace ProFormaLibrary
{
    public partial class ProFormaGenerator : Form, ICustomerItemSelection
    {
        List<string> requestType = new List<string>();
        List<string> ibfTimeslot = new List<string>();
        List<CustomerModel> customers = new List<CustomerModel>();
        public DateTime deadLine = new DateTime(2023, 06, 01);
        public List<ItemModel> Items = new List<ItemModel>();
        public string SelectedCustomer { get; set; }
        public string HUquantity { get; set; }
        private List<string> Invoices = new List<string>();
        public string? invoiceNumberSaved = "";
        public InvoiceModel Invoice =new InvoiceModel();
        public CustomerModel Customer = new CustomerModel();


        public ProFormaGenerator()
        {
            InitializeComponent();
            LoadRequestType();
            LoadIbfTimeslots();
            LoadCustomers();
            SetToolbarLabelExpiryDate();
            ClearContent();
            GetHighestInvoiceNumberAndIncrement();
            //LoadSampleItems();
        }

        /// <summary>
        /// Method which loads List of customers from DataBase
        /// </summary>
        private void LoadCustomers()
        {
            customers = SqliteDataAccess.LoadCustomers();
            WireupCustomers();
            PopulateCustomerInfo();
        }

        /// <summary>
        /// Wiring up customer List for combo box drop down selection
        /// List<customers>
        /// </summary>
        private void WireupCustomers()
        {
            selectCustomerComboBox.DataSource = null;
            selectCustomerComboBox.DataSource = customers;
            selectCustomerComboBox.DisplayMember = "CustomerName";
            selectCustomerComboBox.SelectedIndex = -1;
            selectCustomerComboBox.ResetText();
        }


        private void GetHighestInvoiceNumberAndIncrement()
        {
            Invoices = SqliteDataAccess.GetHighestInvoiceNumber();
            string maxInvoiceNumber = Invoices.Max();

            if (maxInvoiceNumber != null)
            {
                long max = long.Parse(maxInvoiceNumber);
                //MessageBox.Show(max.ToString());
                max = max + 1;
                //MessageBox.Show(max.ToString());

                InvoiceNumberValue.Text = max.ToString();
                //PackInvoiceNumberValue.Text = max.ToString();
                //CMRNumberValue.Text = max.ToString();
            }
        }

        void ICustomerItemSelection.SelectedCustomer(CustomerModel customer)
        {
            throw new NotImplementedException();
        }

        public void ItemSelection(ItemModel SelectedItem)
        {
            Items.Add(SelectedItem);
            WireUpItems(Items);
            UpdateStripLabelTotal();
        }

        private void LoadSampleItems()
        {
            Items = new List<ItemModel>();
            Items.Clear();

            ItemModel SampleItem1 = new ItemModel();
            ItemModel SampleItem2 = new ItemModel();

            SampleItem1.ItemCustomer = "TestCustomer";
            SampleItem1.ItemName = "Name";
            SampleItem1.ItemNetWeight = 1.25;
            SampleItem1.ItemPrice = 123.22;
            SampleItem1.ItemHScode = 8911234566;
            SampleItem1.ItemCOO = "GB";
            SampleItem1.ContainerName = "Proper Container";
            SampleItem1.ContainerCode = "3084380";
            SampleItem1.ContainerNetWeight = 11.3;
            SampleItem1.ContainerPrice = 23.56;
            SampleItem1.ContainerHSCode = 83984974597;
            SampleItem1.ContainerCOO = "PL";
            SampleItem1.PartsPerContainer = 84;
            SampleItem1.ContainersPerPallet = 4;
            SampleItem1.ItemQuantity = 0;
            SampleItem1.ContainersQuantity = 0;
            SampleItem1.PalletsQuantity = 0;
            SampleItem1.RequiresLid = 1;
            SampleItem1.RequiresPackaging = 1;
            SampleItem1.RequiresPallet = 1;

            SampleItem2.ItemCustomer = "TestCustomer";
            SampleItem2.ItemName = "Name 2";
            SampleItem2.ItemNetWeight = 2.25;
            SampleItem2.ItemPrice = 3.22;
            SampleItem2.ItemHScode = 8234566;
            SampleItem2.ItemCOO = "PL";
            SampleItem2.ContainerName = "Whimpy Container";
            SampleItem2.ContainerCode = "87675f380";
            SampleItem2.ContainerNetWeight = 211.3;
            SampleItem2.ContainerPrice = 223.56;
            SampleItem2.ContainerCOO = "US";
            SampleItem2.PartsPerContainer = 44;
            SampleItem2.ContainersPerPallet = 8;
            SampleItem2.ItemQuantity = 0;
            SampleItem2.ContainersQuantity = 0;
            SampleItem2.PalletsQuantity = 0;
            SampleItem2.RequiresLid = 1;
            SampleItem2.RequiresPackaging = 1;
            SampleItem2.RequiresPallet = 1;

            Items.Add(SampleItem1);
            Items.Add(SampleItem2);

            WireUpItems(Items);
        }

        private void WireUpItems(List<ItemModel> Items)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Items;

            dataGridView1.Columns["ItemId"].Visible = false;
            dataGridView1.Columns["ItemCustomer"].Visible = false;
            dataGridView1.Columns["ItemGrossWeight"].Visible = false;
            dataGridView1.Columns["ContainerGrossWeight"].Visible = false;
            dataGridView1.Columns["ItemPrice"].Visible = false;
            //dataGridView1.Columns["ItemHScode"].Visible = false;
            dataGridView1.Columns["ItemNetWeight"].Visible = false;
            dataGridView1.Columns["ItemCOO"].Visible = false;
            dataGridView1.Columns["ContainerNetWeight"].Visible = false;
            dataGridView1.Columns["ContainerGrossWeight"].Visible = false;
            dataGridView1.Columns["ContainersPerPallet"].Visible = false;
            dataGridView1.Columns["ContainerPrice"].Visible = false;
            //dataGridView1.Columns["ContainerHSCode"].Visible = false;
            dataGridView1.Columns["ContainerCOO"].Visible = false;
            dataGridView1.Columns["CreatedDate"].Visible = false;
            dataGridView1.Columns["CreatedBy"].Visible = false;
            dataGridView1.Columns["RequiresPackaging"].Visible = false;
            dataGridView1.Columns["RequiresLid"].Visible = false;
            dataGridView1.Columns["RequiresPallet"].Visible = false;
            //dataGridView1.Columns["ItemQuantity"].HeaderText = "Item Quantity";
            //dataGridView1.Columns["ItemQuantity"].ReadOnly = true;

            dataGridView1.Columns["ItemName"].HeaderText = "Item Name";
            dataGridView1.Columns["ItemName"].ReadOnly = true;

            dataGridView1.Columns["ContainerName"].HeaderText = "Container Name";
            dataGridView1.Columns["ContainerName"].ReadOnly = true;

            dataGridView1.Columns["ContainerCode"].HeaderText = "Container Code";
            dataGridView1.Columns["ContainerCode"].ReadOnly = true;
        }

        private void SetToolbarLabelExpiryDate()
        {
            toolStripStatusLabel3.Text = deadLine.ToString("dd/MM/yyyy");
        }

        // just checking some stuff
        //private void UserCheck()
        //{
        //    MessageBox.Show(System.Security.Principal.WindowsIdentity.GetCurrent().Name);
        //    MessageBox.Show(Environment.UserName);
        //}
        private bool ValidateExpiryDate()
        {
            DateTime Expiration = deadLine;

            if (Expiration < DateTime.Today)
            {
                return true;
            }
            else if (Expiration == DateTime.Today)
            {
                MessageBox.Show("The licence will expire today", "Suspense", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Expiration > DateTime.Today)
            {
                //MessageBox.Show(@"Welcome, This is a demo software and is provided with on as-is basis. It comes with no warranties whatsoever. ", "Licence Expiry date: " + ExpirationDate.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                //MessageBox.Show("No idea man", "WTF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //private void LockOut()
        //{
        //    selectCustomerComboBox.Enabled = false;
        //    clearButton.Enabled = false;
        //    createInvoiceButton.Enabled = false;
        //    createBrokerRequest.Enabled = false;
        //}



        /// <summary>
        /// Populating request type combo box for customs broker
        /// </summary>
        private void LoadRequestType()
        {
            requestType.Clear();
            requestType.Add("EAD Only");
            requestType.Add("EAD + T1");
            requestType.Add("EAD + T1 + ATA");
            requestType.Add("Amendment");
            requestType.Add("Other");

            WireupRequestType(requestType);
        }

        /// <summary>
        /// populating ibf timeslot combo box
        /// </summary>
        private void LoadIbfTimeslots()
        {
            ibfTimeslot.Clear();
            ibfTimeslot.Add("06:00 - 12:00");
            ibfTimeslot.Add("12:00 - 18:00");
            ibfTimeslot.Add("18:00 - 00:00");
            ibfTimeslot.Add("00:00 - 06:00");

            WireupIBFslots(ibfTimeslot);
        }

        /// <summary>
        /// helper method for LoadRequestType
        /// </summary>
        /// <param name="requestType"></param>
        private void WireupRequestType(List<string> requestType)
        {
            RequestTypeComboBox.Items.Clear();
            RequestTypeComboBox.DataSource = null;
            RequestTypeComboBox.DataSource = requestType;
        }

        /// <summary>
        /// helper method for LoadIbfTimeslots
        /// </summary>
        /// <param name="ibfTimeslot">Timeslot for which the booking should be made</param>
        private void WireupIBFslots(List<string> ibfTimeslot)
        {
            IBFtimeSlotComboBox.Items.Clear();
            IBFtimeSlotComboBox.DataSource = null;
            IBFtimeSlotComboBox.DataSource = ibfTimeslot;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void IBFtimeSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RequestTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProFormaGenerator_Load(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearContent();
        }

        /// <summary>
        /// clears content of form
        /// </summary>
        private void ClearContent()
        {
            IBFtimeSlotComboBox.Text = string.Empty;
            RequestTypeComboBox.Text = string.Empty;
            Hauliertextbox.Text = string.Empty;
            UKexitTextbox.Text = string.Empty;
            driverNumberTextbox.Text = string.Empty;
            CustomsOfficeTextBox.Text = string.Empty;
            selectCustomerComboBox.Text = string.Empty;

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
            IncotermTextBox.Text = string.Empty;
            CurrencytextBox.Text = string.Empty;
            POtextBox.Text = string.Empty;
            KanbanTextBox.Text = string.Empty;

            toolStripStatusLabel5.Text = "There are no items in shipment";
        }

        private void CloseDownButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure you want to Exit?", "Please confirm selection.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private static void NotYet()
        {
            MessageBox.Show("This module is not yet available.", "Disappointment.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CreateInvoiceEntry()
        {

            GetHighestInvoiceNumberAndIncrement();

            //InvoiceModel model = new InvoiceModel();
            Invoice.InvoiceNumber = InvoiceNumberValue.Text;
            invoiceNumberSaved = InvoiceNumberValue.Text;
            Invoice.CMRnumber = Invoice.InvoiceNumber;
            Invoice.Created = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            SqliteDataAccess.CreateInvoice(Invoice);

            GetHighestInvoiceNumberAndIncrement();
        }

        private void CreateInvoiceButton_Click(object sender, EventArgs e)
        {
            CheckLicence();
            //NotYet();

            DialogResult iExit;
            iExit = MessageBox.Show("New invoice will be created, continue?", "Please confirm invoice creation.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                if (Items.Count > 0)
                {
                    InvoiceItem invoiceItem = new InvoiceItem();
                    invoiceItem.InvoiceNumber = InvoiceNumberValue.Text;
                    invoiceItem.CustomerName = ((CustomerModel)selectCustomerComboBox.SelectedItem).CustomerName; //ToString();

                    CreateInvoiceEntry();
                    foreach (ItemModel item in Items)
                    {
                        invoiceItem.ItemQuantity = item.ItemQuantity;
                        invoiceItem.ItemName = item.ItemName;
                        invoiceItem.PartNumber = item.PartNumber;
                        invoiceItem.CustomerNumber = item.CustomerNumber;
                        invoiceItem.ItemNetWeight = item.ItemNetWeight;
                        invoiceItem.ItemGrossWeight = item.ItemGrossWeight;
                        invoiceItem.ItemPrice = item.ItemPrice;
                        invoiceItem.ItemHScode = item.ItemHScode;
                        invoiceItem.ItemCOO = item.ItemCOO;
                        invoiceItem.ContainerName = item.ContainerName;
                        invoiceItem.ContainersQuantity = item.ContainersQuantity;
                        invoiceItem.ContainerCode = item.ContainerCode;
                        invoiceItem.ContainerNetWeight = item.ContainerNetWeight;
                        invoiceItem.ContainerGrossWeight = item.ContainerGrossWeight;
                        invoiceItem.ContainerPrice = item.ContainerPrice;
                        invoiceItem.ContainerHSCode = item.ContainerHSCode;
                        invoiceItem.ContainerCOO = item.ContainerCOO;
                        invoiceItem.PartsPerContainer = item.PartsPerContainer;
                        invoiceItem.ContainersPerPallet = item.ContainersPerPallet;
                        invoiceItem.PalletsQuantity = item.PalletsQuantity;
                        invoiceItem.RequiresPackaging = item.RequiresPackaging;
                        invoiceItem.RequiresLid = item.RequiresLid;
                        invoiceItem.RequiresPallet = item.RequiresPallet;
                        invoiceItem.CreatedDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                        //MessageBox.Show(item.ItemName);
                        SqliteDataAccess.AddInvoiceItem(invoiceItem);
                    }

                    Invoice.ReferenceNumber = POtextBox.Text;
                    Invoice.KanbanNumber = KanbanTextBox.Text;

                    CreateHtmlInvoice(Customer, Invoice, Items);
                    CreatePdfInvoice();

                    Items.Clear();
                    WireUpItems(Items);
                    UpdateStripLabelTotal();
                    ClearContent();
                }
                else
                {
                    MessageBox.Show("You have not added any items to list.", "Nothing to add!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            GetHighestInvoiceNumberAndIncrement();
        }

        private void CreatePdfInvoice()
        {
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();

            htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            if (System.IO.File.Exists("export.pdf"))
            {
                System.IO.File.Delete("export.pdf");
            }

            htmlToPdf.Quiet = false;

            //@".\HTML\Invoice.html"

            htmlToPdf.GeneratePdfFromFile(@".\HTML\Invoice.html", null, @".\HTML\Invoice.pdf");

            htmlToPdf.LogReceived += (sender, e) => {MessageBox.Show("WkHtmlToPdf Log: {0}", e.Data);};

        }

        private bool CanWriteToFile(string filePath)
        {
            string directoryPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            try
            {
                using (FileStream fs = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    return true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }

        private void CreateHtmlInvoice(CustomerModel customer, InvoiceModel invoice, List<ItemModel> Items)
        {
            string HtmlOutput = InvoiceTemplate.EntireModel(invoice, Items, customer);
            string directoryPath = @".\HTML";
            string filePath = Path.Combine(directoryPath, "Invoice.html");


            if (CanWriteToFile(filePath))
            {
                //MessageBox.Show("I CAN WRITE");
                File.WriteAllText(filePath, HtmlOutput);
                try
                {
                    System.Diagnostics.Process.Start("explorer.exe", directoryPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error opening folder: {ex.Message}");
                }

                //File.WriteAllLines(filePath, HtmlOutput);
            }
            else
            {
                MessageBox.Show("I CAN not WRITE");
                Console.WriteLine($"The file '{filePath}' is not accessible for writing.");
            }
        }

    

        private void CheckLicence()
        {
            if (ValidateExpiryDate())
            {
                MessageBox.Show("Licence Expired. Please obtaina a licenced version of a software.", "Expired Licence", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void CreateBrokerRequest_Click(object sender, EventArgs e)
        {
            CheckLicence();
            NotYet();
        }

        private void AddItemLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (((CustomerModel)selectCustomerComboBox.SelectedItem).CustomerName != null)
            {
                SelectedCustomer = ((CustomerModel)selectCustomerComboBox.SelectedItem).CustomerName;

                CheckLicence();
                Form open = new AddItem(this, SelectedCustomer);
                open.ShowDialog();
            }
        }

        private void CreateNewItemLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckLicence();
            Form open = new CreateNewItemForm();
            open.ShowDialog();
        }

        private void EditCustomerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckLicence();
            Form open = new EditCustomer();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            open.FormClosed += Customer_FormClosed;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            open.ShowDialog();
        }

        private void Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            CheckLicence();
            LoadCustomers();
        }

        private void CreatNewCustomerlinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckLicence();
            Form? form = new AddCustomerForm();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            form.FormClosed += Customer_FormClosed;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            form.ShowDialog();
        }

        private void EmailRecipientsListLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckLicence();
            NotYet();
        }

        private void SelectCustomerComboBox_SelectionChangeCommited(object sender, EventArgs e)
        {
            CheckLicence();
        }

        private void PopulateCustomerInfo()
        {
            object selectedItem = selectCustomerComboBox.SelectedItem;

            if (selectedItem != null && selectedItem is CustomerModel)
            {
                Address1Value.Text = ((CustomerModel)selectedItem).CustomerAddressLine1;
                Address2Value.Text = ((CustomerModel)selectedItem).CustomerAddressLine2;
                CityValue.Text = ((CustomerModel)selectedItem).CustomerCity;
                PostCodeValue.Text = ((CustomerModel)selectedItem).CustomerZipCode;
                CountryValue.Text = ((CustomerModel)selectedItem).CustomerCountry;
                VatNumberValue.Text = ((CustomerModel)selectedItem).CustomerVAT;
                eoriNumberValue.Text = ((CustomerModel)selectedItem).CustomerEORI;
                sapNumberValue.Text = ((CustomerModel)selectedItem).SAPnumber;
                contactNameVAlue.Text = ((CustomerModel)selectedItem).CustomerContactPerson;
                telephoneValue.Text = ((CustomerModel)selectedItem).CustomerPhone;
                Hauliertextbox.Text = ((CustomerModel)selectedItem).Haulier;
                UKexitTextbox.Text = ((CustomerModel)selectedItem).CustomerUKExitCode;
                CustomsOfficeTextBox.Text = ((CustomerModel)selectedItem).CustomerFinalCustomsCode;
                IncotermTextBox.Text = ((CustomerModel)selectedItem).Incoterms;
                CurrencytextBox.Text = ((CustomerModel)selectedItem).Currency;


                Customer = ((CustomerModel)selectedItem);
                // MessageBox.Show(this.selectCustomerComboBox.Text as string, "meh", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                // AddressLine1Label.Text = ((System.Data.DataRowView)selectedItem)["CustomerAddressLine1"].ToString();
            }
        }

        /// <summary>
        /// This method blocks the change of selected customer if the list of items is not empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Items.Count > 0)
            {
                //this will not work => selectCustomerComboBox.SelectedIndex = -1;
                MessageBox.Show("You can't change a customer if item list is not empty.", "Customer change invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //selectCustomerComboBox.Text = ((CustomerModel)selectCustomerComboBox.SelectedItem).CustomerName;
            } 
            else
            {
                CheckLicence();
                PopulateCustomerInfo();
            }

        }

        /// <summary>
        /// Remove individual item from list of selected items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                if (rowIndex >= 0)
                {
                    ItemModel it = Items[rowIndex];
                    Items.Remove(it);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Items;
                WireUpItems(Items);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message + " - " + ex.Source);
            }
        }

        /// <summary>
        /// Method to remove individual items from list of selected items (Datagridview)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveSelectedLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                if (rowIndex >= 0)
                {
                    ItemModel it = Items[rowIndex];
                    Items.Remove(it);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Items;
                WireUpItems(Items);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message + " - " + ex.Source);
            }
        }

        /// <summary>
        /// Method to update the thtal number oh handling units 
        /// </summary>
        private void UpdateStripLabelTotal()
        {
            //to update number of HU in current shipment
            int total = 0;
            int columnIndex = 21; // Change this to the index of the column you want to calculate the total for

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Check if the cell value is not null or empty
                if (row.Cells[columnIndex].Value != null && !string.IsNullOrEmpty(row.Cells[columnIndex].Value.ToString()))
                {
                    // Parse the cell value as a decimal and add it to the total
                    int cellValue = int.Parse(row.Cells[columnIndex].Value.ToString());
                    total += cellValue;
                }
            }

            // Output the total
            //MessageBox.Show("The total for column " + columnIndex + " is " + total);
            if (total == 0)
            {
                toolStripStatusLabel5.Text = "There are no items in shipment";
            }
            else
            {
                toolStripStatusLabel5.Text = "Total Number of HUs in current shipment: " + total;
            }

        }

    }
}