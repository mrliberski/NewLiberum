using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Outlook;
using ProFormaLibraries;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Outlook = Microsoft.Office.Interop.Outlook;
using System;
using System.Media;
using System.Windows.Forms;
using OfficeOpenXml;
using DocumentFormat.OpenXml.Office2016.Excel;

namespace ProFormaLibraries
{
    public class PackagingCountTemplate
    {
        public static string PackagingCountEmailBody(List<PackagingCount> packagingCounts)
        {
            string output = "buhaha";
            //Generate body of email
            output = "";
            output += @"<html><head><style>body {color: #3d3d40;font-size:10pt;font-family:Calibri;}</style></head><body>";
            output += @"<h3>Packaging Count Report&nbsp;</h3>";
            output += @"<table border=""1"" cellspacing=""0"" cellpadding=""0"" style=font-size:10pt;font-family:Calibri; border-collapse: collapse; text-align:center; width:90%;>";

            output += @"<tr><td align=""center"">&nbsp;<b>Packaging Name</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Packaging Number</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Empty Pallets</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Full Pallets</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Damaged Pallets</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Pallet Factor</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Total Containers</b>&nbsp;</td>";
            output += @"</tr>";

            foreach ( PackagingCount item in packagingCounts)
            {
                output += @$"<tr><td align=""center"">&nbsp;{item.PackagingName}&nbsp;</td>";
                output += @$"<td align=""center"">&nbsp;{item.PackagingNumber}&nbsp;</td>";
                output += @$"<td align=""center"">&nbsp;{item.CountOfEmpties}&nbsp;</td>";
                output += @$"<td align=""center"">&nbsp;{item.CountOfFulls}&nbsp;</td>";
                output += @$"<td align=""center"">&nbsp;{item.CountOfDamaged}&nbsp;</td>";
                output += @$"<td align=""center"">&nbsp;{item.PalletFactor}&nbsp;</td>";
                output += @$"<td align=""center"">&nbsp;{item.TotalContainers}&nbsp;</td>";
                output += @"</tr>";
            }

            output += "</table>";
            output += "<br>Report generated on " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            return output;
        }

        public static void SendPackagingCount(string PackagingCountemailBody) 
        {
            //Generate email
            DialogResult iExit;
            iExit = MessageBox.Show("Nw count report will be created, continue?", "Please confirm..", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                //TODO - new recipient list must be created and linked accordingly
                //List<string> recipients = SqliteDataAccess.LoadRecipients();
                List<string> recipients = SqliteDataAccess.LoadPackagingCountRecipients();
                //List<string> ccList = SqliteDataAccess.LoadCC();
                string subject = "Packaging Count > " + DateTime.Now.ToString();

                Outlook.Application outlookApp = new Outlook.Application();
                Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

                mailItem.To = string.Join(";", recipients);// + "; Leighton, Rebecca; Wood, Craig; Richards, Cyrus";
                    //mailItem.CC = string.Join(";", ccList);
                    // Set the subject
                    mailItem.Subject = subject;
                    // Set the HTML body
                    mailItem.HTMLBody = PackagingCountemailBody;
                    // Display the email
                    mailItem.Display();

                    // Release resources
                    Marshal.ReleaseComObject(mailItem);
                    Marshal.ReleaseComObject(outlookApp);

            }
        }

    }
}
