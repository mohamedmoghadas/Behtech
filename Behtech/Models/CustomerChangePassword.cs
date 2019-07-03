using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class CustomerChangePassword : BaseEntity
    {
        public string Code { get; set; }
        public Nullable<long> NumberOfChanges { get; set; }
        public long CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
