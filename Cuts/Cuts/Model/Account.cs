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
    
    public partial class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Nullable<int> Role_id { get; set; }
    
        public virtual Role Role { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Store Store { get; set; }
        public virtual User User { get; set; }
    }
}
