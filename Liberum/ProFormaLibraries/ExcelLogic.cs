using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class ExcelLogic
    {
        public static List<CustomerModel> UploadCustomersToDatabase(string path)
        {
            // Excel library Epplus - check licence changes
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            List<CustomerModel> Customers = new List<CustomerModel>();
            using var package = new ExcelPackage(path);
            var ws = package.Workbook.Worksheets[0]; // fuirst workheet

            int row = 2;
            int col = 1;

            while (string.IsNullOrEmpty(ws.Cells[row, col].Value?.ToString()) == false)
            {
                CustomerModel c = new();
                c.CustomerName = ws.Cells[row, col].Value?.ToString();
                c.CustomerAddressLine1 = ws.Cells[row, col + 1].Value?.ToString();
                c.CustomerAddressLine2 = ws.Cells[row, col + 2].Value?.ToString();
                c.CustomerAddressLine3 = ws.Cells[row, col + 3].Value?.ToString();
                c.CustomerCity = ws.Cells[row, col + 4].Value?.ToString();
                c.CustomerPhone = ws.Cells[row, col + 5].Value?.ToString();
                c.CustomerRegion = ws.Cells[row, col + 6].Value?.ToString();
                c.CustomerCountry = ws.Cells[row, col + 7].Value?.ToString();
                c.CustomerZipCode = ws.Cells[row, col + 8].Value?.ToString();
                c.CustomerVAT = ws.Cells[row, col + 9].Value?.ToString();
                c.CustomerEORI = ws.Cells[row, col + 10].Value?.ToString();
                c.CustomerUKExitCode = ws.Cells[row, col + 11].Value?.ToString();
                c.CustomerFinalCustomsCode = ws.Cells[row, col + 12].Value?.ToString();
                c.CustomerFootNote = ws.Cells[row, col + 13].Value?.ToString();
                c.CustomerContactPerson = ws.Cells[row, col + 14].Value?.ToString();
                c.SAPnumber = ws.Cells[row, col + 15].Value?.ToString();
                c.Haulier = ws.Cells[row, col + 16].Value?.ToString();
                c.Incoterms = ws.Cells[row, col + 17].Value?.ToString();
                c.Currency = ws.Cells[row, col + 18].Value?.ToString();

                Customers.Add(c);
                row += 1;
            }

            return Customers;


        }

        public static List<ItemModel> UploadItemsToDatabase(string path, string CustomerName)
        {
            // Excel library Epplus - check licence changes
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            List<ItemModel> Items = new List<ItemModel>();
            using var package = new ExcelPackage(path);
            var ws = package.Workbook.Worksheets[0]; // fuirst workheet

            int row = 2;
            int col = 1;

            while (string.IsNullOrEmpty(ws.Cells[row, col].Value?.ToString()) == false)
            {
                ItemModel c = new();

                c.ItemCustomer = CustomerName;
                c.ItemQuantity = 0;
                c.ItemName = ws.Cells[row, col].Value?.ToString();
                c.PartNumber = ws.Cells[row, col + 1].Value?.ToString();
                c.CustomerNumber = ws.Cells[row, col +2].Value?.ToString();
                c.ItemNetWeight = double.Parse(ws.Cells[row, col + 3].Value.ToString());
                c.ItemGrossWeight = 0;
                c.ItemPrice = double.Parse(ws.Cells[row, col + 4].Value.ToString());
                c.ItemHScode = int.Parse(ws.Cells[row, col + 5].Value.ToString());
                c.ItemCOO = ws.Cells[row, col + 6].Value?.ToString();
                c.ContainerName = ws.Cells[row, col + 7].Value?.ToString();
                c.ContainersQuantity = 0;
                c.ContainerCode = ws.Cells[row, col + 8].Value?.ToString();
                c.ContainerNetWeight = double.Parse(ws.Cells[row, col + 9].Value.ToString());
                c.ContainerGrossWeight = 0;
                c.ContainerPrice = double.Parse(ws.Cells[row, col + 10].Value.ToString());
                c.ContainerHSCode = int.Parse(ws.Cells[row, col + 11].Value.ToString());
                c.ContainerCOO = ws.Cells[row, col + 12].Value?.ToString();
                c.PartsPerContainer = int.Parse(ws.Cells[row, col + 13].Value.ToString());
                c.ContainersPerPallet = int.Parse(ws.Cells[row, col + 14].Value?.ToString());
                c.PalletsQuantity = 0;
                c.RequiresPackaging = 1;
                c.RequiresLid = 1;
                c.RequiresPallet = 1;
                c.CreatedDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                c.Cpp = int.Parse(ws.Cells[row, col + 14].Value?.ToString());  

                Items.Add(c);
                row += 1;
            }

            return Items;


        }
    }
}
