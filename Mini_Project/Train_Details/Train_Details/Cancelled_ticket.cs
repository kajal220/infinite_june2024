//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Train_Details
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cancelled_ticket
    {
        public int Cid { get; set; }
        public Nullable<int> Tno { get; set; }
        public Nullable<System.DateTime> date_of_travel { get; set; }
        public Nullable<int> no_of_ticket { get; set; }
        public Nullable<int> refund { get; set; }
        public Nullable<int> bid { get; set; }
    
        public virtual Booking_status Booking_status { get; set; }
        public virtual Train_details Train_details { get; set; }
    }
}
