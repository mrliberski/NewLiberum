using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class RequestModel
    {
        public string? InvoiceNumber { get; set; }
        public string? RequestType { get; set; }
        public string? IbfDate { get; set; }
        public string? IbfTimeslot { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? KanbanNumber { get; set; }
        public string? Procedure { get; set; }
        public string? TruckNumber { get; set; }
        public string? Contacts { get; set; }
        public string? Customer { get; set; }
        public int? HUtotal { get; set; }
        public string? Haulier { get; set; }
        public string? PhoneNumber { get; set; }
        public string? UKexit { get; set; }
        public string? Destination { get; set; }
        public string? Incoterms { get; set; }
        public string? Currency { get; set; }
    }
}
