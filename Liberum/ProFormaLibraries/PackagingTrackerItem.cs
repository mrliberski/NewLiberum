using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class PackagingTrackerItem
    {
        public string? DeliveryDate { get; set; }

        public string? DeliveryTime { get; set; }

        public string? DeliveryNumber { get; set; }

        public string?  PackagingCode { get; set; }

        public int  AdvisedQty { get; set; }

        public int  ReceivedQty { get; set; }

        public string? Comment { get; set; }

        public string? EntryDate {  get { return DateTime.Now.ToString(); } }

        public static string? CreatedBy { get { return Environment.UserName; } }
    }
}
