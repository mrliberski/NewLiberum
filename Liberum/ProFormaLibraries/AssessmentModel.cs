using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class AssessmentModel
    {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Surname { get; set; }
            public string? Site { get; set; }
            public string? Shift { get; set; }
            public string? CreatedDate { get; set; }
            public string? CreatedBy { get; set; }
            public string? UpdatedDate { get; set; }
            public string? UpdatedBy { get; set; }
            public string? Comments { get; set; }
            public string? LiveRecord { get; set; }
            public string? A1 { get; set; } // PPT pedestrian
            public string? A2 { get; set; } // PPT Rider
            public string? A3 { get; set; } // Not a scooby
            public string? A4 { get; set; } // Pallet Stacker
            public string? A5 { get; set; } // Pallet Stacker
            public string? B1 { get; set; } // Counterbalance up to 5T
            public string? B2 { get; set; } // Counterbalance up to ?
            public string? H1 { get; set; } // Tow train
            public string? F1 { get; set; } // VNA
            public string? M3A { get; set; } // Scissor Lift
            public string? M3B { get; set; } // Cherry picker
            public string? D1 { get; set; } // Reach truck 
            public string? Remote { get; set; } // Crane Remote
            public string? Crane { get; set; } // Crane
            public string? Assessment { get; set; } // Crane assessment
            public string? P1 { get; set; } // bendi
            public string? RackingInspection { get; set; } // Racking Inspection
    }
}
