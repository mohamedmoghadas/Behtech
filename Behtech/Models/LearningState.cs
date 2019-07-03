using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class LearningState : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LearningState()
        {
            this.LearningCustomerClass = new HashSet<LearningCustomerClass>();
        }

        public string State { get; set; }
        public Nullable<long> IdLanguage { get; set; }

        public virtual Languages Languages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearningCustomerClass> LearningCustomerClass { get; set; }
    }
}
