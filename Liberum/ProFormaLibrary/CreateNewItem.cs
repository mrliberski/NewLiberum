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
    public partial class CreateNewItemForm : Form
    {
        List<CustomerModel> customers = new List<CustomerModel>();
        List<string> RequiresLid = new List<string>();
        List<string> RequiresPackaging = new List<string>();
        List<string> RequiresPallet = new List<string>();

        bool FormValid;

        public CreateNewItemForm()
        {
            InitializeComponent();
            LoadCustomers();
            ClearErrorLabels();
            ClearForm();
            LoadRequired();
        }

        private void LoadRequired()
        {
            RequiresPackaging.Clear();
            RequiresLid.Clear();
            RequiresPallet.Clear();

            RequiresPallet.Add("YES");
            RequiresPallet.Add("NO");

            RequiresPackaging.Add("YES");
            RequiresPackaging.Add("NO");

            RequiresLid.Add("YES");
            RequiresLid.Add("NO");

            WireupRequiredSelections(RequiresPackaging, RequiresLid, RequiresPallet);
        }

        private void WireupRequiredSelections(List<string> RequiresPackaging, List<string> RequiresLid, List<string> RequiresPallet)
        {
            requiresPackComboBox.Items.Clear();
            requiresPackComboBox.DataSource = null;
            requiresPackComboBox.DataSource = RequiresPackaging;
            requiresPackComboBox.SelectedIndex = 0;

            requiresLidComboBox.Items.Clear();
            requiresLidComboBox.DataSource = null;
            requiresLidComboBox.DataSource = RequiresLid;
            requiresLidComboBox.SelectedIndex = 0;

            requiresPalletCombo.Items.Clear();
            requiresPalletCombo.DataSource = null;
            requiresPalletCombo.DataSource = RequiresPallet;
            requiresPalletCombo.SelectedIndex = 0;
        }

        //TODO -  load countries selection method

        private void ClearErrorLabels()
        {
            ItemNameErrorLabel.Text = string.Empty;
            itemHScodeErrorLabel.Text = string.Empty;
            ItemNetErrorLabel.Text = string.Empty;
            ItemPPUerrorLabel.Text = string.Empty;
            ItemCOOerrorLAbel.Text = string.Empty;
            ContainerNameErrolLabel.Text = string.Empty;
            ContainerCodeErrorLabel.Text = string.Empty;
            ContainerWeightErrorLabel.Text = string.Empty;
            ContainerPriceErrorLAbel.Text = string.Empty;
            ContainerHScodeErrorLabel.Text = string.Empty;
            ContainerCOOerrorLabel.Text = string.Empty;
            ContainerPPUerrorLabel.Text = string.Empty;
            ContainerPerPalletErrorLabel.Text = string.Empty;
            ReqPackagingErrorLabel.Text = string.Empty;
            ReqPalletErrorLabel.Text = string.Empty;
            LidErrorLAbel.Text = string.Empty;
            BottomFormErrorLAbel.Text = string.Empty;
            partNumberErrorLAbel.Text = string.Empty;
            CustomerNumberErrorLabel.Text = string.Empty;
        }

        private void ClearForm()
        {
            itemNameTextbox.Text = string.Empty;
            netWeightTextBox.Text = string.Empty;
            itemPriceTextBox.Text = string.Empty;
            itemCOOtextBox.Text = string.Empty;
            HScodeTextBox.Text = string.Empty;
            containerHStextBox.Text = string.Empty;
            containerNameTextBox.Text = string.Empty;
            ContainerCodeTextBox.Text = string.Empty;
            containerCOOtextBox.Text = string.Empty;
            containerWeightTextBox.Text = string.Empty;
            containerPriceTextBox.Text = string.Empty;
            partsPerBoxTextBox.Text = string.Empty;
            boxesPerPalletTextBox.Text = string.Empty;
            PartNumberTextBox.Text = string.Empty;
            CustomerNumberTextBox.Text = string.Empty;
        }

        private void LoadCustomers()
        {
            customers = SqliteDataAccess.LoadCustomers();
            WireupCustomers();
        }

        private void WireupCustomers()
        {
            selectCustomerComboBox.DataSource = null;
            selectCustomerComboBox.DataSource = customers;
            selectCustomerComboBox.DisplayMember = "CustomerName";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotYet()
        {
            MessageBox.Show("This method is not yet available.", "Disappointment.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void CreateItemButton_Click(object sender, EventArgs e)
        {
            FormValid = true;
            ValidateForm();

            if (!FormValid)
            {
                MessageBox.Show("Please check your entries.", "Validation failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //MessageBox.Show("valid");

            ItemModel model = new ItemModel();

            AddEntryToDatabase(model);

            ClearForm();
            this.Close();
        }

        private void AddEntryToDatabase(ItemModel model)
        {
            // TODO: VALIDATION!!!!!
            model.CreatedDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            model.ItemCustomer = selectCustomerComboBox.Text;
            model.ItemName = itemNameTextbox.Text;
            model.PartNumber = PartNumberTextBox.Text;
            model.CustomerNumber = CustomerNumberTextBox.Text;
            model.ItemNetWeight = double.Parse(netWeightTextBox.Text);
            model.ItemPrice = double.Parse(itemPriceTextBox.Text);
            model.ItemHScode = long.Parse(HScodeTextBox.Text);
            model.ItemCOO = itemCOOtextBox.Text;
            model.ContainerName = containerNameTextBox.Text;
            model.ContainerCode = ContainerCodeTextBox.Text;
            model.ContainerNetWeight = double.Parse(containerWeightTextBox.Text);
            model.ContainerPrice = double.Parse(containerPriceTextBox.Text);
            model.ContainerHSCode = long.Parse(containerHStextBox.Text);
            model.ContainerCOO = containerCOOtextBox.Text;
            model.PartsPerContainer = int.Parse(partsPerBoxTextBox.Text);
            model.ContainersPerPallet = int.Parse(boxesPerPalletTextBox.Text);
            model.RequiresPackaging = 1;
            model.RequiresLid = 1;
            model.RequiresPallet = 1;
            model.Cpp = int.Parse(boxesPerPalletTextBox.Text);


            SqliteDataAccess.SaveNewItem(model);
        }

        // TODO - make validation more gracious
        private void ValidateForm()
        {
            if (itemNameTextbox.Text.Length < 3)
            {
                MessageBox.Show("Item Name must have at least 3 characters", "Customer Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormValid = false;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Close();
            Form open = new UpdateItemForm();
            open.ShowDialog();
            //MessageBox.Show("this is on TODO list ;)", "I'll do it one day", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
