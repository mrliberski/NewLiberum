using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class InvoiceModel
    {
        public int InvoiceId { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? CMRnumber { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? KanbanNumber { get; set; }
        public string? Created { get; set; }
        public string? Creator { get { return Environment.UserName; } }
    }
}
