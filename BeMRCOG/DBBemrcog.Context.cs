﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBBemrcogEntities : DbContext
    {
        public DBBemrcogEntities()
            : base("name=DBBemrcogEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblChat> tblChats { get; set; }
        public virtual DbSet<tblChatOLD> tblChatOLDs { get; set; }
        public virtual DbSet<tblChatRole> tblChatRoles { get; set; }
        public virtual DbSet<tblChatUser> tblChatUsers { get; set; }
        public virtual DbSet<tblCourse> tblCourses { get; set; }
        public virtual DbSet<tblCourseDetail> tblCourseDetails { get; set; }
        public virtual DbSet<tblCourseModule> tblCourseModules { get; set; }
        public virtual DbSet<tblCoursePackage> tblCoursePackages { get; set; }
        public virtual DbSet<tblCourseType> tblCourseTypes { get; set; }
        public virtual DbSet<tblEvent> tblEvents { get; set; }
        public virtual DbSet<tblModuleDetail> tblModuleDetails { get; set; }
        public virtual DbSet<tblModule> tblModules { get; set; }
        public virtual DbSet<tblModuleTopic> tblModuleTopics { get; set; }
        public virtual DbSet<tblPackageModuleCount> tblPackageModuleCounts { get; set; }
        public virtual DbSet<tblPackage> tblPackages { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblQuestionAnswer> tblQuestionAnswers { get; set; }
        public virtual DbSet<tblQuestionChoice> tblQuestionChoices { get; set; }
        public virtual DbSet<tblQuestion> tblQuestions { get; set; }
        public virtual DbSet<tblQuize> tblQuizes { get; set; }
        public virtual DbSet<tblQuizProgress> tblQuizProgresses { get; set; }
        public virtual DbSet<tblQuizQuestion> tblQuizQuestions { get; set; }
        public virtual DbSet<tblReview> tblReviews { get; set; }
        public virtual DbSet<tblRole> tblRoles { get; set; }
        public virtual DbSet<tblSlider> tblSliders { get; set; }
        public virtual DbSet<tblTopic> tblTopics { get; set; }
        public virtual DbSet<tblTopicFeedBack> tblTopicFeedBacks { get; set; }
        public virtual DbSet<tblTopicUnitsQuize> tblTopicUnitsQuizes { get; set; }
        public virtual DbSet<tblUnit> tblUnits { get; set; }
        public virtual DbSet<tblUnitsProgress> tblUnitsProgresses { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUserCoursePurchase> tblUserCoursePurchases { get; set; }
        public virtual DbSet<tblUserModuleSubscription> tblUserModuleSubscriptions { get; set; }
    }
}