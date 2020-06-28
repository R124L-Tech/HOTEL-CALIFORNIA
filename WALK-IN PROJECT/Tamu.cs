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
    
    public partial class Tamu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tamu()
        {
            this.Reservasi = new HashSet<Reservasi>();
        }
    
        public int Id { get; set; }
        public string NoIdTamu { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Telp { get; set; }
        public string Email { get; set; }
        public string TandaPengenal { get; set; }
        public Nullable<System.DateTime> CheckIn { get; set; }
        public Nullable<System.DateTime> CheckOut { get; set; }
        public string NoKamar { get; set; }
        public Nullable<int> JumlahTamu { get; set; }
        public string Status { get; set; }
    
        public virtual Kamar Kamar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservasi> Reservasi { get; set; }
    }
}
