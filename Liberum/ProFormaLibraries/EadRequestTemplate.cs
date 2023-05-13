using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Xml.Schema;

namespace ProFormaLibraries
{
    public class EadRequestTemplate
    {
        public string EadRequestFormModel(RequestModel request)
        {
            string output = "";
            output += @"<html><head><style>body {color: #3d3d40;font-size:10pt;font-family:Calibri;}</style></head><body>";
            output += @"<h3>512 EMA - UK to EU - Export instruction&nbsp;</h3>";
            output += @"<table border=""1"" cellspacing=""0"" cellpadding=""0"" style=font-size:10pt;font-family:Calibri; border-collapse: collapse; text-align:center; width:90%;>";

            output += @"<tr><td align=""center"">&nbsp;<b>Customer Name</b>&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;<b>Antolin Redditch</b>&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Exporter name & EORI&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;Antolin Interiors UK <br> GB683819882000&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Invoice Number&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.InvoiceNumber}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;<b>Request Type</b>&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;<b>{request.RequestType}</b>&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Kanban Number&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.KanbanNumber}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Customer PO number&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.ReferenceNumber}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;<b>Importer Name</b>&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;<b>{request.Customer}</b>&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;UK Exit Coded&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.UKexit}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Destination Code&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.Destination}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Haulier&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.Haulier}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Truck / trailer number&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.TruckNumber}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Driver's phone number&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.PhoneNumber}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;IBF booking date&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.IbfDate}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;IBF timeslot&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.IbfTimeslot}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Contact e-mail&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.Contacts}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Packing Count&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.HUtotal}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Value of goods:&nbsp;</td>";
            output += @"<td align=""center"">&nbsp;Please refer to invoice in attachment&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Incoterms&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.Incoterms}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Procedure Code (CPC)&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{request.Procedure}&nbsp;</td>";
            output += @"</tr>";

            output += @"<tr><td align=""center"">&nbsp;Requester&nbsp;</td>";
            output += @$"<td align=""center"">&nbsp;{Environment.UserName}&nbsp;</td>";
            output += @"</tr>";

            output += "</table>";
            output += "<br>Request generated on " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"); 

            return output;
        }
    }
}


