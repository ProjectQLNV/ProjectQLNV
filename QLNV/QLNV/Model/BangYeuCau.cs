//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNV.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BangYeuCau
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BangYeuCau()
        {
            this.CaTrucs = new HashSet<CaTruc>();
        }
    
        public int YeuCauID { get; set; }
        public Nullable<System.DateTimeOffset> NgayTruc { get; set; }
        public Nullable<int> SoLuongCaTruc { get; set; }
        public Nullable<int> IDAdmin { get; set; }
    
        public virtual BangAdmin BangAdmin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaTruc> CaTrucs { get; set; }
    }
}
