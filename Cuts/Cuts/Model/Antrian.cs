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
    
    public partial class Antrian
    {
        public string Username { get; set; }
        public int Nomor { get; set; }
        public string Nama { get; set; }
        public string Product { get; set; }
        public Nullable<System.TimeSpan> Estimate_duration { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Price { get; set; }
        public string Username_user { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual Store Store { get; set; }
    }
}
