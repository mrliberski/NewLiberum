using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class EadFormTemplate
    {
        public string EadForm()
        {
            string output = "";
            output += @"
            <!DOCTYPE html>
            <html>
                <head>
                    <title>EAD Request Template</title>
                    <style>
                    body {background-color:whitesmoke;text-align:center; font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;}
                    h1   {color:black;}
                    p    {color: black; padding: 2px; margin: 2px;}
                    table { border-collapse: collapse;}
                    td, th {border: 1px solid black;padding: 2px;}
                    table {border-collapse: collapse;}
                    td, th {border: none;}
                    </style>
                </head>";

            output += @"
                <body>
                <div>
                    <div style =""background-color:lightgray; float:inline-end; text-align:center; padding-left: 10px; font-family: Calibri;""; >
                        <p> <h3>512 EMA -UK to EU - Export Instructions&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h3></p>
                    </div>
                </div>
                <hr>";

            output += @"<div style=""width:60%; margin: 0 auto;"">
                <table align=""center"" cellspacing=""0"" cellpadding=""0"" style=""font-size:12pt;font-family:Calibri; border-collapse: collapse; text-align:center; align-items: center; width: 100%;"">";

            output += @"    
                <tr>
                        <td align=""center"" style=""border: 1px solid black; text-align: right;"">&nbsp;Truck / Trailer Number:&nbsp;</td>
                        <td align=""center"" style=""border: 1px solid black; text-align: left;"">&nbsp;{Truck / Trailer Number}&nbsp;</td>
                </tr>";

            output += @"    <tr>
                    <td align=""center"" style=""border: 1px solid black;text-align: right;"">&nbsp;Customer & Reference for Invoice (if any): &nbsp;</td>
                    <td align=""center"" style=""border: 1px solid black;text-align: left;"">&nbsp;Antolin Redditch&nbsp;</td>
                </tr>";

            output += @"    <tr>
                    <td align=""center"" style=""border: 1px solid black;text-align: right;"">&nbsp;Contact email: &nbsp;</td>
                    <td align=""center"" style=""border: 1px solid black;text-align: left;"">
                        pawel.liberski@grupoantolin.com; <br>
                        paula.southall@grupoantolin.com; <br>
                        alexandra.cendrowska@grupoantolin.com;<br> 
                        alina.sim@grupoantolin.com
                        &nbsp;</td>
                </tr>";

            output += @"   <tr>
                    <td align=""center"" style=""border: 1px solid black;text-align: right;"">&nbsp;Exporter Name and EORI: &nbsp;</td>
                    <td align=""center"" style=""border: 1px solid black;text-align: left;"">&nbsp;Grupo Antolin GB 683819882000&nbsp;</td>
                </tr>";

            output += @"    <tr>
                    <td align=""center"" style=""border: 1px solid black;text-align: right;"">&nbsp;Importer Name:&nbsp;</td>
                    <td align=""center"" style=""border: 1px solid black;text-align: left;"">&nbsp;{Importer Name}&nbsp;</td>
                </tr>";

            output += @"    <tr>
                    <td align=""center"" style=""border: 1px solid black;text-align: right;"">&nbsp;Description of goods: &nbsp;</td>
                    <td align=""center"" style=""border: 1px solid black;text-align: left;"">&nbsp;{Description of goods}&nbsp;</td>
                </tr>";

            output += @"    <tr>
                    <td align=""center"" style=""border: 1px solid black;text-align: right;"">&nbsp;Packing count:&nbsp;</td>
                    <td align=""center"" style=""border: 1px solid black;text-align: left;"">&nbsp;{Packing count}&nbsp;</td>
                </tr>";

            output += @"    <tr>
                    <td align=""center"" style=""border: 1px solid black;text-align: right;"">&nbsp;Value of goods:&nbsp;</td>
                    <td align=""center"" style=""border: 1px solid black;text-align: left;"">&nbsp;{Value of goods + currency}&nbsp;</td>
                </tr>";

            output += @"    <tr>
                    <td align=""center"" style=""border: 1px solid black;text-align: right;"">&nbsp;Procedure Code:&nbsp;</td>
                    <td align=""center"" style=""border: 1px solid black;text-align: left;"">&nbsp;{Procedure code}&nbsp;</td>
                </tr>";

            output += @"   <tr>
                    <td align=""center"" style=""border: 1px solid black;text-align: right;"">&nbsp;Licence details:&nbsp;</td>
                    <td align=""center"" style=""border: 1px solid black;text-align: left;"">&nbsp;N/A - please use LIC99 override on entry if necessary.&nbsp;</td>
                </tr>";

            output += @"    <tr>
                    <td align=""center"" style=""border: 1px solid black;text-align: right;"">&nbsp;Other instructions:&nbsp;</td>
                    <td align=""center"" style=""border: 1px solid black;text-align: left;"">&nbsp;{Other instructions}&nbsp;</td>
                </tr></table>
                </div>

                <div style=""font-size:9pt;font-family:Calibri; border-collapse: collapse; text-align:center; align-items: center;"">
                    <i>Unless previously agreed to the contrary, FIVE ONE TWO (E.M.A.) LIMITED will declare the consignment under direct representation</i> 
                    <hr>";

            output += @"        <div>
                            Issued by: {Issuer} + {Timestamp}
                        </div>
                </div>

                </body>
                </html>";


            return output;
        }
    }
}
