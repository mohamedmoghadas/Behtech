using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class User : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.DailyUserWorks = new HashSet<DailyUserWorks>();
        }

      
        public string FullName { get; set; }
        public Nullable<long> NationalCode { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DateRegister { get; set; }
        public string UserImage { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<long> IdShahr { get; set; }
        public Nullable<long> IdUnit { get; set; }
        public Nullable<long> IdOstan { get; set; }
        public Nullable<long> IdJob { get; set; }

        public virtual City City { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DailyUserWorks> DailyUserWorks { get; set; }
        public virtual Jobs Jobs { get; set; }
    }
}
