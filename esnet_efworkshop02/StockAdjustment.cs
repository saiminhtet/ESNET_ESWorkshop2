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
    
    public partial class StockAdjustment
    {
        public short VideoCode { get; set; }
        public Nullable<int> AdjustmentQty { get; set; }
        public System.DateTime DateAdjusted { get; set; }
        public string WhoAdjust { get; set; }
        public string AdjustReason { get; set; }
    
        public virtual Movies Movies { get; set; }
    }
}
