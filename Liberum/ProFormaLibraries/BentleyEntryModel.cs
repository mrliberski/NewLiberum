using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class BentleyEntryModel
    {
        public int Id { get; set; }

        public int LhFinished { get; set; }

        public int LhLasered { get; set; }

        public int LhWad { get; set; }

        public int LhHud { get; set; }

        public int LhPab { get; set; }

        public int LhUnlasered { get; set; }

        public int RhFinished { get; set; }

        public int RhLasered { get; set; }

        public int RhWad { get; set; }

        public int RhHud { get; set; }

        public int RhPab { get; set; }

        public int RhUnlasered { get; set; }

        public int Cmp { get; set; }

        public string? EntryDate  { get;set;}// EntryDate => DateTime.Now.ToString("dd-MMM-yyyy");

        public static string? CreatedBy { get { return Environment.UserName; } }

    }
}
