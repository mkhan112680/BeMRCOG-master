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
    
    public partial class tblPackage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPackage()
        {
            this.tblCoursePackages = new HashSet<tblCoursePackage>();
            this.tblPackageModuleCounts = new HashSet<tblPackageModuleCount>();
        }
    
        public int PACKAGE_ID { get; set; }
        public string PACKAGE_NAME { get; set; }
        public decimal PACKAGE_PRICE { get; set; }
        public Nullable<int> CRTD_BY { get; set; }
        public Nullable<System.DateTime> CRTD_DATE { get; set; }
        public Nullable<int> UPDT_BY { get; set; }
        public Nullable<System.DateTime> UPDT_DATE { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCoursePackage> tblCoursePackages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPackageModuleCount> tblPackageModuleCounts { get; set; }
    }
}
