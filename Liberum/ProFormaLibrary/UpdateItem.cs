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
        public string? Customer { get; set; }
        public List<ItemModel> ItemSelection = new List<ItemModel>();


        //ICustomerItemSelection callingForm;

        public UpdateItemForm()
        {
            InitializeComponent();
            LoadCustomers();
            ClearErrorLabels();
            ClearForm();
            LoadRequired();
            SetCustomer();
        }

        private void SetCustomer()
        {
            Customer = ((CustomerModel)selectCustomerComboBox.SelectedItem).CustomerName;
            //MessageBox.Show(Customer);

            if (Customer == null)
            {
                BottomFormErrorLAbel.Text = "Customer was not specified";
            }
            else
            {
                BottomFormErrorLAbel.Text = "";
                PopulateItems(Customer);
            }
        }

        private void PopulateItems(string Customer)
        {
            ItemSelection = SqliteDataAccess.LoadItems(Customer);
            if (ItemSelection.Count > 0)
            {
                BottomFormErrorLAbel.Text = "";
                WireupItems();
            }
            else
            {
                BottomFormErrorLAbel.Text = "Could not find any items in the database";
            }
        }

        private void WireupItems()
        {
            ItemNameCombo.DataSource = null;
            ItemNameCombo.DataSource = ItemSelection;
            ItemNameCombo.DisplayMember = "ItemName";

            ClearForm();
            object SelectedItem = ItemNameCombo.SelectedItem;
            PopulateItemData(SelectedItem);

            //selectCustomerComboBox.DataSource = null;
            //selectCustomerComboBox.DataSource = customers;
            //selectCustomerComboBox.DisplayMember = "CustomerName";
        }

        private void PopulateItemData(object SelectedItem)
        {
            if (SelectedItem != null && SelectedItem is ItemModel)
            {
                NewItemNameTextbox.Text = ((ItemModel)SelectedItem).ItemName;
                netWeightTextBox.Text = ((ItemModel)SelectedItem).ItemNetWeight.ToString();
                itemPriceTextBox.Text = ((ItemModel)SelectedItem).ItemPrice.ToString();
                itemCOOtextBox.Text = ((ItemModel)SelectedItem).ItemCOO;
                HScodeTextBox.Text = ((ItemModel)SelectedItem).ItemHScode.ToString();
                containerHStextBox.Text = ((ItemModel)SelectedItem).ContainerHSCode.ToString();
                containerNameTextBox.Text = ((ItemModel)SelectedItem).ContainerName;
                ContainerCodeTextBox.Text = ((ItemModel)SelectedItem).ContainerCode;
                containerCOOtextBox.Text = ((ItemModel)SelectedItem).ContainerCOO;
                containerWeightTextBox.Text = ((ItemModel)SelectedItem).ContainerNetWeight.ToString();
                containerPriceTextBox.Text = ((ItemModel)SelectedItem).ContainerPrice.ToString();
                partsPerBoxTextBox.Text = ((ItemModel)SelectedItem).PartsPerContainer.ToString();
                boxesPerPalletTextBox.Text = ((ItemModel)SelectedItem).Cpp.ToString();
                PartNumberTextBox.Text = ((ItemModel)SelectedItem).PartNumber;
                CustomerNumberTextBox.Text = ((ItemModel)SelectedItem).CustomerNumber;

                if (((ItemModel)SelectedItem).RequiresPackaging == 1)
                {
                    requiresPackComboBox.SelectedIndex = 0;
                } else requiresPackComboBox.SelectedIndex = 1;

                if (((ItemModel)SelectedItem).RequiresLid == 1)
                {
                    requiresLidComboBox.SelectedIndex = 0;
                }else requiresLidComboBox.SelectedIndex = 1;

                if (((ItemModel)SelectedItem).RequiresPallet == 1)
                {
                    requiresPalletCombo.SelectedIndex = 0;
                    
                }else requiresPalletCombo.SelectedIndex = 1;

            }
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
            label3.Text = string.Empty;
            label4.Text = string.Empty;
            partNumberErrorLAbel.Text = string.Empty;
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
            //MessageBox.Show("Updating");

            // build model
            // update databse
            // clear form
            // update itemlist

            object selectedItem = ItemNameCombo.SelectedItem;

            if (selectedItem != null && selectedItem is ItemModel)
            {
                ItemModel model = new ItemModel();
                string OriginalItemName = ((ItemModel)selectedItem).ItemName;

                if (model != null)
                {
                    model.ItemName = NewItemNameTextbox.Text;
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
                    model.Cpp = int.Parse(boxesPerPalletTextBox.Text);

                    if (requiresLidComboBox.SelectedValue == "YES")
                    {
                        model.RequiresLid = 1;
                    }
                    else model.RequiresLid = 0;

                    if (requiresPackComboBox.SelectedValue == "YES")
                    {
                        model.RequiresPackaging = 1;
                    }
                    else model.RequiresPackaging = 0;

                    if (requiresPalletCombo.SelectedValue == "YES")
                    {
                        model.RequiresPallet = 1;
                    }
                    else model.RequiresPallet = 0;

                    //MessageBox.Show(model.ItemId.ToString());
                }

                SqliteDataAccess.UpdateItem(model, OriginalItemName);
                ClearForm();
                ClearErrorLabels();
                PopulateItems(Customer);
                MessageBox.Show("Item was updated successfully.");
            }





        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void selectCustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCustomer();
        }

        private void ItemNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearForm();
            object SelectedItem = ItemNameCombo.SelectedItem;
            PopulateItemData(SelectedItem);
        }
    }
}
