using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    /// <summary>
    /// Class describing a properties of each Customer
    /// </summary>
    public class CustomerModel
    {
        /// <summary>
        /// Customer id
        /// </summary> 
        public string? CustomerId { get; set; }

        /// <summary>
        /// Last name of contact person
        /// </summary>
        public string? CustomerName { get; set; }

        /// <summary>
        /// Firsty Line of customer's Address 
        /// </summary>
        public string? CustomerAddressLine1 { get; set; }

        /// <summary>
        /// Second line of customer's address
        /// </summary>
        public string? CustomerAddressLine2 { get; set; }

        /// <summary>
        /// Third line of customer's address
        /// </summary>
        public string? CustomerAddressLine3 { get; set; }

        /// <summary>
        /// |Customer's main city of residency
        /// </summary>
        public string? CustomerCity { get; set; }

        /// <summary>
        /// Customer's phone number (optional)
        /// </summary>
        public string? CustomerPhone { get; set; }

        /// <summary>
        /// Custmer's region
        /// </summary>
        public string? CustomerRegion { get; set; }  

        /// <summary>
        /// Custoimer's country
        /// </summary>
        public string? CustomerCountry { get; set; }

        /// <summary>
        /// Customer's postal code
        /// </summary>
        public string? CustomerZipCode { get; set;}

        /// <summary>
        /// Customer's VAT number 
        /// </summary>
        public string? CustomerVAT { get;set;}  

        /// <summary>
        /// Customer's EORI number
        /// </summary>
        public string? CustomerEORI { get;set;}

        /// <summary>
        ///Default Exit Code for custome
        /// </summary>
        public string? CustomerUKExitCode { get; set; }

        /// <summary>
        /// Destination code of customer's preferred final customs office
        /// </summary>
        public string? CustomerFinalCustomsCode { get; set; }

        /// <summary>
        /// Sometimes customers have special customs permissions
        /// which need to be stated in the body of the invoice
        /// </summary>
        public string? CustomerFootNote { get; set; }

        public string? CustomerContactPerson { get; set; }

        public string? SAPnumber { get; set; }

        public string? Haulier { get; set; }

        public string? Incoterms { get; set; }

        public string? Currency { get; set;}
    }
}
