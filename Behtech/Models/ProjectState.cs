using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class ProjectState : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectState()
        {
            this.CustomerProject = new HashSet<CustomerProject>();
        }

     
        public string State { get; set; }
        public Nullable<long> IdLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerProject> CustomerProject { get; set; }
        public virtual Languages Languages { get; set; }
    }
}
