using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class BentleyCountModel
    {
        /// <summary>
        /// Name of the packaging - this will be taken from the label
        /// </summary>
        public int id  { get; set; } = 0;
        public string? PackagingName { get; set; }
        public string? PackagingNumber { get; set; }
        public int CountOfEmpties { get; set; }
        public int PackFactor { get; set; }
        public int TotalParts { get; set; }

    }
}
