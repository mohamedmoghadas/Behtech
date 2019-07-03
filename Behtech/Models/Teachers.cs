using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class Teachers : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teachers()
        {
            this.Learnings = new HashSet<Learnings>();
        }

    
        public string Name { get; set; }
        public string Image { get; set; }
        public string TeacherSalaryPerHour { get; set; }
        public string TeacherSalaryPerMonth { get; set; }
        public string Address { get; set; }
        public string Tell { get; set; }
        public string Moblie { get; set; }
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Learnings> Learnings { get; set; }
    }
}
