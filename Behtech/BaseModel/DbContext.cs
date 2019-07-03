using Behtech.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.BaseModel
{
    public partial class BehTechEntities : DbContext
    {
        public BehTechEntities()
           // : base("name=BehTechEntities")
        {
        }
        public BehTechEntities(DbContextOptions options) : base(options) { }


        public virtual DbSet<AboutUs> AboutUs { get; set; }
        public virtual DbSet<BehtechRoles> BehtechRoles { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerChangePassword> CustomerChangePassword { get; set; }
        public virtual DbSet<CustomerProject> CustomerProject { get; set; }
        public virtual DbSet<CustomerProjectTicket> CustomerProjectTicket { get; set; }
        public virtual DbSet<DailyUserWorks> DailyUserWorks { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<FactorOrder> FactorOrder { get; set; }
        public virtual DbSet<FactorPayment> FactorPayment { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LearningCustomerClass> LearningCustomerClass { get; set; }
        public virtual DbSet<Learnings> Learnings { get; set; }
        public virtual DbSet<LearningState> LearningState { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<ProjectImage> ProjectImage { get; set; }
        public virtual DbSet<ProjectProperty> ProjectProperty { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<ProjectState> ProjectState { get; set; }
        public virtual DbSet<ProjectType> ProjectType { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<RelativeProjects> RelativeProjects { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<SampleWorks> SampleWorks { get; set; }
        public virtual DbSet<SlidShows> SlidShows { get; set; }
        public virtual DbSet<SocialMedias> SocialMedias { get; set; }
        public virtual DbSet<SocialNetWork> SocialNetWork { get; set; }
        public virtual DbSet<Suggestion> Suggestion { get; set; }
      
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Todo> Todo { get; set; }
        public virtual DbSet<Unite> Unite { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<WorkingDay> WorkingDay { get; set; }
    }
}
