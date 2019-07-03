using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class Projects : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projects()
        {
            this.CustomerProject = new HashSet<CustomerProject>();
            this.CustomerProjectTicket = new HashSet<CustomerProjectTicket>();
            this.ProjectImage = new HashSet<ProjectImage>();
            this.ProjectProperty = new HashSet<ProjectProperty>();
            this.RelativeProjects = new HashSet<RelativeProjects>();
        }
        
        public string ProjectName { get; set; }
        public string DescriptionProject { get; set; }
        public Nullable<bool> StateExist { get; set; }
        public Nullable<System.DateTime> DateRegister { get; set; }
        public Nullable<long> IdProjectType { get; set; }
        public Nullable<long> IdLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerProject> CustomerProject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerProjectTicket> CustomerProjectTicket { get; set; }
        public virtual Languages Languages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectImage> ProjectImage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectProperty> ProjectProperty { get; set; }
        public virtual ProjectType ProjectType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelativeProjects> RelativeProjects { get; set; }
    }
}
