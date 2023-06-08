
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ProFormaLibraries
{
    public class InvoiceTemplate
    {
        public static string EntireModel(InvoiceModel Invoice, List<ItemModel> Items, CustomerModel Customer)
        {
            string InvoiceContent = "";

            //below in no longer needed - image was rendered oh in html but failed in pdf so base 64 was used instead
            //string GraphicsPath = AppDomain.CurrentDomain.BaseDirectory + @"Pictures\antolin.png";
            //string GraphicsPathWithFilePrefix = "file:///" + GraphicsPath;
            //string placeholder = "*dummy*";
            int itemCount = 10;
            int HUcount = 0;
            double WeightCount = 0;
            double ValueCount = 0;
            double NetWeightCount = 0;


            //string PicFolderPath = @".\Pictures";
            //string PicFilePath = Path.Combine(PicFolderPath, "antolin.png");

            InvoiceContent = InvoiceContent +
                @"<!DOCTYPE html><html><head><title>Pro Forma Invoice Template</title><style>
                        body { background-color:white; text-align:center; }
                        h1   { color: black; }
                        p    {color: black;padding: 2px; margin: 2px;}
                        table { border-collapse: collapse;}
                        td, th {border: 1px solid black; padding: 2px;}
                        table {border-collapse: collapse;}
                        td, th { border: none;}</style></head><body>
                    <div><div style = ""float:left""><img src = ""data:image/png;base64, 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";

            //GraphicsPath = @".Pictures\antolin.png";

            //MessageBox.Show(GraphicsPath);

            //InvoiceContent = InvoiceContent+ GraphicsPathWithFilePrefix; 

            InvoiceContent = InvoiceContent + @""" alt = ""Antolin"" style = ""padding: 5pt; max-width: 50%; height: auto;""></div>
                    <div style = ""background-color:white; float:inline-end; text-align: right; padding-left: 10px;""><p><h3>";

            InvoiceContent = InvoiceContent + Invoice.InvoiceType;

            InvoiceContent = InvoiceContent + "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</h3></p></div></div><hr>";

            InvoiceContent = InvoiceContent + @$"

                    <table align = ""center"" cellspacing = ""0"" cellpadding = ""0"" style = ""font-size:10pt; font-family:Calibri; border-collapse: collapse; text-align:center; align-items: center; width: 100%;"" >
                        <tr><th>Date: {Invoice.Created.Substring(0, 10)}</th>
                            <th>Document Number: {Invoice.InvoiceNumber}</th>
                            <th>Currency: {Customer.Currency}</th>
                            <th>Incoterms: {Customer.Incoterms}</th>
                            <th>Reference Number: {Invoice.ReferenceNumber}</th>
                            <th>Kaban Info: {Invoice.KanbanNumber}</th>
                        </tr></table>

                        <hr>

                        <div style = ""font-size: 8pt; font-family:Calibri; text-align:center; float:left; width:50%;"" >
                            <p style = ""padding:1px; font-size:10pt; font-family:Calibri; text-align:center;"" ><b>{Customer.CustomerName}</b><br>
                                    {Customer.CustomerAddressLine1}, {Customer.CustomerAddressLine2}<br>
                                    {Customer.CustomerAddressLine3}<br>
                                    {Customer.CustomerZipCode}, {Customer.CustomerCity}<br>
                                    {Customer.CustomerCountry}<br>
                                    VAT: {Customer.CustomerVAT}<br>EORI: {Customer.CustomerEORI}</p>
                        </div>

                        <div style = ""font-size: 8pt; font-family:Calibri; text-align:center; float:left; width: 50%;"" >
                            <p style = ""padding:1px; font-size: 10pt; font-family:Calibri; text-align:center;"" ><b>Antolin Interiors UK Ltd</b><br>
                                    Merse Road, North Moons Moat<br>B98 9HL Redditch<br>United Kingdom<br>VAT: GB683819882<br>EORI:GB683819882000 </p><br></div>&nbsp;<br><br>

            <div style = ""width: 100%;"">
            <table align = ""center"" cellspacing = ""0"" cellpadding = ""0"" style = ""font-size:8pt; font-family:Calibri; border-collapse: collapse; text-align:center; align-items: center; width: 100%;"">
                <tr>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Item #&nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Description &nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Part Number&nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Customer PN&nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Qty &nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; HS Code&nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; COO &nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Total Weight(kg)&nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Value EA {Customer.Currency}&nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-right: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp;Value Total {Customer.Currency}&nbsp;</th></tr>";

            foreach (ItemModel model in Items)
            {
                InvoiceContent = InvoiceContent + @$"
                    <tr bottom-border = ""0"">
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {itemCount}&nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; text-align: left; "" > &nbsp; {model.ItemName} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.PartNumber} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.CustomerNumber} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ItemQuantity} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ItemHScode} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ItemCOO} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ItemNetWeight*model.ItemQuantity} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ItemPrice} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-right: 1px solid black; "" > &nbsp; {model.ItemQuantity*model.ItemPrice} &nbsp;</td></tr>

                    <tr>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; text-align: left; "" > &nbsp; {model.ContainerName} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ContainerCode} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ContainersQuantity} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ContainerHSCode} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ContainerCOO} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ContainersQuantity*model.ContainerNetWeight} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ContainerPrice} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-right: 1px solid black; "" > &nbsp; {model.ContainerPrice*model.ContainersQuantity} &nbsp;</td></tr>
                ";

                HUcount = HUcount + model.PalletsQuantity;

                WeightCount = WeightCount + (model.ContainersQuantity*model.ContainerNetWeight);
                WeightCount = WeightCount + (model.ItemQuantity*model.ItemNetWeight);

                NetWeightCount = NetWeightCount + (model.ItemQuantity * model.ItemNetWeight);

                ValueCount = ValueCount + (model.ContainersQuantity * model.ContainerPrice);
                ValueCount = ValueCount + (model.ItemPrice*model.ItemQuantity);

                itemCount = itemCount + 10;
            }

            InvoiceContent = InvoiceContent + $@"

                 <tr>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; text-align: left; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-right: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td></tr></table>

                        <table align = ""center"" cellspacing = ""0"" cellpadding = ""0"" style = ""font-size:10pt; font-family:Calibri; border-collapse: collapse; text-align:center; align-items: center; width: 100%; "" ><hr>
                            <tr>
                                <th> Handling Units: {HUcount} </th>
                                <th> Net Weight: {NetWeightCount.ToString("0.00")} kg </th>
                                <th> Total Weight: {WeightCount.ToString("0.00")} kg </th>
                                <th> Total Value: {Customer.Currency} {ValueCount.ToString("0.00")} </th>
                        </tr></table></div>
                        <div style = ""font-size:9pt; font-family:Calibri; border-collapse: collapse; text-align:center; align-items: center; "">
                        <hr>The exporter of the products covered by this document (EORI GB683819882000) declares that, except where otherwise clearly indicated, these products are of UK preferential origin.
                        <br><br><i>Customer specific note: {Customer.CustomerFootNote}</i><hr><div>Issued by: {Invoice.Creator}</div></div></body></html>";

            return InvoiceContent; 
            
        }


        public static string EntireModel(InvoiceModel Invoice, List<InvoiceItem> Items, CustomerModel Customer)
        {
            string InvoiceContent = "";

            //below in no longer needed - image was rendered oh in html but failed in pdf so base 64 was used instead
            //string GraphicsPath = AppDomain.CurrentDomain.BaseDirectory + @"Pictures\antolin.png";
            //string GraphicsPathWithFilePrefix = "file:///" + GraphicsPath;
            //string placeholder = "*dummy*";
            int itemCount = 10;
            int HUcount = 0;
            double WeightCount = 0;
            double ValueCount = 0;

            //if (Invoice.KanbanNumber == null)
            //{
            //    Invoice.KanbanNumber = string.Empty;
            //}
            //if(Invoice.ReferenceNumber == null)
            //{
            //    Invoice.ReferenceNumber = string.Empty;
            //}


            //string PicFolderPath = @".\Pictures";
            //string PicFilePath = Path.Combine(PicFolderPath, "antolin.png");

            InvoiceContent = InvoiceContent +
                @"<!DOCTYPE html><html><head><title>Pro Forma Invoice Template</title><style>
                        body { background-color:white; text-align:center; }
                        h1   { color: black; }
                        p    {color: black;padding: 2px; margin: 2px;}
                        table { border-collapse: collapse;}
                        td, th {border: 1px solid black; padding: 2px;}
                        table {border-collapse: collapse;}
                        td, th { border: none;}</style></head><body>
                    <div><div style = ""float:left""><img src = ""data:image/png;base64, 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";

            //GraphicsPath = @".Pictures\antolin.png";

            //MessageBox.Show(GraphicsPath);

            //InvoiceContent = InvoiceContent+ GraphicsPathWithFilePrefix; 

            InvoiceContent = InvoiceContent + @""" alt = ""Antolin"" style = ""padding: 5pt; max-width: 50%; height: auto;""></div>
                    <div style = ""background-color:white; float:inline-end; text-align: right; padding-left: 10px;""><p><h3>
                                    Pro Forma Invoice&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</h3></p></div></div><hr>";

            InvoiceContent = InvoiceContent + @$"

                    <table align = ""center"" cellspacing = ""0"" cellpadding = ""0"" style = ""font-size:10pt; font-family:Calibri; border-collapse: collapse; text-align:center; align-items: center; width: 100%;"" >
                        <tr><th>Date: {Invoice.Created.Substring(0, 10)}</th>
                            <th>Document Number: {Invoice.InvoiceNumber}</th>
                            <th>Currency: {Customer.Currency}</th>
                            <th>Incoterms: {Customer.Incoterms}</th>
                            <th>Reference Number: {Invoice.ReferenceNumber}</th>
                            <th>Kaban Info: {Invoice.KanbanNumber}</th>
                        </tr></table>

                        <hr>";

            InvoiceContent = InvoiceContent + @$"            <div style = ""font-size: 8pt; font-family:Calibri; text-align:center; float:left; width:50%;"" >
                            <p style = ""padding:1px; font-size:10pt; font-family:Calibri; text-align:center;"" ><b>{Customer.CustomerName}</b><br>
                                    {Customer.CustomerAddressLine1}, {Customer.CustomerAddressLine2}<br>
                                    {Customer.CustomerAddressLine3}<br>
                                    {Customer.CustomerZipCode}, {Customer.CustomerCity}<br>
                                    {Customer.CustomerCountry}<br>
                                    VAT: {Customer.CustomerVAT}<br>EORI: {Customer.CustomerEORI}</p>
                        </div>";

            InvoiceContent = InvoiceContent + @$"            <div style = ""font-size: 8pt; font-family:Calibri; text-align:center; float:left; width: 50%;"" >
                            <p style = ""padding:1px; font-size: 10pt; font-family:Calibri; text-align:center;"" ><b>Antolin Interiors UK Ltd</b><br>
                                    Merse Road, North Moons Moat<br>B98 9HL Redditch<br>United Kingdom<br>VAT: GB683819882<br>EORI:GB683819882000 </p><br></div>&nbsp;<br><br>

            <div style = ""width: 100%;"">
            <table align = ""center"" cellspacing = ""0"" cellpadding = ""0"" style = ""font-size:8pt; font-family:Calibri; border-collapse: collapse; text-align:center; align-items: center; width: 100%;"">
                <tr>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Item #&nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Description &nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Part Number&nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Customer PN&nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Qty &nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; HS Code&nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; COO &nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Total Weight(kg)&nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; Value EA {Customer.Currency}&nbsp;</th>
                    <th align = ""center"" style = ""font-weight:bold; border-left: 1px solid black; border-right: 1px solid black; border-top: 1px solid black; border-bottom: 1px solid black; "" > &nbsp;Value Total {Customer.Currency}&nbsp;</th></tr>";

            foreach (InvoiceItem model in Items)
            {
                InvoiceContent = InvoiceContent + @$"
                    <tr bottom-border = ""0"">
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {itemCount}&nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; text-align: left; "" > &nbsp; {model.ItemName} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.PartNumber} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.CustomerNumber} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ItemQuantity} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ItemHScode} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ItemCOO} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ItemNetWeight * model.ItemQuantity} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ItemPrice} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-right: 1px solid black; "" > &nbsp; {model.ItemQuantity * model.ItemPrice} &nbsp;</td></tr>

                    <tr>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; text-align: left; "" > &nbsp; {model.ContainerName} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ContainerCode} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ContainersQuantity} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ContainerHSCode} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ContainerCOO} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ContainersQuantity * model.ContainerNetWeight} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; "" > &nbsp; {model.ContainerPrice} &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-right: 1px solid black; "" > &nbsp; {model.ContainerPrice * model.ContainersQuantity} &nbsp;</td></tr>
                ";

                HUcount = HUcount + model.PalletsQuantity;

                WeightCount = WeightCount + (model.ContainersQuantity * model.ContainerNetWeight);
                WeightCount = WeightCount + (model.ItemQuantity * model.ItemNetWeight);

                ValueCount = ValueCount + (model.ContainersQuantity * model.ContainerPrice);
                ValueCount = ValueCount + (model.ItemPrice * model.ItemQuantity);

                itemCount = itemCount + 10;
            }

            InvoiceContent = InvoiceContent + $@"

                 <tr>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; text-align: left; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td>
                        <td align = ""center"" style = ""border-left: 1px solid black; border-right: 1px solid black; border-bottom: 1px solid black; "" > &nbsp; &nbsp;</td></tr></table>

                        <table align = ""center"" cellspacing = ""0"" cellpadding = ""0"" style = ""font-size:10pt; font-family:Calibri; border-collapse: collapse; text-align:center; align-items: center; width: 100%; "" ><hr>
                            <tr>
                                <th> Handling Units: {HUcount} </th>
                                <th> Total Weight: {WeightCount.ToString("0.00")} kg </th>
                                <th> Total Value: {Customer.Currency} {ValueCount.ToString("0.00")} </th>
                        </tr></table></div>
                        <div style = ""font-size:9pt; font-family:Calibri; border-collapse: collapse; text-align:center; align-items: center; "">
                        <hr>The exporter of the products covered by this document (EORI GB683819882000) declares that, except where otherwise clearly indicated, these products are of UK preferential origin.
                        <br><br><i>Customer specific note: {Customer.CustomerFootNote}</i><hr><div>Issued by: {Invoice.Creator}</div></div></body></html>";

            return InvoiceContent;

        }

    }
}
