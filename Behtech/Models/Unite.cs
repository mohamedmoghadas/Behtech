using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class Unite : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unite()
        {
            this.CustomerProjectTicket = new HashSet<CustomerProjectTicket>();
            this.Suggestion = new HashSet<Suggestion>();
        }

       
        public string UnitName { get; set; }
        public Nullable<long> IdLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerProjectTicket> CustomerProjectTicket { get; set; }
        public virtual Languages Languages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suggestion> Suggestion { get; set; }
    }
}
