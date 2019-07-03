using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class Customer : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.CustomerChangePassword = new HashSet<CustomerChangePassword>();
            this.CustomerProject = new HashSet<CustomerProject>();
            this.CustomerProjectTicket = new HashSet<CustomerProjectTicket>();
            this.LearningCustomerClass = new HashSet<LearningCustomerClass>();
            this.Learnings = new HashSet<Learnings>();
            this.Payments = new HashSet<Payments>();
        }

        public long Id { get; set; }
        public bool statedelete { get; set; }
        public Nullable<System.DateTime> dateinsert { get; set; }
        public Nullable<System.DateTime> dateupdate { get; set; }
        public Nullable<System.DateTime> datedelete { get; set; }
        public Nullable<long> IdUserInsert { get; set; }
        public Nullable<long> IdUserUpdate { get; set; }
        public Nullable<long> IdUserDelete { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> DateRegister { get; set; }
        public string CustomerImage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerChangePassword> CustomerChangePassword { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerProject> CustomerProject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerProjectTicket> CustomerProjectTicket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearningCustomerClass> LearningCustomerClass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Learnings> Learnings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
