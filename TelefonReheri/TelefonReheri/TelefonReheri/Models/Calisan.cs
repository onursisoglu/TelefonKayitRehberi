//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelefonReheri.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calisan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Calisan()
        {
            this.Calisan1 = new HashSet<Calisan>();
            this.KullaniciBilgisi = new HashSet<KullaniciBilgisi>();
        }
    
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public int DepartmanID { get; set; }
        public bool IsManager { get; set; }
        public bool IsAdmin { get; set; }
        public Nullable<int> Yoneticisi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calisan> Calisan1 { get; set; }
        public virtual Calisan Calisan2 { get; set; }
        public virtual Departman Departman { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciBilgisi> KullaniciBilgisi { get; set; }
    }
}
