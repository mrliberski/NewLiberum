using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class HtmlAndPdfLogic
    {
        public static void CreateHtmlInvoice(CustomerModel customer, InvoiceModel invoice, List<ItemModel> Items)
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
                catch (System.Exception ex)
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

        public static void CreateHtmlInvoice(CustomerModel customer, InvoiceModel invoice, List<InvoiceItem> Items)
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
                catch (System.Exception ex)
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

        public static bool CanWriteToFile(string filePath)
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
        public static void CreatePdfInvoice()
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

            htmlToPdf.LogReceived += (sender, e) => { MessageBox.Show("WkHtmlToPdf Log: {0}", e.Data); };
            File.Delete(@".\HTML\Invoice.html");
        }

    }
}
