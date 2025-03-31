using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ProFormaLibraries
{
    public class StockLaneEmail
    {   
        public static void SendEmail(StockLaneCheckModel model)
        {
            string output = "";
            output += @"<html><head><style>body {color: #3d3d40;font-size:10pt;font-family:Calibri;}</style></head><body>";
            output += @$"<h3>Stock Lane Check - {DateOnly.FromDateTime(DateTime.Now)}&nbsp;</h3>";


            output += @"<table border=""1"" cellspacing=""0"" cellpadding=""0"" style=font-size:10pt;font-family:Calibri; border-collapse: collapse; text-align:center; width:90%;>";

            output += @"<tr>";
            output += @"<td align=""center"">&nbsp;<b>&nbsp;Item Description</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Part Number</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Checked 100%</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Lane Mixed?</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Quantity</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Actions</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Time</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Date</b>&nbsp;</td>";

            output += @"</tr>";

            output += @"<tr>";
            output += @$"<td align=""center"">&nbsp;{model.ItemDescription}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{model.PartNumber}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{model.Checked}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{model.Mixed}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{model.Quantity}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{model.Actions}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{model.Time}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{model.Date}&nbsp;</td>";
            output += @"</tr>";

            output += "</table>";
            output += "<br>" + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            CreateEmail(output);
        }

        private static void CreateEmail(string output)
        {
            //Generate email
            List<string> recipients = SqliteDataAccess.LoadStockCheckRecipients();
            //List<string> ccList = SqliteDataAccess.LoadCC();

            Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

            mailItem.To = string.Join(";", recipients);// + "; Leighton, Rebecca; Wood, Craig; Richards, Cyrus";
                             //mailItem.CC = string.Join(";", ccList);                   
            mailItem.Subject = "Stock Lane Check > " + DateOnly.FromDateTime(DateTime.Now);
            mailItem.HTMLBody = output;
            mailItem.Display();

            // Release resources
            Marshal.ReleaseComObject(mailItem);
            Marshal.ReleaseComObject(outlookApp);
        }
    }
}
