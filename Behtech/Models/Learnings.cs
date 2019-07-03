using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class Learnings : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Learnings()
        {
            this.LearningCustomerClass = new HashSet<LearningCustomerClass>();
        }

        public string CoursName { get; set; }
        public Nullable<System.DateTime> ClassDateBegin { get; set; }
        public string ClassDateEnd { get; set; }
        public Nullable<int> ClassDuringTime { get; set; }
        public string DaysOfClass { get; set; }
        public string Description { get; set; }
        public string CoursImage { get; set; }
        public Nullable<int> ClassCapacity { get; set; }
        public Nullable<int> ClassCustomerRegister { get; set; }
        public Nullable<int> discount { get; set; }
        public string DescriptionDiscount { get; set; }
        public string Price { get; set; }
        public string CustomerPrice { get; set; }
        public long TeacherId { get; set; }
        public Nullable<long> IdCustomer { get; set; }
        public Nullable<long> IdLanguage { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Languages Languages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearningCustomerClass> LearningCustomerClass { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}
