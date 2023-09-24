using ProFormaLibraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFormaUI
{
    public partial class UploadItems : Form
    {
        List<CustomerModel> customers = new List<CustomerModel>();

        public UploadItems()
        {
            InitializeComponent();
            LoadCustomers();
            ResetForm();
        }

        private void ResetForm()
        {
            ErrorPlaceholderValueLabel.ForeColor = Color.Red;
            ErrorPlaceholderValueLabel.Text = string.Empty;
            InfoLabel.Text = string.Empty;
            PathSelectionTextBox.Text = string.Empty;
            ItemModelValue.Text = LoadCustomerModel();
        }

        private string LoadCustomerModel()
        {
            string? _text =
            @"Columns in spreadheet must be in line with following pattern:

Item Name | Part Number | Customer Number | Net weight | Price | HS | COO | Container Name| Container Code | Container Weight | 
Container Price | Container HS | Container COO | Parts per container | Container Per Pallet

First line (header) is always omitted.
                ";



            return _text;
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
            selectCustomerComboBox.SelectedIndex = -1;
            selectCustomerComboBox.ResetText();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter for .xlsx files
            openFileDialog.Filter = "Excel Files|*.xlsx";

            // Set the initial directory (optional)
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Show the dialog and get the result
            DialogResult result = openFileDialog.ShowDialog();

            // Check if the user selected a file and clicked OK
            if (result == DialogResult.OK)
            {
                // Get the selected file name
                string fileName = openFileDialog.FileName;
                PathSelectionTextBox.Text = fileName;
            }
        }

        private void UploadFileButton_Click(object sender, EventArgs e)
        {
            ValidateMe();
            UploadFile();
            //MessageBox.Show("Not yet available");
        }



        private void ValidateMe()
        {

        }

        private void UploadFile()
        {
            string path = PathSelectionTextBox.Text;

            if (File.Exists(path) && Regex.IsMatch(path, @"^.+\.xlsx$"))
            {
                string customer = selectCustomerComboBox.Text;
                //MessageBox.Show(customer);
                //MessageBox.Show(path);
                List<ItemModel> Items = ExcelLogic.UploadItemsToDatabase(path, customer);

                foreach (var c in Items)
                {
                    try
                    {
                        SqliteDataAccess.SaveNewItem(c);
                    }
                    catch (Exception ex)
                    {
                        ErrorPlaceholderValueLabel.ForeColor = Color.Red;
                        //ErrorPlaceholderValueLabel.Text = string.Empty;
                        ErrorPlaceholderValueLabel.Text += ex.Message + " for customer: " + c.ItemName;
                    }
                }

                InfoLabel.ForeColor = Color.Green;
                InfoLabel.Text = string.Empty;
                InfoLabel.Text = "Upload sequence completed";
                //MessageBox.Show("Upload completed");
            }
            else
            {
                ErrorPlaceholderValueLabel.ForeColor = Color.Red;
                ErrorPlaceholderValueLabel.Text = string.Empty;
                ErrorPlaceholderValueLabel.Text = "Invalid file selection or invalid file extension.";
            }
        }
    }
}
