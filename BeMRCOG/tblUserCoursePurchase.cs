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
    
    public partial class tblUserCoursePurchase
    {
        public int USER_COURSE_PURCHASE_ID { get; set; }
        public int COURSE_PACKAGE_ID { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public decimal COURSE_PACKAGE_PRICE { get; set; }
        public Nullable<int> CRTD_BY { get; set; }
        public Nullable<System.DateTime> CRTD_DATE { get; set; }
        public Nullable<int> UPDT_BY { get; set; }
        public Nullable<System.DateTime> UPDT_DATE { get; set; }
        public bool IsActive { get; set; }
    
        public virtual tblCoursePackage tblCoursePackage { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
