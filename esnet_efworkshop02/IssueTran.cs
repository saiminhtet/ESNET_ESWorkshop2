//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace esnet_efworkshop02
{
    using System;
    using System.Collections.Generic;
    
    public partial class IssueTran
    {
        public short TransactionID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<short> VideoCode { get; set; }
        public Nullable<System.DateTime> DateIssue { get; set; }
        public Nullable<System.DateTime> DateDue { get; set; }
        public Nullable<System.DateTime> DateActualReturn { get; set; }
        public string RentalStatus { get; set; }
        public string Remarks { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Movies Movies { get; set; }
    }
}
