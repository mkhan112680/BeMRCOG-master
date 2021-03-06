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
    
    public partial class tblUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUser()
        {
            this.tblQuizProgresses = new HashSet<tblQuizProgress>();
            this.tblUnitsProgresses = new HashSet<tblUnitsProgress>();
            this.tblUserCoursePurchases = new HashSet<tblUserCoursePurchase>();
            this.tblUserModuleSubscriptions = new HashSet<tblUserModuleSubscription>();
        }
    
        public int USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_EMAIL { get; set; }
        public string USER_IMAGE { get; set; }
        public string USER_PASSWORD { get; set; }
        public int ROLE_ID { get; set; }
        public int STATUS { get; set; }
        public int CONNECTED_PARENT { get; set; }
        public System.DateTime CRTD_DATE { get; set; }
        public Nullable<System.DateTime> RECONNECTED_DATE { get; set; }
        public string CONNECTION_ID { get; set; }
        public Nullable<int> CRTD_BY { get; set; }
        public Nullable<int> UPDT_BY { get; set; }
        public Nullable<System.DateTime> UPDT_DATE { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuizProgress> tblQuizProgresses { get; set; }
        public virtual tblRole tblRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnitsProgress> tblUnitsProgresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUserCoursePurchase> tblUserCoursePurchases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUserModuleSubscription> tblUserModuleSubscriptions { get; set; }
    }
}
