//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cuts.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Temp_store
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> Type_id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Operational_hour { get; set; }
        public string Phone { get; set; }
        public Nullable<int> Status_id { get; set; }
    
        public virtual Store_type Store_type { get; set; }
        public virtual Temp_store_status Temp_store_status { get; set; }
    }
}
