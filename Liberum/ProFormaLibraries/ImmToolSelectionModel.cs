using DocumentFormat.OpenXml.Office.CoverPageProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class ImmToolSelectionModel
    {
        /// <summary>
        /// Represents Record Number from DB
        /// </summary>
        public int Id {  get; set; }

        /// <summary>
        /// Tool number if available
        /// </summary>
        public string? ToolNumber { get; set; }

        /// <summary>
        /// Project Number
        /// </summary>
        public string? Project {  get; set; }


        public string? ProductName { get; set; }

        public int SecondsPerPart { get; set; }

        /// <summary>
        /// How many people are required to run this product
        /// </summary>
        public int Manning {  get; set; }

    }
}
