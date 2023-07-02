using ClosedXML.Excel;
using OfficeOpenXml;


namespace ProFormaLibraries
{
    public class XmlAndPdfLogic
    {
        public static void CreateCMRdocument(CustomerModel Customer, InvoiceModel Invoice, List<ItemModel> Items)
        {

            if (File.Exists(@".\HTML\CMR.xlsx"))
            {
                File.Delete(@".\HTML\CMR.xlsx");
            }

            File.Copy(@".\CMRfiles\CMR.xlsx", @".\HTML\CMR.xlsx");


            string BaseFolder = @".\HTML";

            // Path to the template file
            string templatePath = Path.Combine(BaseFolder,"CMR.xlsx");

            // Create a new Excel package from the template file
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(templatePath)))
            {
                // Get the first worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets[3];

                // Populate cells
                worksheet.Cells["D6"].Value = File.ReadAllText(@".\CMRfiles\SenderAddress.txt");
                worksheet.Cells["S6"].Value = Invoice.InvoiceNumber;// S6 - consignment note number
                worksheet.Cells["D14"].Value = $"{Customer.CustomerName}, {Customer.CustomerAddressLine1}, {Customer.CustomerAddressLine2}, {Customer.CustomerZipCode}, {Customer.CustomerCity}, {Customer.CustomerCountry}"; // D14 - odbiorca
                worksheet.Cells["D20"].Value = $"{Customer.CustomerCity}, {Customer.CustomerCountry}"; // D20 - miejscowosc, kraj
                worksheet.Cells["D28"].Value = $"Invoice Number {Invoice.InvoiceNumber}, export declaration, despatch note and transit documents.";// D28 - zalaczone dokumenty
       
                // POP UP
                Form popupForm = new Form();
                TextBox textBox = new TextBox();
                Button okButton = new Button();

                popupForm.Text = "Enter Goods Description for CMR document";
                popupForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                popupForm.MaximizeBox = false;
                popupForm.MinimizeBox = false;
                popupForm.Size = new Size(500, 200);
                popupForm.StartPosition = FormStartPosition.CenterScreen;

                textBox.Location = new Point(20, 20);
                textBox.Size = new Size(400, 30);

                okButton.Text = "OK";
                okButton.DialogResult = DialogResult.OK;
                okButton.Location = new Point(20, 50);
                okButton.Size = new Size(75, 30);

                popupForm.Controls.Add(textBox);
                popupForm.Controls.Add(okButton);

                string opisTowaru = string.Empty;

                if (popupForm.ShowDialog() == DialogResult.OK)
                {
                    opisTowaru = textBox.Text;
                    // Call your method here with the value.
                    worksheet.Cells["D32"].Value = opisTowaru;
                }

                // up to 41
                int iloscSztuk = 0;                                  // K32 ilosc sztuk
                int iloscPalet = 0;                                  // M32 sposob pakowania - ilosc pallet+pallets
                string rodzajTowaru = opisTowaru;                    // Q32 - rodzaj towaru
                double wagaBrutto = 0;                               // W32 - waga brutto + kgs


                foreach (ItemModel item in Items)
                {
                    iloscSztuk += item.ItemQuantity / item.PartsPerContainer;
                    iloscPalet += item.PalletsQuantity;
                    wagaBrutto += item.ItemQuantity * item.ItemNetWeight;
                    wagaBrutto += item.ContainersQuantity * item.ContainerNetWeight;
                }

                worksheet.Cells["D47"].Value = $"{Invoice.ReferenceNumber}, {Invoice.KanbanNumber}";// D47 - Instrukcje nadawcy
                worksheet.Cells["K32"].Value = iloscSztuk;
                worksheet.Cells["M32"].Value = $"{iloscPalet} pallets";
                worksheet.Cells["Q32"].Value = rodzajTowaru;
                worksheet.Cells["W32"].Value = $"{wagaBrutto} kg";

             // Save the modified Excel file
             package.Save();

                // Close the Excel package
                package.Dispose();
            }
        }


        public static void CreatePDF()
        {
            string sourceFolder = @".\CMRfiles";
            string excelFileName = "CMR.xlsx";
            string destinationFolder = @".\HTML";
            string pdfFileName = "CMR.pdf";

            string sourceFilePath = Path.Combine(sourceFolder, excelFileName);
            string destinationFilePath = Path.Combine(destinationFolder, pdfFileName);

            if (System.IO.File.Exists(destinationFilePath))
            {
                System.IO.File.Delete(destinationFilePath);
            }

            using (XLWorkbook workbook = new XLWorkbook(sourceFilePath))
                {
                    // Optionally, modify the workbook if needed

                    workbook.SaveAs(destinationFilePath, new SaveOptions { EvaluateFormulasBeforeSaving = false });
                }
        }

    }
}

