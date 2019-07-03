using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class Property : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Property()
        {
            this.ProjectProperty = new HashSet<ProjectProperty>();
        }

        
        public string Name { get; set; }
        public Nullable<bool> DeletePermision { get; set; }
        public Nullable<long> IdParent { get; set; }
       

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectProperty> ProjectProperty { get; set; }
    }
}
