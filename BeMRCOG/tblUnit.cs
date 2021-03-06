//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeMRCOG
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUnit()
        {
            this.tblTopicUnitsQuizes = new HashSet<tblTopicUnitsQuize>();
            this.tblUnitsProgresses = new HashSet<tblUnitsProgress>();
        }
    
        public int UNIT_ID { get; set; }
        public string UNIT_NAME { get; set; }
        public string AUDIO_LINK { get; set; }
        public string PDF_LINK { get; set; }
        public string VIDEO_LINK { get; set; }
        public Nullable<int> CRTD_BY { get; set; }
        public Nullable<System.DateTime> CRTD_DATE { get; set; }
        public Nullable<int> UPDT_BY { get; set; }
        public Nullable<System.DateTime> UPDT_DATE { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTopicUnitsQuize> tblTopicUnitsQuizes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnitsProgress> tblUnitsProgresses { get; set; }
    }
}
