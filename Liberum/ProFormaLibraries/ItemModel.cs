using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ProFormaLibraries
{
    public class ItemModel
    {
        public int ItemId { get; set; }
        public string? ItemCustomer { get; set; }
        public int ItemQuantity { get; set; }
        public string? ItemName { get; set; }
        public string? PartNumber { get; set; }
        public string? CustomerNumber { get; set; }
        public double ItemNetWeight { get; set; }
        public double ItemGrossWeight{ get; set; }
        public double ItemPrice { get; set; }
        public long ItemHScode { get; set; }
        public string? ItemCOO{ get; set; }
        public string? ContainerName{ get; set; }
        public int ContainersQuantity { get; set; }
        public string? ContainerCode { get; set; }
        public double ContainerNetWeight { get; set; }
        public double ContainerGrossWeight { get; set; }
        public double ContainerPrice { get; set; }
        public long ContainerHSCode { get; set; }
        public string? ContainerCOO { get; set; }
        public int PartsPerContainer{ get; set; } 
        public int ContainersPerPallet{ get; set; }
        public int PalletsQuantity { get; set; }
        public int RequiresPackaging { get; set; }
        public int RequiresLid { get; set; }
        public int RequiresPallet { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedBy { get {return Environment.UserName; } }
        public int Cpp { get; set; } // replacement for container per pallet which for some reason gets updted in db but can be never pulled out 
    }
}
