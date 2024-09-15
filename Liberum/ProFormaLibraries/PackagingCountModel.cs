using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    class PackagingCountModel
    {
        public string? PackagingName { get; set; }
        public string? PackagingNumber { get; set; }
        public int CountOfEmpties { get; set; }
        public int CountOfFulls { get; set; }
        public int CountOfDamaged { get; set; }
        public int PalletFactor { get; set; }
        public int PackFactor { get; set; }
        public int TotalContainers { get; set; }
    }
}
