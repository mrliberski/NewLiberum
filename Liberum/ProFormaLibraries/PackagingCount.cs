using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class PackagingCount
    {
        /// <summary>
        /// Name of the packaging - this will be taken from the label
        /// </summary>
        public string? PackagingName { get; set; }
        public string? PackagingNumber { get; set; }
        public int CountOfEmpties { get; set; }
        public int CountOfFulls { get; set; }
        public int CountOfDamaged { get; set; }
        public int PalletFactor { get; set; }
        public int PackFactor {  get; set; }
        public int TotalContainers { get; set; }    

    }
}
