using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    public class CurrentHandoverModel
    {
        public int Id { get; set; }
        public DateTime HandoverDate { get; set; }
        public string? Shift {  get; set; }
        public string? HealthAndSafety { get; set; }
        public string? EquipmentIssues { get; set; }

        public string? AssemblyLines { get; set; }
        public string? MouldShop { get; set; }
        public string? HangOnParts { get; set; }
        public string? Warehouse { get; set; }
        public string? AOB {  get; set; }

        //DESPATCH 1
        public string? DespatchPlan1 { get; set; }
        public string? Arrival1 { get; set; }
        public string? Departure1 { get; set; }
        public string? FirstSeq1 { get; set; }
        public string? LastSeq1 { get; set; }
        public string? RegNumber1 { get; set; }
        public string? ToPlan1 { get; set; }
        public string? Comment1 { get; set; }

        //DESPATCH 2
        public string? DespatchPlan2 { get; set; }
        public string? Arrival2 { get; set; }
        public string? Departure2 { get; set; }
        public string? FirstSeq2 { get; set; }
        public string? LastSeq2 { get; set; }
        public string? RegNumber2 { get; set; }
        public string? ToPlan2 { get; set; }
        public string? Comment2 { get; set; }

        //DESPATCH 3
        public string? DespatchPlan3 { get; set; }
        public string? Arrival3 { get; set; }
        public string? Departure3 { get; set; }
        public string? FirstSeq3 { get; set; }
        public string? LastSeq3 { get; set; }
        public string? RegNumber3 { get; set; }
        public string? ToPlan3 { get; set; }
        public string? Comment3 { get; set; }

        //DESPATCH 4
        public string? DespatchPlan4 { get; set; }
        public string? Arrival4 { get; set; }
        public string? Departure4 { get; set; }
        public string? FirstSeq4 { get; set; }
        public string? LastSeq4 { get; set; }
        public string? RegNumber4 { get; set; }
        public string? ToPlan4 { get; set; }
        public string? Comment4 { get; set; }

        //DESPATCH 5
        public string? DespatchPlan5 { get; set; }
        public string? Arrival5 { get; set; }
        public string? Departure5 { get; set; }
        public string? FirstSeq5 { get; set; }
        public string? LastSeq5 { get; set; }
        public string? RegNumber5 { get; set; }
        public string? ToPlan5 { get; set; }
        public string? Comment5 { get; set; }


        //DESPATCH 6
        public string? DespatchPlan6 { get; set; }
        public string? Arrival6 { get; set; }
        public string? Departure6 { get; set; }
        public string? FirstSeq6 { get; set; }
        public string? LastSeq6 { get; set; }
        public string? RegNumber6 { get; set; }
        public string? ToPlan6 { get; set; }
        public string? Comment6 { get; set; }

        //DESPATCH 7
        public string? DespatchPlan7 { get; set; }
        public string? Arrival7 { get; set; }
        public string? Departure7 { get; set; }
        public string? FirstSeq7 { get; set; }
        public string? LastSeq7 { get; set; }
        public string? RegNumber7 { get; set; }
        public string? ToPlan7 { get; set; }
        public string? Comment7 { get; set; }

        //DESPATCH 8
        public string? DespatchPlan8 { get; set; }
        public string? Arrival8 { get; set; }
        public string? Departure8 { get; set; }
        public string? FirstSeq8 { get; set; }
        public string? LastSeq8 { get; set; }
        public string? RegNumber8 { get; set; }
        public string? ToPlan8 { get; set; }
        public string? Comment8 { get; set; }

        //DESPATCH 9
        public string? DespatchPlan9 { get; set; }
        public string? Arrival9 { get; set; }
        public string? Departure9 { get; set; }
        public string? FirstSeq9 { get; set; }
        public string? LastSeq9 { get; set; }
        public string? RegNumber9 { get; set; }
        public string? ToPlan9 { get; set; }
        public string? Comment9 { get; set; }

        //DESPATCH 10
        public string? DespatchPlan10 { get; set; }
        public string? Arrival10 { get; set; }
        public string? Departure10 { get; set; }
        public string? FirstSeq10 { get; set; }
        public string? LastSeq10 { get; set; }
        public string? RegNumber10 { get; set; }
        public string? ToPlan10 { get; set; }
        public string? Comment10 { get; set; }

        //SUBMITION
        public DateTime SubmittedDate { get; set; }
        public static string? CreatedBy { get { return Environment.UserName; } }

        public int HandoverNumber { get; set; }
    }
}
