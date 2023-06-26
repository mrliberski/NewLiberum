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
    public partial class UpdateItemForm : Form
    {
        List<CustomerModel> customers = new List<CustomerModel>();
        List<string> RequiresLid = new List<string>();
        List<string> RequiresPackaging = new List<string>();
        List<string> RequiresPallet = new List<string>();

        public UpdateItemForm()
        {
            InitializeComponent();
            LoadCustomers();
            ClearErrorLabels();
            ClearForm();
            LoadRequired();
        }
        private void ClearForm()
        {
            NewItemNameTextbox.Text = string.Empty;
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Updating");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