//string XMLoutput = string.Empty;

//string file01 = File.ReadAllText(Path.Combine(BaseFolder, "File001.txt"));
//string file02 = File.ReadAllText(Path.Combine(BaseFolder, "File002.txt"));
//string file03 = File.ReadAllText(Path.Combine(BaseFolder, "File003.txt"));
//string file04 = File.ReadAllText(Path.Combine(BaseFolder, "File004.txt"));
//string file05 = File.ReadAllText(Path.Combine(BaseFolder, "File005.txt"));
//string file06 = File.ReadAllText(Path.Combine(BaseFolder, "File006.txt"));
//string file07 = File.ReadAllText(Path.Combine(BaseFolder, "File007.txt"));
//string file08 = File.ReadAllText(Path.Combine(BaseFolder, "File008.txt"));
//string file09 = File.ReadAllText(Path.Combine(BaseFolder, "File009.txt"));
//string file10 = File.ReadAllText(Path.Combine(BaseFolder, "File010.txt"));
//string file11 = File.ReadAllText(Path.Combine(BaseFolder, "File011.txt"));
//string file12 = File.ReadAllText(Path.Combine(BaseFolder, "File012.txt"));
//string file13 = File.ReadAllText(Path.Combine(BaseFolder, "File013.txt"));
//string file14 = File.ReadAllText(Path.Combine(BaseFolder, "File014.txt"));
//string file15 = File.ReadAllText(Path.Combine(BaseFolder, "File015.txt"));
//string file16 = File.ReadAllText(Path.Combine(BaseFolder, "File016.txt"));
//string file17 = File.ReadAllText(Path.Combine(BaseFolder, "File017.txt"));
//string file18 = File.ReadAllText(Path.Combine(BaseFolder, "File018.txt"));


//XMLoutput = XMLoutput + file01;
//XMLoutput = XMLoutput + file02; //sender address
//XMLoutput = XMLoutput + file03;
//// invoice number
//XMLoutput = XMLoutput + file04;
//// Desination address
//XMLoutput = XMLoutput + file05;
//// destination - city, country
//XMLoutput = XMLoutput + file06;
//XMLoutput = XMLoutput + file07; // sender - city, country
//XMLoutput = XMLoutput + file08;
//// data wysylki
//XMLoutput = XMLoutput + file09;
//// opis towaru
//XMLoutput = XMLoutput + file10;
//// liczba sztuk (2)
//XMLoutput = XMLoutput + file11;
//// metoda pakowania (2 boxes)
//XMLoutput = XMLoutput + file12;
//// opis (car parts)
//XMLoutput = XMLoutput + file13;
//// waga brutto
//XMLoutput = XMLoutput + file14;
//// instrukcje nadawcy Kanban Number SCXXXXX1 (redeliveries); PO Number:N/A
//XMLoutput = XMLoutput + file15;
//XMLoutput = XMLoutput + file16;  //miejscowosc Nadania
//XMLoutput = XMLoutput + file17;
//// data nadania
//XMLoutput = XMLoutput + file18;

//XmlDocument xdoc = new XmlDocument();
//xdoc.LoadXml(XMLoutput);
//xdoc.Save(Path.Combine(@".\HTML", "CMR.xml"));

//var path = @".\HTML\CMR.txt";
//File.WriteAllText(path, XMLoutput);