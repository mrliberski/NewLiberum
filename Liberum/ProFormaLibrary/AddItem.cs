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

namespace ProFormaUI
{
    public partial class AddItem : Form
    {
        public List<ItemModel> ItemSelection = new List<ItemModel>();
        public string? Customer { get; set; }
        public string? InitialQty;
        public string? InitialPPC;
        public string? InitialContainerPerHU;
        public string? InitialPackQty;
        public string? InitialHU;

        ICustomerItemSelection callingForm;

        public AddItem(ICustomerItemSelection caller, string? SelectedCustomer)
        {
            InitializeComponent();
            callingForm = caller;
            Customer = SelectedCustomer;

            if (Customer == null)
            {
                itemNotFondLabel.Text = "Customer was not specified";
            }
            else
            {
                itemNotFondLabel.Text = "";
                PopulateItems(Customer);
            }

            ResetErrorLabels();

        }

        private void ResetErrorLabels()
        {
            quantityErrorLabel.Text = string.Empty;
            PackQtyErrorLabel.Text = string.Empty;
            //LidsErrorLabel.Text = string.Empty;
            PalletsErrorLAbel.Text = string.Empty;
            CPHUerrorLAbel.Text = string.Empty;
            PPCerrorLAbel.Text = string.Empty;
        }

        private void PopulateItems(string Customer)
        {

            ItemSelection = SqliteDataAccess.LoadItems(Customer);
            if (ItemSelection.Count > 0)
            {
                itemNotFondLabel.Text = "";
                WireupItems();
            }
            else
            {
                itemNotFondLabel.Text = "Could not find any items in the database";
            }
        }

        private void WireupItems()
        {
            AvailableItemsComboBox.DataSource = null;
            AvailableItemsComboBox.DataSource = ItemSelection;
            AvailableItemsComboBox.DisplayMember = "ItemName";

            //selectCustomerComboBox.DataSource = null;
            //selectCustomerComboBox.DataSource = customers;
            //selectCustomerComboBox.DisplayMember = "CustomerName";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TellMe(string message)
        {
            MessageBox.Show(message);
        }

        private void AvailableItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetItem();
        }

        private void ResetItem()
        {
            object selectedItem = AvailableItemsComboBox.SelectedItem;

            if (selectedItem != null && selectedItem is ItemModel)
            {
                ItemQtyTextBox.Text = ((ItemModel)selectedItem).ItemQuantity.ToString();
                PAckagingQtyTextBox.Text = ((ItemModel)selectedItem).ContainersQuantity.ToString();
                PPCtextBox.Text = ((ItemModel)selectedItem).PartsPerContainer.ToString();
                CPPtextBox.Text = ((ItemModel)selectedItem).Cpp.ToString();
                PalletsTextBox.Text = ((ItemModel)selectedItem).PalletsQuantity.ToString();
                ItemHScodeLabel.Text = ((ItemModel)selectedItem).ItemHScode.ToString();
                //TellMe(((ItemModel)selectedItem).PalletsQuantity.ToString());
                selectedItemNameLabel.Text = ((ItemModel)selectedItem).ItemName;
                PackagingNameLabel.Text = ((ItemModel)selectedItem).ContainerName;

                if (((ItemModel)selectedItem).ItemCOO != null)
                {
                    ItemCOOlabel.Text = ((ItemModel)selectedItem).ItemCOO.ToString();
                }

                PackagingCodeLabel.Text = ((ItemModel)selectedItem).ContainerCode.ToString();
                PackagingHSlabel.Text = ((ItemModel)selectedItem).ContainerHSCode.ToString();
                PackagingCOOlabel.Text = ((ItemModel)selectedItem).ContainerCOO.ToString();

                //Save initial state
                SaveInitialState();
            }
        }

        private void SaveInitialState()
        {
            InitialQty = "0";
            InitialPPC = ((ItemModel)AvailableItemsComboBox.SelectedItem).PartsPerContainer.ToString(); 
            InitialContainerPerHU = ((ItemModel)AvailableItemsComboBox.SelectedItem).Cpp.ToString(); 
        }

