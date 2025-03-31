using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class StockLaneCheckModel
    {
        public int Id { get; set; }

        public string? ItemDescription { get; set; }

        public string? PartNumber { get; set; }

        public string? Checked { get; set; }

        public string? Mixed { get; set; }

        public int Quantity { get; set; }

        public string? Time { get; set; }

        public string? Date { get; set; }

        public string? Actions { get; set; }

        public string TimeAdded
        {
            get => DateTime.Now.ToString("hh:mm"); // Returns the current time in hh:mm format
            set
            {
                // Optionally handle setting a value, if needed
            }
        }

        public string DateAdded
        {
            get => DateTime.Now.ToString("dd/MM/yyyy"); // Returns the current date in dd/MM/yyyy format
            set
            {
                // Optionally handle setting a value, if needed
            }
        }

        //public string? AddedBy { get { return Environment.UserName; } }
        public string? AddedBy { get; set; }

        public string? Email { get; set; }
    }
}
