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
    public partial class UploadCustomers : Form
    {
        public UploadCustomers()
        {
            InitializeComponent();
            ResetForm();
        }

        private void ResetForm()
        {
            ErrorPlaceholderValueLabel.Text = string.Empty;
            InfoLabel.Text = string.Empty;
            PathSelectionTextBox.Text = string.Empty;
            CustomerModelValue.Text = LoadCustomerModel();
        }

        private void ValidateFile()
        {
            //check extension
            //check if available?
            //check format
        }

        private void UploadFile()
        {
            //Once validated only we can try to upload and capture any errors
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

        private string LoadCustomerModel()
        {
            string output = 
                @"Columns in spreadheet must be in line with following pattern:

Customer Name | Address1 | Address2 | Address3 | City | Phone | Region | Country | PostCode | VAT | EORI | UK Exit | EU Entry | Footnote  
Contact Person | SAP number | Haulier | Incoterms | Currency

First line (header) is always omitted.
                ";

            return output;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
