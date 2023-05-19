using OfficeOpenXml;
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

            // Excel library Epplus - check licence changes
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            List<CustomerModel> Customers = new List<CustomerModel>();
            using var package = new ExcelPackage(PathSelectionTextBox.Text);
            var ws = package.Workbook.Worksheets[0]; // fuirst workheet

            int row = 2;
            int col = 1;

            while (string.IsNullOrEmpty(ws.Cells[row,col].Value?.ToString()) == false)
            {
                CustomerModel c = new();
                c.CustomerName = ws.Cells[row,col].Value?.ToString();
                c.CustomerAddressLine1 = ws.Cells[row, col+1].Value?.ToString();
                c.CustomerAddressLine2 = ws.Cells[row, col+2].Value?.ToString();
                c.CustomerAddressLine3 = ws.Cells[row, col+3].Value?.ToString();
                c.CustomerCity = ws.Cells[row, col+4].Value?.ToString();
                c.CustomerPhone = ws.Cells[row, col+5].Value?.ToString();
                c.CustomerRegion = ws.Cells[row, col+6].Value?.ToString();
                c.CustomerCountry = ws.Cells[row, col+7].Value?.ToString();
                c.CustomerZipCode = ws.Cells[row, col+8].Value?.ToString();
                c.CustomerVAT = ws.Cells[row, col+9].Value?.ToString();
                c.CustomerEORI = ws.Cells[row, col+10].Value?.ToString();
                c.CustomerUKExitCode = ws.Cells[row, col+11].Value?.ToString();
                c.CustomerFinalCustomsCode = ws.Cells[row, col+12].Value?.ToString();
                c.CustomerFootNote = ws.Cells[row, col+13].Value?.ToString();
                c.CustomerContactPerson = ws.Cells[row, col+14].Value?.ToString();
                c.SAPnumber = ws.Cells[row, col+15].Value?.ToString();
                c.Haulier = ws.Cells[row, col+16].Value?.ToString();
                c.Incoterms = ws.Cells[row, col+17].Value?.ToString();
                c.Currency = ws.Cells[row, col+18].Value?.ToString();

                Customers.Add(c);
                row += 1;
            }


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