        private void ItemQtyTextBox_TextChanged(object sender, EventArgs e)
        {
            //reset error
            quantityErrorLabel.Text = string.Empty;

            //int quantityOfItems;
            if (int.TryParse(ItemQtyTextBox.Text, out int quantityOfItems))
            {
                RecalculateBoxes();
                // update model
                ((ItemModel)AvailableItemsComboBox.SelectedItem).ItemQuantity = quantityOfItems;
                ((ItemModel)AvailableItemsComboBox.SelectedItem).ContainersQuantity = int.Parse(PAckagingQtyTextBox.Text);
            }
            else
            {
                quantityErrorLabel.Text = "Quantity format is not correct.";
            }
        }

        private void RecalculateBoxes()
        {
            PAckagingQtyTextBox.Text = Math.Ceiling(int.Parse(ItemQtyTextBox.Text) / decimal.Parse(PPCtextBox.Text)).ToString();

            // pallet qty = container qty / pphu qty and then ceiling
            if (decimal.Parse(CPPtextBox.Text) != 0)
            {
                PalletsTextBox.Text = Math.Ceiling(int.Parse(PAckagingQtyTextBox.Text) / decimal.Parse(CPPtextBox.Text)).ToString();
            }

        }

        private void Hauliertextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPPtextBox_TextChanged(object sender, EventArgs e)
        {
            //reset error
            CPHUerrorLAbel.Text = string.Empty;

            // validate
            //int CperPallet;
            if (!int.TryParse(CPPtextBox.Text, out int CperPallet))
            {
                CPPtextBox.Text = ((ItemModel)AvailableItemsComboBox.SelectedItem).Cpp.ToString();
                CPHUerrorLAbel.Text = "Value was reset due to incorrect format...";
            }
            else
            {
                ((ItemModel)AvailableItemsComboBox.SelectedItem).Cpp = int.Parse(CPPtextBox.Text);
                // recalculate 
                RecalculateBoxes();
            }
        }

        private void PPCtextBox_TextChanged(object sender, EventArgs e)
        {
            PPCerrorLAbel.Text = string.Empty;

            //int PPCallet;
            if (int.TryParse(PPCtextBox.Text, out int PPCallet))
            {
                RecalculateBoxes();
                ((ItemModel)AvailableItemsComboBox.SelectedItem).ContainersPerPallet = PPCallet;
            }
            else
            {
                PPCtextBox.Text = ((ItemModel)AvailableItemsComboBox.SelectedItem).PartsPerContainer.ToString();
                PPCerrorLAbel.Text = "Value was reset due to incorrect format...";
            }
        }

        private void PalletsTextBox_TextChanged(object sender, EventArgs e)
        {
            PalletsErrorLAbel.Text = string.Empty;
            // pallet qty = container qty / pphu qty and then ceiling

            //int Pallet;
            if (int.TryParse(PalletsTextBox.Text, out int Pallet))
            {
                //RecalculateBoxes ();
                ((ItemModel)AvailableItemsComboBox.SelectedItem).PalletsQuantity = Pallet;
            }
            else
            {
                PalletsTextBox.Text = ((ItemModel)AvailableItemsComboBox.SelectedItem).PalletsQuantity.ToString();
                PalletsErrorLAbel.Text = "Value was reset due to incorrect format...";
            }
        }

        private void LidsTexBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {

            //iExit = MessageBox.Show("New invoice will be created, continue?", "Please confirm invoice creation.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (iExit == DialogResult.Yes)
            //{
            //    if (Items.Count > 0)
            //    {




                    //TODO - validate
            if (AvailableItemsComboBox.SelectedItem != null && int.Parse(ItemQtyTextBox.Text) > 0)
            {
                ItemModel model = new ItemModel();
                model = AvailableItemsComboBox.SelectedItem as ItemModel;
                callingForm.ItemSelection(model);
                this.Close();
            }
            else
            {
                MessageBox.Show("No items could be selected...", "Empty selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ItemQtyTextBox.Text = InitialQty;
            PPCtextBox.Text = InitialPPC;
            CPPtextBox.Text = InitialContainerPerHU;
        }
    }
}
