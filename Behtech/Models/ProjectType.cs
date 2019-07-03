using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class ProjectType : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectType()
        {
            this.Projects = new HashSet<Projects>();
            this.SampleWorks = new HashSet<SampleWorks>();
        }

      
        public Nullable<long> IdLanguage { get; set; }
        public long languageId { get; set; }
        public string ProjectTypeName { get; set; }

        public virtual Languages Languages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projects> Projects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SampleWorks> SampleWorks { get; set; }
    }
}
