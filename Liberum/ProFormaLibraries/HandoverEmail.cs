using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ProFormaLibraries
{
    public class HandoverEmail
    {
        public static void CreateHandoverEmail(CurrentHandoverModel Handover)
        {
            string output = "";
            output += @"<html><head><style>body {color: #3d3d40;font-size:10pt;font-family:Calibri;}</style></head><body>";
            output += @$"<h3>LOGISTICS SHIFT REPORT - {Handover.Shift} {DateOnly.FromDateTime(DateTime.Now)}&nbsp;</h3>";

            output += @$"<h4>Health and Safety&nbsp;</h4>";
            output += $@"<hr>{Handover.HealthAndSafety}&nbsp;&nbsp";

            output += @$"<h4>MHE Equipment&nbsp;</h4>";
            output += $@"<hr>{Handover.EquipmentIssues}&nbsp;&nbsp";

            output += @$"<h4>Assembly Lines&nbsp;</h4>";
            output += $@"<hr>{Handover.AssemblyLines}&nbsp;&nbsp";

            output += @$"<h4>Mould Shop&nbsp;</h4>";
            output += $@"<hr>{Handover.MouldShop}&nbsp;&nbsp";

            output += @$"<h4>Hang on parts&nbsp;</h4>";
            output += $@"<hr>{Handover.HangOnParts}&nbsp;&nbsp";

            output += @$"<h4>Warehouse & Material &nbsp;</h4>";
            output += $@"<hr>{Handover.Warehouse}&nbsp;&nbsp";

            output += @$"<h4>Dock and Other Topics &nbsp;</h4>";
            output += $@"<hr>{Handover.AOB}&nbsp;&nbsp";

            output += @$"<h4>Shipments &nbsp;</h4>";
            output += @"<table border=""1"" cellspacing=""0"" cellpadding=""0"" style=font-size:10pt;font-family:Calibri; border-collapse: collapse; text-align:center; width:90%;>";

            output += @"<tr>";
            output += @"<td align=""center"">&nbsp;<b>&nbsp;#</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Planned Arrival</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Actual Arrival</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Departure</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>First Sequence</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Last Sequence</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Reg Number</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Commodity</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Comment</b>&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr>";
            output += @"<td align=""center"">&nbsp;<b>&nbsp;1</b>&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.DespatchPlan1}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Arrival1}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Departure1}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.FirstSeq1}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.LastSeq1}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.RegNumber1}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.ToPlan1}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Comment1}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr>";
            output += @"<td align=""center"">&nbsp;<b>&nbsp;2</b>&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.DespatchPlan2}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Arrival2}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Departure2}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.FirstSeq2}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.LastSeq2}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.RegNumber2}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.ToPlan2}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Comment2}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr>";
            output += @"<td align=""center"">&nbsp;<b>&nbsp;3</b>&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.DespatchPlan3}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Arrival3}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Departure3}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.FirstSeq3}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.LastSeq3}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.RegNumber3}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.ToPlan3}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Comment3}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr>";
            output += @"<td align=""center"">&nbsp;<b>&nbsp;4</b>&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.DespatchPlan4}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Arrival4}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Departure4}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.FirstSeq4}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.LastSeq4}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.RegNumber4}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.ToPlan4}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Comment4}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr>";
            output += @"<td align=""center"">&nbsp;<b>&nbsp;5</b>&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.DespatchPlan5}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Arrival5}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Departure5}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.FirstSeq5}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.LastSeq5}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.RegNumber5}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.ToPlan5}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Comment5}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr>";
            output += @"<td align=""center"">&nbsp;<b>&nbsp;6</b>&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.DespatchPlan6}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Arrival6}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Departure6}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.FirstSeq6}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.LastSeq6}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.RegNumber6}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.ToPlan6}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Comment6}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr>";
            output += @"<td align=""center"">&nbsp;<b>&nbsp;7</b>&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.DespatchPlan7}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Arrival7}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Departure7}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.FirstSeq7}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.LastSeq7}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.RegNumber7}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.ToPlan7}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Comment7}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr>";
            output += @"<td align=""center"">&nbsp;<b>&nbsp;8</b>&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.DespatchPlan8}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Arrival8}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Departure8}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.FirstSeq8}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.LastSeq8}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.RegNumber8}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.ToPlan8}&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Handover.Comment8}&nbsp;</td>";
            output += @"</tr>";

            output += "</table>";
            output += "<br>" + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            CreateEmail(output);
        }

        private static void CreateEmail(string output)
        {
            //Generate email
            DialogResult iExit;
            iExit = MessageBox.Show("New handover email will be generated, continue?", "Please confirm..", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                List<string> recipients = SqliteDataAccess.LoadHandoverRecipients();
                //List<string> ccList = SqliteDataAccess.LoadCC();

                Outlook.Application outlookApp = new Outlook.Application();
                Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

                mailItem.To = string.Join(";", recipients);// + "; Leighton, Rebecca; Wood, Craig; Richards, Cyrus";
                //mailItem.CC = string.Join(";", ccList);                   
                mailItem.Subject = "Logistics Handover > " + DateOnly.FromDateTime(DateTime.Now);
                mailItem.HTMLBody = output;
                mailItem.Display();

                // Release resources
                Marshal.ReleaseComObject(mailItem);
                Marshal.ReleaseComObject(outlookApp);
            }
        }
    }
}
