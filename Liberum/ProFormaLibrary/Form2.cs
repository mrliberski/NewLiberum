using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ProFormaUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void emailBuild_Click(object sender, EventArgs e)
        {
            string recipients = "mrliberski@outlook.com";// GetRecipients();
            string subject = "Request;";
            string body = "<h1>Hello!</h1><p>This is a test email with HTML formatting.</p>\"";// buildBody();
            string attachmentPAth = AppDomain.CurrentDomain.BaseDirectory + @"Html\Invoice.pdf";

            Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
            // Set the recipient
            mailItem.To = recipients;
            // Set the subject
            mailItem.Subject = subject;
            // Set the HTML body
            mailItem.HTMLBody = body;
            // Attach a file
            //if (!string.IsNullOrEmpty(attachmentPath))
            //{
            //    mailItem.Attachments.Add(attachmentPath);
            //}

            // Display the email
            mailItem.Display();
        }
    }
}
