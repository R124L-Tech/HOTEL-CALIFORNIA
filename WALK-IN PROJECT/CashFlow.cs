//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WALK_IN_PROJECT
{
    using System;
    using System.Collections.Generic;
    
    public partial class CashFlow
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Tanggal { get; set; }
        public string Sumber { get; set; }
        public Nullable<int> Jumlah { get; set; }
        public string Jenis { get; set; }
        public string Admin { get; set; }
    
        public virtual Admin Admin1 { get; set; }
    }
}
